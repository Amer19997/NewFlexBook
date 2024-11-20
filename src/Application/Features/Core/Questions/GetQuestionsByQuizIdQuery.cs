using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.Core.Lessons.GetLessonById.Queries;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;

namespace FlexBook.Application.Features.Core.Questions;
// GetQuestionsByQuizIdQuery
public class GetQuestionsByQuizIdQuery : IRequest<TResponse<List<GetQuestionDto>>>
{
    public Guid QuizId { get; set; }

    public GetQuestionsByQuizIdQuery(Guid quizId)
    {
        QuizId = quizId;
    }
}