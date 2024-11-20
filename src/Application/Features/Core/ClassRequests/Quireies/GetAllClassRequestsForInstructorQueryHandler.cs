using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Domain;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Repositories;
using MediatR;

namespace FlexBook.Application.Features.Core.ClassRequests.Quireies;

public class GetAllClassRequestsForInstructorQueryHandler : IRequestHandler<GetAllClassRequestsForInstructorQuery, TResponse<IEnumerable<ClassRequestDto>>>
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

    public async Task<TResponse<IEnumerable<ClassRequestDto>>> Handle(GetAllClassRequestsForInstructorQuery request, CancellationToken cancellationToken)
    {
        // Check if the user is authenticated
        var userId = _currentUserService.UserId;
        if (string.IsNullOrEmpty(userId))
        {
            return TResponse<IEnumerable<ClassRequestDto>>.Failure(
                new[] { "Unauthorized access" },
                "Unauthorized access",
                401);
        }
        var InstructorId = Guid.Parse(userId);

        // Verify that the instructor exists
        var instructor = await _unitOfWork.Users.FindById(InstructorId, cancellationToken);
        if (instructor == null)
        {
            return TResponse<IEnumerable<ClassRequestDto>>.Failure(
                new[] { "Instructor not found" },
                "Instructor not found",
                404);
        }

        // Retrieve class requests for the instructor
        var classRequests = await _classRequestRepository.GetAllClassRequestsForInstructorAsync(InstructorId, cancellationToken);

        // Map to ClassRequestDto
        var classRequestDtos = classRequests.Select(req => new ClassRequestDto
        {
            RequestId = req.Id,
            ClassId = req.ClassId,
            StudentId = req.StudentId,
            Status = req.Status.ToString()
        }).ToList();

        // Return success response with mapped DTOs
        return TResponse<IEnumerable<ClassRequestDto>>.Success(classRequestDtos);
    }
}