using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace FlexBook.Domain.Entities.Catalog.Dtos;
public class LessonDto
{
    public Guid Id { get; set; }
    public string NameAr { get; set; }
    public string NameEn { get; set; }
    //public string Description { get; set; }
    //public string? ResourceUrl { get; set; }
    //public bool HasCodeEditor { get; set; }
    //public DateTime CreationDate { get; set; }
    //public LessonContentType ContentType { get; set; }
    //public string CodeEditorLanguage { get; set; }
    //public string CodeEditorInitialCode { get; set; }
    //// Media: audio, video, presentation, article
    //public string? FileUrl { get; set; } = default!;
    //public Guid SectionId { get; set; }
    //// Video properties
    //public string? VideoUrl { get; set; } // URL of the video file
    //public TimeSpan VideoDuration { get; set; } // Duration of the video

}