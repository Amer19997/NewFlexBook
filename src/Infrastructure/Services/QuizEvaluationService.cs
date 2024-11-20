using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Domain.Entities.Catalog;
using System.Text.Json;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;

namespace FlexBook.Infrastructure.Services;
public class QuizEvaluationService : IQuizEvaluationService
{
    public Task<bool> EvaluateMultipleChoice(GetQuestionForInstructorDto question, List<string> userAnswers)
    {
        if (question.CorrectAnswers == null || !userAnswers.Any())
            return Task.FromResult(false);

        bool isCorrect = question.CorrectAnswers.All(userAnswers.Contains) && userAnswers.All(question.CorrectAnswers.Contains);
        return Task.FromResult(isCorrect);
    }

    public Task<bool> EvaluateMatching(GetQuestionForInstructorDto question, Dictionary<string, string> userAnswers)
    {
        if (question.MatchingPairs == null || !userAnswers.Any())
            return Task.FromResult(false);

        bool isCorrect = question.MatchingPairs.All(pair =>
            userAnswers.ContainsKey(pair.Key) && userAnswers[pair.Key] == pair.Value);

        return Task.FromResult(isCorrect);
    }

    public Task<bool> EvaluateTrueFalse(GetQuestionForInstructorDto question, string userAnswer)
    {
        if (string.IsNullOrEmpty(question.Answer) || string.IsNullOrEmpty(userAnswer))
            return Task.FromResult(false);

        bool isCorrect = string.Equals(question.Answer, userAnswer, StringComparison.OrdinalIgnoreCase);
        return Task.FromResult(isCorrect);
    }

    public Task<bool> EvaluateEssay(GetQuestionForInstructorDto question, string userAnswer)
    {
        if (string.IsNullOrEmpty(userAnswer))
            return Task.FromResult(false);

        var keywords = JsonSerializer.Deserialize<List<string>>(question.CorrectAnswersJson ?? "[]");
        bool isCorrect = keywords != null && keywords.All(kw => userAnswer.Contains(kw, StringComparison.OrdinalIgnoreCase));

        return Task.FromResult(isCorrect);
    }
}