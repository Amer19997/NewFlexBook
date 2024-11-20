using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.Get.Instructor;
public class GetLessonByIdAfterInstructorLoginDto
{

    public Guid Id { get; set; }
    public string NameAr { get; set; }
    public string NameEn { get; set; }
    public bool IsHidden { get; set; } = false;

    public string TitleAr { get; set; } = default!;
    public string TitleEn { get; set; } = default!;
    public string DescriptionAr { get; set; } = default!;
    public string DescriptionEn { get; set; } = default!;

    // Cover Photo Upload
    public string CoverPhoto { get; set; } // Added CoverPhoto property

    public string? ResourceUrl { get; set; }
    public bool HasCodeEditor { get; set; }
    public DateTime CreationDate { get; set; }
    //public LessonContentType ContentType { get; set; }
    public string CodeEditorLanguage { get; set; }
    public string CodeEditorInitialCode { get; set; }
    // Media: audio, video, presentation, article
    public string? FileUrl { get; set; } = default!;
    public Guid SectionId { get; set; }
    // Video properties
    public string? InteractiveContentUrl { get; set; }
    public bool HasInteractiveContent { get; set; }
    public bool? HideVideo { get; set; }    // Hide the video content of the lesson
    public bool? HideFile { get; set; }     // Hide the file content of the lesson
    public bool? HideCodeEditor { get; set; }     // Hide the file content of the lesson
    public bool? HideContentImage { get; set; }     // Hide the file content of the lesson
    public bool? HideGif { get; set; }     // Hide the file content of the lesson
    public bool? HideInteractivePart { get; set; }  // Hide the interactive part of the lesson

    public string? VideoUrl { get; set; } // URL of the video file
    public string? ImageUrl { get; set; }
    public string? GifUrl { get; set; }
    //public TimeSpan VideoDuration { get; set; } // Duration of the video
}
