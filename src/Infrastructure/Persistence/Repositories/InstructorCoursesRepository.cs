using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Repositories;

    public class InstructorCoursesRepository : Repository<InstructorAvailableCourse>, IInstructorCoursesRepository
    {
        public InstructorCoursesRepository(FlexBookDbContext dbContext) : base(dbContext) { }

        public async Task<bool> AnyAsync(Guid instructorId, Guid courseId)
    {
        return await dbContext.InstructorCourses
            .AnyAsync(ic => ic.InstructorId == instructorId && ic.CourseId == courseId);
    }

    public async Task AddAsync(InstructorAvailableCourse instructorCourse)
    {
        await dbContext.InstructorCourses.AddAsync(instructorCourse);
    }
    public async Task<List<Course>> GetCoursesByInstructorIdAsync(Guid instructorId)
    {
        return await dbContext.InstructorCourses
            .Where(ic => ic.InstructorId == instructorId)
            .Include(ic => ic.Course)  // Include course details
            .Select(ic => ic.Course)
            .ToListAsync();
    }
}
