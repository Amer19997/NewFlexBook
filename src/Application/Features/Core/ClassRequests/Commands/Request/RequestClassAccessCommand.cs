using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using MediatR;

namespace FlexBook.Application.Features.Core.ClassRequests.Commands.Request;
public class RequestClassAccessCommand : IRequest<TResponse<bool>>
{
    public Guid? ClassId { get; set; } // Optional: ID of the class
    public string ClassName { get; set; } // Optional: Name of the class

    public RequestClassAccessCommand( Guid? classId = null, string className = null)
    {
        ClassId = classId;
        ClassName = className;
    }
}