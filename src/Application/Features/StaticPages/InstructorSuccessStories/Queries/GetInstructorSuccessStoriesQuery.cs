using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;
using X.PagedList;

namespace FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Queries;
public record GetInstructorSuccessStoriesQuery(
    string Search = "",
    int PageNumber = 1,
    int PageSize = 10,
    string SortBy = "CreatedAt",
    string SortDirection = "asc"
) : IRequest<TResponse<IPagedList<InstructorSuccessStoryDto>>>;

