using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get.Instructor;
using MediatR;

namespace FlexBook.Application.Features.Core.Lessons.GetLessonByIdForInstructor;
// Query for retrieving a specific lesson by its ID for the instructor
public class GetLessonByIdForInstructorQuery : IRequest<GetLessonByIdAfterInstructorLoginDto>
{
    public Guid LessonId { get; set; }
    public Guid InstructorId { get; set; }

    public GetLessonByIdForInstructorQuery(Guid lessonId, Guid instructorId)
    {
        LessonId = lessonId;
        InstructorId = instructorId;
    }
}
