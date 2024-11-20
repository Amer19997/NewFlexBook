using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities;
public class ClassDto
{
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public Guid InstructorId { get; set; }
    public string ClassName { get; set; } = default!;
    public string Syllabus { get; set; } = default!;
}
