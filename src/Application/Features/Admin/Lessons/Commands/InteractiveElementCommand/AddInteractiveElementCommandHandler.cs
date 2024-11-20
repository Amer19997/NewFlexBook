using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain;
using MediatR;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;

namespace FlexBook.Application.Features.Admin.Lessons.Commands.InteractiveElementCommand;
public class AddInteractiveElementCommandHandler : IRequestHandler<AddInteractiveElementCommand, TResponse<GetInteractiveElementDto>>
{
    private readonly IFileUploadService _fileUploadService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IInteractiveContentService _interactiveContentService;
    public AddInteractiveElementCommandHandler(IFileUploadService fileUploadService, IUnitOfWork unitOfWork, IInteractiveContentService interactiveContentService)
    {
        _fileUploadService = fileUploadService;
        _unitOfWork = unitOfWork;
        _interactiveContentService = interactiveContentService;
    }

    public async Task<TResponse<GetInteractiveElementDto>> Handle(AddInteractiveElementCommand request, CancellationToken cancellationToken)
    {
        // Upload the Zip file if provided
        //string? zipUrl = null;
        //if (request.ZipFile != null)
        //{
        //    zipUrl = await _fileUploadService.UploadFileAsync(request.ZipFile);
        //    if (string.IsNullOrEmpty(zipUrl))
        //    {
        //        return TResponse<GetInteractiveElementDto>.Failure(new[] { "File upload failed." });
        //    }
        //}
        // Step 2: Handle interactive content upload and extraction
        string? interactiveContentUrl = null;
        if (request.InteractiveContentZip != null && request.InteractiveContentZip.Length > 0)
        {
            // Extract and save interactive content
            //interactiveContentUrl = await ExtractAndSaveInteractiveContent(request.InteractiveContentZip);
            interactiveContentUrl = await _interactiveContentService.ExtractAndSaveInteractiveContentAsync(request.InteractiveContentZip);
        }
        // Determine the next ElementNumber for the InteractiveElement
        var existingElements = await _unitOfWork.InteractiveElementRepository.GetAllByLessonPartId(request.LessonPartId, cancellationToken);
        int nextElementNumber = existingElements.Any() ? existingElements.Max(e => e.ElementNumber) + 1 : 1;

        // Create new InteractiveElement entity with the next ElementNumber
        var interactiveElement = new InteractiveElement
        {
            LessonPartId = request.LessonPartId,
            ElementNumber = nextElementNumber,
            ZipUrl = interactiveContentUrl
        };

        // Save InteractiveElement to the database
        await _unitOfWork.InteractiveElementRepository.Add(interactiveElement, cancellationToken);

        await _unitOfWork.CommitAsync(cancellationToken);
        // Map to InteractiveElementDto
        var interactiveElementDto = new GetInteractiveElementDto
        {
            Id = interactiveElement.Id,
            LessonPartId = interactiveElement.LessonPartId,
            ElementNumber = interactiveElement.ElementNumber,
            ZipUrl = interactiveContentUrl
        };
        return TResponse<GetInteractiveElementDto>.Success(interactiveElementDto);
    }
}