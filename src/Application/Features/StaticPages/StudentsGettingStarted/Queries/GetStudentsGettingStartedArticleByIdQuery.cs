using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Queries;
public record GetStudentsGettingStartedArticleByIdQuery(Guid Id) : IRequest<TResponse<StudentsGettingStartedArticleDto>>;
