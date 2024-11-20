namespace FlexBook.Domain.Entities.Catalog.Dtos.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GetLessonAfterLoginDto
{
    public Guid Id { get; set; }
    public string NameAr { get; set; }
    public string NameEn { get; set; }
    public string TitleAr { get; set; } = default!;
    public string TitleEn { get; set; } = default!;
    public string DescriptionAr { get; set; } = default!;
    public string DescriptionEn { get; set; } = default!;

    // Cover Photo Upload
    public string CoverPhoto { get; set; } // Added CoverPhoto property

    public List<string> Resources { get; set; } = default!;
    public DateTime CreationDate { get; set; }
    public LessonContentType ContentType { get; set; }
    public bool HasCodeEditor { get; set; }

    public string CodeEditorLanguage { get; set; }
    public string CodeEditorInitialCode { get; set; }

    // Media: audio, video, presentation, article
    public string? FileUrl { get; set; } = default!;
    public Guid SectionId { get; set; }

    // Interactive and video properties
    public string? InteractiveContentUrl { get; set; }
    public bool HasInteractiveContent { get; set; }
    public bool IsHidden { get; set; } = false;

    public string? VideoUrl { get; set; } // URL of the video file
    public string? ImageUrl { get; set; }
    public string? GifUrl { get; set; }
    public TimeSpan VideoDuration { get; set; } // Duration of the video

    // Nested Lesson Parts with Interactive Elements
    public List<GetLessonPartDto> LessonParts { get; set; } = new();

    // Nested Quizzes
    public List<GetQuizDto> Quizzes { get; set; } = new();
}

public class LessonPartDto
{
    public Guid Id { get; set; }
    public string Content { get; set; } = default!;
    public bool HideLessonPart { get; set; } = false;

    // Interactive elements within each LessonPart
    public List<InteractiveElementDto> InteractiveElements { get; set; } = new();
}

public class InteractiveElementDto
{
    public Guid Id { get; set; }
    public string ZipUrl { get; set; } = default!;
    public bool HideInteractiveElement { get; set; } = false;
}

public class QuizDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public bool HideQuiz { get; set; } = false;

    // Questions within each Quiz
    public List<QuestionDto> Questions { get; set; } = new();
}

public class QuestionDto
{
    public Guid Id { get; set; }
    public string QuestionText { get; set; } = default!;
    public QuestionType QuestionType { get; set; }

    // Optional fields for different question types
    public List<string>? Options { get; set; }
    public List<string>? CorrectAnswers { get; set; }
    public Dictionary<string, string>? MatchingPairs { get; set; }
    public string? Answer { get; set; }
}