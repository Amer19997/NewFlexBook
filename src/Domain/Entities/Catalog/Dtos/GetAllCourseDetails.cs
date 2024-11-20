using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos;
public class GetAllCourseDetails
{
    public Guid Id { get; set; }
    public string NameAr { get; set; } = default!;
    public string NameEn { get; set; } = default!;
    public string DiscriptionAr { get; set; } = default!;
    public string DiscriptionEn { get; set; } = default!;
    public Guid CategoryId { get; set; }
    public Guid TopicId { get; set; }
    public string CoverPhoto { get; set; } = default!;
    public string Code { get; set; } = default!;

    public List<Guid> UniversityIds { get; set; } = new List<Guid>();
    public List<Guid> FacultyIds { get; set; } = new List<Guid>();
    public List<Guid> DepartmentIds { get; set; } = new List<Guid>();
    public List<Guid> SpecializationIds { get; set; } = new List<Guid>();
}
