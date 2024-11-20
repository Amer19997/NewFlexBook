//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using FlexBook.Application.Common.Interfaces;
//using Microsoft.AspNetCore.Http;

//namespace FlexBook.Infrastructure.Services;
//public class CloudVideoStorageService : IVideoStorageService
//{
//    private readonly IAmazonS3 _amazonS3;
//    private readonly string _bucketName;

//    public CloudVideoStorageService(IAmazonS3 amazonS3, string bucketName)
//    {
//        _amazonS3 = amazonS3;
//        _bucketName = bucketName;
//    }

//    public async Task<string> UploadVideoAsync(IFormFile videoFile)
//    {
//        var fileKey = Guid.NewGuid().ToString() + Path.GetExtension(videoFile.FileName);

//        var putRequest = new PutObjectRequest
//        {
//            BucketName = _bucketName,
//            Key = fileKey,
//            InputStream = videoFile.OpenReadStream(),
//            ContentType = videoFile.ContentType
//        };
//        await _amazonS3.PutObjectAsync(putRequest);

//        return $"https://{_bucketName}.s3.amazonaws.com/{fileKey}";
//    }

//    public async Task<Stream> StreamVideoAsync(string videoUrl)
//    {
//        var fileKey = new Uri(videoUrl).Segments.Last();
//        var response = await _amazonS3.GetObjectAsync(_bucketName, fileKey);
//        return response.ResponseStream;
//    }
//}
