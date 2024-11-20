using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.StudentStories.Commands;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.StudentStories.Handlers;
public class DeleteStudentSuccessStoryCommandHandler : IRequestHandler<DeleteStudentSuccessStoryCommand, TResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public DeleteStudentSuccessStoryCommandHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<bool>> Handle(DeleteStudentSuccessStoryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var story = await _unitOfWork.StudentSuccessStoryRepository.FindById(request.Id, cancellationToken);
            if (story == null)
                return TResponse<bool>.Failure(new[] { _resourceService.GetError("SuccessStoryNotFound") });

            _unitOfWork.StudentSuccessStoryRepository.Remove(story);
            await _unitOfWork.CommitAsync(cancellationToken);

            return TResponse<bool>.Success(true);
        }
        catch (Exception ex)
        {
            return TResponse<bool>.Failure(new []{ _resourceService.GetError("ErrorDeletingSuccessStory"), ex.Message });
        }
    }
}
