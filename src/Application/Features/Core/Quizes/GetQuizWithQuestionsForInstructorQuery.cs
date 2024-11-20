using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;

namespace FlexBook.Application.Features.Core.Quizes;
// GetQuizWithQuestionsQuery
public class GetQuizWithQuestionsForInstructorQuery : IRequest<GetQuizAfterInstructorLoginDto>
{
    public Guid QuizId { get; }

    public GetQuizWithQuestionsForInstructorQuery(Guid quizId)
    {
        QuizId = quizId;
    }
}