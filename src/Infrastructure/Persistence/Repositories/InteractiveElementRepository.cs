using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Repositories;

namespace FlexBook.Infrastructure.Persistence.Repositories
{
    public class InteractiveElementRepository : Repository<InteractiveElement>, IInteractiveElementRepository
    {
        public InteractiveElementRepository(FlexBookDbContext dbContext) : base(dbContext)
        {
        }

        // Method to get all InteractiveElements by LessonPartId
        public async Task<List<InteractiveElement>> GetAllByLessonPartId(Guid lessonPartId, CancellationToken cancellationToken)
        {
            // Use the Filter method from the generic repository to fetch interactive elements by LessonPartId
            var interactiveElements = await Filter(ie => ie.LessonPartId == lessonPartId, cancellationToken);
            return interactiveElements.OrderBy(ie => ie.ElementNumber).ToList();
        }
    }
}
