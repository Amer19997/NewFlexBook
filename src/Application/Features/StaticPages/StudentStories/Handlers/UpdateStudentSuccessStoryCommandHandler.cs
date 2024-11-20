using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.StudentStories.Commands;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.StudentStories.Handlers;
public class UpdateStudentSuccessStoryCommandHandler : IRequestHandler<UpdateStudentSuccessStoryCommand, TResponse<StudentSuccessStoryDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public UpdateStudentSuccessStoryCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<StudentSuccessStoryDto>> Handle(UpdateStudentSuccessStoryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var story = await _unitOfWork.StudentSuccessStoryRepository.FindById(request.Id, cancellationToken);
            if (story == null)
                return TResponse<StudentSuccessStoryDto>.Failure(new[] { _resourceService.GetError("SuccessStoryNotFound") });

            // Handle file uploads for video and image
            if (request.VideoFile != null)
            {
                story.VideoUrl = await _fileUploadService.UploadFileAsync(request.VideoFile);
            }

            if (request.ImageFile != null)
            {
                story.ImageUrl = await _fileUploadService.UploadFileAsync(request.ImageFile);
            }

            // Update other fields
            story.NameAr = request.NameAr;
            story.NameEn = request.NameEn;
            story.UniversityNameAr = request.UniversityNameAr;
            story.UniversityNameEn = request.UniversityNameEn;
            story.DescriptionAr = request.DescriptionAr;
            story.DescriptionEn = request.DescriptionEn;
            story.LastUpdated = DateTime.UtcNow;

            _unitOfWork.StudentSuccessStoryRepository.Update(story);
            await _unitOfWork.CommitAsync(cancellationToken);

            // Return the response
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
            return TResponse<StudentSuccessStoryDto>.Failure(new[] { _resourceService.GetError("ErrorUpdatingSuccessStory"), ex.Message });
        }
    }
}