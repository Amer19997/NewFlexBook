using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.Catalog;
public class InteractiveElement:BaseEntity<Guid>
{
    public int ElementNumber { get; set; } // Unique number for this element within a lesson part
    public string ZipUrl { get; set; }  // URL of the uploaded .zip file
    public Guid LessonPartId { get; set; }
    public LessonPart LessonPart { get; set; } = default!;

}
