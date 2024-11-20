using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Exceptions;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using FlexBook.Domain.Enums;
using MediatR;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities;
using FlexBook.Domain;

namespace FlexBook.Application.Features.Core.Lessons.GetLessonById.Queries
{
    public class GetLessonByIdQueryHandler : IRequestHandler<GetLessonByIdQuery, TResponse<object>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IResourceService _resourceService;
        private readonly ICurrentUserService _currentUserService;

        public GetLessonByIdQueryHandler(
            IUnitOfWork unitOfWork,
            IResourceService resourceService,
            ICurrentUserService currentUserService)
        {
            _unitOfWork = unitOfWork;
            _resourceService = resourceService;
            _currentUserService = currentUserService;
        }

        public async Task<TResponse<object>> Handle(GetLessonByIdQuery request, CancellationToken cancellationToken)
        {
            // Fetch the lesson from the repository
            var lesson = await _unitOfWork.LessonRepository.GetByIdAsync(
                l => l.Id == request.LessonId,
                includeProperties: "LessonParts.InteractiveElements,Quizzes.Questions",
                cancellationToken: cancellationToken
            );

            if (lesson == null)
            {
                return TResponse<object>.Failure(
                    new[] { _resourceService.GetError("LessonNotFound") },
                    _resourceService.GetError("LessonNotFound"),
                    404
                );
            }

            // Retrieve UserId from CurrentUserService
            var userId = _currentUserService.UserId;
            if (string.IsNullOrEmpty(userId))
            {
                return TResponse<object>.Failure(
                    new[] { _resourceService.GetError("UnauthorizedAccess") },
                    _resourceService.GetError("UnauthorizedAccess"),
                    401
                );
            }

            // Convert userId to Guid
            var userGuid = Guid.Parse(userId);

            // Check user type
            var user = await _unitOfWork.Users.FindById(userGuid, cancellationToken);

            // Build Lesson DTO
            var lessonDto = BuildLessonDto(lesson);

            if (user.UserType == UserTypeEnum.Student)
            {
                return await HandleStudentView(lesson, lessonDto, request, userGuid, cancellationToken);
            }
            else if (user.UserType == UserTypeEnum.Instructor)
            {
                return await HandleInstructorView(lesson, lessonDto, userGuid, cancellationToken);
            }

            return TResponse<object>.Failure(
                new[] { _resourceService.GetError("UnauthorizedAccess") },
                _resourceService.GetError("UnauthorizedAccess"),
                403
            );
        }

        private GetLessonAfterLoginDto BuildLessonDto(Lesson lesson)
        {
            return new GetLessonAfterLoginDto
            {
                Id = lesson.Id,
                NameAr = lesson.NameAr,
                NameEn = lesson.NameEn,
                DescriptionAr = lesson.DescriptionAr,
                DescriptionEn = lesson.DescriptionEn,
                CoverPhoto = lesson.CoverPhoto,
                TitleAr = lesson.TitleAr,
                TitleEn = lesson.TitleEn,
                CreationDate = lesson.CreationDate,
                Resources = lesson.Resources,
                HasCodeEditor = lesson.HasCodeEditor,
                CodeEditorLanguage = lesson.CodeEditorLanguage,
                CodeEditorInitialCode = lesson.CodeEditorInitialCode,
                SectionId = lesson.SectionId,
                LessonParts = lesson.LessonParts.Select(part => new GetLessonPartDto
                {
                    Id = part.Id,
                    LessonId = part.LessonId,
                    Content = part.Content,
                    InteractiveElements = part.InteractiveElements.Select(e => new GetInteractiveElementDto
                    {
                        Id = e.Id,
                        LessonPartId = e.LessonPartId,
                        ZipUrl = e.ZipUrl
                    }).ToList()
                }).ToList(),
                Quizzes = lesson.Quizzes?.Select(quiz => new GetQuizDto
                {
                    Id = quiz.Id,
                    Name = quiz.Name,
                    Questions = quiz.Questions?.Select(q => new GetQuestionDto
                    {
                        QuestionText = q.QuestionText,
                        QuestionType = q.QuestionType,
                        Options = q.Options,
                        CorrectAnswers = q.CorrectAnswers,
                        MatchingPairs = q.MatchingPairs,
                        Answer = q.Answer
                    }).ToList()
                }).ToList()
            };
        }

