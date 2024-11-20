using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Commands;
public record DeleteAuthorizingTeamMemberCommand(Guid Id) : IRequest<TResponse<string>>;
