using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Exceptions;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Domain.Entities.Catalog.Dtos.Get.Instructor;

namespace FlexBook.Application.Features.Core.Lessons.GetLessonByIdForInstructor;
// Handler for processing GetLessonByIdForInstructorQuery
public class GetLessonByIdForInstructorQueryHandler : IRequestHandler<GetLessonByIdForInstructorQuery, GetLessonByIdAfterInstructorLoginDto>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetLessonByIdForInstructorQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<GetLessonByIdAfterInstructorLoginDto> Handle(GetLessonByIdForInstructorQuery request, CancellationToken cancellationToken)
    {
        // Fetch the lesson
        //var lesson = await _unitOfWork.LessonRepository.GetByIdAsync(request.LessonId, cancellationToken);
        var lesson = await _unitOfWork.LessonRepository.GetByIdAsync(l => l.Id == request.LessonId);

        if (lesson == null)
        {
            throw new NotFoundException("Lesson not found.");
        }

        // Fetch the course associated with the lesson
        var SectionID = lesson.SectionId;
        var section = await _unitOfWork.SectionRepository.GetByIdAsync(
s => s.Id == SectionID,  // Filter expression
          "",    // Related entities to include
cancellationToken                // Cancellation token
);
        var courseId=section.CourseId;
        // Check if the instructor is associated with this course
        var hasCourse = await _unitOfWork.InstructorCoursesRepository.AnyAsync(request.InstructorId, courseId);
        if (!hasCourse)
        {
            throw new NotFoundException("Instructor does not have access to this course.");
        }

        // Fetch instructor-specific overrides for this lesson
        var lessonOverride = await _unitOfWork.InstructorCourseOverrideRepository
            .FirstOrDefaultAsync(o => o.InstructorId == request.InstructorId && o.LessonId == lesson.Id, cancellationToken);

        // Apply instructor-specific overrides to the lesson
        var lessonDto = new GetLessonByIdAfterInstructorLoginDto
        {
            Id = lesson.Id,
            NameAr = lesson.NameEn,
            NameEn = lesson.NameEn,
            DescriptionAr = lessonOverride?.CustomLessonDescriptionAr ?? lesson.DescriptionAr,
            DescriptionEn = lessonOverride?.CustomLessonDescriptionEn ?? lesson.DescriptionEn,
            IsHidden = lessonOverride?.HideLesson == true,
            //HideVideo = lessonOverride?.HideVideo == true,
            HideFile = lessonOverride?.HideFile == true,
            //HideContentImage= lessonOverride?.HideContentImage == true,
            HideInteractivePart = lessonOverride?.HideInteractiveElement == true,
            //ImageUrl=lessonOverride?.HideContentImage==true?null:lesson.ImageUrl,
            //VideoUrl = lessonOverride?.HideVideo == true ? null : lesson.VideoUrl,
            //FileUrl = lessonOverride?.HideFile == true ? null : lesson.FileUrl,
            //InteractiveContentUrl = lessonOverride?.HideInteractivePart == true ? null : lesson.InteractiveContentUrl
        };

        return lessonDto;
    }
}