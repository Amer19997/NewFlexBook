using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Enums;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Repositories;
public class ClassRequestRepository : Repository<ClassRequest>, IClassRequestRepository
{
    public ClassRequestRepository(FlexBookDbContext dbContext) : base(dbContext) { }

    public async Task<ClassRequest?> GetPendingRequestAsync(Guid studentId, Guid classId, CancellationToken cancellationToken)
    {
        return await dbContext.ClassRequests
            .FirstOrDefaultAsync(cr => cr.StudentId == studentId && cr.ClassId == classId && cr.Status == RequestStatus.Pending, cancellationToken);
    }
    public async Task<IEnumerable<ClassRequest>> GetAllClassRequestsForInstructorAsync(Guid instructorId, CancellationToken cancellationToken)
    {
        return await dbContext.ClassRequests
            .Include(cr => cr.Class)
            .Include(cr => cr.Student)
            .Where(cr => cr.Class.InstructorId == instructorId)
            .ToListAsync(cancellationToken);
    }
}