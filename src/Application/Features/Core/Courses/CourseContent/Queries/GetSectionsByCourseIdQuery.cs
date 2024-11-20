using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;

namespace FlexBook.Application.Features.Core.Courses.CourseContent.Queries;
public record GetSectionsByCourseIdQuery(Guid CourseId) : IRequest<TResponse<List<GetSectionAfterLoginDTo>>>;

