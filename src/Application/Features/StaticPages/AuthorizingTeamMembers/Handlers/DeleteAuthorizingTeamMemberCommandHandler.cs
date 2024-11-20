using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Commands;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Handlers;
public class DeleteAuthorizingTeamMemberCommandHandler : IRequestHandler<DeleteAuthorizingTeamMemberCommand, TResponse<string>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public DeleteAuthorizingTeamMemberCommandHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<string>> Handle(DeleteAuthorizingTeamMemberCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var teamMember = await _unitOfWork.AuthorizingTeamMemberRepository.FindById(request.Id, cancellationToken);
            if (teamMember == null)
                return TResponse<string>.Failure(new[] { _resourceService.GetError("Team member not found") }, "Team member not found", 404);

            _unitOfWork.AuthorizingTeamMemberRepository.Remove(teamMember);
            await _unitOfWork.CommitAsync(cancellationToken);

            return TResponse<string>.Success(_resourceService.GetMessage("AuthorizingTeamMember deleted successfully"));
        }
        catch (Exception ex)
        {
            return TResponse<string>.Failure(new[] { _resourceService.GetError("Error deleting team member") }, ex.Message);
        }
    }
}
