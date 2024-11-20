using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;

namespace FlexBook.Application.Features.Core.Quizes.GetQuizzesBySection;
public class GetQuizzesBySectionIdQuery : IRequest<TResponse<List<GetQuizAfterInstructorLoginDto>>>
{
    public Guid SectionId { get; set; }

    public GetQuizzesBySectionIdQuery(Guid sectionId)
    {
        SectionId = sectionId;
    }
}
