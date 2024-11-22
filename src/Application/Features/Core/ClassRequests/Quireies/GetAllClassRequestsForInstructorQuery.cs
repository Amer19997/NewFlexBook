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
public class GetAllClassRequestsForInstructorQuery : IRequest<TResponse<IEnumerable<object>>>
{
    public int ?Status { get; set; } = null;// The status filter for class requests
    public int PageNumber { get; set; } = 1; // Default page number
    public int PageSize { get; set; } = 10; // Default page size
}