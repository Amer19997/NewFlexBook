using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.StaticPages.Dtos;
public class EvaluatingAdoptingArticleDto
{
    public Guid Id { get; set; }
    public string TitleAr { get; set; } = default!;
    public string TitleEn { get; set; } = default!;
    public string ContentAr { get; set; } = default!;
    public string ContentEn { get; set; } = default!;
    public string AuthorName { get; set; } = default!;
    public string AuthorPhotoUrl { get; set; } = default!;
    public DateTime UpdatedAt { get; set; }
}
