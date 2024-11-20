using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.Catalog
{
    public class Question : BaseEntity<Guid>
    {
        public string QuestionText { get; set; } = default!;
        public QuestionType QuestionType { get; set; }

        // Store Options as a JSON string in the database
        public string? OptionsJson { get; set; }

        // Store CorrectAnswers as a JSON string in the database
        public string? CorrectAnswersJson { get; set; }

        [NotMapped]
        public List<string>? Options
        {
            get => string.IsNullOrEmpty(OptionsJson)
                ? new List<string>()
                : JsonSerializer.Deserialize<List<string>>(OptionsJson) ?? new List<string>();
            set => OptionsJson = value == null ? "[]" : JsonSerializer.Serialize(value);
        }

        [NotMapped]
        public List<string>? CorrectAnswers
        {
            get => string.IsNullOrEmpty(CorrectAnswersJson)
                ? new List<string>()
                : JsonSerializer.Deserialize<List<string>>(CorrectAnswersJson) ?? new List<string>();
            set => CorrectAnswersJson = value == null ? "[]" : JsonSerializer.Serialize(value);
        }

        // Store MatchingPairs as a JSON string in the database
        public string? MatchingPairsJson { get; set; }

        [NotMapped]
        public Dictionary<string, string>? MatchingPairs
        {
            get => string.IsNullOrEmpty(MatchingPairsJson)
                ? new Dictionary<string, string>()
                : JsonSerializer.Deserialize<Dictionary<string, string>>(MatchingPairsJson) ?? new Dictionary<string, string>();
            set => MatchingPairsJson = value == null ? "{}" : JsonSerializer.Serialize(value);
        }

        public string? Answer { get; set; }

        public Guid QuizId { get; set; }
        public Quiz Quiz { get; set; } = default!;
    }
}
