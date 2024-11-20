using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.InstructorAfterLogin;
using FlexBook.Domain.Entities.Catalog.Dtos.StudentAfterLogin;
using MediatR;

namespace FlexBook.Application.Features.Core.Courses.StudentAvailbleCourses;
    public class GetAvailableCoursesForStudentQuery : IRequest<TResponse<List<StudentCourseDto>>>

{
    public Guid StudentId { get; set; }

    public GetAvailableCoursesForStudentQuery(Guid studentId)
    {
        StudentId = studentId;
    }
}