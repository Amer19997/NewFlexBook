using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.InstructorCommunity.Queries;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Interfaces;

namespace FlexBook.Application.Features.StaticPages.InstructorCommunity.Handlers;
public class GetInstructorCommunityEntryByIdQueryHandler : IRequestHandler<GetInstructorCommunityEntryByIdQuery, TResponse<InstructorCommunityEntryDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetInstructorCommunityEntryByIdQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<InstructorCommunityEntryDto>> Handle(GetInstructorCommunityEntryByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var entry = await _unitOfWork.InstructorCommunityEntryRepository.FindById(request.Id, cancellationToken);
            if (entry == null)
            {
                return TResponse<InstructorCommunityEntryDto>.Failure(new[] { "Entry not found." }, "Unable to find entry.", 404);
            }

            var entryDto = new InstructorCommunityEntryDto
            {
                Id = entry.Id,
                TitleAr = entry.TitleAr,
                TitleEn = entry.TitleEn,
                ContentAr = entry.ContentAr,
                ContentEn = entry.ContentEn,
                ImageUrl = entry.ImageUrl,
                UpdatedAt = entry.UpdatedAt
            };

            return TResponse<InstructorCommunityEntryDto>.Success(entryDto);
        }
        catch (Exception ex)
        {
            return TResponse<InstructorCommunityEntryDto>.Failure(new[] { _resourceService.GetError("Error retrieving entry") }, ex.Message);
        }
    }
}
