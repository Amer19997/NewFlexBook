using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Domain.Entities.StaticPages.Dtos;
public class ResearchEntryDto
{
    public Guid Id { get; set; }
    public string TitleAr { get; set; }
    public string TitleEn { get; set; }
    public string DescriptionAr { get; set; }
    public string DescriptionEn { get; set; }
    public string ChartImageUrl { get; set; } // URL for the chart image
}
//public class CreateResearchEntryCommand
//{
//    public string TitleAr { get; set; }
//    public string TitleEn { get; set; }
//    public string DescriptionAr { get; set; }
//    public string DescriptionEn { get; set; }
//    public IFormFile ChartImage { get; set; } // Uploaded chart image file
//}

//public class UpdateResearchEntryCommand
//{
//    public Guid Id { get; set; }
//    public string TitleAr { get; set; }
//    public string TitleEn { get; set; }
//    public string DescriptionAr { get; set; }
//    public string DescriptionEn { get; set; }
//    public IFormFile? ChartImage { get; set; } // Optional updated chart image
//}
