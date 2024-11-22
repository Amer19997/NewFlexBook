using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Commands;
public record CreateStudentsGettingStartedArticleCommand(
      string TitleAr,
      string TitleEn,
      string ContentAr,
      string ContentEn,
      string AuthorName,
      IFormFile AuthorPhoto
  ) : IRequest<TResponse<object>>;