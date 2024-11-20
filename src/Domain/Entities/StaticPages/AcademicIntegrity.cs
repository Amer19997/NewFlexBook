using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.StaticPages;
public class AcademicIntegrity : BaseEntity<Guid>
{
     public string TitleAr { get; set; } // Arabic Title
    public string TitleEn { get; set; } // English Title
    public string DescriptionAr { get; set; } // Arabic Description
    public string DescriptionEn { get; set; } // English Description
    public string HeaderTitleAr { get; set; } // Arabic Header Title
    public string HeaderTitleEn { get; set; } // English Header Title
    public string HeaderDescriptionAr { get; set; } // Arabic Header Description
    public string HeaderDescriptionEn { get; set; } // English Header Description
    public string ImageUrl { get; set; } // Optional image for the header
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? LastUpdated { get; set; }
}