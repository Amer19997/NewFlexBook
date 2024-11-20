using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos;
public class MediaDto
{
    public string? VideoUrl { get; set; }
    public string? AudioUrl { get; set; }
    public string? PresentationUrl { get; set; }
    public string? ArticleContent { get; set; }
}
