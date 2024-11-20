using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Entities.UsersAggregate;

namespace FlexBook.Domain.Entities;
public class Class : BaseEntity<Guid>
{
    public Guid CourseId { get; set; }
    public Course? Course { get; set; } = default!;

    public Guid InstructorId { get; set; }
    public User? Instructor { get; set; } = default!;  // This refers to the instructor from the User table

    public string ClassName { get; set; } = default!;
    public string Syllabus { get; set; } = default!;

    public ICollection<User>?Students { get; set; } = new List<User>();  // Students enrolled in this class
}
