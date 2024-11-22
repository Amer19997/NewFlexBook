using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Commands;

namespace FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Handlers;
public class UpdateInstructorSuccessStoryCommandHandler : IRequestHandler<UpdateInstructorSuccessStoryCommand, TResponse<InstructorSuccessStoryDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public UpdateInstructorSuccessStoryCommandHandler(IUnitOfWork unitOfWork, IFileUploadService fileUploadService, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<InstructorSuccessStoryDto>> Handle(UpdateInstructorSuccessStoryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Fetch the existing story
            var story = await _unitOfWork.InstructorSuccessStoryRepository.FindById(request.Id, cancellationToken);

            if (story == null)
                return TResponse<InstructorSuccessStoryDto>.Failure(new[] { "Instructor success story not found" }, "Instructor success story not found", 404);

            // Update properties
            story.TitleAr = request.TitleAr;
            story.TitleEn = request.TitleEn;
            story.DescriptionAr = request.DescriptionAr;
            story.DescriptionEn = request.DescriptionEn;

            // Update image if provided
            if (request.Image != null)
                story.ImageUrl = await _fileUploadService.UploadFileAsync(request.Image);

            // Save changes
            _unitOfWork.InstructorSuccessStoryRepository.Update(story);
            await _unitOfWork.CommitAsync(cancellationToken);

            // Prepare DTO for response
            var storyDto = new InstructorSuccessStoryDto
            {
                Id = story.Id,
                TitleAr = story.TitleAr,
                TitleEn = story.TitleEn,
                DescriptionAr = story.DescriptionAr,
                DescriptionEn = story.DescriptionEn,
                ImageUrl = story.ImageUrl
            };

            return TResponse<InstructorSuccessStoryDto>.Success(storyDto, _resourceService.GetMessage("InstructorSuccessStory Updated Successfully"));
        }
        catch (Exception ex)
        {
            return TResponse<InstructorSuccessStoryDto>.Failure(new[] { _resourceService.GetError("Error updating instructor success story") }, ex.Message);
        }
    }
}
