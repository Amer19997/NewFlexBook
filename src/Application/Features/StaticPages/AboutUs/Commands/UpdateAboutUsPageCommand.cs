
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.StaticPages.AboutUs.Commands;
public record UpdateAboutUsPageCommand(
      Guid Id,
      string TitleAr,
      string TitleEn,
      string ContentAr,
      string ContentEn,
      IFormFile? Image,
      List<UpdateTestimonialDto> Testimonials
  ) : IRequest<TResponse<AboutUsPageDto>>;

public record UpdateTestimonialDto(
    Guid? Id, // Nullable to allow adding new testimonials
    string UserName,
    string FeedbackAr,
    string FeedbackEn,
    IFormFile? UserImage
);