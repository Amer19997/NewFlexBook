using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.Research.Queries;
public class GetResearchEntryByIdQuery : IRequest<TResponse<ResearchEntryDto>>
{
    public Guid Id { get; set; }

    public GetResearchEntryByIdQuery(Guid id)
    {
        Id = id;
    }
}
