using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.StaticPages;
public class InstructorSuccessStory : BaseEntity<Guid>
{
    public string TitleAr { get; set; } = default!;
    public string TitleEn { get; set; } = default!;
    public string DescriptionAr { get; set; } = default!;
    public string DescriptionEn { get; set; } = default!;
    public string? ImageUrl { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}