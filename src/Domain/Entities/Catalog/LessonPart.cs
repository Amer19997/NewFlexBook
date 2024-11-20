using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.Catalog;

public class LessonPart : BaseEntity<Guid>
{
    public Guid LessonId { get; set; }
    public Lesson Lesson { get; set; } = default!;
    public int PartNumber { get; set; }  // Unique number for this part within a lesson
    public string Content { get; set; } = default!; // Main textual content

    public List<InteractiveElement>? InteractiveElements { get; set; } = new();

}