        private async Task<TResponse<object>> HandleStudentView(Lesson lesson, GetLessonAfterLoginDto lessonDto, GetLessonByIdQuery request, Guid userGuid, CancellationToken cancellationToken)
        {
            var classEntity = await _unitOfWork.ClassRepository.GetByIdAsync(request.ClassId.Value, cancellationToken);
            if (classEntity == null || !classEntity.Students.Any(s => s.Id == userGuid))
            {
                return TResponse<object>.Failure(
                    new[] { _resourceService.GetError("NotEnrolledInClass") },
                    _resourceService.GetError("NotEnrolledInClass"),
                    403
                );
            }

            var section = await _unitOfWork.SectionRepository.GetByIdAsync(s => s.Id == lesson.SectionId, cancellationToken: cancellationToken);
            if (section == null || section.CourseId != classEntity.CourseId)
            {
                return TResponse<object>.Failure(
                    new[] { _resourceService.GetError("LessonCourseMismatch") },
                    _resourceService.GetError("LessonCourseMismatch"),
                    404
                );
            }

            var lessonOverride = await _unitOfWork.InstructorCourseOverrideRepository
                .FirstOrDefaultAsync(o => o.InstructorId == classEntity.InstructorId && o.LessonId == lesson.Id, cancellationToken);

            var overriddenLesson = ApplyOverrides(lessonDto, lessonOverride, UserTypeEnum.Student, cancellationToken);
            return TResponse<object>.Success(overriddenLesson);
        }

        private async Task<TResponse<object>> HandleInstructorView(Lesson lesson, GetLessonAfterLoginDto lessonDto, Guid userGuid, CancellationToken cancellationToken)
        {
            var section = await _unitOfWork.SectionRepository.GetByIdAsync(s => s.Id == lesson.SectionId, cancellationToken: cancellationToken);
            var courseId = section?.CourseId;
            if (!await _unitOfWork.InstructorCoursesRepository.AnyAsync(userGuid, courseId.Value))
            {
                return TResponse<object>.Failure(
                    new[] { _resourceService.GetError("InstructorAccessDenied") },
                    _resourceService.GetError("InstructorAccessDenied"),
                    403
                );
            }

            var lessonOverride = await _unitOfWork.InstructorCourseOverrideRepository
                .FirstOrDefaultAsync(o => o.InstructorId == userGuid && o.LessonId == lesson.Id, cancellationToken);

            var overriddenLesson = ApplyOverrides(lessonDto, lessonOverride, UserTypeEnum.Instructor, cancellationToken);
            return TResponse<object>.Success(overriddenLesson);
        }

        //private object ApplyOverrides(GetLessonAfterLoginDto lessonDto, InstructorCourseOverride lessonOverride, UserTypeEnum userType, CancellationToken cancellationToken)
        //{
        //    var overriddenLessonParts = lessonDto.LessonParts.Select(part =>
        //    {
        //        var partOverride = _unitOfWork.InstructorCourseOverrideRepository
        //            .FirstOrDefaultAsync(o => o.LessonPartId == part.Id && o.LessonId == lessonDto.Id, cancellationToken).Result;

        //        var interactiveElements = part.InteractiveElements.Select(element =>
        //        {
        //            var elementOverride = _unitOfWork.InstructorCourseOverrideRepository
        //                .FirstOrDefaultAsync(o => o.InteractiveElementId == element.Id, cancellationToken).Result;

        //            return new
        //            {
        //                element.Id,
        //                element.ZipUrl,
        //                HideInteractiveElement = elementOverride?.HideInteractiveElement == true
        //            };
        //        }).Where(e => !e.HideInteractiveElement).ToList();

        //        return new
        //        {
        //            part.Id,
        //            Content = partOverride?.CustomLessonPartContent ?? part.Content,
        //            HideLessonPart = partOverride?.HideLessonPart == true,
        //            InteractiveElements = interactiveElements
        //        };
        //    }).Where(part => !part.HideLessonPart).ToList();

        //    var overriddenQuizzes = lessonDto.Quizzes?.Select(quiz =>
        //    {
        //        var quizOverride = _unitOfWork.InstructorCourseOverrideRepository
        //            .FirstOrDefaultAsync(o => o.QuizId == quiz.Id, cancellationToken).Result;

        //        return new
        //        {
        //            quiz.Id,
        //            quiz.Name,
        //            HideQuiz = quizOverride?.HideQuiz == true,
        //            Questions = quiz.Questions
        //        };
        //    }).Where(quiz => !quiz.HideQuiz).ToList();

