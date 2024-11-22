using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.InstructorCommunity.Commands;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.InstructorCommunity.Handlers;
public class CreateInstructorCommunityEntryCommandHandler : IRequestHandler<CreateInstructorCommunityEntryCommand, TResponse<object>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public CreateInstructorCommunityEntryCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<object>> Handle(CreateInstructorCommunityEntryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Upload the image file
            string imageUrl = await _fileUploadService.UploadFileAsync(request.Image);

            // Create new entry
            var entry = new InstructorCommunityEntry
            {
                TitleAr = request.TitleAr,
                TitleEn = request.TitleEn,
                ContentAr = request.ContentAr,
                ContentEn = request.ContentEn,
                ImageUrl = imageUrl,
                UpdatedAt = DateTime.UtcNow
            };

            await _unitOfWork.InstructorCommunityEntryRepository.Add(entry, cancellationToken);
            await _unitOfWork.CommitAsync(cancellationToken);

            return TResponse<object>.Success(new { entry.Id }, _resourceService.GetMessage("Instructor Community entry created successfully."));
        }
        catch (Exception ex)
        {
            return TResponse<object>.Failure(new[] { _resourceService.GetError("Error creating entry") }, ex.Message, 500);
        }
    }
}
