using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities.UsersAggregate;
using static System.Collections.Specialized.BitVector32;

namespace FlexBook.Domain.Entities.LookUps;
public class Course:BaseEntity<Guid>
{
    public string NameAr {  get; set; }
    public string NameEn {  get; set; }
    public string DiscriptionAr {  get; set; }
    public string DiscriptionEn {  get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = default!;
    public string CoverPhoto { get; set; } // Added CoverPhoto property
                                           // Unique code for the course
    public string Code { get; set; }  // Unique code for students to access the course

    public ICollection<FlexBook.Domain.Entities.Catalog.Section> Sections { get; set; } = new List<FlexBook.Domain.Entities.Catalog.Section>();
    // Add the following lines for the Topic relationship
    public Guid TopicId { get; set; }
    public Topic Topic { get; set; }
    // Relationships with other entities
    public ICollection<University> Universities { get; set; } = new List<University>();
    public ICollection<Faculty> Faculties { get; set; } = new List<Faculty>();
    public ICollection<Department> Departments { get; set; } = new List<Department>();
    public ICollection<Specialization> Specializations { get; set; } = new List<Specialization>();
    // List of instructors (Users) associated with this course
    public List<User> Instructors { get; set; } = new List<User>();
    public ICollection<InstructorAvailableCourse> InstructorAvailableCourse { get; private set; } = new List<InstructorAvailableCourse>();

    public List<UserInterstes> UserInterstesList { get; set; }
    // Relationship with Classes (one Course can have many Classes)
    public ICollection<Class> Classes { get; set; } = new List<Class>();

}
