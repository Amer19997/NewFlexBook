using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.Get.Instructor;
public class GetInstructorClassDto
{
    public Guid ClassId { get; set; }
    public string? ClassNameAr { get; set; }
    public string? ClassNameEn { get; set; }

    public string Syllabus { get; set; }
    public string InstructorName { get; set; }

    // New properties
    public string CourseNameAr { get; set; }
    public string CourseNameEn { get; set; }

    public string FacultyNameAr { get; set; }
    public string FacultyNameEn { get; set; }

    public string DepartmentNameAr { get; set; }
    public string DepartmentNameEn { get; set; }

}