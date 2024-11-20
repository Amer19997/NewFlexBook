using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Entities;

namespace FlexBook.Domain.Repositories;
public interface IStudentAvailableCoursesRepository : IRepository<StudentAvailableCourse>
{
    /// <summary>
    /// Checks if an instructor-course association already exists.
    /// </summary>
    Task<bool> AnyAsync(Guid studentId, Guid courseId);

    Task AddAsync(StudentAvailableCourse studentAvailableCourse);
    Task<List<Course>> GetCoursesByStudentIdAsync(Guid studentId);


}