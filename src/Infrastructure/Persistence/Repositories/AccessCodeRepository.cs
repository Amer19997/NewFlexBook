using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Repositories;
public class AccessCodeRepository : Repository<AccessCode>, IAccessCodeRepository
{
    public AccessCodeRepository(FlexBookDbContext dbContext) : base(dbContext) { }

    public async Task<AccessCode?> GetValidAccessCodeAsync(Guid studentId, string code, CancellationToken cancellationToken)
    {
        return await dbContext.AccessCodes
            .FirstOrDefaultAsync(ac => ac.StudentId == studentId && ac.Code == code && !ac.IsUsed && ac.ExpiryDate > DateTime.UtcNow, cancellationToken);
    }
}
