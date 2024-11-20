using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.Catalog;
public class Quiz : BaseEntity<Guid>
{
    public string Name { get; set; }

    // Foreign key to Section (optional, as quiz may belong to a lesson instead)
    public Guid? SectionId { get; set; }
    public Section? Section { get; set; }

    // Foreign key to Lesson (optional, so quiz can belong to either a section or lesson)
    public Guid? LessonId { get; set; }
    public Lesson? Lesson { get; set; }
    public QuizType? QuizType { get; set; }

    // A quiz can have many questions
    public ICollection<Question>? Questions { get; set; }

}
