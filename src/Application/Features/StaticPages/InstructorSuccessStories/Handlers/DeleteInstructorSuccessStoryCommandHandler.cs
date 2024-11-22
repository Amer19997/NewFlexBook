using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Commands;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Handlers;
public class DeleteInstructorSuccessStoryCommandHandler : IRequestHandler<DeleteInstructorSuccessStoryCommand, TResponse>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteInstructorSuccessStoryCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse> Handle(DeleteInstructorSuccessStoryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var story = await _unitOfWork.InstructorSuccessStoryRepository.FindById(request.Id, cancellationToken);
            if (story == null)
                return TResponse.Failure(new[] { "Story not found." }, "Unable to delete non-existent story.");

            _unitOfWork.InstructorSuccessStoryRepository.Remove(story);
            await _unitOfWork.CommitAsync(cancellationToken);

            return TResponse.Success("Instructor success story deleted successfully.");
        }
        catch (Exception ex)
        {
            return TResponse.Failure(new[] { "Error deleting instructor success story." }, ex.Message);
        }
    }
}
