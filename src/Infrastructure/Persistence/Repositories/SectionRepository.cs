using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Repositories;
public class SectionRepository : Repository<Section>, ISectionRepository
{
    public SectionRepository(FlexBookDbContext dbContext) : base(dbContext) { }

    public async Task<List<Section>> GetSectionsByCourseIdAsync(Guid courseId, CancellationToken cancellationToken)
    {
        return await dbContext.Sections
            .Where(s => s.CourseId == courseId)
            .ToListAsync(cancellationToken);
    }
}
