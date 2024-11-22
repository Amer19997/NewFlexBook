using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Queries;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Interfaces;

namespace FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Handlers;

public class GetStudentsGettingStartedArticleByIdQueryHandler : IRequestHandler<GetStudentsGettingStartedArticleByIdQuery, TResponse<StudentsGettingStartedArticleDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetStudentsGettingStartedArticleByIdQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<StudentsGettingStartedArticleDto>> Handle(GetStudentsGettingStartedArticleByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var article = await _unitOfWork.StudentsGettingStartedArticleRepository.FindById(request.Id, cancellationToken);

            if (article == null)
                return TResponse<StudentsGettingStartedArticleDto>.Failure(new[] { "Article not found" }, "Article not found", 404);

            var articleDto = new StudentsGettingStartedArticleDto
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

            return TResponse<StudentsGettingStartedArticleDto>.Success(articleDto);
        }
        catch (Exception ex)
        {
            return TResponse<StudentsGettingStartedArticleDto>.Failure(new[] { _resourceService.GetError("Error retrieving article") }, ex.Message);
        }
    }
}
