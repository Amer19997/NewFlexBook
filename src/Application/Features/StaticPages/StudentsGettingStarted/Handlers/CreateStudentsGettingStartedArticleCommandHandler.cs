using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Commands;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Handlers;
public class CreateStudentsGettingStartedArticleCommandHandler : IRequestHandler<CreateStudentsGettingStartedArticleCommand, TResponse<object>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public CreateStudentsGettingStartedArticleCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<object>> Handle(CreateStudentsGettingStartedArticleCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Upload author photo
            string? authorPhotoUrl = request.AuthorPhoto != null
                ? await _fileUploadService.UploadFileAsync(request.AuthorPhoto)
                : null;

            // Create entity
            var article = new StudentsGettingStartedArticle
            {
                TitleAr = request.TitleAr,
                TitleEn = request.TitleEn,
                ContentAr = request.ContentAr,
                ContentEn = request.ContentEn,
                AuthorName = request.AuthorName,
                AuthorPhotoUrl = authorPhotoUrl,
                UpdatedAt = DateTime.UtcNow
            };

            // Save to database
            await _unitOfWork.StudentsGettingStartedArticleRepository.Add(article, cancellationToken);
            await _unitOfWork.CommitAsync(cancellationToken);

            // Prepare response data
            var responseDto = new
            {
                article.Id,
                article.TitleAr,
                article.TitleEn,
                article.AuthorName,
                article.AuthorPhotoUrl
            };

            return TResponse<object>.Success(responseDto, _resourceService.GetMessage("Article created successfully."));
        }
        catch (Exception ex)
        {
            return TResponse<object>.Failure(new[] { "Error creating article: " + ex.Message }, ex.Message, 500);
        }
    }
}