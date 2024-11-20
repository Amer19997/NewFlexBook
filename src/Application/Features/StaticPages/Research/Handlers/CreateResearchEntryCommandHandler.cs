using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Features.StaticPages.Research.Commands;
using FlexBook.Domain.Entities.StaticPages.Dtos;

namespace FlexBook.Application.Features.StaticPages.Research.Handlers;
public class CreateResearchEntryCommandHandler : IRequestHandler<Commands.CreateResearchEntryCommand, TResponse<ResearchEntryDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public CreateResearchEntryCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<ResearchEntryDto>> Handle(Commands.CreateResearchEntryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            string chartImageUrl = null;

            // Upload chart image if provided
            if (request.ChartImage != null)
            {
                chartImageUrl = await _fileUploadService.UploadFileAsync(request.ChartImage);
            }

            // Create ResearchEntry entity
            var researchEntry = new ResearchEntry
            {
                TitleAr = request.TitleAr,
                TitleEn = request.TitleEn,
                DescriptionAr = request.DescriptionAr,
                DescriptionEn = request.DescriptionEn,
                ChartImageUrl = chartImageUrl
            };

            await _unitOfWork.ResearchRepository.Add(researchEntry, cancellationToken);
            await _unitOfWork.CommitAsync(cancellationToken);
            var researchEntryDto = new ResearchEntryDto
            {
                Id = researchEntry.Id,
                TitleAr = researchEntry.TitleAr,
                TitleEn = request.TitleEn,
                DescriptionAr = request.DescriptionAr,
                DescriptionEn = request.DescriptionEn,
                ChartImageUrl = chartImageUrl
            };
            return TResponse<ResearchEntryDto>.Success(researchEntryDto, _resourceService.GetMessage("ResearchEntryCreated"));
        }
        catch (Exception ex)
        {
            return TResponse<ResearchEntryDto>.Failure(new[] { _resourceService.GetError("ErrorCreatingResearchEntry") }, ex.Message);
        }
    }
}