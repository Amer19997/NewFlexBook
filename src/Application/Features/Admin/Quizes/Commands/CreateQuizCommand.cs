using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using FlexBook.Domain.Enums;
using MediatR;

namespace FlexBook.Application.Features.Admin.Quiz.Commands;
     public record CreateQuizCommand(Guid CourseId) : IRequest<TResponse<GetQuizAfterInstructorLoginDto>>

{
    public string Name { get; set; } = default!;
    public QuizType?QuizType { get; set; }
    public Guid? SectionId { get; set; }

    public Guid? LessonId { get; set; }
    public List<GetQuestionForInstructorDto>?Questions { get; set; } = new List<GetQuestionForInstructorDto>();
}
