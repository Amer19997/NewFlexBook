using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AboutUs.Commands;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.AboutUs.Handlers;
public class CreateAboutUsPageCommandHandler : IRequestHandler<CreateAboutUsPageCommand, TResponse<object>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public CreateAboutUsPageCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService
        )
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
        ;
    }

    public async Task<TResponse<object>> Handle(CreateAboutUsPageCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Upload the section image
            var imageUrl = await _fileUploadService.UploadFileAsync(request.Image);

            // Create the About Us Section
            var section = new AboutUsSection
            {
                TitleAr = request.TitleAr,
                TitleEn = request.TitleEn,
                ContentAr = request.ContentAr,
                ContentEn = request.ContentEn,
                ImageUrl = imageUrl
            };

            // Add Testimonials
            foreach (var testimonial in request.Testimonials)
            {
                var testimonialImageUrl = await _fileUploadService.UploadFileAsync(testimonial.UserImage);

                section.Testimonials.Add(new Testimonial
                {
                    UserName = testimonial.UserName,
                    FeedbackAr = testimonial.FeedbackAr,
                    FeedbackEn = testimonial.FeedbackEn,
                    UserImageUrl = testimonialImageUrl
                });
            }

            await _unitOfWork.AboutUsSectionRepository.Add(section, cancellationToken);
            await _unitOfWork.CommitAsync(cancellationToken);

            return TResponse<object>.Success(new { section.Id }, _resourceService.GetMessage("About Us section created successfully."));
        }
        catch (Exception ex)
        {
            return TResponse<object>.Failure(new[] { _resourceService.GetError("Error creating About Us section") }, ex.Message, 500);
        }
    }
}
