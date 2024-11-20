using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos.InstructorAfterLogin;
using MediatR;

namespace FlexBook.Application.Features.Core.Courses.InstructorCourses.Quireies;
//public class GetInstructorCoursesQuery : IRequest<TResponse<List<InstructorCourseDto>>>
//{
//    public Guid InstructorId { get; }
//    public string CourseCode { get; set; } 

//    public GetInstructorCoursesQuery(Guid instructorId, string courseCode = null)
//    {
//        InstructorId = instructorId;
//        CourseCode = courseCode; // Optional course code filter
//    }
//}
// Query to retrieve a list of courses for the currently authenticated instructor
// Query to retrieve a list of courses based on the current user's role (student or instructor)
public class GetAvailableCoursesQuery : IRequest<TResponse<List<object>>>
{
    public string Keyword { get; set; } = "";
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string SortBy { get; set; } = "NameEn";
    public string SortDirection { get; set; } = "asc";
}
