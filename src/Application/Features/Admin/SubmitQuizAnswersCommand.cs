using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog.Dtos;
using MediatR;

namespace FlexBook.Application.Features.Admin;
// SubmitQuizAnswersCommand
public class SubmitQuizAnswersCommand : IRequest<bool>
{
    public Guid QuizId { get; set; }
    public List<QuestionAnswerDto> UserAnswers { get; set; }

    public SubmitQuizAnswersCommand(Guid quizId, List<QuestionAnswerDto> userAnswers)
    {
        QuizId = quizId;
        UserAnswers = userAnswers;
    }
}
