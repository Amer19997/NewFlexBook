using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;

namespace FlexBook.Domain.Repositories;
public interface IClassRepository:IRepository<Class>
{
    Task<Class?> GetByIdAsync(Guid classId, CancellationToken cancellationToken);
    Task<IEnumerable<Class>> GetClassesByInstructorAsync(Guid instructorId, CancellationToken cancellationToken);
    Task<IEnumerable<Class>> GetClassesByStudentAsync(Guid studentId, CancellationToken cancellationToken);
    Task AddAsync(Class classEntity, CancellationToken cancellationToken);
    Task<List<Class>> GetClassesByCourseAndAffiliationAsync(
          Guid courseId,
          Guid? universityId,
          Guid? facultyId,
          Guid? departmentId,
          Guid? specializationId,
          CancellationToken cancellationToken);
    void Remove(Class classEntity);
    Task<Class?> GetClassByNameAsync(string className, CancellationToken cancellationToken);
    Task<bool> AnyAsync(Guid instructorId, Guid classId, CancellationToken cancellationToken = default);


}
