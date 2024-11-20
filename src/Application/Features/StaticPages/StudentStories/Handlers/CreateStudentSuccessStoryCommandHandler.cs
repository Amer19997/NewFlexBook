using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.StudentStories.Commands;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.StudentStories.Handlers;
public class CreateStudentSuccessStoryCommandHandler : IRequestHandler<CreateStudentSuccessStoryCommand, TResponse<StudentSuccessStoryDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public CreateStudentSuccessStoryCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<StudentSuccessStoryDto>> Handle(CreateStudentSuccessStoryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Handle file uploads for video and image
            string? videoUrl = request.VideoFile != null ? await _fileUploadService.UploadFileAsync(request.VideoFile) : null;
            string? imageUrl = request.ImageFile != null ? await _fileUploadService.UploadFileAsync(request.ImageFile) : null;

            // Create the StudentSuccessStory entity
            var story = new StudentSuccessStory
            {
                NameAr = request.NameAr,
                NameEn = request.NameEn,
                UniversityNameAr = request.UniversityNameAr,
                UniversityNameEn = request.UniversityNameEn,
                DescriptionAr = request.DescriptionAr,
                DescriptionEn = request.DescriptionEn,
                VideoUrl = videoUrl,
                ImageUrl = imageUrl,
                LastUpdated = DateTime.UtcNow
            };

            // Save the story to the repository
            await _unitOfWork.StudentSuccessStoryRepository.Add(story, cancellationToken);
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
            // Fix: Convert the single error message to a string array
            return TResponse<StudentSuccessStoryDto>.Failure(new[] { _resourceService.GetError("ErrorCreatingSuccessStory") }, ex.Message);
        }
    }
}