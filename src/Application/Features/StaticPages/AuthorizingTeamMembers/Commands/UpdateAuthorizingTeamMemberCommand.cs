using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Commands;
public record UpdateAuthorizingTeamMemberCommand(
    Guid Id,
    string FirstNameAr,
    string FirstNameEn,
    string LastNameAr,
    string LastNameEn,
    string DescriptionAr,
    string DescriptionEn,
    IFormFile? Photo
) : IRequest<TResponse<AuthorizingTeamMemberDto>>;