using System;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Queries;
using FlexBook.Domain;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Handlers;

public class GetAuthorizingTeamMemberByIdQueryHandler : IRequestHandler<GetAuthorizingTeamMemberByIdQuery, TResponse<AuthorizingTeamMemberDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetAuthorizingTeamMemberByIdQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<AuthorizingTeamMemberDto>> Handle(GetAuthorizingTeamMemberByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var teamMember = await _unitOfWork.AuthorizingTeamMemberRepository.FindById(request.Id, cancellationToken);
            if (teamMember == null)
                return TResponse<AuthorizingTeamMemberDto>.Failure(new[] { _resourceService.GetError("Team member not found") }, "Team member not found", 404);

            var dto = new AuthorizingTeamMemberDto
            {
                Id = teamMember.Id,
                FirstNameAr = teamMember.FirstNameAr,
                LastNameAr = teamMember.LastNameAr,
                FirstNameEn = teamMember.FirstNameEn,
                LastNameEn = teamMember.LastNameEn,
                DescriptionAr = teamMember.DescriptionAr,
                DescriptionEn = teamMember.DescriptionEn,
                PhotoUrl = teamMember.PhotoUrl
            };

            return TResponse<AuthorizingTeamMemberDto>.Success(dto);
        }
        catch (Exception ex)
        {
            return TResponse<AuthorizingTeamMemberDto>.Failure(new[] { _resourceService.GetError("Error retrieving team member") }, ex.Message);
        }
    }
}
