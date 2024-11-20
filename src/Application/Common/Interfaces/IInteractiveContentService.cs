using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Common.Interfaces
{
    public interface IInteractiveContentService
    {
        Task<string> ExtractAndSaveInteractiveContentAsync(IFormFile interactiveZip);
        //Task<Stream> StreamContentAsync(string contentUrl);
    }
}