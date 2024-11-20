using System;
using System.Collections.Generic;
using System.Linq;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;

namespace FlexBook.Application.Common.Extensions
{
    public static class DtoExtensions
    {
        // Convert Lesson to GetLessonAfterLoginDto
        public static GetLessonAfterLoginDto ToDto(this Lesson lesson)
        {
            return new GetLessonAfterLoginDto
            {
                Id = lesson.Id,
                TitleEn = lesson.TitleEn,
                TitleAr = lesson.TitleAr,
                DescriptionEn = lesson.DescriptionEn,
                DescriptionAr = lesson.DescriptionAr,
                CoverPhoto = lesson.CoverPhoto,
                //Quizzes = lesson.Quizzes.Select(q => q.ToDto()).Cast<GetQuizDto>().ToList()
            };
        }

        // Convert Quiz to QuizDto (adjusting for nullable QuizType)
        public static QuizDto ToDto(this Quiz quiz)
        {
            return new QuizDto
            {
                Name = quiz.Name,
                QuizType = quiz.QuizType ?? default, // Handle nullable QuizType
                Questions = quiz.Questions.Select(q => q.ToDto()).ToList()
            };
        }

        // Convert Question to QuestionDto
        public static QuestionDto ToDto(this Question question)
        {
            return new QuestionDto
            {
                Id = question.Id,
                QuestionText = question.QuestionText,
                QuestionType = question.QuestionType,
                Options = question.Options, // Deserialized from OptionsJson
                CorrectAnswers = question.CorrectAnswers, // Deserialized from CorrectAnswersJson
                MatchingPairs = question.MatchingPairs, // Deserialized from MatchingPairsJson
                Answer = question.Answer
            };
        }
    }
}
