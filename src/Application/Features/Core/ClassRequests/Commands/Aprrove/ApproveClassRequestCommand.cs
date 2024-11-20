using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using MediatR;

namespace FlexBook.Application.Features.Core.ClassRequests.Commands.Aprrove;
public class ApproveClassRequestCommand : IRequest<TResponse<bool>>
{
    public Guid RequestId { get; set; } // ID of the class request to approve

    public ApproveClassRequestCommand(Guid requestId)
    {
        RequestId = requestId;
    }
}