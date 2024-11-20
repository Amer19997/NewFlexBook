using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;

namespace FlexBook.Domain.Repositories;
public interface IInstructorCourseOverrideRepository
{
    Task AddAsync(InstructorCourseOverride overrideEntity, CancellationToken cancellationToken);
    void Update(InstructorCourseOverride overrideEntity);
    Task<InstructorCourseOverride?> GetByIdAsync(Guid overrideId, CancellationToken cancellationToken);
    Task<InstructorCourseOverride?> FirstOrDefaultAsync(Expression<Func<InstructorCourseOverride, bool>> predicate, CancellationToken cancellationToken);
    Task<List<InstructorCourseOverride>> GetOverridesForInstructorAndCourse(Guid instructorId, Guid courseId, CancellationToken cancellationToken);
}
