using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Common.Interfaces;
public interface IFileUploadService
{
    Task<string> UploadFileAsync(IFormFile contentFile); // Uploads a file
}
