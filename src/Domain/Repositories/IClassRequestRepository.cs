using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;

namespace FlexBook.Domain.Repositories;
public interface IClassRequestRepository : IRepository<ClassRequest>
{
    Task<ClassRequest?> GetPendingRequestAsync(Guid studentId, Guid classId, CancellationToken cancellationToken);
    Task<IEnumerable<ClassRequest>> GetAllClassRequestsForInstructorAsync(Guid instructorId, CancellationToken cancellationToken);

}

