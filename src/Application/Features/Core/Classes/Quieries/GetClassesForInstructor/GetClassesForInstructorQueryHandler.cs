using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using FlexBook.Domain;
using MediatR;
using FlexBook.Domain.Entities.Catalog.Dtos.Get.Instructor;

namespace FlexBook.Application.Features.Core.Classes.Quieries.GetClassesForInstructor;
public class GetClassesForInstructorQueryHandler : IRequestHandler<GetClassesForInstructorQuery, TResponse<List<GetInstructorClassDto>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUserService _currentUserService;

    public GetClassesForInstructorQueryHandler(IUnitOfWork unitOfWork, ICurrentUserService currentUserService)
    {
        _unitOfWork = unitOfWork;
        _currentUserService = currentUserService;
    }

    public async Task<TResponse<List<GetInstructorClassDto>>> Handle(GetClassesForInstructorQuery request, CancellationToken cancellationToken)
    {
        // Check if the user is logged in
        var userId = _currentUserService.UserId;
        if (string.IsNullOrEmpty(userId))
        {
            return TResponse<List<GetInstructorClassDto>>.Failure(
                new[] { "Unauthorized access" },
                "User must be logged in",
                401);
        }

        // Parse the userId to Guid
        var instructorId = Guid.Parse(userId);

        // Fetch all classes associated with the instructor
        var classes = await _unitOfWork.ClassRepository.GetClassesByInstructorAsync(instructorId, cancellationToken);

        // Return a message if no classes are found
        if (classes == null )
        {
            return TResponse<List<GetInstructorClassDto>>.Failure(
                new[] { "No classes found for this instructor" },
                "No classes found for this instructor",
                404);
        }

        // Map the classes to GetAvailableClassDto
        var classDtos = new List<GetInstructorClassDto>();
        foreach (var cls in classes)
        {
            classDtos.Add(new GetInstructorClassDto
            {
              ClassId = cls.Id,
                    ClassNameEn = cls.ClassName,
                    Syllabus = cls.Syllabus,
                    InstructorName = $"{cls.Instructor.FirstName} {cls.Instructor.LastName}",
                    CourseNameEn = cls.Course?.NameEn,
                    CourseNameAr = cls.Course?.NameAr,
                FacultyNameAr = cls.Instructor?.Faculty.NameAr,

                FacultyNameEn = cls.Instructor?.Faculty.NameEn,
                    DepartmentNameEn = cls.Instructor?.Department.NameEn,
                DepartmentNameAr = cls.Instructor?.Department.NameAr,

            });
        }

        return TResponse<List<GetInstructorClassDto>>.Success(classDtos, "Classes retrieved successfully");
    }
}
