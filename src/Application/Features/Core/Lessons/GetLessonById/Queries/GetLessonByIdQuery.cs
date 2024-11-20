using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.Core.Lessons.GetLessonById.Queries;
//public class GetLessonByIdQuery : IRequest<TResponse<GetLessonAfterLoginDto>>
//{
//    public Guid Id { get; set; }

//    public GetLessonByIdQuery(Guid id)
//    {
//        Id = id;
//    }
//}
public class GetLessonByIdQuery : IRequest<TResponse<object>>
{
    public Guid LessonId { get; set; }
    public Guid? ClassId { get; set; } // For students

    public GetLessonByIdQuery(Guid lessonId, Guid? classId = null)
    {
        LessonId = lessonId;
        ClassId = classId;
    }
}



