using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Infrastructure.Services;
// LocalPhotoStorageService.cs
public class LocalPhotoStorageService : IPhotoStorageService
{
    private readonly string _photosDirectory;

    public LocalPhotoStorageService(IWebHostEnvironment env)
    {
        // Set the directory to store photos, e.g., "wwwroot/images"
        _photosDirectory = Path.Combine(env.WebRootPath, "images");
        if (!Directory.Exists(_photosDirectory))
        {
            Directory.CreateDirectory(_photosDirectory);
        }
    }

    public async Task<string> UploadPhotoAsync(IFormFile photoFile)
    {
        if (photoFile == null || photoFile.Length == 0)
            throw new ArgumentException("Photo file is empty.");

        // Generate a unique filename with the original extension
        string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(photoFile.FileName);
        string filePath = Path.Combine(_photosDirectory, uniqueFileName);

        // Save the file to the filesystem
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await photoFile.CopyToAsync(stream);
        }

        // Return the relative path to the saved file, e.g., "/images/filename.jpg"
        return $"/images/{uniqueFileName}";
    }
}
