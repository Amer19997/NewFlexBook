using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Repositories;
public class LessonRepository : Repository<Lesson>, ILessonRepository
{
    public LessonRepository(FlexBookDbContext dbContext) : base(dbContext) { }

    public async Task<List<Lesson>> GetLessonsBySectionIdAsync(Guid sectionId, CancellationToken cancellationToken)
    {
        return await dbContext.Lessons
            .Where(l => l.SectionId == sectionId)
            .ToListAsync(cancellationToken);
    }
}
