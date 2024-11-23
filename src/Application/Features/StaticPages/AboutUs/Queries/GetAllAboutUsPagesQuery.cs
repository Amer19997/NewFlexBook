using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;
using System.Collections.Generic;

namespace FlexBook.Application.Features.StaticPages.AboutUs.Queries
{
    public record GetAllAboutUsPagesQuery : IRequest<TResponse<List<AboutUsPageDto>>>;
}
