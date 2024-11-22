using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Commands;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Handlers;
public class DeleteStudentsGettingStartedArticleCommandHandler : IRequestHandler<DeleteStudentsGettingStartedArticleCommand, TResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public DeleteStudentsGettingStartedArticleCommandHandler(
        IUnitOfWork unitOfWork,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse> Handle(DeleteStudentsGettingStartedArticleCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Fetch the existing article
            var article = await _unitOfWork.StudentsGettingStartedArticleRepository.FindById(request.Id, cancellationToken);
            if (article == null)
            {
                return TResponse.Failure(new[] { "Article not found." }, "Unable to delete a non-existent article.", 404);
            }

            // Delete the article
            _unitOfWork.StudentsGettingStartedArticleRepository.Remove(article);
            await _unitOfWork.CommitAsync(cancellationToken);

            return TResponse.Success(_resourceService.GetMessage("Article deleted successfully."));
        }
        catch (Exception ex)
        {
            return TResponse.Failure(new[] { _resourceService.GetError("Error deleting article") }, ex.Message, 500);
        }
    }
}