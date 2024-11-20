using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.Get;
public class GetInteractiveElementDto
{
    public Guid Id { get; set; }
    public Guid LessonPartId { get; set; }
    public int ElementNumber { get; set; }
    public string ZipUrl { get; set; } = string.Empty;
}