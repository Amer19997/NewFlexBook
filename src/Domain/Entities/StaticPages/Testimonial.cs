using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.StaticPages;
public class Testimonial : BaseEntity<Guid>
{
    public string UserName { get; set; } = default!;      // Name of the user providing the testimonial
    public string UserImageUrl { get; set; } = default!; // URL of the user's image
    public string FeedbackAr { get; set; } = default!;   // Arabic feedback text
    public string FeedbackEn { get; set; } = default!;   // English feedback text
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Last update timestamp

    // Foreign key reference to the parent AboutUsSection
    public Guid AboutUsSectionId { get; set; }
    public AboutUsSection AboutUsSection { get; set; } = default!;
}