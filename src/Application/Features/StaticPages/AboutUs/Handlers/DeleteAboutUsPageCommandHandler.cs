using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AboutUs.Commands;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.AboutUs.Handlers;
public class DeleteAboutUsPageCommandHandler : IRequestHandler<DeleteAboutUsPageCommand, TResponse<bool>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;

    public DeleteAboutUsPageCommandHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
    }

    public async Task<TResponse<bool>> Handle(DeleteAboutUsPageCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Find the About Us section by ID
            var section = await _unitOfWork.AboutUsSectionRepository.FindById(request.Id, cancellationToken);
            if (section == null)
            {
                return TResponse<bool>.Failure(new[] { "About Us section not found." }, "The specified section does not exist.", 404);
            }

            // Remove the section (Cascade delete will handle testimonials)
            _unitOfWork.AboutUsSectionRepository.Remove(section);

            // Commit the changes
            await _unitOfWork.CommitAsync(cancellationToken);

            return TResponse<bool>.Success(true, _resourceService.GetMessage("About Us section deleted successfully."));
        }
        catch (Exception ex)
        {
            return TResponse<bool>.Failure(new[] { _resourceService.GetError("Error deleting About Us section") }, ex.Message, 500);
        }
    }
}
