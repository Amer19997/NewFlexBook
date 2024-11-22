using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.InstructorCommunity.Commands;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.InstructorCommunity.Handlers;
public class DeleteInstructorCommunityEntryCommandHandler : IRequestHandler<DeleteInstructorCommunityEntryCommand, TResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public DeleteInstructorCommunityEntryCommandHandler(
        IUnitOfWork unitOfWork,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<bool>> Handle(DeleteInstructorCommunityEntryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Find the existing entry
            var entry = await _unitOfWork.InstructorCommunityEntryRepository.FindById(request.Id, cancellationToken);
            if (entry == null)
            {
                return TResponse<bool>.Failure(new[] { "Entry not found." }, "Unable to delete a non-existent entry.", 404);
            }

            _unitOfWork.InstructorCommunityEntryRepository.Remove(entry);
            await _unitOfWork.CommitAsync(cancellationToken);

            return TResponse<bool>.Success(true, _resourceService.GetMessage("Entry deleted successfully."));
        }
        catch (Exception ex)
        {
            return TResponse<bool>.Failure(new[] { _resourceService.GetError("Error deleting entry") }, ex.Message, 500);
        }
    }
}