using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AboutUs.Commands;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.AboutUs.Handlers;
public class UpdateAboutUsPageCommandHandler : IRequestHandler<UpdateAboutUsPageCommand, TResponse<AboutUsPageDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;

    public UpdateAboutUsPageCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<AboutUsPageDto>> Handle(UpdateAboutUsPageCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Find the section
            var section = await _unitOfWork.AboutUsSectionRepository.FindById(request.Id, cancellationToken);
            if (section == null)
            {
                return TResponse<AboutUsPageDto>.Failure(new[] { "Section not found." }, "Unable to update a non-existent section.", 404);
            }

            // Update section fields
            section.TitleAr = request.TitleAr;
            section.TitleEn = request.TitleEn;
            section.ContentAr = request.ContentAr;
            section.ContentEn = request.ContentEn;

            // Update the section image if provided
            if (request.Image != null)
            {
                section.ImageUrl = await _fileUploadService.UploadFileAsync(request.Image);
            }

            // Handle Testimonials
            foreach (var testimonialDto in request.Testimonials)
            {
                if (testimonialDto.Id.HasValue)
                {
                    // Update existing testimonial
                    var testimonial = section.Testimonials.FirstOrDefault(t => t.Id == testimonialDto.Id.Value);
                    if (testimonial != null)
                    {
                        testimonial.UserName = testimonialDto.UserName;
                        testimonial.FeedbackAr = testimonialDto.FeedbackAr;
                        testimonial.FeedbackEn = testimonialDto.FeedbackEn;

                        if (testimonialDto.UserImage != null)
                        {
                            testimonial.UserImageUrl = await _fileUploadService.UploadFileAsync(testimonialDto.UserImage);
                        }
                    }
                }
                else
                {
                    // Add new testimonial
                    var newImageUrl = await _fileUploadService.UploadFileAsync(testimonialDto.UserImage);
                    section.Testimonials.Add(new Testimonial
                    {
                        UserName = testimonialDto.UserName,
                        FeedbackAr = testimonialDto.FeedbackAr,
                        FeedbackEn = testimonialDto.FeedbackEn,
                        UserImageUrl = newImageUrl
                    });
                }
            }

            // Save changes
            _unitOfWork.AboutUsSectionRepository.Update(section);
            await _unitOfWork.CommitAsync(cancellationToken);

            // Prepare the response DTO
            var dto = new AboutUsPageDto
            {
                Id = section.Id,
                TitleAr = section.TitleAr,
                TitleEn = section.TitleEn,
                ContentAr = section.ContentAr,
                ContentEn = section.ContentEn,
                ImageUrl = section.ImageUrl,
                UpdatedAt = section.UpdatedAt,
                Testimonials = section.Testimonials.Select(t => new TestimonialDto
                {
                    Id = t.Id,
                    UserName = t.UserName,
                    UserImageUrl = t.UserImageUrl,
                    FeedbackAr = t.FeedbackAr,
                    FeedbackEn = t.FeedbackEn
                }).ToList()
            };

            return TResponse<AboutUsPageDto>.Success(dto, _resourceService.GetMessage("Section updated successfully."));
        }
        catch (Exception ex)
        {
            return TResponse<AboutUsPageDto>.Failure(new[] { _resourceService.GetError("Error updating section") }, ex.Message, 500);
        }
    }
}