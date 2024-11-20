//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using FlexBook.Application.Common.Interfaces;
//using FlexBook.Application.Features.Core.Video;
//using FlexBook.Domain;
//using MediatR;
//using Microsoft.AspNetCore.Mvc;

//namespace FlexBook.Application.Features.Core;
//public class StreamLessonVideoQueryHandler : IRequestHandler<StreamLessonVideoQuery, IActionResult>
//{
//    private readonly IUnitOfWork _unitOfWork;
//    private readonly IVideoStorageService _videoStorageService;

//    public StreamLessonVideoQueryHandler(IUnitOfWork unitOfWork, IVideoStorageService videoStorageService)
//    {
//        _unitOfWork = unitOfWork;
//        _videoStorageService = videoStorageService;
//    }

//    public async Task<IActionResult> Handle(StreamLessonVideoQuery request, CancellationToken cancellationToken)
//    {
//        // Get the lesson
//        var lesson = await _unitOfWork.LessonRepository.FindById(request.LessonId, cancellationToken);
//        if (lesson == null || string.IsNullOrEmpty(lesson.VideoUrl))
//        {
//            return new NotFoundObjectResult("Lesson or video not found.");
//        }

//        // Fetch video stream
//        var videoStream = await _videoStorageService.StreamVideoWithRangeSupportAsync(lesson.VideoUrl, request.HttpContext);

//        // Return the video stream response with correct headers
//        return videoStream;
//    }
//    //public async Task<IActionResult> Handle(StreamLessonVideoQuery request, CancellationToken cancellationToken)
//    //{
//    //    var lesson = await _unitOfWork.LessonRepository.FindById(request.LessonId, cancellationToken);

//    //    if (lesson == null || string.IsNullOrEmpty(lesson.VideoUrl))
//    //    {
//    //        return new NotFoundObjectResult("Lesson or video not found.");
//    //    }

//    //    var videoStream = await _videoStorageService.StreamVideoAsync(lesson.VideoUrl);
//    //    return new FileStreamResult(videoStream, "video/mp4");
//    //}
//}