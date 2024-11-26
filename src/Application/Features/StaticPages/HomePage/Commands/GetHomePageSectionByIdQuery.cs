using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.HomePage.Queries;

 public record GetHomePageSectionByIdQuery : IRequest<TResponse<HomePageSectionDto>>;
