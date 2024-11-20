using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;

namespace FlexBook.Application.Features.Core.Lessons;
// GetLessonsBySectionIdQuery
public class GetLessonsBySectionIdQuery : IRequest<TResponse<List<GetLessonAfterLoginDto>>>
{
    public Guid SectionId { get; set; }

    public GetLessonsBySectionIdQuery(Guid sectionId)
    {
        SectionId = sectionId;
    }
}