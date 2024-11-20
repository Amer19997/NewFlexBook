using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.Core.Courses.InstructorCourses.Quireies;
using FlexBook.Application.Features.LookUps.Courses.Queries.GetCourses;
using FlexBook.Domain;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Entities.Catalog.Dtos.InstructorAfterLogin;
using FlexBook.Domain.Entities.Catalog.Dtos.StudentAfterLogin;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Enums;
using FlexBook.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Application.Features.Core.Courses.Queries
{
    public class GetAvailableCoursesQueryHandler : IRequestHandler<GetAvailableCoursesQuery, TResponse<List<object>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUserService _currentUserService;
        private readonly IResourceService _resourceService;

        public GetAvailableCoursesQueryHandler(
            IUnitOfWork unitOfWork,
            ICurrentUserService currentUserService,
            IResourceService resourceService)
        {
            _unitOfWork = unitOfWork;
            _currentUserService = currentUserService;
            _resourceService = resourceService;
        }

        public async Task<TResponse<List<object>>> Handle(GetAvailableCoursesQuery request, CancellationToken cancellationToken)
        {
            // Check if the user is authenticated and get the user ID
            var userId = _currentUserService.UserId;
            if (string.IsNullOrEmpty(userId))
            {
                return TResponse<List<object>>.Failure(
                    new[] { _resourceService.GetError("UnauthorizedAccess") },
                    _resourceService.GetError("UnauthorizedAccess"),
                    401);
            }

            // Convert userId to GUID and retrieve user details
            var userGuid = Guid.Parse(userId);
            var user = await _unitOfWork.Users.FindById(userGuid, cancellationToken);
            if (user == null)
            {
                return TResponse<List<object>>.Failure(
                    new[] { _resourceService.GetError("UserNotFound") },
                    _resourceService.GetError("UserNotFound"),
                    404);
            }

            // Build the base query for courses based on user type
            IQueryable<Course> coursesQuery = user.UserType switch
            {
                UserTypeEnum.Student => user.FacultyId.HasValue && user.SpecializationId.HasValue
                    ? _unitOfWork.CouresRepository.GetCoursesByConditions(
                        user.UniversityId,
                        user.FacultyId.Value,
                        user.DepartmentId,
                        user.SpecializationId.Value)
                    : _unitOfWork.CouresRepository.GetCoursesByUniversityAndDepartment(
                        user.UniversityId,
                        user.DepartmentId),

                UserTypeEnum.Instructor => user.FacultyId.HasValue && user.SpecializationId.HasValue
                    ? _unitOfWork.CouresRepository.GetCoursesByConditions(
                        user.UniversityId,
                        user.FacultyId.Value,
                        user.DepartmentId,
                        user.SpecializationId.Value)
                    : _unitOfWork.CouresRepository.GetCoursesByUniversityAndDepartment(
                        user.UniversityId,
                        user.DepartmentId),

                _ => null
            };

            if (coursesQuery == null)
            {
                return TResponse<List<object>>.Failure(
                    new[] { _resourceService.GetError("UnauthorizedAccess") },
                    _resourceService.GetError("UnauthorizedAccess"),
                    403);
            }

            // Apply filtering by keyword if provided
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                coursesQuery = coursesQuery.Where(c =>
                    c.NameEn.Contains(request.Keyword) || c.NameAr.Contains(request.Keyword));
            }

            // Apply sorting based on the SortBy and SortDirection fields
            coursesQuery = request.SortDirection.ToLower() == "desc"
                ? coursesQuery.OrderByDescending(c => EF.Property<object>(c, request.SortBy))
                : coursesQuery.OrderBy(c => EF.Property<object>(c, request.SortBy));

            // Apply pagination
            coursesQuery = coursesQuery.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize);

            // Execute the query and convert the result to a list
            var courseList = await coursesQuery.ToListAsync(cancellationToken);

            // Map the courses to the appropriate DTO based on the user type
            var courseDtos = user.UserType == UserTypeEnum.Student
                ? courseList.Select(course => new StudentCourseDto
                {
                    CourseId = course.Id,
                    CourseNameEn = course.NameEn,
                    CourseNameAr = course.NameAr,
                    CourseDescriptionEn = course.DiscriptionEn,
                    CourseDescriptionAr = course.DiscriptionAr,
                    CourseCode = course.Code,
                    CoverPhoto = course.CoverPhoto
                }).ToList<object>()
                : courseList.Select(course => new InstructorCourseDto
                {
                    CourseId = course.Id,
                    CourseNameEn = course.NameEn,
                    CourseNameAr = course.NameAr,
                    CourseDescriptionEn = course.DiscriptionEn,
                    CourseDescriptionAr = course.DiscriptionAr,
                    CourseCode = course.Code,
                    CoverPhoto = course.CoverPhoto
                }).ToList<object>();
            // Save the available courses to the appropriate table based on user type
            if (user.UserType == UserTypeEnum.Student)
            {
                foreach (var course in courseList)
                {
                    // Check if the student-course association already exists
                    var exists = await _unitOfWork.StudentAvailableCoursesRepository.AnyAsync(userGuid, course.Id);
                    if (!exists)
                    {
                        await _unitOfWork.StudentAvailableCoursesRepository.AddAsync(new StudentAvailableCourse
                        {
                            StudentId = userGuid,
                            CourseId = course.Id,
                        });
                    }
                }
            }
            else if (user.UserType == UserTypeEnum.Instructor)
            {
                foreach (var course in courseList)
                {
                    // Check if the instructor-course association already exists
                    var exists = await _unitOfWork.InstructorCoursesRepository.AnyAsync(userGuid, course.Id);
                    if (!exists)
                    {
                        await _unitOfWork.InstructorCoursesRepository.AddAsync(new InstructorAvailableCourse
                        {
                            InstructorId = userGuid,
                            CourseId = course.Id,

                        });
                    }
                }
            }

            // Save changes to database
            await _unitOfWork.CommitAsync(cancellationToken);
            return TResponse<List<object>>.Success(courseDtos);
        }
    }
}
