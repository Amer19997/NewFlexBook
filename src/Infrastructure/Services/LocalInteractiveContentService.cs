using FlexBook.Application.Common.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace FlexBook.Infrastructure.Services
{
    public class LocalInteractiveContentService : IInteractiveContentService
    {
        private readonly string _interactiveDirectory;

        public LocalInteractiveContentService(IWebHostEnvironment env)
        {
            // Set the directory to store interactive content, e.g., "wwwroot/interactive"
            _interactiveDirectory = Path.Combine(env.WebRootPath, "interactive");
            if (!Directory.Exists(_interactiveDirectory))
            {
                Directory.CreateDirectory(_interactiveDirectory);
            }
        }

        public async Task<string> ExtractAndSaveInteractiveContentAsync(IFormFile interactiveZip)
        {
            if (interactiveZip == null || interactiveZip.Length == 0)
                throw new ArgumentException("Interactive zip file is empty or null.");

            // Generate a unique filename with the original extension
            string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(interactiveZip.FileName);
            string filePath = Path.Combine(_interactiveDirectory, uniqueFileName);

            // Save the file to the filesystem
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await interactiveZip.CopyToAsync(stream);
            }
            var extractionfolder = Guid.NewGuid().ToString();
            // Extract the contents of the zip file into a separate folder
            string extractPath = Path.Combine(_interactiveDirectory, extractionfolder);
            Directory.CreateDirectory(extractPath); // Ensure the extraction folder exists
            ZipFile.ExtractToDirectory(filePath, extractPath);

            // Return the relative path to the story.html file within the extracted folder
            return Path.Combine("/interactive", extractionfolder, "story.html");
        }

        public Task<Stream> StreamContentAsync(string contentUrl)
        {
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", contentUrl.TrimStart('/'));
            var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
            return Task.FromResult<Stream>(stream);
        }
    }
}
