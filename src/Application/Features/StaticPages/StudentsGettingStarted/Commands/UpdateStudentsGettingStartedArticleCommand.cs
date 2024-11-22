using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Commands;
public record UpdateStudentsGettingStartedArticleCommand(
    Guid Id,
    string TitleAr,
    string TitleEn,
    string ContentAr,
    string ContentEn,
    string AuthorName,
    IFormFile? AuthorPhoto
) : IRequest<TResponse<StudentsGettingStartedArticleDto>>;
