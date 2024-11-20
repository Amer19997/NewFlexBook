using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.Research.Commands;
public class DeleteResearchEntryCommand : IRequest<TResponse<bool>>
{
    public Guid Id { get; set; }
}