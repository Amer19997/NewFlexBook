using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.StaticPages.Dtos;
public class AboutUsPageDto
{
    public Guid Id { get; set; }
    public string TitleAr { get; set; } = default!;
    public string TitleEn { get; set; } = default!;
    public string ContentAr { get; set; } = default!;
    public string ContentEn { get; set; } = default!;
    public string ImageUrl { get; set; } = default!;
    public DateTime UpdatedAt { get; set; }

    // List of testimonials for the About Us section
    public ICollection<TestimonialDto> Testimonials { get; set; } = new List<TestimonialDto>();
}