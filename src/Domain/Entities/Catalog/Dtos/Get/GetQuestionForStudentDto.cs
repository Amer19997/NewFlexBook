using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.Get;
internal class GetQuestionForStudentDto
{
    public Guid Id { get; set; }
    public string QuestionText { get; set; }
    public QuestionType QuestionType { get; set; }
    public ICollection<string>? Options { get; set; } = new List<string>();


    // For Multiple Choice (multiple correct answers)

    //public ICollection<string>? CorrectAnswers { get; set; } = new List<string>();

    //public Dictionary<string, string>? MatchingPairs { get; set; }
    //public string? Answer { get; set; }
    public Guid QuizId { get; set; }
}
