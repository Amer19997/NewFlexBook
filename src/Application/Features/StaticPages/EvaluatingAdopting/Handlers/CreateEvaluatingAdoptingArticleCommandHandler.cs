using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.EvaluatingAdopting.Commands;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.EvaluatingAdopting.Handlers;
public class CreateEvaluatingAdoptingArticleCommandHandler : IRequestHandler<CreateEvaluatingAdoptingArticleCommand, TResponse<object>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public CreateEvaluatingAdoptingArticleCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<object>> Handle(CreateEvaluatingAdoptingArticleCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Upload author photo
            string? authorPhotoUrl = null;
            if (request.AuthorPhoto != null)
            {
                authorPhotoUrl = await _fileUploadService.UploadFileAsync(request.AuthorPhoto);
            }

            // Create entity
            var article = new EvaluatingAdoptingArticle
            {
                TitleAr = request.TitleAr,
                TitleEn = request.TitleEn,
                ContentAr = request.ContentAr,
                ContentEn = request.ContentEn,
                AuthorName = request.AuthorName,
                AuthorPhotoUrl = authorPhotoUrl,
                UpdatedAt = DateTime.UtcNow
            };

            await _unitOfWork.EvaluatingAdoptingArticleRepository.Add(article, cancellationToken);
            await _unitOfWork.CommitAsync(cancellationToken);

            return TResponse<object>.Success(new { article.Id }, _resourceService.GetMessage("Article created successfully."));
        }
        catch (Exception ex)
        {
            return TResponse<object>.Failure(new[] { _resourceService.GetError("Error creating article") }, ex.Message, 500);
        }
    }
}