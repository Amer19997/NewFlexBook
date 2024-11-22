using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Commands;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Interfaces;

namespace FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Handlers;
public class CreateInstructorSuccessStoryCommandHandler : IRequestHandler<CreateInstructorSuccessStoryCommand, TResponse<object>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public CreateInstructorSuccessStoryCommandHandler(IUnitOfWork unitOfWork, IFileUploadService fileUploadService, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<object>> Handle(CreateInstructorSuccessStoryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Upload image
            string? imageUrl = request.Image != null ? await _fileUploadService.UploadFileAsync(request.Image) : null;

            // Create entity
            var story = new InstructorSuccessStory
            {
                TitleAr = request.TitleAr,
                TitleEn = request.TitleEn,
                DescriptionAr = request.DescriptionAr,
                DescriptionEn = request.DescriptionEn,
                ImageUrl = imageUrl
            };

            // Add to repository
            await _unitOfWork.InstructorSuccessStoryRepository.Add(story, cancellationToken);
            await _unitOfWork.CommitAsync(cancellationToken);

            // Prepare DTO for response
            var storyDto = new
            {
                story.Id,
                story.TitleAr,
                story.TitleEn,
                story.DescriptionAr,
                story.DescriptionEn,
                story.ImageUrl
            };

            return TResponse<object>.Success(storyDto, _resourceService.GetMessage("InstructorSuccessStory Created Successfully"));
        }
        catch (Exception ex)
        {
            return TResponse<object>.Failure(new[] { "Error creating instructor success story: " + ex.Message }, ex.Message, 500);
        }
    }
}
    
