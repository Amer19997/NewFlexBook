using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Queries;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain;
using MediatR;
using X.PagedList;
using FlexBook.Application.Common.Interfaces;

namespace FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Handlers;
public class GetInstructorSuccessStoriesQueryHandler : IRequestHandler<GetInstructorSuccessStoriesQuery, TResponse<IPagedList<InstructorSuccessStoryDto>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetInstructorSuccessStoriesQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<IPagedList<InstructorSuccessStoryDto>>> Handle(GetInstructorSuccessStoriesQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var pagedStories = await _unitOfWork.InstructorSuccessStoryRepository.FindPagedList(
                filter: story => string.IsNullOrWhiteSpace(request.Search) ||
                    story.TitleAr.Contains(request.Search) ||
                    story.TitleEn.Contains(request.Search),
                orderBy: request.SortDirection.ToLower() == "desc"
                    ? query => query.OrderByDescending(GetSortExpression(request.SortBy))
                    : query => query.OrderBy(GetSortExpression(request.SortBy)),
                pageNumber: request.PageNumber,
                pageSize: request.PageSize
            );

            var storyDtos = pagedStories.Select(story => new InstructorSuccessStoryDto
            {
                Id = story.Id,
                TitleAr = story.TitleAr,
                TitleEn = story.TitleEn,
                DescriptionAr = story.DescriptionAr,
                DescriptionEn = story.DescriptionEn,
                ImageUrl = story.ImageUrl
            }).ToList();

            return TResponse<IPagedList<InstructorSuccessStoryDto>>.Success(new StaticPagedList<InstructorSuccessStoryDto>(storyDtos, pagedStories.PageNumber, pagedStories.PageSize, pagedStories.TotalItemCount));
        }
        catch (Exception ex)
        {
            return TResponse<IPagedList<InstructorSuccessStoryDto>>.Failure(new[] { _resourceService.GetError("Error retrieving stories") }, ex.Message);
        }
    }

    private static System.Linq.Expressions.Expression<Func<InstructorSuccessStory, object>> GetSortExpression(string sortBy)
    {
        return sortBy.ToLower() switch
        {
            "titlear" => story => story.TitleAr,
            "titleen" => story => story.TitleEn,
            _ => story => story.CreatedAt // Default sort
        };
    }
}