using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Common.Interfaces;
// IPhotoStorageService.cs
public interface IPhotoStorageService
{
    Task<string> UploadPhotoAsync(IFormFile photoFile);  // Upload a photo and return its URL or path
}