using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Repositories;


    public class ClassRepository : Repository<Class>, IClassRepository
    {
        public ClassRepository(FlexBookDbContext dbContext) : base(dbContext) { }

        // Fetch a class by its ID, including the related course and instructor
        // Fetch a class by its ID, including the related course and instructor
        public async Task<Class?> GetByIdAsync(Guid classId, CancellationToken cancellationToken)
    {
        return await dbContext.Classes
            .Include(c => c.Course)  // Include related Course entity
            .Include(c => c.Instructor)  // Include related Instructor (User entity)
            .Include(c => c.Students)  // Include students enrolled in the class
            .FirstOrDefaultAsync(c => c.Id == classId, cancellationToken);
    }
    public async Task<bool> AnyAsync(Guid instructorId, Guid classId, CancellationToken cancellationToken = default)
    {
        // Query to check if any class is associated with the instructor and matches the classId
        return await dbContext.Set<Class>()
            .AnyAsync(c => c.Id == classId && c.InstructorId == instructorId, cancellationToken);
    }

    // Get all classes for a specific instructor
    public async Task<IEnumerable<Class>> GetClassesByInstructorAsync(Guid instructorId, CancellationToken cancellationToken)
    {
        return await dbContext.Classes
            .Where(c => c.InstructorId == instructorId)
            .Include(c=>c.Instructor)
            .Include(c => c.Course)
            .ToListAsync(cancellationToken);
    }

    // Get all classes where a specific student is enrolled
    public async Task<IEnumerable<Class>> GetClassesByStudentAsync(Guid studentId, CancellationToken cancellationToken)
    {
        return await dbContext.Classes
            .Where(c => c.Students.Any(s => s.Id == studentId))  // Check if the student is enrolled in the class
            .Include(c => c.Course)
            .Include(c => c.Instructor)
            .ToListAsync(cancellationToken);
    }

    // Add a new class to the database
    // Add a new class to the database
    public async Task AddAsync(Class classEntity, CancellationToken cancellationToken)
    {
        if (classEntity == null)
            throw new ArgumentNullException(nameof(classEntity), "Class entity cannot be null");

        await dbContext.Classes.AddAsync(classEntity, cancellationToken);
    }
    public async Task<List<Class>> GetClassesByCourseAndAffiliationAsync(
           Guid courseId,
           Guid? universityId,
           Guid? facultyId,
           Guid? departmentId,
           Guid? specializationId,
           CancellationToken cancellationToken)
    {
        var query = dbContext.Classes
            .Include(c => c.Instructor)
            .Where(c => c.CourseId == courseId &&
                        c.Instructor.UniversityId == universityId &&
                        c.Instructor.FacultyId == facultyId &&
                        c.Instructor.DepartmentId == departmentId);

        if (specializationId.HasValue)
        {
            query = query.Where(c => c.Instructor.SpecializationId == specializationId);
        }

        return await query.ToListAsync(cancellationToken);
    }
    // Remove a class from the database
    public void Remove(Class classEntity)
    {
        dbContext.Classes.Remove(classEntity);
    }

    // Get a class by its name
    public async Task<Class?> GetClassByNameAsync(string className, CancellationToken cancellationToken)
    {
        return await dbContext.Classes
            .FirstOrDefaultAsync(c => c.ClassName.Equals(className, StringComparison.OrdinalIgnoreCase), cancellationToken);
    }
}
