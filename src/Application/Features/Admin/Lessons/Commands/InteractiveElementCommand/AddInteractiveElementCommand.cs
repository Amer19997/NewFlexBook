using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.Admin.Lessons.Commands.InteractiveElementCommand;
public class AddInteractiveElementCommand : IRequest<TResponse<GetInteractiveElementDto>>
{
    public Guid LessonPartId { get; set; }
    public int ElementNumber { get; set; }  // Number assigned to this element within the lesson part
    public IFormFile InteractiveContentZip { get; set; }

}