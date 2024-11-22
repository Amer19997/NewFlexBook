using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Queries;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Interfaces;

namespace FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Handlers;
public class GetInstructorSuccessStoryByIdQueryHandler : IRequestHandler<GetInstructorSuccessStoryByIdQuery, TResponse<InstructorSuccessStoryDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetInstructorSuccessStoryByIdQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<InstructorSuccessStoryDto>> Handle(GetInstructorSuccessStoryByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var story = await _unitOfWork.InstructorSuccessStoryRepository.FindById(request.Id, cancellationToken);
            if (story == null)
                return TResponse<InstructorSuccessStoryDto>.Failure(new[] { _resourceService.GetError("Story not found") }, "Story not found", 404);

            var dto = new InstructorSuccessStoryDto
            {
                Id = story.Id,
                TitleAr = story.TitleAr,
                TitleEn = story.TitleEn,
                DescriptionAr = story.DescriptionAr,
                DescriptionEn = story.DescriptionEn,
                ImageUrl = story.ImageUrl
            };

            return TResponse<InstructorSuccessStoryDto>.Success(dto);
        }
        catch (Exception ex)
        {
            return TResponse<InstructorSuccessStoryDto>.Failure(new[] { _resourceService.GetError("Error retrieving story") }, ex.Message);
        }
    }
}
