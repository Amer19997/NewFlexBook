using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.StaticPages.StudentStories.Commands;
public record CreateStudentSuccessStoryCommand(
    string NameAr,
    string NameEn,
    string UniversityNameAr,
    string UniversityNameEn,
    string DescriptionAr,
    string DescriptionEn,
    IFormFile? VideoFile,
    IFormFile? ImageFile
) : IRequest<TResponse<StudentSuccessStoryDto>>;

