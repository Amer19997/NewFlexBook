using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Commands;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Handlers;
public class CreateAuthorizingTeamMemberCommandHandler : IRequestHandler<CreateAuthorizingTeamMemberCommand, TResponse<object>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public CreateAuthorizingTeamMemberCommandHandler(IUnitOfWork unitOfWork, IFileUploadService fileUploadService, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<object>> Handle(CreateAuthorizingTeamMemberCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Upload photo
            string? photoUrl = request.Photo != null ? await _fileUploadService.UploadFileAsync(request.Photo) : null;

            // Create entity
            var teamMember = new AuthorizingTeamMember
            {
                FirstNameAr = request.FirstNameAr,
                FirstNameEn = request.FirstNameEn,
                LastNameAr = request.LastNameAr,
                LastNameEn = request.LastNameEn,
                DescriptionAr = request.DescriptionAr,
                DescriptionEn = request.DescriptionEn,
                PhotoUrl = photoUrl
            };
            var memberDto = new
            {
                Id = teamMember.Id,
                FirstNameAr = teamMember.FirstNameAr,
                FirstNameEn = teamMember.FirstNameEn,
                LastNameAr = teamMember.LastNameAr,
                LastNameEn = teamMember.LastNameEn,
                DescriptionAr = teamMember.DescriptionAr,
                DescriptionEn = teamMember.DescriptionEn,
                PhotoUrl = teamMember.PhotoUrl

            }; 

            // S LastNameAr ave to database
            await _unitOfWork.AuthorizingTeamMemberRepository.Add(teamMember, cancellationToken);
            await _unitOfWork.CommitAsync(cancellationToken);

            return TResponse<object>.Success(memberDto,_resourceService.GetMessage( "AuthorizingTeamMember Created Successfully"));
        }
        catch (Exception ex)
        {
            return TResponse<object>.Failure(new[] { "Error creating team member: " + ex.Message }, ex.Message, 500);
        }
    }
}

