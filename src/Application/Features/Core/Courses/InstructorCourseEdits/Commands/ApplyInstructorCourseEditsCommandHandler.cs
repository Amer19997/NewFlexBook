using System;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities;
using FlexBook.Domain;
//using FlexBook.Domain.Entities.Overrides;
using MediatR;
using static FlexBook.Application.Features.Core.Courses.InstructorCourseEdits.Commands.ApplyInstructorCourseEditsCommand;

namespace FlexBook.Application.Features.Core.Courses.InstructorCourseEdits.Commands
{
    public class ApplyInstructorCourseEditsCommandHandler : IRequestHandler<ApplyInstructorCourseEditsCommand, TResponse<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUserService _currentUserService;

        public ApplyInstructorCourseEditsCommandHandler(IUnitOfWork unitOfWork, ICurrentUserService currentUserService)
        {
            _unitOfWork = unitOfWork;
            _currentUserService = currentUserService;
        }

        public async Task<TResponse<bool>> Handle(ApplyInstructorCourseEditsCommand request, CancellationToken cancellationToken)
        {
            var userId = _currentUserService.UserId;
            if (string.IsNullOrEmpty(userId))
            {
                return TResponse<bool>.Failure(
                    new[] { "Unauthorized access" },
                    "User must be logged in",
                    401);
            }

            var instructorId = Guid.Parse(userId);

            // Ensure instructor has access to the course
            var hasAccess = await _unitOfWork.InstructorCoursesRepository.AnyAsync(instructorId, request.CourseId);
            if (!hasAccess)
            {
                return TResponse<bool>.Failure(
                    new[] { "Access denied" },
                    "Instructor does not have permission to edit this course",
                    403);
            }

            try
            {
                // Process Section Edits
                foreach (var sectionEdit in request.SectionEdits)
                {
                    await HandleSectionEdit(sectionEdit, instructorId, request.CourseId, cancellationToken);
                }

                // Process Lesson Edits
                foreach (var lessonEdit in request.LessonEdits)
                {
                    await HandleLessonEdit(lessonEdit, instructorId, request.CourseId, cancellationToken);
                }

                // Process Lesson Part Edits
                foreach (var partEdit in request.LessonPartEdits)
                {
                    await HandleLessonPartEdit(partEdit, instructorId, request.CourseId, cancellationToken);
                }

                // Process Quiz Edits
                foreach (var quizEdit in request.QuizEdits)
                {
                    await HandleQuizEdit(quizEdit, instructorId, request.CourseId, cancellationToken);
                }

                // Commit all changes to the database
                await _unitOfWork.CommitAsync(cancellationToken);
                return TResponse<bool>.Success(true, "Course edits applied successfully");
            }
            catch (Exception ex)
            {
                return TResponse<bool>.Failure(
                    new[] { "Error applying course edits" },
                    $"An unexpected error occurred: {ex.Message}",
                    500);
            }
        }

        private async Task HandleSectionEdit(ApplyInstructorCourseEditsCommand.SectionEdit sectionEdit, Guid instructorId, Guid courseId, CancellationToken cancellationToken)
        {
            var existingOverride = await _unitOfWork.InstructorCourseOverrideRepository
                .FirstOrDefaultAsync(o =>
                    o.InstructorId == instructorId &&
                    o.CourseId == courseId &&
                    o.SectionId == sectionEdit.SectionId &&
                    o.LessonId == null,
                    cancellationToken);

            if (existingOverride == null)
            {
                var newOverride = new InstructorCourseOverride
                {
                    InstructorId = instructorId,
                    CourseId = courseId,
                    SectionId = sectionEdit.SectionId,
                    HideSection = sectionEdit.HideSection,
                    LastUpdated = DateTime.UtcNow
                };

                await _unitOfWork.InstructorCourseOverrideRepository.AddAsync(newOverride, cancellationToken);
            }
            else
            {
                existingOverride.HideSection = sectionEdit.HideSection ?? existingOverride.HideSection;
                existingOverride.LastUpdated = DateTime.UtcNow;

                _unitOfWork.InstructorCourseOverrideRepository.Update(existingOverride);
            }
        }

        private async Task HandleLessonEdit(ApplyInstructorCourseEditsCommand.LessonEdit lessonEdit, Guid instructorId, Guid courseId, CancellationToken cancellationToken)
        {
            var existingOverride = await _unitOfWork.InstructorCourseOverrideRepository
                .FirstOrDefaultAsync(o =>
                    o.InstructorId == instructorId &&
                    o.CourseId == courseId &&
                    o.LessonId == lessonEdit.LessonId,
                    cancellationToken);

            if (existingOverride == null)
            {
                var newOverride = new InstructorCourseOverride
                {
                    InstructorId = instructorId,
                    CourseId = courseId,
                    LessonId = lessonEdit.LessonId,
                    CustomTitleAr = lessonEdit.CustomTitleAr,
                    CustomTitleEn = lessonEdit.CustomTitleEn,
                    CustomLessonDescriptionAr = lessonEdit.CustomDescriptionAr,
                    CustomLessonDescriptionEn = lessonEdit.CustomDescriptionEn,
                    HideLesson = lessonEdit.HideLesson,
                    HideCodeEditor = lessonEdit.HideCodeEditor, // Handle HideCodeEditor flag

                    LastUpdated = DateTime.UtcNow
                };

                await _unitOfWork.InstructorCourseOverrideRepository.AddAsync(newOverride, cancellationToken);
            }
            else
            {
                existingOverride.CustomTitleAr = lessonEdit.CustomTitleAr ?? existingOverride.CustomTitleAr;
                existingOverride.CustomTitleEn = lessonEdit.CustomTitleEn ?? existingOverride.CustomTitleEn;
                existingOverride.CustomLessonDescriptionAr = lessonEdit.CustomDescriptionAr ?? existingOverride.CustomLessonDescriptionAr;
                existingOverride.CustomLessonDescriptionEn = lessonEdit.CustomDescriptionEn ?? existingOverride.CustomLessonDescriptionEn;
                existingOverride.HideLesson = lessonEdit.HideLesson ?? existingOverride.HideLesson;
                existingOverride.HideCodeEditor = lessonEdit.HideCodeEditor ?? existingOverride.HideCodeEditor;
                existingOverride.LastUpdated = DateTime.UtcNow;

                _unitOfWork.InstructorCourseOverrideRepository.Update(existingOverride);
            }
        }

