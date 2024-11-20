using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Infrastructure.Services;
public class FileUploadService : IFileUploadService
{
    private readonly string _contentFileDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "contentfiles");

    public async Task<string> UploadFileAsync(IFormFile contentFile)
    {
        if (!Directory.Exists(_contentFileDirectory))
        {
            Directory.CreateDirectory(_contentFileDirectory);
        }

        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(contentFile.FileName);
        var filePath = Path.Combine(_contentFileDirectory, fileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await contentFile.CopyToAsync(stream);
        }

        return $"/contentfiles/{fileName}";
    }
}
