using System;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities
{
    public class InstructorCourseOverride : BaseEntity<Guid>
    {
        public Guid InstructorId { get; set; } = Guid.Empty; // Default to an empty GUID
        public Guid CourseId { get; set; } = Guid.Empty; // Default to an empty GUID
        public Guid? SectionId { get; set; } = Guid.Empty; // Nullable, no default needed
        public Guid? LessonId { get; set; } = Guid.Empty; // Nullable, no default needed
        public Guid? LessonPartId { get; set; } = Guid.Empty; // Nullable, no default needed
        public Guid? QuizId { get; set; } = Guid.Empty; // Nullable, no default needed
        public Guid? InteractiveElementId { get; set; } = Guid.Empty; // Nullable, no default needed

        // Customization fields for lessons and lesson parts
        public string? CustomLessonDescriptionAr { get; set; } = string.Empty; // Default to an empty string
        public string? CustomLessonDescriptionEn { get; set; } = string.Empty; // Default to an empty string
        public string? CustomTitleAr { get; set; } = string.Empty; // Default to an empty string
        public string? CustomTitleEn { get; set; } = string.Empty; // Default to an empty string

        // Customizable content for LessonPart
        public string? CustomLessonPartContent { get; set; } = string.Empty; // Default to an empty string

        // Hide flags for different elements
        public bool? HideSection { get; set; } = false; // Default to false
        public bool? HideLesson { get; set; } = false; // Default to false
        public bool? HideLessonPart { get; set; } = false; // Default to false
        public bool? HideFile { get; set; } = false; // Default to false
        public bool? HideCodeEditor { get; set; } = false; // Default to false
        public bool? HideInteractiveElement { get; set; } = false; // Default to false
        public bool? HideQuiz { get; set; } = false; // Default to false

        public DateTime LastUpdated { get; set; } = DateTime.UtcNow; // Default to current UTC time
    }
}
