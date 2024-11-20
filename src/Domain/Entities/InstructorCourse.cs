using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Entities.UsersAggregate;

namespace FlexBook.Domain.Entities;
public class InstructorAvailableCourse
{
    public Guid InstructorId { get; set; }
    public User Instructor { get; set; }

    public Guid CourseId { get; set; }
    public Course Course { get; set; }

}