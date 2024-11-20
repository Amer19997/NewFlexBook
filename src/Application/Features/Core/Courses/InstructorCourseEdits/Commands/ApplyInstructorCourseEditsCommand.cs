using System;
using System.Collections.Generic;
using MediatR;
using FlexBook.Application.Common.Models;

namespace FlexBook.Application.Features.Core.Courses.InstructorCourseEdits.Commands
{
    public class ApplyInstructorCourseEditsCommand : IRequest<TResponse<bool>>
    {
        /// <summary>
        /// The ID of the course being edited.
        /// </summary>
        public Guid CourseId { get; set; }

        /// <summary>
        /// List of edits for sections within the course.
        /// </summary>
        public List<SectionEdit> SectionEdits { get; set; } = new();

        /// <summary>
        /// List of edits for lessons within the course.
        /// </summary>
        public List<LessonEdit> LessonEdits { get; set; } = new();

        /// <summary>
        /// List of edits for lesson parts within the course.
        /// </summary>
        public List<LessonPartEdit> LessonPartEdits { get; set; } = new();

        /// <summary>
        /// List of edits for quizzes within the course.
        /// </summary>
        public List<QuizEdit> QuizEdits { get; set; } = new();

        // Nested types representing specific edit structures

        /// <summary>
        /// Represents edits for a section.
        /// </summary>
        public class SectionEdit
        {
            public Guid SectionId { get; set; }
            public bool? HideSection { get; set; } // Optional flag to hide the section
        }

        /// <summary>
        /// Represents edits for a lesson.
        /// </summary>
        public class LessonEdit
        {
            public Guid LessonId { get; set; }
            public string? CustomTitleAr { get; set; } // Custom Arabic title
            public string? CustomTitleEn { get; set; } // Custom English title
            public string? CustomDescriptionAr { get; set; } // Custom Arabic description
            public string? CustomDescriptionEn { get; set; } // Custom English description
            public bool? HideLesson { get; set; } // Optional flag to hide the lesson
            public bool?HideCodeEditor { get; set; }    
        }

        /// <summary>
        /// Represents edits for a lesson part.
        /// </summary>
        public class LessonPartEdit
        {
            public Guid LessonPartId { get; set; }
            public string? CustomContent { get; set; } // Custom textual content
            public bool? HideLessonPart { get; set; } // Optional flag to hide the lesson part
            public List<InteractiveElementEdit> InteractiveElementEdits { get; set; } = new();
        }

        /// <summary>
        /// Represents edits for an interactive element.
        /// </summary>
        public class InteractiveElementEdit
        {
            public Guid InteractiveElementId { get; set; }
            public bool? HideInteractiveElement { get; set; } // Optional flag to hide the interactive element
        }

        /// <summary>
        /// Represents edits for a quiz.
        /// </summary>
        public class QuizEdit
        {
            public Guid QuizId { get; set; }
            public bool? HideQuiz { get; set; } // Optional flag to hide the quiz
        }
    }
}
