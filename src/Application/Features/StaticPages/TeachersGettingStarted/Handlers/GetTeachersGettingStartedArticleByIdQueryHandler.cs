using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.TeachersGettingStarted.Queries;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Interfaces;

namespace FlexBook.Application.Features.StaticPages.TeachersGettingStarted.Handlers;
public class GetTeachersGettingStartedArticleByIdQueryHandler : IRequestHandler<GetTeachersGettingStartedArticleByIdQuery, TResponse<TeachersGettingStartedArticleDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetTeachersGettingStartedArticleByIdQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<TeachersGettingStartedArticleDto>> Handle(GetTeachersGettingStartedArticleByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var article = await _unitOfWork.TeachersGettingStartedArticleRepository.FindById(request.Id, cancellationToken);
            if (article == null)
            {
                return TResponse<TeachersGettingStartedArticleDto>.Failure(new[] { "Article not found." }, "Unable to find article.", 404);
            }

            var articleDto = new TeachersGettingStartedArticleDto
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

            return TResponse<TeachersGettingStartedArticleDto>.Success(articleDto);
        }
        catch (Exception ex)
        {
            return TResponse<TeachersGettingStartedArticleDto>.Failure(new[] { _resourceService.GetError("Error retrieving article") }, ex.Message);
        }
    }
}
