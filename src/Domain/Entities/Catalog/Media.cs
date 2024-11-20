using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog;
// Media class for audio, video, presentation, or article
public class Media
{
    public string? VideoUrl { get; set; }
    public string? AudioUrl { get; set; }
    public string? PresentationUrl { get; set; }
    public string? ArticleContent { get; set; }

    public Guid LessonId { get; set; } // Foreign key for Lesson
    public Lesson Lesson { get; set; } = default!; // Navigation property to Lesson
}
