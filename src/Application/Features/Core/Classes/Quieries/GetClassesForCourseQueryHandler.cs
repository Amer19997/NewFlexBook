using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Domain;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;

namespace FlexBook.Application.Features.Core.Classes.Quieries;
public class GetClassesForCourseQueryHandler : IRequestHandler<GetClassesForCourseQuery, TResponse<List<GetAvailableClassDto>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUserService _currentUserService;

    public GetClassesForCourseQueryHandler(IUnitOfWork unitOfWork, ICurrentUserService currentUserService)
    {
        _unitOfWork = unitOfWork;
        _currentUserService = currentUserService;
    }

    public async Task<TResponse<List<GetAvailableClassDto>>> Handle(GetClassesForCourseQuery request, CancellationToken cancellationToken)
    {
        // Check if the user is logged in by verifying UserId from the current user service
        var userId = _currentUserService.UserId;
        if (string.IsNullOrEmpty(userId))
        {
            return TResponse<List<GetAvailableClassDto>>.Failure(
                new[] { "Unauthorized access" },
                "User must be logged in",
                401);
        }

        // Ensure that the student exists in the system
        var studentGuid = Guid.Parse(userId);
        var student = await _unitOfWork.Users.FindById(studentGuid, cancellationToken);
        if (student == null)
        {
            return TResponse<List<GetAvailableClassDto>>.Failure(
                new[] { "Student not found" },
                "Student not found",
                404);
        }

        // Get classes for the course matching the student’s affiliation criteria
        var classes = await _unitOfWork.ClassRepository.GetClassesByCourseAndAffiliationAsync(
            request.CourseId,
            student.UniversityId,
            student.FacultyId,
            student.DepartmentId,
            student.SpecializationId,
            cancellationToken);
        // Apply optional class name filter
        if (!string.IsNullOrEmpty(request.ClassName))
        {
            classes = classes.Where(cls => cls.ClassName.Contains(request.ClassName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        // Return a message if no classes are available for this course
        if (classes == null || classes.Count == 0)
        {
            return TResponse<List<GetAvailableClassDto>>.Failure(
                new[] { "No classes available for this course" },
                "No classes available for this course",
                404);
        }

        // Map the retrieved classes to GetAvailableClassDto
        var classDtos = new List<GetAvailableClassDto>();
        foreach (var cls in classes)
        {
            // Optional: Check enrollment status of the student for each class
            //var isEnrolled = await _unitOfWork.StudentClassRepository
            //    .IsStudentEnrolledInClassAsync(studentGuid, cls.Id, cancellationToken);

            classDtos.Add(new GetAvailableClassDto
            {
                ClassId = cls.Id,
                ClassName = cls.ClassName,
                Syllabus = cls.Syllabus,
                InstructorName = $"{cls.Instructor.FirstName} {cls.Instructor.LastName}",
                //IsEnrolled = isEnrolled
            });
        }

        // Return successful response with class DTOs and message
        return TResponse<List<GetAvailableClassDto>>.Success(classDtos, "Classes retrieved successfully");
    }
}
