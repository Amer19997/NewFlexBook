//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using FlexBook.Application.Common.Interfaces;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace FlexBook.Infrastructure.Services;
//public class LocalVideoStorageService : IVideoStorageService
//{
//    //private readonly string _videoDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "videos");
//    private readonly string _videoDirectory;

//    public LocalVideoStorageService(IWebHostEnvironment env)
//    {
//        // Set the directory to store photos, e.g., "wwwroot/images"
//        _videoDirectory = Path.Combine(env.WebRootPath, "videos");
//        if (!Directory.Exists(_videoDirectory))
//        {
//            Directory.CreateDirectory(_videoDirectory);
//        }
//    }
//    //public async Task<string> UploadVideoAsync(IFormFile videoFile)
//    //{
//    //    if (!Directory.Exists(_videoDirectory))
//    //    {
//    //        Directory.CreateDirectory(_videoDirectory);
//    //    }

//    //    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(videoFile.FileName);
//    //    var filePath = Path.Combine(_videoDirectory, fileName);

//    //    using (var stream = new FileStream(filePath, FileMode.Create))
//    //    {
//    //        await videoFile.CopyToAsync(stream);
//    //    }

//    //    return $"/videos/{fileName}";
//    //}

//    public async Task<string> UploadVideoAsync(IFormFile videoFile)
//    {
//        if (videoFile == null || videoFile.Length == 0)
//            throw new ArgumentException("video file is empty.");

//        // Generate a unique filename with the original extension
//        string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(videoFile.FileName);
//        string filePath = Path.Combine(_videoDirectory, uniqueFileName);

//        // Save the file to the filesystem
//        using (var stream = new FileStream(filePath, FileMode.Create))
//        {
//            await videoFile.CopyToAsync(stream);
//        }

//        // Return the relative path to the saved file, e.g., "/images/filename.jpg"
//        return $"/videos/{uniqueFileName}";
//    }

//    public Task<IActionResult> StreamVideoWithRangeSupportAsync(string videoUrl, HttpContext httpContext)
//    {
//        // Extract the full file path
//        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", videoUrl.TrimStart('/'));

//        //if (!File.Exists(filePath))
//        //{
//        //    return Task.FromResult<IActionResult>(new NotFoundResult());
//        //}

//        var fileInfo = new FileInfo(filePath);
//        var fileLength = fileInfo.Length;
//        var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);

//        var rangeHeader = httpContext.Request.Headers["Range"].ToString();

//        // Support range requests (e.g., "Range: bytes=0-")
//        if (!string.IsNullOrEmpty(rangeHeader))
//        {
//            var range = rangeHeader.Replace("bytes=", "").Split('-');
//            var start = long.Parse(range[0]);
//            var end = range.Length > 1 && !string.IsNullOrEmpty(range[1]) ? long.Parse(range[1]) : fileLength - 1;
//            var contentLength = end - start + 1;

//            // Seek to the requested part of the file
//            fileStream.Seek(start, SeekOrigin.Begin);
//            return Task.FromResult<IActionResult>(new FileStreamResult(fileStream, "video/mp4")
//            {
//                EnableRangeProcessing = true,
//                //StatusCode = StatusCodes.Status206PartialContent,
//                FileDownloadName = fileInfo.Name
//            });
//        }

//        // Serve the full file if no range is requested
//        return Task.FromResult<IActionResult>(new FileStreamResult(fileStream, "video/mp4")
//        {
//            EnableRangeProcessing = true
//        });
//    }
















//    //public Task<Stream> StreamVideoAsync(string videoUrl)
//    //{
//    //    var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", videoUrl.TrimStart('/'));
//    //    var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
//    //    return Task.FromResult<Stream>(stream);
//    //}
//}