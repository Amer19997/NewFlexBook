using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain;
using MediatR;
using X.PagedList;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.LookUps.Courses.Queries.GetCourses;
using FlexBook.Application.Users.Commands.SignUpCommand;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Enums;

namespace FlexBook.Application.Features.LookUps.Courses.Queries.GetCourseById;



public class GetCourseByIdQueryHandler : IRequestHandler<GetCourseByIdQuery, TResponse<object>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IResourceService _resourceService;
    private readonly ICurrentUserService _currentUserService;

    public GetCourseByIdQueryHandler(
        IUnitOfWork unitOfWork,
        IMapper mapper,
        IResourceService resourceService,
        ICurrentUserService currentUserService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _resourceService = resourceService;
        _currentUserService = currentUserService;
    }

    public async Task<TResponse<object>> Handle(GetCourseByIdQuery request, CancellationToken cancellationToken)
    {
        // Retrieve course with sections, lessons, and quizzes
        var course = await _unitOfWork.CouresRepository.GetByIdAsync(
            c => c.Id == request.CourseId,
            "Sections,Sections.Lessons,Sections.Quizzes",
            cancellationToken);

        if (course == null)
        {
            return TResponse<object>.Failure(
                new[] { _resourceService.GetError("Course not found.") },
                _resourceService.GetError("Course not found."),
                404);
        }

        // Check if user is authenticated
        var userId = _currentUserService.UserId;
        if (string.IsNullOrEmpty(userId))
        {
            // User is not signed in, return the base CourseDetailDTO
            //var coursedto = _mapper.Map<CourseDetailDTO>(course);
            return TResponse<object>.Success(MapToCourseDetailDto(course));

            //return TResponse<object>.Success(coursedto);
        }

        // Convert userId to Guid
        var userGuid = Guid.Parse(userId);
        var user = await _unitOfWork.Users.FindById(userGuid, cancellationToken);

        if (user.UserType == UserTypeEnum.Student)
        {
            // Validate student enrollment in the course
            // If ClassId is null, return the master course view (CourseDetailDTO)
            if (request.ClassId == null)
            {
                return TResponse<object>.Success(MapToCourseDetailDto(course));

                //return TResponse<object>.Success(_mapper.Map<CourseDetailDTO>(course));
            }
            var classEntity = await _unitOfWork.ClassRepository.GetByIdAsync(request.ClassId.Value, cancellationToken);

            if (classEntity == null || !classEntity.Students.Any(s => s.Id == userGuid))
            {
                // Student is not enrolled, return the master course view (CourseDetailDTO)
                return TResponse<object>.Success(MapToCourseDetailDto(course));

                //return TResponse<object>.Success(_mapper.Map<CourseDetailDTO>(course));
            }

            // Fetch instructor overrides for this course, for filtering hidden content
            var courseOverride = await _unitOfWork.InstructorCourseOverrideRepository
                .GetOverridesForInstructorAndCourse(classEntity.InstructorId, request.CourseId, cancellationToken);

            // Apply overrides and filter hidden content for students
            var overriddenCourse = ApplyCourseOverrides(course, courseOverride, user.UserType, hideForStudents: true);
            return TResponse<object>.Success(overriddenCourse);
        }
        else if (user.UserType == UserTypeEnum.Instructor)
        {
            // Verify instructor's access to the course
            var hasAccess = await _unitOfWork.InstructorCoursesRepository.AnyAsync(userGuid, request.CourseId);
            if (!hasAccess)
            {
                return TResponse<object>.Success(MapToCourseDetailDto(course));

                //return TResponse<object>.Success(_mapper.Map<CourseDetailDTO>(course));

            }

            // Retrieve instructor-specific overrides for customization
            var courseOverride = await _unitOfWork.InstructorCourseOverrideRepository
                .GetOverridesForInstructorAndCourse(userGuid, request.CourseId, cancellationToken);

            // Apply overrides for instructors without hiding any content
            var overriddenCourse = ApplyCourseOverrides(course, courseOverride, user.UserType, hideForStudents: false);
            return TResponse<object>.Success(overriddenCourse);
        }

        return TResponse<object>.Failure(
            new[] { _resourceService.GetError("UnauthorizedAccess") },
            _resourceService.GetError("UnauthorizedAccess"),
            403);
    }
    private CourseDetailDTO MapToCourseDetailDto(Course course)
    {
        return new CourseDetailDTO
        {
            NameAr = course.NameAr,
            NameEn = course.NameEn,
            DiscriptionAr = course.DiscriptionAr,
            DiscriptionEn = course.DiscriptionEn,
            CoverPhoto = course.CoverPhoto,
            Sections = course.Sections.Select(section => new SectionDto
            {
                Id = section.Id,
                TitleAr = section.TitleAr,
                TitleEn = section.TitleEn,
                CourseId = course.Id,
                Lessons = section.Lessons.Select(lesson => new LessonDto
                {
                    Id = lesson.Id,
                    NameAr = lesson.NameAr,
                    NameEn = lesson.NameEn
                }).ToList(),
                Quizzes = section.Quizzes.Select(quiz => new Domain.Entities.Catalog.Dtos.QuizDto
                {
                    Id = quiz.Id,
                    Name = quiz.Name
                }).ToList()
            }).ToList()
        };
    }
    private object ApplyCourseOverrides(Course course, IEnumerable<InstructorCourseOverride> overrides, UserTypeEnum userType, bool hideForStudents)
    {
        return new
        {
            course.Id,
            course.NameAr,
            course.NameEn,
            course.DiscriptionEn,
            course.DiscriptionAr,
            course.CoverPhoto,
            Sections = course.Sections.Select(section =>
            {
                var sectionOverride = overrides.FirstOrDefault(o => o.SectionId == section.Id);
                bool isSectionHidden = sectionOverride?.HideSection == true;

                // Hide section if it's marked as hidden for students
                if (hideForStudents && isSectionHidden) return null;

                return new
                {
                    section.Id,
                    section.TitleAr,
                    section.TitleEn,
                    IsHidden = isSectionHidden,
                    Lessons = section.Lessons.Select(lesson =>
                    {
                        var lessonOverride = overrides.FirstOrDefault(o => o.LessonId == lesson.Id);
                        bool isLessonHidden = lessonOverride?.HideLesson == true;

                        // Hide lesson if it's marked as hidden for students
                        if (hideForStudents && isLessonHidden) return null;

                        return new
                        {
                            lesson.Id,
                            lesson.NameEn,
                            lesson.NameAr,
                            IsHidden = isLessonHidden
                        };
                    }).Where(l => l != null).ToList(), // Filter out hidden lessons for students
                    Quizzes = section.Quizzes.Select(quiz => new
                    {
                        quiz.Id,
                        quiz.Name
                    }).ToList()
                };
            }).Where(s => s != null).ToList() // Filter out hidden sections for students
        };
    }
}







