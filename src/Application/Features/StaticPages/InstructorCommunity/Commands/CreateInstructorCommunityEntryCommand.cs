using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.StaticPages.InstructorCommunity.Commands;
public record CreateInstructorCommunityEntryCommand(
        string TitleAr,
        string TitleEn,
        string ContentAr,
        string ContentEn,
        IFormFile Image
    ) : IRequest<TResponse<object>>;
