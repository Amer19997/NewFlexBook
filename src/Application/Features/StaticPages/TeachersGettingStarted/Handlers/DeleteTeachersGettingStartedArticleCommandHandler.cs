using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.TeachersGettingStarted.Commands;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.TeachersGettingStarted.Handlers;
public class DeleteTeachersGettingStartedArticleCommandHandler : IRequestHandler<DeleteTeachersGettingStartedArticleCommand, TResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public DeleteTeachersGettingStartedArticleCommandHandler(
        IUnitOfWork unitOfWork,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<bool>> Handle(DeleteTeachersGettingStartedArticleCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var article = await _unitOfWork.TeachersGettingStartedArticleRepository.FindById(request.Id, cancellationToken);
            if (article == null)
            {
                return TResponse<bool>.Failure(new[] { "Article not found." }, "Unable to delete a non-existent article.", 404);
            }

            _unitOfWork.TeachersGettingStartedArticleRepository.Remove(article);
            await _unitOfWork.CommitAsync(cancellationToken);

            return TResponse<bool>.Success(true, _resourceService.GetMessage("Article deleted successfully."));
        }
        catch (Exception ex)
        {
            return TResponse<bool>.Failure(new[] { _resourceService.GetError("Error deleting article") }, ex.Message, 500);
        }
    }
}