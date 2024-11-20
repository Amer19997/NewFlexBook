using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.LookUps.Courses.Queries.GetCoursesBasicListQuery;
using MediatR;

namespace FlexBook.Application.Features.LookUps.Categories.Queries;

public record GetCategoriesListQuery : IRequest<TResponse<GetCategoriestResult>>;
