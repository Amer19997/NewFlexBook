using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.InstructorCommunity.Commands;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.InstructorCommunity.Handlers;
public class UpdateInstructorCommunityEntryCommandHandler : IRequestHandler<UpdateInstructorCommunityEntryCommand, TResponse<InstructorCommunityEntryDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public UpdateInstructorCommunityEntryCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<InstructorCommunityEntryDto>> Handle(UpdateInstructorCommunityEntryCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Find the existing entry
            var entry = await _unitOfWork.InstructorCommunityEntryRepository.FindById(request.Id, cancellationToken);
            if (entry == null)
            {
                return TResponse<InstructorCommunityEntryDto>.Failure(new[] { "Entry not found." }, "Unable to update a non-existent entry.", 404);
            }

            // Update entry properties
            entry.TitleAr = request.TitleAr;
            entry.TitleEn = request.TitleEn;
            entry.ContentAr = request.ContentAr;
            entry.ContentEn = request.ContentEn;

            // Update image if provided
            if (request.Image != null)
            {
                entry.ImageUrl = await _fileUploadService.UploadFileAsync(request.Image);
            }

            entry.UpdatedAt = DateTime.UtcNow;

            _unitOfWork.InstructorCommunityEntryRepository.Update(entry);
            await _unitOfWork.CommitAsync(cancellationToken);

            // Return updated DTO
            var responseDto = new InstructorCommunityEntryDto
            {
                Id = entry.Id,
                TitleAr = entry.TitleAr,
                TitleEn = entry.TitleEn,
                ContentAr = entry.ContentAr,
                ContentEn = entry.ContentEn,
                ImageUrl = entry.ImageUrl,
                UpdatedAt = entry.UpdatedAt
            };

            return TResponse<InstructorCommunityEntryDto>.Success(responseDto, _resourceService.GetMessage("Entry updated successfully."));
        }
        catch (Exception ex)
        {
            return TResponse<InstructorCommunityEntryDto>.Failure(new[] { _resourceService.GetError("Error updating entry") }, ex.Message, 500);
        }
    }
}