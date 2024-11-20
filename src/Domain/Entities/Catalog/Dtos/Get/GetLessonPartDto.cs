using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.Get;
public class GetLessonPartDto
{
    public Guid Id { get; set; }
    public Guid LessonId { get; set; }
    public int PartNumber { get; set; }
    public string Content { get; set; } = string.Empty;
    public List<GetInteractiveElementDto> InteractiveElements { get; set; } = new();
}