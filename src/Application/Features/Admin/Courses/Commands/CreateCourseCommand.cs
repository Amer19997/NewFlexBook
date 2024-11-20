using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog.Dtos;
using MediatR;

namespace FlexBook.Application.Features.Admin.Courses.Commands;
public class CreateCourseCommand : IRequest<GetAllCourseDetails>
{
    public string NameAr { get; set; } = default!;
    public string NameEn { get; set; } = default!;
    public string DiscriptionAr { get; set; } = default!;
    public string DiscriptionEn { get; set; } = default!;
    public Guid CategoryId { get; set; }
    public Guid TopicId { get; set; }
    public string CoverPhoto { get; set; } = default!;  // URL or path to the cover photo
    public string Code { get; set; } = default!;  // Unique code for the course

    // Relationships
    public List<Guid> UniversityIds { get; set; } = new List<Guid>();
    public List<Guid> FacultyIds { get; set; } = new List<Guid>();
    public List<Guid> DepartmentIds { get; set; } = new List<Guid>();
    public List<Guid> SpecializationIds { get; set; } = new List<Guid>();
}
