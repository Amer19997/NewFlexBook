using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AboutUs.Queries;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain.Repositories;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.AboutUs.Handlers;
public class GetAboutUsPageQueryHandler : IRequestHandler<GetAboutUsPageQuery, TResponse<AboutUsPageDto>>
{
    private readonly IAboutUsSectionRepository _repository;

    public GetAboutUsPageQueryHandler(IAboutUsSectionRepository repository)
    {
        _repository = repository;
    }

    public async Task<TResponse<AboutUsPageDto>> Handle(GetAboutUsPageQuery request, CancellationToken cancellationToken)
    {
        var section = await _repository.GetSectionWithTestimonialsAsync(request.Id, cancellationToken);
        if (section == null)
        {
            return TResponse<AboutUsPageDto>.Failure(new[] { "Section not found." }, "Unable to find the specified section.", 404);
        }

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

        return TResponse<AboutUsPageDto>.Success(dto);
    }
}