using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.StaticPages;
public class InstructorCommunityEntry : BaseEntity<Guid>
{
    public string TitleAr { get; set; } = default!;       // Arabic title
    public string TitleEn { get; set; } = default!;       // English title
    public string ContentAr { get; set; } = default!;     // Arabic content
    public string ContentEn { get; set; } = default!;     // English content
    public string ImageUrl { get; set; } = default!;      // Associated image URL
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Last updated timestamp
}