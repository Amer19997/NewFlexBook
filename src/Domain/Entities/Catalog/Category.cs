using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Entities.UsersAggregate;

namespace FlexBook.Domain.Entities.Catalog;
public class Category : BaseEntity<Guid>
{
    public string NameAr { get; set; }
    public string NameEn { get; set; }
    public Guid TopicId { get; set; }
    public Topic Topic { get; set; }
    public ICollection<Course> Courses { get; set; } = new List<Course>();
    public string CoverPhoto { get; set; } // Added CoverPhoto property
    public List<UserInterstes> UserInterstesList { get; set; }

}
