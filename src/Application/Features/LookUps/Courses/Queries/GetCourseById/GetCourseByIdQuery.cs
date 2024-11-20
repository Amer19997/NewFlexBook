using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using MediatR;

namespace FlexBook.Application.Features.LookUps.Courses.Queries.GetCourseById;
// Query to retrieve course details by ID
public class GetCourseByIdQuery : IRequest<TResponse<object>>
{
    public Guid CourseId { get; }
    public Guid? ClassId { get; } // Optional, for students to check enrollment

    public GetCourseByIdQuery(Guid courseId, Guid? classId = null)
    {
        CourseId = courseId;
        ClassId = classId;
    }
}