        //    return new
        //    {
        //        lessonDto.Id,
        //        lessonDto.NameAr,
        //        lessonDto.NameEn,
        //        DescriptionAr = lessonOverride?.CustomLessonDescriptionAr ?? lessonDto.DescriptionAr,
        //        DescriptionEn = lessonOverride?.CustomLessonDescriptionEn ?? lessonDto.DescriptionEn,
        //        HideLesson= lessonOverride.HideLesson,
        //        TitleAr = lessonOverride?.CustomTitleAr ?? lessonDto.TitleAr,
        //        TitleEn = lessonOverride?.CustomTitleEn ?? lessonDto.TitleEn,
        //        Resources = lessonDto.Resources,
        //        CoverPhoto = lessonDto.CoverPhoto,
        //        LessonParts = overriddenLessonParts,
        //        Quizzes = overriddenQuizzes
        //    };
        //}
        private object ApplyOverrides(GetLessonAfterLoginDto lessonDto, InstructorCourseOverride? lessonOverride, UserTypeEnum userType, CancellationToken cancellationToken)
        {
            var isStudent = userType == UserTypeEnum.Student;

            // Process lesson parts
            var overriddenLessonParts = lessonDto.LessonParts
                .Select<GetLessonPartDto, object?>(part => // Explicit type for Select
                {
                    var partOverride = _unitOfWork.InstructorCourseOverrideRepository
                        .FirstOrDefaultAsync(o => lessonOverride != null &&
                                                  o.InstructorId == lessonOverride.InstructorId &&
                                                  o.CourseId == lessonOverride.CourseId &&
                                                  o.LessonPartId == part.Id, cancellationToken)
                        .Result;

                    // Process interactive elements
                    var interactiveElements = part.InteractiveElements
                        .Select<GetInteractiveElementDto, object?>(element => // Explicit type for Select
                        {
                            var elementOverride = _unitOfWork.InstructorCourseOverrideRepository
                                .FirstOrDefaultAsync(o => lessonOverride != null &&
                                                          o.InstructorId == lessonOverride.InstructorId &&
                                                          o.CourseId == lessonOverride.CourseId &&
                                                          o.InteractiveElementId == element.Id, cancellationToken)
                                .Result;

                            var isHidden = elementOverride?.HideInteractiveElement == true;

                            return isStudent
                                ? (isHidden ? null : new { element.Id, element.ZipUrl })
                                : new { element.Id, element.ZipUrl, IsHidden = isHidden };
                        })
                        .Where(e => e != null)
                        .ToList();

                    var isPartHidden = partOverride?.HideLessonPart == true;

                    return isStudent
                        ? (isPartHidden ? null : new
                        {
                            part.Id,
                            Content = partOverride?.CustomLessonPartContent ?? part.Content,
                            InteractiveElements = interactiveElements
                        })
                        : new
                        {
                            part.Id,
                            Content = partOverride?.CustomLessonPartContent ?? part.Content,
                            IsHidden = isPartHidden,
                            InteractiveElements = interactiveElements
                        };
                })
                .Where(part => part != null)
                .ToList();

            // Process quizzes
            var overriddenQuizzes = lessonDto.Quizzes?
                .Select<GetQuizDto, object?>(quiz => // Explicit type for Select
                {
                    var quizOverride = _unitOfWork.InstructorCourseOverrideRepository
                        .FirstOrDefaultAsync(o => lessonOverride != null &&
                                                  o.InstructorId == lessonOverride.InstructorId &&
                                                  o.CourseId == lessonOverride.CourseId &&
                                                  o.QuizId == quiz.Id, cancellationToken)
                        .Result;

                    var isHidden = quizOverride?.HideQuiz == true;

                    return isStudent
                        ? (isHidden ? null : new { quiz.Id, quiz.Name, Questions = quiz.Questions })
                        : new { quiz.Id, quiz.Name, IsHidden = isHidden, Questions = quiz.Questions };
                })
                .Where(quiz => quiz != null)
                .ToList();

            // Return lesson with applied overrides
            return new
            {
                lessonDto.Id,
                lessonDto.NameAr,
                lessonDto.NameEn,
                DescriptionAr = lessonOverride?.CustomLessonDescriptionAr ?? lessonDto.DescriptionAr,
                DescriptionEn = lessonOverride?.CustomLessonDescriptionEn ?? lessonDto.DescriptionEn,
                TitleAr = lessonOverride?.CustomTitleAr ?? lessonDto.TitleAr,
                TitleEn = lessonOverride?.CustomTitleEn ?? lessonDto.TitleEn,
                CoverPhoto = lessonDto.CoverPhoto,
                Resources = lessonDto.Resources,
                HasCodeEditor = lessonDto.HasCodeEditor,
                CodeEditorLanguage = lessonDto.CodeEditorLanguage,
                CodeEditorInitialCode = lessonDto.CodeEditorInitialCode,
                HideCodeEditor=lessonOverride?.HideCodeEditor==true,
                HideLesson = lessonOverride?.HideLesson == true,
                LessonParts = overriddenLessonParts,
                Quizzes = overriddenQuizzes
            };
        }


    }
}
