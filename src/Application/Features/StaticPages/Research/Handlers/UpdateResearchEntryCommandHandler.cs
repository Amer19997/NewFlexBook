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
public class UpdateResearchEntryCommandHandler : IRequestHandler<UpdateResearchEntryCommand, TResponse<object>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public UpdateResearchEntryCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<object>> Handle(UpdateResearchEntryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Fetch existing research entry
            var researchEntry = await _unitOfWork.ResearchRepository.FindById(request.Id, cancellationToken);

            if (researchEntry == null)
                return TResponse<object>.Failure(new[] { _resourceService.GetError("ResearchEntryNotFound") }, "Research entry not found", 404);

            // Update properties
            researchEntry.TitleAr = request.TitleAr;
            researchEntry.TitleEn = request.TitleEn;
            researchEntry.DescriptionAr = request.DescriptionAr;
            researchEntry.DescriptionEn = request.DescriptionEn;

            // Update chart image if provided
            if (request.ChartImage != null)
            {
                researchEntry.ChartImageUrl = await _fileUploadService.UploadFileAsync(request.ChartImage);
            }

            _unitOfWork.ResearchRepository.Update(researchEntry);
            await _unitOfWork.CommitAsync(cancellationToken);
            var updatedResearchEntry = new
            {
                Id = researchEntry.Id,
                TitleAr = researchEntry.TitleAr,
                TitleEn = researchEntry.TitleEn,
                DescriptionAr = researchEntry.DescriptionAr,
                DescriptionEn = researchEntry.DescriptionEn,
                ChartImageUrl = researchEntry.ChartImageUrl,
            };
            return TResponse<object>.Success(updatedResearchEntry, _resourceService.GetMessage("ResearchEntryUpdated"));
        }
        catch (Exception ex)
        {
            return TResponse<object>.Failure(new[] { _resourceService.GetError("ErrorUpdatingResearchEntry") }, ex.Message);
        }
    }
}