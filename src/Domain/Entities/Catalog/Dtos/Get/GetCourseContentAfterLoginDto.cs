using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.Get;
public class GetCourseContentAfterLoginDto
{
    public Guid CourseId { get; set; }
    public string NameAr { get; set; }
    public string NameEn { get; set; }
    public string DiscriptionAr { get; set; }
    public string DiscriptionEn { get; set; }
    public string CoverPhoto { get; set; } = default!;
    public List<GetSectionAfterInstructorLoginDTo> Sections { get; set; } = new List<GetSectionAfterInstructorLoginDTo>();

}
