using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Queries;
using FlexBook.Domain;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;
using X.PagedList;

namespace FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Handlers;

public class GetAuthorizingTeamMembersQueryHandler : IRequestHandler<GetAuthorizingTeamMembersQuery, TResponse<IPagedList<AuthorizingTeamMemberDto>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetAuthorizingTeamMembersQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<IPagedList<AuthorizingTeamMemberDto>>> Handle(GetAuthorizingTeamMembersQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var pagedMembers = await _unitOfWork.AuthorizingTeamMemberRepository.FindPagedList(
                filter: member =>
                    string.IsNullOrWhiteSpace(request.Search) ||
                    member.FirstNameAr.Contains(request.Search) ||
                    member.FirstNameEn.Contains(request.Search) ||
                    member.LastNameAr.Contains(request.Search) ||
                    member.LastNameEn.Contains(request.Search),
                orderBy: request.SortDirection.ToLower() == "desc"
                    ? query => query.OrderByDescending(GetSortExpression(request.SortBy))
                    : query => query.OrderBy(GetSortExpression(request.SortBy)),
                pageNumber: request.PageNumber,
                pageSize: request.PageSize
            );

            var memberDtos = pagedMembers.Select(member => new AuthorizingTeamMemberDto
            {
                Id = member.Id,
                FirstNameAr = member.FirstNameAr,
                LastNameAr = member.LastNameAr,
                FirstNameEn = member.FirstNameEn,
                LastNameEn = member.LastNameEn,
                DescriptionAr = member.DescriptionAr,
                DescriptionEn = member.DescriptionEn,
                PhotoUrl = member.PhotoUrl
            }).ToList();

            return TResponse<IPagedList<AuthorizingTeamMemberDto>>.Success(new StaticPagedList<AuthorizingTeamMemberDto>(memberDtos, pagedMembers.PageNumber, pagedMembers.PageSize, pagedMembers.TotalItemCount));
        }
        catch (Exception ex)
        {
            return TResponse<IPagedList<AuthorizingTeamMemberDto>>.Failure(new[] { _resourceService.GetError("Error retrieving team members") }, ex.Message);
        }
    }

    private static System.Linq.Expressions.Expression<Func<AuthorizingTeamMember, object>> GetSortExpression(string sortBy)
    {
        return sortBy.ToLower() switch
        {
            "firstnamear" => member => member.FirstNameAr,
            "firstnameen" => member => member.FirstNameEn,
            "lastnamear" => member => member.LastNameAr,
            "lastnameen" => member => member.LastNameEn,
            _ => member => member.CreatedAt // Default sort
        };
    }
}
