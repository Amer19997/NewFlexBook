using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Features.StaticPages.StudentStories.Queries;
using FlexBook.Application.Common.Interfaces;

namespace FlexBook.Application.Features.StaticPages.StudentStories.Handlers;
public class GetStudentSuccessStoryByIdQueryHandler : IRequestHandler<GetStudentSuccessStoryByIdQuery, TResponse<StudentSuccessStoryDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public GetStudentSuccessStoryByIdQueryHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<StudentSuccessStoryDto>> Handle(GetStudentSuccessStoryByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var story = await _unitOfWork.StudentSuccessStoryRepository.FindById(request.Id, cancellationToken);
            if (story == null)
                return TResponse<StudentSuccessStoryDto>.Failure(new[] { _resourceService.GetError("SuccessStoryNotFound") });
 
            // Build the DTO manually
            var resultDto = new StudentSuccessStoryDto
            {
                Id = story.Id,
                NameAr = story.NameAr,
                NameEn = story.NameEn,
                UniversityNameAr = story.UniversityNameAr,
                UniversityNameEn = story.UniversityNameEn,
                DescriptionAr = story.DescriptionAr,
                DescriptionEn = story.DescriptionEn,
                VideoUrl = story.VideoUrl,
                ImageUrl = story.ImageUrl,
                LastUpdated = story.LastUpdated
            };

            return TResponse<StudentSuccessStoryDto>.Success(resultDto);
        }
        catch (Exception ex)
        {
            return TResponse<StudentSuccessStoryDto>.Failure(new[] { _resourceService.GetError("ErrorFetchingSuccessStory")}, ex.Message);
        }
    }
}