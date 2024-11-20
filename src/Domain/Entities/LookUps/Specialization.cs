using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.LookUps;
public class Specialization : BaseEntity<Guid>
{
    public string NameAr { get; set; }
    public string NameEn { get; set; }
    public Guid DepartmentId { get; set; }
    public LookUpStatus LookUpStatus { get; set; }

    public Department Department { get; set; }
     public List<Course> Courses { get; set; } = new List<Course>();
}