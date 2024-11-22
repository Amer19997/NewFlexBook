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
        if (request.IsApprove)
        {
            // Approve the request
            var accessCode = new Domain.Entities.AccessCode
            {
                ClassId = classRequest.ClassId,
                StudentId = classRequest.StudentId,
                Code = Guid.NewGuid().ToString("N").Substring(0, 8),
                ExpiryDate = DateTime.UtcNow.AddHours(24),
                IsUsed = false
            };

            var student = await _unitOfWork.Users.FindById(classRequest.StudentId, cancellationToken);
            if (student == null || string.IsNullOrEmpty(student.Email))
            {
                return TResponse<bool>.Failure(
                    new[] { "Student email not found" },
                    "The student associated with this request does not have a valid email address",
                    400);
            }

            var emailMessage = new EmailMessage(
                student.Email,
                "Class Request Approved",
                $"Your class request has been approved. Access code: {accessCode.Code}");

            try
            {
                _notificationService.Push(new[] { emailMessage });
            }
            catch (Exception ex)
            {
                return TResponse<bool>.Failure(
                    new[] { "Failed to send email" },
                    $"An error occurred while sending the email: {ex.Message}",
                    500);
            }

            classRequest.Status = RequestStatus.Approved;
            await _unitOfWork.AccessCodeRepository.Add(accessCode, cancellationToken);
        }
        else
        {
            // Reject the request
            //if (string.IsNullOrEmpty(request.RejectionReason))
            //{
            //    return TResponse<bool>.Failure(
            //        new[] { "Rejection reason required" },
            //        "A reason must be provided when rejecting a request",
            //        400);
            //}

            var student = await _unitOfWork.Users.FindById(classRequest.StudentId, cancellationToken);
            //if (student != null && !string.IsNullOrEmpty(student.Email))
            //{
            //    var rejectionEmail = new EmailMessage(
            //        student.Email,
            //        "Class Request Rejected",
            //        $"Your class request has been rejected. Reason: {request.RejectionReason}");

            //    try
            //    {
            //        _notificationService.Push(new[] { rejectionEmail });
            //    }
            //    catch (Exception ex)
            //    {
            //        return TResponse<bool>.Failure(
            //            new[] { "Failed to send rejection email" },
            //            $"An error occurred while sending the rejection email: {ex.Message}",
            //            500);
            //    }
            //}

            classRequest.Status = RequestStatus.Denied;
            //classRequest.RejectionReason = request.RejectionReason; // Assuming a RejectionReason property exists
        }
        _unitOfWork.ClassRequestRepository.Update(classRequest);
        await _unitOfWork.CommitAsync(cancellationToken);

        // Optionally send an email notification
        //await _emailService.SendEmailAsync(classRequest.Student.Email, "Your Access Code", $"Your access code is: {accessCode.Code}");

        // Return success response
        var message = request.IsApprove ? "Class request approved successfully" : "Class request rejected successfully";
        return TResponse<bool>.Success(true, message);
     }
}

