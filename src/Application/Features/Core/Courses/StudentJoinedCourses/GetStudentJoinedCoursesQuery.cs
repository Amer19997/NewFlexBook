using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.StudentAfterLogin;
using MediatR;

namespace FlexBook.Application.Features.Core.Courses.StudentJoinedCourses;
public class GetStudentJoinedCoursesQuery : IRequest<List<CourseDto>>
{
    public Guid StudentId { get; set; }
}