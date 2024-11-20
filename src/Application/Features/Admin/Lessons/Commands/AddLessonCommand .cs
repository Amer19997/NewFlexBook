using System;
using System.Collections.Generic;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Http;


    public class AddLessonCommand : IRequest<TResponse<GetLessonAfterLoginDto>>
    {
        public string NameAr { get; set; } = default!;
        public string NameEn { get; set; } = default!;
        public string TitleAr { get; set; } = default!;
        public string TitleEn { get; set; } = default!;
        public string DescriptionAr { get; set; } = default!;
        public string DescriptionEn { get; set; } = default!;
        public bool HasCodeEditor { get; set; }
        public string? CodeEditorLanguage { get; set; }
        public string? CodeEditorInitialCode { get; set; }
        public Guid SectionId { get; set; }

        // File uploads
        public IFormFile? CoverPhoto { get; set; }
        public List<IFormFile>? ResourceFiles { get; set; }

        // Lesson parts and their interactive elements
        //public List<LessonPartDto> LessonParts { get; set; } = new();
        //public List<QuizDto> Quizzes { get; set; } = new(); // New list for quizzes

    }

    public class LessonPartDto
    {
        public string Content { get; set; } = default!;
        public List<InteractiveElementDto> InteractiveElements { get; set; } = new();
    }

    public class InteractiveElementDto
    {
        public IFormFile ZipFile { get; set; } = default!;
    }
    public class QuizDto
    {

        public string Name { get; set; } = default!;
        public QuizType QuizType { get; set; }
        public List<QuestionDto> Questions { get; set; } = new();
    }
    public class QuestionDto:BaseEntity<Guid>
    {
    
        public string QuestionText { get; set; } = default!;
        public QuestionType QuestionType { get; set; }
        public List<string>? Options { get; set; }
        public List<string>? CorrectAnswers { get; set; }
        public Dictionary<string, string>? MatchingPairs { get; set; }
        public string? Answer { get; set; }
    }

