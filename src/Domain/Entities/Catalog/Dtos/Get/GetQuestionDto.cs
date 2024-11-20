using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.Get;
public class GetQuestionDto
{
    public Guid Id { get; set; }
    public Guid QuizId { get; set; }


    public string QuestionText { get; set; } = default!;
    public QuestionType QuestionType { get; set; }
    public List<string>? Options { get; set; }
    public List<string>? CorrectAnswers { get; set; }
    public Dictionary<string, string>? MatchingPairs { get; set; }
    public string? Answer { get; set; }
}

