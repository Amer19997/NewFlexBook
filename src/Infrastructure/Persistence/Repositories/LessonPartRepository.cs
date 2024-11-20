using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Repositories;

namespace FlexBook.Infrastructure.Persistence.Repositories
{
    public class LessonPartRepository : Repository<LessonPart>, ILessonPartRepository
    {
        public LessonPartRepository(FlexBookDbContext dbContext) : base(dbContext)
        {
        }

        // Method to get all LessonParts by LessonId
        public async Task<List<LessonPart>> GetAllByLessonId(Guid lessonId, CancellationToken cancellationToken)
        {
            // Use the Filter method from the generic repository to fetch lesson parts by LessonId
            var lessonParts = await Filter(lp => lp.LessonId == lessonId, cancellationToken);
            return lessonParts.OrderBy(lp => lp.PartNumber).ToList();
        }
    }
}
