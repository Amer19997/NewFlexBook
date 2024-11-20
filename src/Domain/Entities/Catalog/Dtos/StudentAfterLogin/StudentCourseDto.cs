using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.StudentAfterLogin;
public class StudentCourseDto
{
    public Guid CourseId { get; set; }
    public string CourseNameEn { get; set; }
    public string CourseNameAr { get; set; }
    public string CourseDescriptionEn { get; set; }
    public string CourseDescriptionAr { get; set; }
    public string CourseCode { get; set; }  // The unique code for accessing the course
    public string CoverPhoto { get; set; }  // Cover photo of the course

}
