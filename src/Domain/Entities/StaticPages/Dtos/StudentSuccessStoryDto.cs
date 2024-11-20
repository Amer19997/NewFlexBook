using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.StaticPages.Dtos;
public class StudentSuccessStoryDto
{
    public Guid Id { get; set; }
    public string NameAr { get; set; } = default!;
    public string NameEn { get; set; } = default!;
    public string UniversityNameAr { get; set; } = default!;
    public string UniversityNameEn { get; set; } = default!;
    public string DescriptionAr { get; set; } = default!;
    public string DescriptionEn { get; set; } = default!;
    public string VideoUrl { get; set; } = default!;
    public string ImageUrl { get; set; } = default!;
    public DateTime LastUpdated { get; set; }
}