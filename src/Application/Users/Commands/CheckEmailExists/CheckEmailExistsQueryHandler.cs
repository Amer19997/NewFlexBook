using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Repositories;
using MediatR;

namespace FlexBook.Application.Users.Commands.CheckEmailExists;
public class CheckEmailExistsQueryHandler : IRequestHandler<CheckEmailExistsQuery, TResponse<bool>>
{
    private readonly IUserRepository _userRepository;

    public CheckEmailExistsQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<TResponse<bool>> Handle(CheckEmailExistsQuery request, CancellationToken cancellationToken)
    {
        var emailExists = await _userRepository.CheckEmailIsFound(request.Email);
        return TResponse<bool>.Success(emailExists);
    }
}