using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.InstructorCommunity.Queries;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;
using X.PagedList;
using FlexBook.Application.Common.Interfaces;

namespace FlexBook.Application.Features.StaticPages.InstructorCommunity.Handlers;
public class GetInstructorCommunityEntriesQueryHandler : IRequestHandler<GetInstructorCommunityEntriesQuery, TResponse<IPagedList<InstructorCommunityEntryDto>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetInstructorCommunityEntriesQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<IPagedList<InstructorCommunityEntryDto>>> Handle(GetInstructorCommunityEntriesQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var entries = await _unitOfWork.InstructorCommunityEntryRepository.FindPagedList(
                filter: entry => string.IsNullOrWhiteSpace(request.Search) || entry.TitleAr.Contains(request.Search) || entry.TitleEn.Contains(request.Search),
                orderBy: request.SortDirection.ToLower() == "desc"
                    ? query => query.OrderByDescending(entry => entry.UpdatedAt)
                    : query => query.OrderBy(entry => entry.UpdatedAt),
                pageNumber: request.PageNumber,
                pageSize: request.PageSize
            );

            var entryDtos = entries.Select(entry => new InstructorCommunityEntryDto
            {
                Id = entry.Id,
                TitleAr = entry.TitleAr,
                TitleEn = entry.TitleEn,
                ContentAr = entry.ContentAr,
                ContentEn = entry.ContentEn,
                ImageUrl = entry.ImageUrl,
                UpdatedAt = entry.UpdatedAt
            }).ToList();

            return TResponse<IPagedList<InstructorCommunityEntryDto>>.Success(new StaticPagedList<InstructorCommunityEntryDto>(entryDtos, entries.PageNumber, entries.PageSize, entries.TotalItemCount));
        }
        catch (Exception ex)
        {
            return TResponse<IPagedList<InstructorCommunityEntryDto>>.Failure(new[] { _resourceService.GetError("Error retrieving entries") }, ex.Message);
        }
    }
}