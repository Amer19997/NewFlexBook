using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AboutUs.Queries;
using FlexBook.Domain;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Application.Features.StaticPages.AboutUs.Handlers;

public class GetAllAboutUsPagesQueryHandler : IRequestHandler<GetAllAboutUsPagesQuery, TResponse<List<AboutUsPageDto>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllAboutUsPagesQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse<List<AboutUsPageDto>>> Handle(GetAllAboutUsPagesQuery request, CancellationToken cancellationToken)
    {
        try
        {
            // Fetch all About Us sections and include related Testimonials
            var sections = await _unitOfWork.AboutUsSectionRepository
                .GetAllAsQueryable()
                .Include(section => section.Testimonials)
                .ToListAsync(cancellationToken);

            // Map to DTOs
            var dtoList = sections.Select(section => new AboutUsPageDto
            {
                Id = section.Id,
                TitleAr = section.TitleAr,
                TitleEn = section.TitleEn,
                ContentAr = section.ContentAr,
                ContentEn = section.ContentEn,
                ImageUrl = section.ImageUrl,
                UpdatedAt = section.UpdatedAt,
                Testimonials = section.Testimonials.Select(testimonial => new TestimonialDto
                {
                    Id = testimonial.Id,
                    UserName = testimonial.UserName,
                    UserImageUrl = testimonial.UserImageUrl,
                    FeedbackAr = testimonial.FeedbackAr,
                    FeedbackEn = testimonial.FeedbackEn
                }).ToList()
            }).ToList();

            return TResponse<List<AboutUsPageDto>>.Success(dtoList, "Fetched all About Us sections successfully.");
        }
        catch (Exception ex)
        {
            return TResponse<List<AboutUsPageDto>>.Failure(
                new[] { "An error occurred while fetching About Us sections." },
                ex.Message,
                500);
        }
    }
}
