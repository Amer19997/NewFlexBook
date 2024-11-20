using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;

namespace FlexBook.Application.Features.Core.Sections.GetSectionsByCourseIdQuery;
// GetSectionsByCourseIdQuery
public class GetSectionsByCourseIdQuery : IRequest<TResponse<List<GetSectionAfterLoginDTo>>>
{
    public Guid CourseId { get; set; }

    public GetSectionsByCourseIdQuery(Guid courseId)
    {
        CourseId = courseId;
    }
}