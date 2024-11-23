using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.StaticPages.AboutUs.Commands;

public record CreateAboutUsPageCommand(
    string TitleAr,
    string TitleEn,
    string ContentAr,
    string ContentEn,
    IFormFile Image,
    List<CreateTestimonialDto> Testimonials
) : IRequest<TResponse<object>>;

public record CreateTestimonialDto(
    string UserName,
    string FeedbackAr,
    string FeedbackEn,
    IFormFile UserImage
);
