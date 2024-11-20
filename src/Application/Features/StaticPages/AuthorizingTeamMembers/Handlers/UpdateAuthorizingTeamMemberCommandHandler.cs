using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Commands;
using FlexBook.Domain;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;
using IResourceService = FlexBook.Application.Common.Interfaces.IResourceService;

namespace FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Handlers;
public class UpdateAuthorizingTeamMemberCommandHandler : IRequestHandler<UpdateAuthorizingTeamMemberCommand, TResponse<AuthorizingTeamMemberDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;


    public UpdateAuthorizingTeamMemberCommandHandler(IUnitOfWork unitOfWork, IFileUploadService fileUploadService,IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;

    }

    public async Task<TResponse<AuthorizingTeamMemberDto>> Handle(UpdateAuthorizingTeamMemberCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Fetch the existing team member
            var teamMember = await _unitOfWork.AuthorizingTeamMemberRepository.FindById(request.Id, cancellationToken);

            if (teamMember == null)
                return TResponse<AuthorizingTeamMemberDto>.Failure(new[] { "Team member not found" }, "Team member not found", 404);

            // Update properties
            teamMember.FirstNameAr = request.FirstNameAr;
            teamMember.FirstNameEn = request.FirstNameEn;
            teamMember.LastNameAr = request.LastNameAr;
            teamMember.LastNameEn = request.LastNameEn;
            teamMember.DescriptionAr = request.DescriptionAr;
            teamMember.DescriptionEn = request.DescriptionEn;

            // Update photo if provided
            if (request.Photo != null)
                teamMember.PhotoUrl = await _fileUploadService.UploadFileAsync(request.Photo);

            _unitOfWork.AuthorizingTeamMemberRepository.Update(teamMember);
            await _unitOfWork.CommitAsync(cancellationToken);
            AuthorizingTeamMemberDto MemberDto = new AuthorizingTeamMemberDto
            {
                Id = teamMember.Id,
                FirstNameAr = teamMember.FirstNameAr,
                LastNameAr = teamMember.LastNameAr,
                FirstNameEn = teamMember.FirstNameEn,
                LastNameEn = teamMember.LastNameEn,
                DescriptionEn = teamMember.DescriptionEn,
                DescriptionAr = teamMember.DescriptionAr,
                PhotoUrl = teamMember.PhotoUrl,

            };
             return TResponse<AuthorizingTeamMemberDto>.Success(MemberDto, _resourceService.GetMessage("AuthorizingTeamMember Updated Successfully"));

        }
        catch (Exception ex)
        {
            return TResponse<AuthorizingTeamMemberDto>.Failure(new[] { _resourceService.GetError("Error updating team member") },  ex.Message );

        }
    }
}
