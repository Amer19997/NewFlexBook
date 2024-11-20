using System;
using FlexBook.Application.Common.Models;
using MediatR;

namespace FlexBook.Application.Features.Core.AccessCode
{
    /// <summary>
    /// Command to use an access code to enroll a student in a specified class.
    /// </summary>
    public class UseAccessCodeCommand : IRequest<TResponse<bool>>
    {
        public Guid ClassId { get; set; } // The ID of the class the student is trying to access
        public string AccessCode { get; set; } // Access code for enrollment

        /// <summary>
        /// Initializes a new instance of the <see cref="UseAccessCodeCommand"/> class.
        /// </summary>
        public UseAccessCodeCommand(Guid classId, string accessCode)
        {
            ClassId = classId;
            AccessCode = accessCode;
        }
    }
}
