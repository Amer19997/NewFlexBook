using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Commands;
public record CreateInstructorSuccessStoryCommand(
    string TitleAr,
    string TitleEn,
    string DescriptionAr,
    string DescriptionEn,
    IFormFile? Image
) : IRequest<TResponse<object>>;