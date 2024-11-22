using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.StaticPages;
public class EvaluatingAdoptingArticle : BaseEntity<Guid>
{
    public string TitleAr { get; set; } = default!;       // Arabic title
    public string TitleEn { get; set; } = default!;       // English title
    public string ContentAr { get; set; } = default!;     // Arabic content
    public string ContentEn { get; set; } = default!;     // English content
    public string AuthorName { get; set; } = default!;    // Author's name
    public string AuthorPhotoUrl { get; set; } = default!; // Author's photo URL
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Last updated timestamp
}
