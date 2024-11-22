using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.StaticPages.Dtos;
public class InstructorSuccessStoryDto
{
    public Guid Id { get; set; }
    public string TitleAr { get; set; } = default!;
    public string TitleEn { get; set; } = default!;
    public string DescriptionAr { get; set; } = default!;
    public string DescriptionEn { get; set; } = default!;
    public string? ImageUrl { get; set; } = default!;
}