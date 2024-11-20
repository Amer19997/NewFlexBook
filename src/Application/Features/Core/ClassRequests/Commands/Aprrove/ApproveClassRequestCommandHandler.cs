using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Enums;
using FlexBook.Domain;
using MediatR;
using FlexBook.Domain.Entities;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Common.Interfaces.NotificationServices;
namespace FlexBook.Application.Features.Core.ClassRequests.Commands.Aprrove;
public class ApproveClassRequestCommandHandler : IRequestHandler<ApproveClassRequestCommand, TResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUserService _currentUserService;
    private readonly INotificationService _notificationService;

    public ApproveClassRequestCommandHandler(IUnitOfWork unitOfWork, INotificationService notificationService, ICurrentUserService currentUserService )
    {
        _unitOfWork = unitOfWork;
        _currentUserService = currentUserService;
        _notificationService = notificationService;
    }

    public async Task<TResponse<bool>> Handle(ApproveClassRequestCommand request, CancellationToken cancellationToken)
    {
        // Retrieve the current user ID
        var userId = _currentUserService.UserId;
        if (string.IsNullOrEmpty(userId))
        {
            return TResponse<bool>.Failure(
                new[] { "Unauthorized access" },
                "User must be logged in",
                401);
        }

        // Convert userId to Guid
        var instructorId = Guid.Parse(userId);

        // Retrieve the class request by ID
        var classRequest = await _unitOfWork.ClassRequestRepository.FindById(request.RequestId, cancellationToken);
        if (classRequest == null)
        {
            return TResponse<bool>.Failure(
                new[] { "Class request not found" },
                "The specified class request does not exist",
                404);
        }

        // Ensure that the class request is pending
        if (classRequest.Status != RequestStatus.Pending)
        {
            return TResponse<bool>.Failure(
                new[] { "Invalid request status" },
                "Only pending requests can be approved",
                400);
        }

        // Verify that the instructor is authorized to approve the request
        var instructor = await _unitOfWork.Users.FindById(instructorId, cancellationToken);
        if (instructor == null || instructor.UserType != UserTypeEnum.Instructor)
        {
            return TResponse<bool>.Failure(
                new[] { "Unauthorized access" },
                "Only instructors can approve class requests",
                403);
        }

        // Ensure that the instructor has access to the class related to the request
        var hasAccess = await _unitOfWork.ClassRepository
            .AnyAsync(instructorId, classRequest.ClassId);
        if (!hasAccess)
        {
            return TResponse<bool>.Failure(
                new[] { "Access denied" },
                "The instructor does not have permission to approve this class request",
                403);
        }

        // Generate an access code for the approved request
        var accessCode = new Domain.Entities.AccessCode
        {
            ClassId = classRequest.ClassId,
            StudentId = classRequest.StudentId,
            Code = Guid.NewGuid().ToString("N").Substring(0, 8),
            ExpiryDate = DateTime.UtcNow.AddHours(24),
            IsUsed=false
            
        };
        // Retrieve the student to send the email notification
        var student = await _unitOfWork.Users.FindById(classRequest.StudentId, cancellationToken);
        if (student == null || string.IsNullOrEmpty(student.Email))
        {
            return TResponse<bool>.Failure(
                new[] { "Student email not found" },
                "The student associated with this request does not have a valid email address",
                400);
        }

        // Step 5: Prepare and send the email notification
        var emailMessage = new EmailMessage(
            student.Email,
            "Class Request",
            $"Class request approved successfully." +
            $"Please use this access code to join: {accessCode.Code}");
        //'{classRequest.Class.ClassName}'
        try
        {
            _notificationService.Push(new[] { emailMessage });
        }
        catch (Exception ex)
        {
            return TResponse<bool>.Failure(
                new[] { "Failed to send email access code" },
                $"An error occurred while sending the access code: {ex.Message}",
                500);
        }


        // Approve the request and save the access code
        classRequest.Status = RequestStatus.Approved;
        await _unitOfWork.AccessCodeRepository.Add(accessCode, cancellationToken);
        _unitOfWork.ClassRequestRepository.Update(classRequest);
        await _unitOfWork.CommitAsync(cancellationToken);

        // Optionally send an email notification
        //await _emailService.SendEmailAsync(classRequest.Student.Email, "Your Access Code", $"Your access code is: {accessCode.Code}");

        // Return success response
        return TResponse<bool>.Success(true, "Class request approved successfully");
    }
}

