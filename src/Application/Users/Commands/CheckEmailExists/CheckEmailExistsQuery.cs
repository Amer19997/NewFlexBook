using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using MediatR;

namespace FlexBook.Application.Users.Commands.CheckEmailExists;
public class CheckEmailExistsQuery : IRequest<TResponse<bool>>
{
    public string Email { get; set; }
    public CheckEmailExistsQuery(string email)
    {
        Email = email;
    }
}
