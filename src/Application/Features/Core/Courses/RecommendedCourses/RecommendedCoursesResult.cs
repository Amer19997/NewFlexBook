using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Application.Features.Core.Courses.RecommendedCourses;
public class RecommendedCoursesResult
{
    public List<object> CoursesList { get; set; }
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}