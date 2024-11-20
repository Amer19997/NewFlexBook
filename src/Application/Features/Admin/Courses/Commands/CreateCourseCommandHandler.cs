using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Helpers;
using FlexBook.Application.Common.Interfaces;
using Microsoft.Extensions.Options;

namespace FlexBook.Application.Features.Admin.Courses.Commands;

public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, GetAllCourseDetails>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAccountService _accountService;
    private readonly ITokenService _tokenService;
    private readonly IResourceService _resourceService;
    private readonly AppSettings _appSettings;
    private readonly IMediator _mediator;


    public CreateCourseCommandHandler(IUnitOfWork unitOfWork,
             IAccountService accountService,
             ITokenService tokenService,
             IOptions<AppSettings> appSettings,
             IResourceService resourceService,
             IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _accountService = accountService;
        _tokenService = tokenService;
        _appSettings = appSettings.Value;
        _resourceService = resourceService;
        _mediator = mediator;
    }

    public async Task<GetAllCourseDetails> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        // Create the course entity
        var course = new Course
        {
            Id = Guid.NewGuid(),
            NameAr = request.NameAr,
            NameEn = request.NameEn,
            DiscriptionAr = request.DiscriptionAr,
            DiscriptionEn = request.DiscriptionEn,
            CategoryId = request.CategoryId,
            TopicId = request.TopicId,
            CoverPhoto = request.CoverPhoto,
            Code = request.Code
        };


        // Assign the relationships (Universities, Faculties, Departments, Specializations)
        if (request.UniversityIds.Any())
        {
            course.Universities = (await _unitOfWork.UnivesityRepository.GetByIdsAsync(request.UniversityIds, cancellationToken)).ToList();
        }


        if (request.FacultyIds.Any())
        {
            course.Faculties = (await _unitOfWork.FacultyRepository.GetByIdsAsync(request.FacultyIds, cancellationToken)).ToList();
        }

        if (request.DepartmentIds.Any())
        {
            course.Departments = (await _unitOfWork.DepartmentRepository.GetByIdsAsync(request.DepartmentIds, cancellationToken)).ToList();
        }

        if (request.SpecializationIds.Any())
        {
            course.Specializations = (await _unitOfWork.SpecializationRepository.GetByIdsAsync(request.SpecializationIds, cancellationToken)).ToList();
        }

        // Add the course to the repository
        _unitOfWork.CouresRepository.Add(course,cancellationToken);
        await _unitOfWork.CommitAsync(cancellationToken);

        // Return the DTO of the created course
        return new GetAllCourseDetails
        {
            Id = course.Id,
            NameAr = course.NameAr,
            NameEn = course.NameEn,
            DiscriptionAr = course.DiscriptionAr,
            DiscriptionEn = course.DiscriptionEn,
            CategoryId = course.CategoryId,
            TopicId = course.TopicId,
            CoverPhoto = course.CoverPhoto,
            Code = course.Code,
            UniversityIds = course.Universities.Select(u => u.Id).ToList(),
            FacultyIds = course.Faculties.Select(f => f.Id).ToList(),
            DepartmentIds = course.Departments.Select(d => d.Id).ToList(),
            SpecializationIds = course.Specializations.Select(s => s.Id).ToList()
        };
    }
}