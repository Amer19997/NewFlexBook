using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Exceptions;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Domain;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.UsersAggregate;
using FlexBook.Domain.Repositories;
using MediatR;

namespace FlexBook.Application.Features.Core.ClassRequests.Quireies;

public class GetAllClassRequestsForInstructorQueryHandler : IRequestHandler<GetAllClassRequestsForInstructorQuery, TResponse<IEnumerable<object>>>
{
    private readonly IClassRequestRepository _classRequestRepository;
    private readonly ICurrentUserService _currentUserService;
    private readonly IUnitOfWork _unitOfWork;
    
    public GetAllClassRequestsForInstructorQueryHandler(IClassRequestRepository classRequestRepository, ICurrentUserService currentUserService, IUnitOfWork unitOfWork)
    {
        _classRequestRepository = classRequestRepository;
        _currentUserService = currentUserService;
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse<IEnumerable<object>>> Handle(GetAllClassRequestsForInstructorQuery request, CancellationToken cancellationToken)
    {
        // Check if the user is authenticated
        var userId = _currentUserService.UserId;
        if (string.IsNullOrEmpty(userId))
        {
            return TResponse<IEnumerable<object>>.Failure(
                new[] { "Unauthorized access" },
                "Unauthorized access",
                401);
        }
        var InstructorId = Guid.Parse(userId);

        // Verify that the instructor exists
        var instructor = await _unitOfWork.Users.FindById(InstructorId, cancellationToken);
        if (instructor == null)
        {
            return TResponse<IEnumerable<object>>.Failure(
                new[] { "Instructor not found" },
                "Instructor not found",
                404);
        }

        // Retrieve class requests for the instructor
        var classRequests = await _classRequestRepository.GetAllClassRequestsForInstructorAsync(InstructorId, cancellationToken);
        if (classRequests == null)
        {
            return TResponse<IEnumerable<object>>.Failure(
                new[] { "No Requests found" },
                "No Requests found",
                404);
        }
        //foreach (var classRequest in classRequests) 
        //{
        //    var student = await _unitOfWork.Users.FindById(classRequest.StudentId,cancellationToken);

        //}

        // Map to ClassRequestDto
        var classRequestDtos = await Task.WhenAll(classRequests.Select(async req =>
        {
            // Include Faculty and Department when fetching the student
            string includeProperties = "Faculty,Department";

            User student = await _unitOfWork.Users.GetByIdAsync(
                c => c.Id == req.StudentId,   // Filter by StudentId
                includeProperties,            // Include Faculty and Department
                cancellationToken
            );
            // Handle null case
            if (student == null)
            {
                // You can log the issue or handle it as per your application's needs
                throw new Exception($"Student with ID {req.StudentId} not found.");
            }
            return new
            {
                RequestId = req.Id,
                ClassId = req.ClassId,
                StudentId = req.StudentId,
                StudentFirstName = student.FirstName,
                StudentLastName = student.LastName,
                FacultyNameAr = student.Faculty.NameAr,
                FacultyNameEn = student.Faculty.NameEn,
                DepartmentNameAr = student.Department.NameAr,
                DepartmentNameEn = student.Department.NameEn,
                Status = req.Status.ToString()
            };
        }));

        // Return success response with mapped DTOs
        return TResponse<IEnumerable<object>>.Success(classRequestDtos);
    }
}