using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Commands;
public record UpdateInstructorSuccessStoryCommand(
       Guid Id,
       string TitleAr,
       string TitleEn,
       string DescriptionAr,
       string DescriptionEn,
       IFormFile? Image
   ) : IRequest<TResponse<InstructorSuccessStoryDto>>;
