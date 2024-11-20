using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.StaticPages.Dtos;
public class AcademicIntegrityDto
{
    public Guid Id { get; set; }
    public string TitleAr { get; set; }
    public string TitleEn { get; set; }
    public string DescriptionAr { get; set; }
    public string DescriptionEn { get; set; }
    public string HeaderTitleAr { get; set; }
    public string HeaderTitleEn { get; set; }
    public string HeaderDescriptionAr { get; set; }
    public string HeaderDescriptionEn { get; set; }
    public string ImageUrl { get; set; }
}