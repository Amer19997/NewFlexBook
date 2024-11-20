using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Enums;
using MediatR;

namespace FlexBook.Application.Features.Admin.Questions;
// AddQuestionCommand
public class AddQuestionCommand : IRequest<TResponse<QuestionDto>>
{
    public string QuestionText { get; set; } = default!;
    public QuestionType QuestionType { get; set; }
    public Guid QuizId { get; set; }
    public List<string>? Options { get; set; }
    public List<string>? CorrectAnswers { get; set; }
    public Dictionary<string, string>? MatchingPairs { get; set; }
    public string? Answer { get; set; }
}
public class QuestionDto
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
