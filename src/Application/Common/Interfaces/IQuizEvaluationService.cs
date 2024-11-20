using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;

namespace FlexBook.Application.Common.Interfaces;
// Interface for quiz evaluation service
public interface IQuizEvaluationService
{
    Task<bool> EvaluateMultipleChoice(GetQuestionForInstructorDto question, List<string> userAnswers);
    Task<bool> EvaluateMatching(GetQuestionForInstructorDto question, Dictionary<string, string> userAnswers);
    Task<bool> EvaluateTrueFalse(GetQuestionForInstructorDto question, string userAnswer);
    Task<bool> EvaluateEssay(GetQuestionForInstructorDto question, string userAnswer);
}
