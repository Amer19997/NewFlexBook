using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.HomePage.Commands;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.HomePage.Handlers;
public class DeleteHomePageSectionCommandHandler : IRequestHandler<DeleteHomePageSectionCommand, TResponse<object>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public DeleteHomePageSectionCommandHandler(
        IUnitOfWork unitOfWork,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<object>> Handle(DeleteHomePageSectionCommand request, CancellationToken cancellationToken)
    {
        var section = await _unitOfWork.HomePageSectionRepository.GetHomePageSectionAsync(cancellationToken);

        if (section == null)
        {
            return TResponse<object>.Failure(
                new[] { _resourceService.GetError("Home page section not found.") },
                "Entity not found",
                404
            );
        }

         _unitOfWork.HomePageSectionRepository.Remove(section);
 
        await _unitOfWork.CommitAsync(cancellationToken);

        return TResponse<object>.Success(new { section.Id }, _resourceService.GetMessage("Home page section deleted successfully."));
    }
}