using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;

namespace FlexBook.Application.Features.Admin.Lessons.Commands.LessonPartCommand;
public class AddLessonPartCommand : IRequest<TResponse<GetLessonPartDto>>
{
    public Guid LessonId { get; set; }
    public string Content { get; set; } = default!;
    //public List<InteractiveElementDto>? InteractiveElements { get; set; } = new();
}