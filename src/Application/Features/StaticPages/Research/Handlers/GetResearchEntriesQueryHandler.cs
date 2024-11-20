using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.Research.Queries;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Domain.Entities.StaticPages;
using System.Linq.Expressions;
using X.PagedList;

namespace FlexBook.Application.Features.StaticPages.Research.Handlers;
public class GetResearchEntriesQueryHandler : IRequestHandler<GetResearchEntriesQuery, TResponse<IPagedList<ResearchEntryDto>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetResearchEntriesQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<IPagedList<ResearchEntryDto>>> Handle(GetResearchEntriesQuery request, CancellationToken cancellationToken)
    {
        try
        {
            // Paginated and filtered research entries
            var pagedResearchEntries = await _unitOfWork.ResearchRepository.FindPagedList(
                filter: entry =>
                    string.IsNullOrWhiteSpace(request.Search) ||
                    entry.TitleAr.Contains(request.Search) ||
                    entry.TitleEn.Contains(request.Search) ||
                    entry.DescriptionAr.Contains(request.Search) ||
                    entry.DescriptionEn.Contains(request.Search),
                orderBy: request.SortDirection.ToLower() == "desc"
                    ? query => query.OrderByDescending(GetSortExpression(request.SortBy))
                    : query => query.OrderBy(GetSortExpression(request.SortBy)),
                pageNumber: request.PageNumber,
                pageSize: request.PageSize
            );

            // Map to DTO
            var researchDtos = pagedResearchEntries.Select(entry => new ResearchEntryDto
            {
                Id = entry.Id,
                TitleAr = entry.TitleAr,
                TitleEn = entry.TitleEn,
                DescriptionAr = entry.DescriptionAr,
                DescriptionEn = entry.DescriptionEn,
                ChartImageUrl = entry.ChartImageUrl
            }).ToList();

            // Return success response with paged DTOs
            return TResponse<IPagedList<ResearchEntryDto>>.Success(
                new StaticPagedList<ResearchEntryDto>(
                    researchDtos,
                    pagedResearchEntries.PageNumber,
                    pagedResearchEntries.PageSize,
                    pagedResearchEntries.TotalItemCount
                )
            );
        }
        catch (Exception ex)
        {
            // Return failure response with error handling
            return TResponse<IPagedList<ResearchEntryDto>>.Failure(
                new[] { _resourceService.GetError("Error retrieving research entries") },
                ex.Message
            );
        }
    }

    // Method to get sort expression dynamically based on the sortBy field
    private static Expression<Func<ResearchEntry, object>> GetSortExpression(string sortBy)
    {
        return sortBy.ToLower() switch
        {
            "titlear" => entry => entry.TitleAr,
            "titleen" => entry => entry.TitleEn,
            "descriptionar" => entry => entry.DescriptionAr,
            "descriptionen" => entry => entry.DescriptionEn,
            _ => entry => entry.LastUpdated // Default sort
        };
    }

}