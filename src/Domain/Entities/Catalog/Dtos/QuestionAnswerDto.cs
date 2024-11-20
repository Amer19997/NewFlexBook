using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos;
// Question Answer DTO
public class QuestionAnswerDto
{
    public Guid QuestionId { get; set; }
    public string Answer { get; set; } = string.Empty; // Used for True/False, Essay, etc.
    public List<string> Answers { get; set; } = new List<string>(); // Used for Multiple Choice
    public Dictionary<string, string> MatchingAnswers { get; set; } = new Dictionary<string, string>(); // Used for Matching
}