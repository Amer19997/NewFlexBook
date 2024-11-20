using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.Research.Queries;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Interfaces;

namespace FlexBook.Application.Features.StaticPages.Research.Handlers;
public class GetResearchEntryByIdQueryHandler : IRequestHandler<GetResearchEntryByIdQuery, TResponse<ResearchEntryDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetResearchEntryByIdQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<ResearchEntryDto>> Handle(GetResearchEntryByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            // Fetch research entry by ID
            var researchEntry = await _unitOfWork.ResearchRepository.FindById(request.Id, cancellationToken);

            if (researchEntry == null)
                return TResponse<ResearchEntryDto>.Failure(new[] { _resourceService.GetError("ResearchEntryNotFound") }, "Research entry not found", 404);

            var dto = new ResearchEntryDto
            {
                Id = researchEntry.Id,
                TitleAr = researchEntry.TitleAr,
                TitleEn = researchEntry.TitleEn,
                DescriptionAr = researchEntry.DescriptionAr,
                DescriptionEn = researchEntry.DescriptionEn,
                ChartImageUrl = researchEntry.ChartImageUrl
            };

            return TResponse<ResearchEntryDto>.Success(dto);
        }
        catch (Exception ex)
        {
            return TResponse<ResearchEntryDto>.Failure(new[] { _resourceService.GetError("ErrorFetchingResearchEntry") }, ex.Message);
        }
    }
}