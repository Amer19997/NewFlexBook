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
    public Guid RequestId { get; set; }
    public bool IsApprove { get; set; } // Indicates approval or rejection
    //public string? RejectionReason { get; set; } // Optional rejection reason

    public ApproveClassRequestCommand(Guid requestId, bool isApprove/*, string? rejectionReason = null*/)
    {
        RequestId = requestId;
        IsApprove = isApprove;
        //RejectionReason = rejectionReason;
    }

}