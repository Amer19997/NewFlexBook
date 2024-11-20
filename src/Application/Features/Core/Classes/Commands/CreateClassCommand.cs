using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities;
using MediatR;

namespace FlexBook.Application.Features.Core.Classes.Commands;
public class CreateClassCommand : IRequest<TResponse<ClassDto>>
{
    public Guid CourseId { get; set; }
    public string ClassName { get; set; } = default!;
    public string Syllabus { get; set; } = default!;
}