using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.Get;
public class GetQuizDto
{
    public Guid Id { get; set; }
    public Guid? SectionId { get; set; }

    // Foreign key to Lesson (optional, so quiz can belong to either a section or lesson)
    public Guid? LessonId { get; set; }
    public string Name { get; set; } = default!;
    public QuizType QuizType { get; set; }
    public List<GetQuestionDto> Questions { get; set; } = new();
}
