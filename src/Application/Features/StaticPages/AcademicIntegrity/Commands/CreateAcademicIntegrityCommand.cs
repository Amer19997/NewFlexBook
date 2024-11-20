using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.StaticPages.AcademicIntegrity.Commands;
public record CreateAcademicIntegrityCommand(
    string TitleAr,
    string TitleEn,
    string DescriptionAr,
    string DescriptionEn,
    string HeaderTitleAr,
    string HeaderTitleEn,
    string HeaderDescriptionAr,
    string HeaderDescriptionEn,
    IFormFile? Image
) : IRequest<TResponse<AcademicIntegrityDto>>;

