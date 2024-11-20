using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.Core.Classes.Quieries.CoursesOfJoinedClasses;
public class GetCoursesOfJoinedClassesQueryHandler : IRequestHandler<GetCoursesOfJoinedClassesQuery, TResponse<List<CoursesOfJoinedClassDto>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUserService _currentUserService;

    public GetCoursesOfJoinedClassesQueryHandler(IUnitOfWork unitOfWork, ICurrentUserService currentUserService)
    {
        _unitOfWork = unitOfWork;
        _currentUserService = currentUserService;
    }

    public async Task<TResponse<List<CoursesOfJoinedClassDto>>> Handle(GetCoursesOfJoinedClassesQuery request, CancellationToken cancellationToken)
    {
        // Step 1: Ensure the student is authenticated
        var userId = _currentUserService.UserId;
        if (string.IsNullOrEmpty(userId))
        {
            return TResponse<List<CoursesOfJoinedClassDto>>.Failure(
                new[] { "Unauthorized access" },
                "User must be logged in",
                401);
        }

        // Parse the user ID
        var studentId = Guid.Parse(userId);

        // Step 2: Retrieve the joined classes for the student
        var joinedClasses = await _unitOfWork.ClassRepository.GetClassesByStudentAsync(studentId, cancellationToken);
        if (joinedClasses == null || !joinedClasses.Any())
        {
            return TResponse<List<CoursesOfJoinedClassDto>>.Failure(
                new[] { "No joined classes found" },
                "The student has not joined any classes",
                404);
        }

        // Step 3: Get distinct courses associated with the joined classes
        var courseIds = joinedClasses.Select(c => c.CourseId).Distinct();
        var courses = await _unitOfWork.CouresRepository.GetByIdsAsync(courseIds, cancellationToken);

        if (courses == null || !courses.Any())
        {
            return TResponse<List<CoursesOfJoinedClassDto>>.Failure(
                new[] { "Courses not found" },
                "No courses found for the joined classes",
                404);
        }

        // Step 4: Map the courses to CourseDto
        //var courseDtos = courses.Select(course => new CourseDto
        //{
        //    Id = course.Id,
        //    NameAr = course.NameAr,
        //    NameEn = course.NameEn,
        //    DiscriptionAr = course.DiscriptionAr,
        //    DiscriptionEn = course.DiscriptionEn,
        //    CoverPhoto= course.CoverPhoto,
        //}).ToList();
        // Step 4: Map the courses to CourseDto with ClassId included
        var courseDtos = joinedClasses.Select(classEntity =>
        {
            var course = courses.FirstOrDefault(c => c.Id == classEntity.CourseId);
            if (course == null) return null;

            return new CoursesOfJoinedClassDto
            {
                Id = course.Id,
                ClassId = classEntity.Id,
                NameAr = course.NameAr,
                NameEn = course.NameEn,
                DiscriptionAr = course.DiscriptionAr,
                DiscriptionEn = course.DiscriptionEn,
                CoverPhoto = course.CoverPhoto,



            };
        }).Where(dto => dto != null).ToList();

        // Return success response with list of CourseDto
        return TResponse<List<CoursesOfJoinedClassDto>>.Success(courseDtos);
    }
}
public class CoursesOfJoinedClassDto
{
    public Guid Id { get; set; }
    //public Guid? ClassId { get; set; }  // Add the ClassId property
    public Guid ClassId { get; set; }        // ID of the class associated with the course

    public string NameAr { get; set; } = default!;
    public string NameEn { get; set; } = default!;
    public string DiscriptionAr { get; set; } = default!;
    public string DiscriptionEn { get; set; } = default!;
    public string CoverPhoto { get; set; } = default!;
    //public List<SectionDto> Sections { get; set; } = new List<SectionDto>();
}