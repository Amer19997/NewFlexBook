using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Repositories;
public class StudentAvailableCoursesRepository : Repository<StudentAvailableCourse>, IStudentAvailableCoursesRepository
{
    public StudentAvailableCoursesRepository(FlexBookDbContext dbContext) : base(dbContext) { }

    public async Task<bool> AnyAsync(Guid studentId, Guid courseId)
    {
        return await dbContext.StudentAvailableCourses
            .AnyAsync(ic => ic.StudentId == studentId && ic.CourseId == courseId);
    }

    public async Task AddAsync(StudentAvailableCourse studentAvailableCourse)
    {
        await dbContext.StudentAvailableCourses.AddAsync(studentAvailableCourse);
    }
    public async Task<List<Course>> GetCoursesByStudentIdAsync(Guid studentId)
    {
        return await dbContext.StudentAvailableCourses
            .Where(ic => ic.StudentId == studentId)
            .Include(ic => ic.Course)  // Include course details
            .Select(ic => ic.Course)
            .ToListAsync();
    }
}
