using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.StaticPages.Dtos;
public class TestimonialDto
{
    public Guid Id { get; set; }
    public string UserName { get; set; } = default!;
    public string UserImageUrl { get; set; } = default!;
    public string FeedbackAr { get; set; } = default!;
    public string FeedbackEn { get; set; } = default!;
}