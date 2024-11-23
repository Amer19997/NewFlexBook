using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.StaticPages;
public class AboutUsSection : BaseEntity<Guid>
{
    public string TitleAr { get; set; } = default!;       // Arabic title
    public string TitleEn { get; set; } = default!;       // English title
    public string ContentAr { get; set; } = default!;     // Arabic content
    public string ContentEn { get; set; } = default!;     // English content
    public string ImageUrl { get; set; } = default!;      // Main image for the section
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Last update timestamp

    // Collection of testimonials related to this section
    public ICollection<Testimonial> Testimonials { get; set; } = new List<Testimonial>();
}