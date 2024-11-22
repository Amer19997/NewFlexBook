using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.EvaluatingAdopting.Queries;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;
using X.PagedList;
using FlexBook.Application.Common.Interfaces;

namespace FlexBook.Application.Features.StaticPages.EvaluatingAdopting.Handlers;
public class GetEvaluatingAdoptingArticlesQueryHandler : IRequestHandler<GetEvaluatingAdoptingArticlesQuery, TResponse<IPagedList<EvaluatingAdoptingArticleDto>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetEvaluatingAdoptingArticlesQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<IPagedList<EvaluatingAdoptingArticleDto>>> Handle(GetEvaluatingAdoptingArticlesQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var articles = await _unitOfWork.EvaluatingAdoptingArticleRepository.FindPagedList(
                filter: article => string.IsNullOrWhiteSpace(request.Search) || article.TitleAr.Contains(request.Search) || article.TitleEn.Contains(request.Search),
                orderBy: request.SortDirection.ToLower() == "desc"
                    ? query => query.OrderByDescending(article => article.UpdatedAt)
                    : query => query.OrderBy(article => article.UpdatedAt),
                pageNumber: request.PageNumber,
                pageSize: request.PageSize
            );

            var articleDtos = articles.Select(article => new EvaluatingAdoptingArticleDto
            {
                Id = article.Id,
                TitleAr = article.TitleAr,
                TitleEn = article.TitleEn,
                ContentAr = article.ContentAr,
                ContentEn = article.ContentEn,
                AuthorName = article.AuthorName,
                AuthorPhotoUrl = article.AuthorPhotoUrl,
                UpdatedAt = article.UpdatedAt
            }).ToList();

            return TResponse<IPagedList<EvaluatingAdoptingArticleDto>>.Success(new StaticPagedList<EvaluatingAdoptingArticleDto>(articleDtos, articles.PageNumber, articles.PageSize, articles.TotalItemCount));
        }
        catch (Exception ex)
        {
            return TResponse<IPagedList<EvaluatingAdoptingArticleDto>>.Failure(new[] { _resourceService.GetError("Error retrieving articles") }, ex.Message);
        }
    }
}
