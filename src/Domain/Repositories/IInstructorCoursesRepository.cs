using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Repositories;
public interface IInstructorCoursesRepository : IRepository<InstructorAvailableCourse>
{
    /// <summary>
    /// Checks if an instructor-course association already exists.
    /// </summary>
    Task<bool> AnyAsync(Guid instructorId, Guid courseId);

    /// <summary>
    /// Adds a new instructor-course association.
    /// </summary>
    Task AddAsync(InstructorAvailableCourse instructorCourse);
    Task<List<Course>> GetCoursesByInstructorIdAsync(Guid instructorId);

}