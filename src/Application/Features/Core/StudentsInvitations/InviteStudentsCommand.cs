using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using MediatR;

namespace FlexBook.Application.Features.Core.StudentsInvitations;
public class InviteStudentsCommand : IRequest<TResponse<bool>>
{
    public Guid ClassId { get; set; } // ID of the class for which students are being invited
    public List<string> StudentEmails { get; set; } // List of email addresses for the students to invite

    public InviteStudentsCommand(Guid classId, List<string> studentEmails)
    {
        ClassId = classId;
        StudentEmails = studentEmails ?? new List<string>();
    }
}
