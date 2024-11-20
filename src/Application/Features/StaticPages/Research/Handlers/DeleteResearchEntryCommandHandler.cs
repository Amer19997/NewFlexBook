using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.Research.Commands;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.Research.Handlers;
public class DeleteResearchEntryCommandHandler : IRequestHandler<DeleteResearchEntryCommand, TResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public DeleteResearchEntryCommandHandler(
        IUnitOfWork unitOfWork,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<bool>> Handle(DeleteResearchEntryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Fetch existing research entry
            var researchEntry = await _unitOfWork.ResearchRepository.FindById(request.Id, cancellationToken);

            if (researchEntry == null)
                return TResponse<bool>.Failure(new[] { _resourceService.GetError("ResearchEntryNotFound") }, "Research entry not found", 404);

            _unitOfWork.ResearchRepository.Remove(researchEntry);
            await _unitOfWork.CommitAsync(cancellationToken);

            return TResponse<bool>.Success(true, _resourceService.GetMessage("ResearchEntryDeleted"));
        }
        catch (Exception ex)
        {
            return TResponse<bool>.Failure(new[] { _resourceService.GetError("ErrorDeletingResearchEntry") }, ex.Message);
        }
    }
}