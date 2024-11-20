//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MediatR;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace FlexBook.Application.Features.Core.Video;
//// StreamLessonVideoQuery
//public class StreamLessonVideoQuery : IRequest<IActionResult>
//{
//    public Guid LessonId { get; set; }
//    public HttpContext HttpContext { get; set; } // HttpContext is needed for range support

//    public StreamLessonVideoQuery(Guid lessonId, HttpContext httpContext)
//    {
//        LessonId = lessonId;
//        HttpContext = httpContext;
//    }
//}