        private async Task HandleLessonPartEdit(ApplyInstructorCourseEditsCommand.LessonPartEdit partEdit, Guid instructorId, Guid courseId, CancellationToken cancellationToken)
        {
            var existingOverride = await _unitOfWork.InstructorCourseOverrideRepository
                .FirstOrDefaultAsync(o =>
                    o.InstructorId == instructorId &&
                    o.CourseId == courseId &&
                    o.LessonPartId == partEdit.LessonPartId,
                    cancellationToken);

            if (existingOverride == null)
            {
                var newOverride = new InstructorCourseOverride
                {
                    InstructorId = instructorId,
                    CourseId = courseId,
                    LessonPartId = partEdit.LessonPartId,
                    CustomLessonPartContent = partEdit.CustomContent,
                    HideLessonPart = partEdit.HideLessonPart,

                    LastUpdated = DateTime.UtcNow

                };

                await _unitOfWork.InstructorCourseOverrideRepository.AddAsync(newOverride, cancellationToken);
            }
            else
            {
                existingOverride.CustomLessonPartContent = partEdit.CustomContent ?? existingOverride.CustomLessonPartContent;
                existingOverride.HideLessonPart = partEdit.HideLessonPart ?? existingOverride.HideLessonPart;
                existingOverride.LastUpdated = DateTime.UtcNow;

                _unitOfWork.InstructorCourseOverrideRepository.Update(existingOverride);
            }

            foreach (var interactiveEdit in partEdit.InteractiveElementEdits)
            {
                await HandleInteractiveElementEdit(interactiveEdit, instructorId, courseId, cancellationToken);
            }
        }

        private async Task HandleInteractiveElementEdit(ApplyInstructorCourseEditsCommand.InteractiveElementEdit interactiveEdit, Guid instructorId, Guid courseId, CancellationToken cancellationToken)
        {
            var existingOverride = await _unitOfWork.InstructorCourseOverrideRepository
                .FirstOrDefaultAsync(o =>
                    o.InstructorId == instructorId &&
                    o.CourseId == courseId &&
                    o.InteractiveElementId == interactiveEdit.InteractiveElementId,
                    cancellationToken);

            if (existingOverride == null)
            {
                var newOverride = new InstructorCourseOverride
                {
                    InstructorId = instructorId,
                    CourseId = courseId,
                    InteractiveElementId = interactiveEdit.InteractiveElementId,
                    HideInteractiveElement = interactiveEdit.HideInteractiveElement,
                    LastUpdated = DateTime.UtcNow
                };

                await _unitOfWork.InstructorCourseOverrideRepository.AddAsync(newOverride, cancellationToken);
            }
            else
            {
                existingOverride.HideInteractiveElement = interactiveEdit.HideInteractiveElement ?? existingOverride.HideInteractiveElement;
                existingOverride.LastUpdated = DateTime.UtcNow;

                _unitOfWork.InstructorCourseOverrideRepository.Update(existingOverride);
            }
        }

        private async Task HandleQuizEdit(ApplyInstructorCourseEditsCommand.QuizEdit quizEdit, Guid instructorId, Guid courseId, CancellationToken cancellationToken)
        {
            var existingOverride = await _unitOfWork.InstructorCourseOverrideRepository
                .FirstOrDefaultAsync(o =>
                    o.InstructorId == instructorId &&
                    o.CourseId == courseId &&
                    o.QuizId == quizEdit.QuizId,
                    cancellationToken);

            if (existingOverride == null)
            {
                var newOverride = new InstructorCourseOverride
                {
                    InstructorId = instructorId,
                    CourseId = courseId,
                    QuizId = quizEdit.QuizId,
                    HideQuiz = quizEdit.HideQuiz,
                    LastUpdated = DateTime.UtcNow
                };

                await _unitOfWork.InstructorCourseOverrideRepository.AddAsync(newOverride, cancellationToken);
            }
            else
            {
                existingOverride.HideQuiz = quizEdit.HideQuiz ?? existingOverride.HideQuiz;
                existingOverride.LastUpdated = DateTime.UtcNow;

                _unitOfWork.InstructorCourseOverrideRepository.Update(existingOverride);
            }
        }
    }
}
