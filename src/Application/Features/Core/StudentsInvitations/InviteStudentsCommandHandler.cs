using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Interfaces.NotificationServices;
using FlexBook.Application.Common.Models;
using FlexBook.Domain;
using FlexBook.Domain.Enums;
using FlexBook.Domain.Repositories;
using MediatR;

namespace FlexBook.Application.Features.Core.StudentsInvitations;
public class InviteStudentsCommandHandler : IRequestHandler<InviteStudentsCommand, TResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly INotificationService _notificationService;
    private readonly ICurrentUserService _currentUserService;

    public InviteStudentsCommandHandler(
        IUnitOfWork unitOfWork,
        INotificationService notificationService,
        ICurrentUserService currentUserService)
    {
        _unitOfWork = unitOfWork;
        _notificationService = notificationService;
        _currentUserService = currentUserService;
    }

    public async Task<TResponse<bool>> Handle(InviteStudentsCommand request, CancellationToken cancellationToken)
    {
        // Step 1: Validate user login
        var userId = _currentUserService.UserId;
        if (string.IsNullOrEmpty(userId))
        {
            return TResponse<bool>.Failure(
                new[] { "Unauthorized access" },
                "User must be logged in to invite students",
                401);
        }

        var instructorId = Guid.Parse(userId);

        // Step 2: Check if the class exists and belongs to the instructor
        var classEntity = await _unitOfWork.ClassRepository.GetByIdAsync(request.ClassId, cancellationToken);
        if (classEntity == null)
        {
            return TResponse<bool>.Failure(
                new[] { "Class not found" },
                "The specified class does not exist",
                404);
        }

        if (classEntity.InstructorId != instructorId)
        {
            return TResponse<bool>.Failure(
                new[] { "Access denied" },
                "You do not have permission to invite students to this class",
                403);
        }

        // Step 3: Initialize lists for access codes and messages
        var accessCodes = new List<Domain.Entities.AccessCode>();
        var messages = new List<Message>();

        // Step 4: Process each email and validate
        foreach (var email in request.StudentEmails)
        {
            if (string.IsNullOrEmpty(email) || !IsValidEmail(email))
            {
                return TResponse<bool>.Failure(
                    new[] { $"Invalid email: {email}" },
                    $"The email '{email}' is not in a valid format",
                    400);
            }
            var user = await _unitOfWork.Users.GetUserByEmailOrNameAsync(email);
            if (user == null || user.UserType != UserTypeEnum.Student)
            {
                continue; // Skip if user is not found or not a student
            }
            // Generate a unique access code for each valid email
            var accessCode = new Domain.Entities.AccessCode
            {
                ClassId = classEntity.Id,
                StudentId = user.Id, // Assign the fetched StudentId
                Code = Guid.NewGuid().ToString("N")[..8],
                ExpiryDate = DateTime.UtcNow.AddDays(7),
                IsUsed = false
            };
            accessCodes.Add(accessCode);

            // Create email message with access code
            var emailMessage = new EmailMessage(
                email,
                "Class Invitation",
                $"You have been invited to join the class '{classEntity.ClassName}'. " +
                $"Please use this access code to join: {accessCode.Code}");

            messages.Add(emailMessage);
        }

        // Step 5: Send invitations
        try
        {
            _notificationService.Push(messages.ToArray());
        }
        catch (Exception ex)
        {
            return TResponse<bool>.Failure(
                new[] { "Failed to send email invitations" },
                $"An error occurred while sending invitations: {ex.Message}",
                500);
        }

        // Step 6: Save all generated access codes in the database
        await _unitOfWork.AccessCodeRepository.AddRange(accessCodes, cancellationToken);
        await _unitOfWork.CommitAsync(cancellationToken);

        // Return success response
        return TResponse<bool>.Success(
            true,
            "Invitations sent successfully, and access codes were generated and saved.");
    }

    // Helper method for validating email format
    private bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}