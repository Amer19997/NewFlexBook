using MediatR;
using FlexBook.Application.Common.Exceptions;
using FlexBook.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Domain;

namespace FlexBook.Application.Features.Core.Lessons.GetLessonByIdForStudent
{
    public class GetLessonByIdForStudentQueryHandler : IRequestHandler<GetLessonByIdForStudentQuery, object>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetLessonByIdForStudentQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<object> Handle(GetLessonByIdForStudentQuery request, CancellationToken cancellationToken)
        {
            // Step 1: Verify that the student is enrolled in the class
            var classEntity = await _unitOfWork.ClassRepository.GetByIdAsync(request.ClassId, cancellationToken);
            if (classEntity == null || !classEntity.Students.Any(s => s.Id == request.StudentId))
            {
                throw new UnauthorizedAccessException("Student is not enrolled in this class.");
            }

            // Step 2: Ensure the class belongs to the course containing the lesson
            var lesson = await _unitOfWork.LessonRepository.GetByIdAsync(l => l.Id == request.LessonId);
            if (lesson == null)
            {
                throw new NotFoundException("Lesson not found.");
            }

            var section = await _unitOfWork.SectionRepository.GetByIdAsync(s => s.Id == lesson.SectionId);
            if (section.CourseId != classEntity.CourseId)
            {
                throw new NotFoundException("Lesson does not belong to the course of the specified class.");
            }

            // Step 3: Retrieve instructor-specific overrides for this lesson
            var lessonOverride = await _unitOfWork.InstructorCourseOverrideRepository
                .FirstOrDefaultAsync(o => o.InstructorId == classEntity.InstructorId && o.LessonId == lesson.Id, cancellationToken);

            // Step 4: Dynamically build the anonymous object excluding hidden fields
            var response = new
            {
                Id = lesson.Id,
                NameAr = lesson.NameAr,
                NameEn = lesson.NameEn,
                DescriptionAr = lessonOverride?.CustomLessonDescriptionAr ?? lesson.DescriptionAr,
                DescriptionEn = lessonOverride?.CustomLessonDescriptionEn ?? lesson.DescriptionEn,
                IsHidden = lessonOverride?.HideLesson == true,
                //VideoUrl = lessonOverride?.HideVideo == true ? null : lesson.VideoUrl,
                //FileUrl = lessonOverride?.HideFile == true ? null : lesson.FileUrl,
                //ImageUrl = lessonOverride?.HideContentImage == true ? null : lesson.ImageUrl,
                //InteractiveContentUrl = lessonOverride?.HideInteractivePart == true ? null : lesson.InteractiveContentUrl
            };

            // Step 5: Build the final anonymous object including only non-null properties
            var finalResponse = new
            {
                response.Id,
                response.NameAr,
                response.NameEn,
                response.DescriptionAr,
                response.DescriptionEn,
                response.IsHidden,
                //VideoUrl = lessonOverride?.HideVideo == true ? null : lesson.VideoUrl,
                //FileUrl = lessonOverride?.HideFile == true ? null : lesson.FileUrl,
                //ImageUrl = lessonOverride?.HideContentImage == true ? null : lesson.ImageUrl,
                //InteractiveContentUrl = lessonOverride?.HideInteractivePart == true ? null : lesson.InteractiveContentUrl
            };

            return finalResponse;
        }
    }
}
