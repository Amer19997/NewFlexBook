using System;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.Core.AccessCode
{
    public class UseAccessCodeCommandHandler : IRequestHandler<UseAccessCodeCommand, TResponse<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUserService _currentUserService;

        public UseAccessCodeCommandHandler(IUnitOfWork unitOfWork, ICurrentUserService currentUserService)
        {
            _unitOfWork = unitOfWork;
            _currentUserService = currentUserService;
        }

        public async Task<TResponse<bool>> Handle(UseAccessCodeCommand request, CancellationToken cancellationToken)
        {
            // Step 1: Retrieve the current user ID from the current user service
            var userId = _currentUserService.UserId;
            if (string.IsNullOrEmpty(userId))
            {
                return TResponse<bool>.Failure(
                    new[] { "Unauthorized access" },
                    "User must be logged in",
                    401);
            }

            // Parse the userId as a Guid
            var studentId = Guid.Parse(userId);

            // Step 2: Verify if the access code is valid and not used
            var accessCode = await _unitOfWork.AccessCodeRepository.GetValidAccessCodeAsync(studentId, request.AccessCode, cancellationToken);
            if (accessCode == null)
            {
                return TResponse<bool>.Failure(
                    new[] { "Invalid or expired access code" },
                    "The provided access code is either invalid, expired, or has already been used",
                    400);
            }

            // Step 3: Verify that the access code matches the intended class
            if (accessCode.ClassId != request.ClassId)
            {
                return TResponse<bool>.Failure(
                    new[] { "Access code mismatch" },
                    "The access code is not valid for the specified class",
                    400);
            }

            // Step 4: Retrieve the class associated with the access code
            var classEntity = await _unitOfWork.ClassRepository.GetByIdAsync(accessCode.ClassId, cancellationToken);
            if (classEntity == null)
            {
                return TResponse<bool>.Failure(
                    new[] { "Class not found" },
                    "The class associated with this access code does not exist",
                    404);
            }

            // Step 5: Retrieve the student
            var student = await _unitOfWork.Users.FindById(studentId, cancellationToken);
            if (student == null)
            {
                return TResponse<bool>.Failure(
                    new[] { "Student not found" },
                    "The student associated with this request does not exist",
                    404);
            }

            // Step 6: Enroll the student in the class and mark the access code as used
            classEntity.Students.Add(student);
            accessCode.IsUsed = true;

            // Step 7: Update the class and access code status in the database
            _unitOfWork.ClassRepository.Update(classEntity);
            _unitOfWork.AccessCodeRepository.Update(accessCode);
            await _unitOfWork.CommitAsync(cancellationToken);

            // Return success response
            return TResponse<bool>.Success(true, "Access code successfully used, and you have joined the class");
        }
    }
}
