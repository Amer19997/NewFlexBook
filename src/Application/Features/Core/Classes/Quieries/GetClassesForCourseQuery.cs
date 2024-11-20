using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.Core.Courses.StudentAvailbleCourses;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;

namespace FlexBook.Application.Features.Core.Classes.Quieries;
public class GetClassesForCourseQuery : IRequest<TResponse<List<GetAvailableClassDto>>>
{
    public Guid CourseId { get; set; }
    public string ClassName { get; set; } // Optional class name filter

    public GetClassesForCourseQuery(Guid courseId, string className = null)
    {
        CourseId = courseId;
        ClassName = className;
    }
}