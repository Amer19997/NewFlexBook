using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Exceptions;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Enums;
using FlexBook.Domain;
using MediatR;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;

namespace FlexBook.Application.Features.Core.Classes.Commands;
public class CreateClassCommandHandler : IRequestHandler<CreateClassCommand, TResponse<ClassDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICurrentUserService _currentUserService;
    private readonly IResourceService _resourceService;

    public CreateClassCommandHandler(
        IUnitOfWork unitOfWork,
        ICurrentUserService currentUserService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _currentUserService = currentUserService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<ClassDto>> Handle(CreateClassCommand request, CancellationToken cancellationToken)
    {
        // Validate request
        if (request == null)
            return TResponse<ClassDto>.Failure(
                new[] { _resourceService.GetError("InvalidRequest") },
                _resourceService.GetError("InvalidRequest"),
                400);

        // Verify the current user is authenticated
        var userId = _currentUserService.UserId;
        if (string.IsNullOrEmpty(userId))
        {
            return TResponse<ClassDto>.Failure(
                      new[] { _resourceService.GetError("UnauthorizedAccess") },
                      "Access denied: User is not authenticated.",
                      401);

        }

        // Validate user is an instructor
        var userGuid = Guid.Parse(userId);
        var instructor = await _unitOfWork.Users.FindById(userGuid, cancellationToken);
        if (instructor == null || instructor.UserType != UserTypeEnum.Instructor)
        {
            return TResponse<ClassDto>.Failure(
                new[] { _resourceService.GetError("UnauthorizedAccess") },
                _resourceService.GetError("UnauthorizedAccess"),
                403);
        }

        // Verify the course exists
        var course = await _unitOfWork.CouresRepository.FindById(request.CourseId, cancellationToken);
        if (course == null)
        {
            return TResponse<ClassDto>.Failure(
                new[] { _resourceService.GetError("CourseNotFound") },
                _resourceService.GetError("CourseNotFound"),
                404);
        }

        // Confirm instructor has access to the course
        var hasCourse = await _unitOfWork.InstructorCoursesRepository.AnyAsync(userGuid, request.CourseId);
        if (!hasCourse)
        {
            return TResponse<ClassDto>.Failure(
                new[] { _resourceService.GetError("AccessDenied") },
                _resourceService.GetError("AccessDenied"),
                403);
        }

        // Create the class entity
        var classEntity = new Class
        {
            CourseId = request.CourseId,
            InstructorId = userGuid,
            ClassName = request.ClassName,
            Syllabus = request.Syllabus
        };

        // Save the class entity to the database
        await _unitOfWork.ClassRepository.AddAsync(classEntity, cancellationToken);
        await _unitOfWork.CommitAsync(cancellationToken);

        // Map to ClassDto
        var classDto = new ClassDto
        {
            Id = classEntity.Id,
            CourseId = classEntity.CourseId,
            InstructorId = classEntity.InstructorId,
            ClassName = classEntity.ClassName,
            Syllabus = classEntity.Syllabus
        };

        // Return success response with ClassDto and success message
        return TResponse<ClassDto>.Success(classDto, "Class created successfully");
    }
}


