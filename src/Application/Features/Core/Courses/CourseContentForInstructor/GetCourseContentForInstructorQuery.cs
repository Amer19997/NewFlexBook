using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;

namespace FlexBook.Application.Features.Core.Courses.CourseContentForInstructor;
// Query for retrieving course content for the instructor
public class GetCourseContentForInstructorQuery : IRequest<GetCourseContentAfterLoginDto>
{
    public Guid CourseId { get; set; }
    public Guid InstructorId { get; set; }

    public GetCourseContentForInstructorQuery(Guid courseId, Guid instructorId)
    {
        CourseId = courseId;
        InstructorId = instructorId;
    }
}
