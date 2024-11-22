using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.TeachersGettingStarted.Commands;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.TeachersGettingStarted.Handlers;

public class UpdateTeachersGettingStartedArticleCommandHandler : IRequestHandler<UpdateTeachersGettingStartedArticleCommand, TResponse<TeachersGettingStartedArticleDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public UpdateTeachersGettingStartedArticleCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<TeachersGettingStartedArticleDto>> Handle(UpdateTeachersGettingStartedArticleCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var article = await _unitOfWork.TeachersGettingStartedArticleRepository.FindById(request.Id, cancellationToken);
            if (article == null)
            {
                return TResponse<TeachersGettingStartedArticleDto>.Failure(new[] { "Article not found." }, "Unable to update a non-existent article.", 404);
            }

            article.TitleAr = request.TitleAr;
            article.TitleEn = request.TitleEn;
            article.ContentAr = request.ContentAr;
            article.ContentEn = request.ContentEn;
            article.AuthorName = request.AuthorName;

            if (request.AuthorPhoto != null)
            {
                article.AuthorPhotoUrl = await _fileUploadService.UploadFileAsync(request.AuthorPhoto);
            }

            article.UpdatedAt = DateTime.UtcNow;

            _unitOfWork.TeachersGettingStartedArticleRepository.Update(article);
            await _unitOfWork.CommitAsync(cancellationToken);

            var responseDto = new TeachersGettingStartedArticleDto
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

            return TResponse<TeachersGettingStartedArticleDto>.Success(responseDto, _resourceService.GetMessage("Article updated successfully."));
        }
        catch (Exception ex)
        {
            return TResponse<TeachersGettingStartedArticleDto>.Failure(new[] { _resourceService.GetError("Error updating article") }, ex.Message, 500);
        }
    }
}