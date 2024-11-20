using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Repositories;

public class InstructorCourseOverrideRepository : Repository<Class>, IInstructorCourseOverrideRepository
{
    public InstructorCourseOverrideRepository(FlexBookDbContext dbContext) : base(dbContext) { }

    // Add a new instructor override
    public async Task AddAsync(InstructorCourseOverride overrideEntity, CancellationToken cancellationToken)
    {
        await dbContext.InstructorCourseOverrides.AddAsync(overrideEntity, cancellationToken);
    }

    // Update an existing instructor override
    public void Update(InstructorCourseOverride overrideEntity)
    {
        dbContext.InstructorCourseOverrides.Update(overrideEntity);
    }

    // Get an instructor override by its ID
    public async Task<InstructorCourseOverride?> GetByIdAsync(Guid overrideId, CancellationToken cancellationToken)
    {
        return await dbContext.InstructorCourseOverrides
            .FirstOrDefaultAsync(o => o.Id == overrideId, cancellationToken);
    }

    // Get the first instructor override that matches the given predicate
    public async Task<InstructorCourseOverride?> FirstOrDefaultAsync(
        Expression<Func<InstructorCourseOverride, bool>> predicate,
        CancellationToken cancellationToken)
    {
        return await dbContext.InstructorCourseOverrides
            .AsNoTracking()
            .FirstOrDefaultAsync(predicate, cancellationToken);
    }

    // Get all overrides for a specific instructor and course
    public async Task<List<InstructorCourseOverride>> GetOverridesForInstructorAndCourse(Guid instructorId, Guid courseId, CancellationToken cancellationToken)
    {
        return await dbContext.InstructorCourseOverrides
            .Where(o => o.InstructorId == instructorId && o.CourseId == courseId)
            .ToListAsync(cancellationToken);
    }





}