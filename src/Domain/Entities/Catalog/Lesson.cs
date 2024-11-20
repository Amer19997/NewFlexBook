using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.Catalog;
public class Lesson : BaseEntity<Guid>
{
    public string NameAr { get; set; } = default!;
    public string NameEn { get; set; } = default!;
    public string TitleAr { get; set; } = default!;
    public string TitleEn { get; set; }=default!;   
    public string DescriptionAr { get; set; } = default!;
    public string DescriptionEn { get; set; } = default!;
    public ICollection<Quiz>? Quizzes { get; set; }
    public List<LessonPart> LessonParts { get; set; } = new();

    public string CoverPhoto { get; set; } // Added CoverPhoto property

    public List<string> Resources { get; set; } = default!;
    public bool HasCodeEditor { get; set; }
    public DateTime CreationDate { get; set; }
    // New properties for video content

    // New properties for content types
    public string CodeEditorLanguage { get; set; }
    public string CodeEditorInitialCode { get; set; }
    // Media: audio, video, presentation, article

    public Guid SectionId { get; set; }
    public Section Section { get; set; } = default!;
 
}
