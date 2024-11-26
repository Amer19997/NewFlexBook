using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Exceptions;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.Core.Courses.InstructorCourses.Quireies;
using System.ComponentModel.Design;
using IResourceService = FlexBook.Application.Common.Interfaces.IResourceService;

namespace FlexBook.Application.Features.Core.Courses.CourseContentForInstructor;
// Handler for processing GetCourseContentForInstructorQuery
public class GetCourseContentForInstructorQueryHandler : IRequestHandler<GetCourseContentForInstructorQuery, GetCourseContentAfterLoginDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUserService _currentUserService;
    private readonly IResourceService _resourceService;

    public GetCourseContentForInstructorQueryHandler(IUnitOfWork unitOfWork, ICurrentUserService currentUserService, Common.Interfaces.IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _currentUserService = currentUserService;
        _resourceService = resourceService;
    }

    public async Task<GetCourseContentAfterLoginDto> Handle(GetCourseContentForInstructorQuery request, CancellationToken cancellationToken)
    {
   
        
            // Check if the user is authenticated and get the user ID
            var userId = _currentUserService.UserId;
      

        // Convert userId to Guid
        var userGuid = Guid.Parse(userId);

        //if (string.IsNullOrEmpty(userId))
        //{
        //    return TResponse<List<GetCourseContentAfterLoginDto>>.Failure(
        //        new[] { _resourceService.GetError("UnauthorizedAccess") },
        //        _resourceService.GetError("UnauthorizedAccess"),
        //        401);
        //}
        // Check if the instructor has access to the course
        var hasCourse = await _unitOfWork.InstructorCoursesRepository.AnyAsync(userGuid, request.CourseId);
        if (!hasCourse)
        {
            throw new NotFoundException("Instructor does not have access to this course.");
        }
        // Explicitly set the related entities to include (Sections, Lessons, and Quizzes)
        string includeProperties = "Sections,Sections.Lessons,Sections.Quizzes";

        // Call GetByIdAsync directly with the set includeProperties
        var course = await _unitOfWork.CouresRepository.GetByIdAsync(
            c => c.Id == request.CourseId,  // Filter by CourseId
            includeProperties,              // Include Sections, Lessons, and Quizzes
            cancellationToken);
        if (course == null)
            // Fetch the course with its sections and lessons
            //var course = await _unitOfWork.CouresRepository.GetByIdWithSectionsAndLessonsAsync(request.CourseId, cancellationToken);
            if (course == null)
            {
                throw new NotFoundException("Course not found.");
            }

        // Fetch instructor overrides for this course
        var instructorOverrides = await _unitOfWork.InstructorCourseOverrideRepository
            .GetOverridesForInstructorAndCourse(userGuid, request.CourseId, cancellationToken);

        // Build the CourseContentDto with the applied instructor overrides
        var courseContentDto = new GetCourseContentAfterLoginDto
        {
            CourseId = course.Id,
            NameAr = course.NameAr,
            NameEn = course.NameEn,
            DiscriptionEn = course.DiscriptionEn,
            DiscriptionAr = course.DiscriptionAr,
            CoverPhoto = course.CoverPhoto,
            Sections = course.Sections.Select(section =>
            {
                var sectionOverride = instructorOverrides.FirstOrDefault(o => o.SectionId == section.Id);

                var sectionDto = new GetSectionAfterInstructorLoginDTo
                {
                    Id = section.Id,
                    TitleAr = section.TitleAr,
                    TitleEn = section.TitleEn,
                    IsHidden = sectionOverride?.HideSection == true,
                    Lessons = section.Lessons.Select(lesson =>
                    {
                        var lessonOverride = instructorOverrides.FirstOrDefault(o => o.LessonId == lesson.Id);

                        return new GetLessonAfterInstructorLoginDto
                        {
                            Id = lesson.Id,
                            NameEn = lesson.NameEn,
                            NameAr = lesson.NameAr,

                            IsHidden = lessonOverride?.HideLesson == true,
                        };
                    }).ToList(),
                    Quizzes = section.Quizzes.Select(quiz => new QuizAfterInstructorLoginDto
                    {
                        Id = quiz.Id,
                        Name = quiz.Name
                    }).ToList()
                };

                return sectionDto;
            }).ToList()
        };

        return courseContentDto;
    }
}