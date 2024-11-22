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
using FlexBook.Application.Common.Interfaces;

namespace FlexBook.Application.Features.StaticPages.EvaluatingAdopting.Handlers;
public class GetEvaluatingAdoptingArticleByIdQueryHandler : IRequestHandler<GetEvaluatingAdoptingArticleByIdQuery, TResponse<EvaluatingAdoptingArticleDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetEvaluatingAdoptingArticleByIdQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<EvaluatingAdoptingArticleDto>> Handle(GetEvaluatingAdoptingArticleByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var article = await _unitOfWork.EvaluatingAdoptingArticleRepository.FindById(request.Id, cancellationToken);
            if (article == null)
            {
                return TResponse<EvaluatingAdoptingArticleDto>.Failure(new[] { "Article not found." }, "Unable to find article.", 404);
            }

            var articleDto = new EvaluatingAdoptingArticleDto
            {
                Id = article.Id,
                TitleAr = article.TitleAr,
                TitleEn = article.TitleEn,
                ContentAr = article.ContentAr,
                ContentEn = article.ContentEn,
                AuthorName = article.AuthorName,
                AuthorPhotoUrl = article.AuthorPhotoUrl,
                UpdatedAt = article.UpdatedAt
            };

            return TResponse<EvaluatingAdoptingArticleDto>.Success(articleDto);
        }
        catch (Exception ex)
        {
            return TResponse<EvaluatingAdoptingArticleDto>.Failure(new[] { _resourceService.GetError("Error retrieving article") }, ex.Message);
        }
    }
}