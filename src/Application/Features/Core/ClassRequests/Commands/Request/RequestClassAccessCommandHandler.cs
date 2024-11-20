using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Enums;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;

namespace FlexBook.Application.Features.Core.ClassRequests.Commands.Request;

public class RequestClassAccessCommandHandler : IRequestHandler<RequestClassAccessCommand, TResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUserService _currentUserService;

    public RequestClassAccessCommandHandler(IUnitOfWork unitOfWork, ICurrentUserService currentUserService)
    {
        _unitOfWork = unitOfWork;
        _currentUserService = currentUserService;
    }

    public async Task<TResponse<bool>> Handle(RequestClassAccessCommand request, CancellationToken cancellationToken)
    {
        // Ensure the user is authenticated
        var userId = _currentUserService.UserId;
        if (string.IsNullOrEmpty(userId))
        {
            return TResponse<bool>.Failure(
                new[] { "Unauthorized access" },
                "User must be logged in",
                401);
        }
        var userGuid = Guid.Parse(userId);

        // Validate that a ClassId or ClassName is provided
        if (request.ClassId == null && string.IsNullOrEmpty(request.ClassName))
        {
            return TResponse<bool>.Failure(
                new[] { "Invalid class details" },
                "Either ClassId or ClassName must be provided",
                400);
        }

        Guid? classId = request.ClassId;

        // Find class by name if ClassId is not provided
        if (classId == null && !string.IsNullOrEmpty(request.ClassName))
        {
            var classEntity = await _unitOfWork.ClassRepository.GetClassByNameAsync(request.ClassName, cancellationToken);
            if (classEntity == null)
            {
                return TResponse<bool>.Failure(
                    new[] { "Class not found" },
                    $"Class not found",
                    404);
            }
            classId = classEntity.Id;
        }

        // Validate that the class ID was successfully set
        if (classId == null)
        {
            return TResponse<bool>.Failure(
                new[] { "Invalid class details" },
                "Class information is incomplete or incorrect",
                400);
        }

        // Check if a pending request already exists for this student and class
        var existingRequest = await _unitOfWork.ClassRequestRepository
            .GetPendingRequestAsync(userGuid, classId.Value, cancellationToken);
        if (existingRequest != null)
        {
            return TResponse<bool>.Failure(
                new[] { "Duplicate request" },
                "A pending request for this class already exists for the student",
                409); // Conflict
        }

        // Create and save the new class request
        var classRequest = new ClassRequest
        {
            ClassId = classId.Value,
            StudentId = userGuid,
            Status = RequestStatus.Pending
        };

        await _unitOfWork.ClassRequestRepository.Add(classRequest, cancellationToken);
        await _unitOfWork.CommitAsync(cancellationToken);

        // Return success response
        return TResponse<bool>.Success(true, "Class access request created successfully");
    }
}