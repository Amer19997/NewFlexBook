using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.Get;
public class GetAvailableClassDto
{
    public Guid ClassId { get; set; }
    public string ClassName { get; set; }
    public string Syllabus { get; set; }
    public string InstructorName { get; set; }
/*    public bool IsEnrolled { get; set; } */ // Indicates if the student is already enrolled in this class

}
