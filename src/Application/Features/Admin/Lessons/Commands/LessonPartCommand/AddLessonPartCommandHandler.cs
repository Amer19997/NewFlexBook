using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;

namespace FlexBook.Application.Features.Admin.Lessons.Commands.LessonPartCommand;
public class AddLessonPartCommandHandler : IRequestHandler<AddLessonPartCommand, TResponse<GetLessonPartDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMediator _mediator;

    public AddLessonPartCommandHandler(IUnitOfWork unitOfWork, IMediator mediator)
    {
        _unitOfWork = unitOfWork;
        _mediator = mediator;
    }

    public async Task<TResponse<GetLessonPartDto>> Handle(AddLessonPartCommand request, CancellationToken cancellationToken)
    {
        // Determine the next PartNumber for the LessonPart
        var existingParts = await _unitOfWork.LessonPartRepository.GetAllByLessonId(request.LessonId, cancellationToken);
        var nextPartNumber = existingParts.Count + 1;

        // Create new LessonPart entity with PartNumber
        var lessonPart = new LessonPart
        {
            LessonId = request.LessonId,
            PartNumber = nextPartNumber,
            Content = request.Content
        };

        // Save LessonPart to the database
        await _unitOfWork.LessonPartRepository.Add(lessonPart, cancellationToken);
        await _unitOfWork.CommitAsync(cancellationToken);

        // Process and add InteractiveElements using AddInteractiveElementCommand for each element
        //var interactiveElementCommands = request.InteractiveElements.Select(e => new AddInteractiveElementCommand
        //{
        //    LessonPartId = lessonPart.Id,
        //    ZipFile = e.ZipFile
        //});

        //int elementCounter = 1;
        //foreach (var command in interactiveElementCommands)
        //{
        //    command.ElementNumber = elementCounter++; // Increment ElementNumber sequentially
        //    var interactiveElementResponse = await _mediator.Send(command, cancellationToken);
        //    if (!interactiveElementResponse.IsSuccess)
        //    {
        //        return TResponse<LessonPart>.Failure("Failed to add interactive element.");
        //    }
        //    lessonPart.InteractiveElements.Add(interactiveElementResponse.Data);
        //}
        // Map to LessonPartDto
        var lessonPartDto = new GetLessonPartDto
        {
            Id = lessonPart.Id,
            LessonId = lessonPart.LessonId,
            PartNumber = lessonPart.PartNumber,
            Content = lessonPart.Content,
            InteractiveElements = lessonPart.InteractiveElements
                .Select(ie => new GetInteractiveElementDto
                {
                    Id = ie.Id,
                    LessonPartId = ie.LessonPartId,
                    ElementNumber = ie.ElementNumber,
                    ZipUrl = ie.ZipUrl
                })
                .ToList()
        };

        return TResponse<GetLessonPartDto>.Success(lessonPartDto);
    }
}

