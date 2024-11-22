using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.EvaluatingAdopting.Commands;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.EvaluatingAdopting.Handlers;
public class UpdateEvaluatingAdoptingArticleCommandHandler : IRequestHandler<UpdateEvaluatingAdoptingArticleCommand, TResponse<EvaluatingAdoptingArticleDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public UpdateEvaluatingAdoptingArticleCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<EvaluatingAdoptingArticleDto>> Handle(UpdateEvaluatingAdoptingArticleCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Fetch the existing article
            var article = await _unitOfWork.EvaluatingAdoptingArticleRepository.FindById(request.Id, cancellationToken);
            if (article == null)
            {
                return TResponse<EvaluatingAdoptingArticleDto>.Failure(new[] { "Article not found." }, "Unable to update a non-existent article.", 404);
            }

            // Update article properties
            article.TitleAr = request.TitleAr;
            article.TitleEn = request.TitleEn;
            article.ContentAr = request.ContentAr;
            article.ContentEn = request.ContentEn;
            article.AuthorName = request.AuthorName;

            // Update photo if provided
            if (request.AuthorPhoto != null)
            {
                article.AuthorPhotoUrl = await _fileUploadService.UploadFileAsync(request.AuthorPhoto);
            }

            article.UpdatedAt = DateTime.UtcNow;

            _unitOfWork.EvaluatingAdoptingArticleRepository.Update(article);
            await _unitOfWork.CommitAsync(cancellationToken);

            // Return DTO
            var responseDto = new EvaluatingAdoptingArticleDto
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

            return TResponse<EvaluatingAdoptingArticleDto>.Success(responseDto, _resourceService.GetMessage("Article updated successfully."));
        }
        catch (Exception ex)
        {
            return TResponse<EvaluatingAdoptingArticleDto>.Failure(new[] { _resourceService.GetError("Error updating article") }, ex.Message, 500);
        }
    }
}