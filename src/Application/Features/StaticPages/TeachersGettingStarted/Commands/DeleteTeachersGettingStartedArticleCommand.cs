using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.TeachersGettingStarted.Commands;
public record DeleteTeachersGettingStartedArticleCommand(Guid Id) : IRequest<TResponse<bool>>;
