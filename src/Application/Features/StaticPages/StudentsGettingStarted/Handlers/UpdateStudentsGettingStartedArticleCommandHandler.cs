using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Commands;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Handlers;

public class UpdateStudentsGettingStartedArticleCommandHandler : IRequestHandler<UpdateStudentsGettingStartedArticleCommand, TResponse<StudentsGettingStartedArticleDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public UpdateStudentsGettingStartedArticleCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<StudentsGettingStartedArticleDto>> Handle(UpdateStudentsGettingStartedArticleCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Fetch the existing article
            var article = await _unitOfWork.StudentsGettingStartedArticleRepository.FindById(request.Id, cancellationToken);
            if (article == null)
            {
                return TResponse<StudentsGettingStartedArticleDto>.Failure(new[] { "Article not found." }, "Unable to update a non-existent article.", 404);
            }

            // Update properties
            article.TitleAr = request.TitleAr;
            article.TitleEn = request.TitleEn;
            article.ContentAr = request.ContentAr;
            article.ContentEn = request.ContentEn;
            article.AuthorName = request.AuthorName;

            // Update author photo if provided
            if (request.AuthorPhoto != null)
            {
                article.AuthorPhotoUrl = await _fileUploadService.UploadFileAsync(request.AuthorPhoto);
            }

            article.UpdatedAt = DateTime.UtcNow;

            // Save changes
            _unitOfWork.StudentsGettingStartedArticleRepository.Update(article);
            await _unitOfWork.CommitAsync(cancellationToken);

            // Prepare response DTO
            var responseDto = new StudentsGettingStartedArticleDto
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

            return TResponse<StudentsGettingStartedArticleDto>.Success(responseDto, _resourceService.GetMessage("Article updated successfully."));
        }
        catch (Exception ex)
        {
            return TResponse<StudentsGettingStartedArticleDto>.Failure(new[] { _resourceService.GetError("Error updating article") }, ex.Message, 500);
        }
    }
}
