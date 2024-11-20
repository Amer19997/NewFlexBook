using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using MediatR;

namespace FlexBook.Application.Features.Admin.Sections.Commands;
// AddSectionCommand
public class AddSectionCommand : IRequest<TResponse<SectionDto>>
{
    public string TitleAr { get; set; } = default!;
    public string TitleEn { get; set; } = default!;
    public Guid CourseId { get; set; }
}
