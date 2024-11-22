using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Queries;
public record GetInstructorSuccessStoryByIdQuery(Guid Id) : IRequest<TResponse<InstructorSuccessStoryDto>>;

