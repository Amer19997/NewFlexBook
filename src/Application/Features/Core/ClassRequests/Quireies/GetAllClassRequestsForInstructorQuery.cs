using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Entities.Catalog.Dtos;
using MediatR;

namespace FlexBook.Application.Features.Core.ClassRequests.Quireies;
public class GetAllClassRequestsForInstructorQuery : IRequest<TResponse<IEnumerable<ClassRequestDto>>>
{

    public GetAllClassRequestsForInstructorQuery()
    {
    }
}