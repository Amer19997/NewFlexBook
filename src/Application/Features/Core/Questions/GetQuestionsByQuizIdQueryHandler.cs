using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Features.Core.Lessons.GetLessonById.Queries;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;

namespace FlexBook.Application.Features.Core.Questions;
public class GetQuestionsByQuizIdQueryHandler : IRequestHandler<GetQuestionsByQuizIdQuery, TResponse<List<GetQuestionDto>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetQuestionsByQuizIdQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse<List<GetQuestionDto>>> Handle(GetQuestionsByQuizIdQuery request, CancellationToken cancellationToken)
    {
        var questions = await _unitOfWork.QuestionRepository.GetQuestionsByQuizIdAsync(request.QuizId, cancellationToken);

        if (questions == null || !questions.Any())
            return TResponse<List<GetQuestionDto>>.Failure(new[] { "No questions found for the specified quiz." });

        var questionDtos = questions.Select(q => new GetQuestionDto
        {
            Id = q.Id,
            QuestionText = q.QuestionText,
            QuestionType = q.QuestionType,
            Options = q.Options,
            CorrectAnswers = q.CorrectAnswers,
            MatchingPairs = q.MatchingPairs,
            Answer = q.Answer,
            QuizId = q.QuizId
        }).ToList();

        return TResponse<List<GetQuestionDto>>.Success(questionDtos);
    }
}