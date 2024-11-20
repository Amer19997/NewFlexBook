using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using FlexBook.Domain.Repositories;
using MediatR;

namespace FlexBook.Application.Features.Core.Quizes;
public class GetQuizWithQuestionsQueryHandler : IRequestHandler<GetQuizWithQuestionsForInstructorQuery, GetQuizAfterInstructorLoginDto>
{
    private readonly IQuizRepository _quizRepository;

    public GetQuizWithQuestionsQueryHandler(IQuizRepository quizRepository)
    {
        _quizRepository = quizRepository;
    }

    public async Task<GetQuizAfterInstructorLoginDto> Handle(GetQuizWithQuestionsForInstructorQuery request, CancellationToken cancellationToken)
    {
        var quiz = await _quizRepository.GetQuizWithQuestionsAsync(request.QuizId);



        var QuizDto = new GetQuizAfterInstructorLoginDto
        {
            Id = quiz.Id,
            Name = quiz.Name,
            QuizType = quiz.QuizType,
            SectionId = quiz.SectionId,
            Questions = quiz.Questions.Select(question => new GetQuestionForInstructorDto
            {
                Id = question.Id,
                QuestionText = question.QuestionText,
                QuestionType = question.QuestionType,
                Options = question.Options,
                CorrectAnswers = question.CorrectAnswers,
                MatchingPairs = question.MatchingPairs,
                Answer = question.Answer
            }).ToList()

        };
        return QuizDto;
    }
}
