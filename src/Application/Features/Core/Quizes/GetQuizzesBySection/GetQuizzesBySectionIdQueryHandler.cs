using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;

namespace FlexBook.Application.Features.Core.Quizes.GetQuizzesBySection;
public class GetQuizzesBySectionIdQueryHandler : IRequestHandler<GetQuizzesBySectionIdQuery, TResponse<List<GetQuizAfterInstructorLoginDto>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetQuizzesBySectionIdQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse<List<GetQuizAfterInstructorLoginDto>>> Handle(GetQuizzesBySectionIdQuery request, CancellationToken cancellationToken)
    {
        var quizzes = await _unitOfWork.QuizRepository.GetQuizzesBySectionIdAsync(request.SectionId, cancellationToken);

        if (quizzes == null || !quizzes.Any())
            return TResponse<List<GetQuizAfterInstructorLoginDto>>.Failure(new[] { "No quizzes found for the specified section." });

        var quizDtos = quizzes.Select(quiz => new GetQuizAfterInstructorLoginDto
        {
            Id = quiz.Id,
            Name = quiz.Name,
            QuizType = quiz.QuizType,
            SectionId = quiz.SectionId,
            Questions = quiz.Questions.Select(q => new GetQuestionForInstructorDto
            {
                Id = q.Id,
                QuestionText = q.QuestionText,
                QuestionType = q.QuestionType,
                Options = q.Options,
                CorrectAnswers = q.CorrectAnswers,
                MatchingPairs = q.MatchingPairs,
                Answer = q.Answer
            }).ToList()
        }).ToList();

        return TResponse<List<GetQuizAfterInstructorLoginDto>>.Success(quizDtos);
    }
}