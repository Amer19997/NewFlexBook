using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;

namespace FlexBook.Domain.Repositories
{
    public interface IInteractiveElementRepository : IRepository<InteractiveElement>
    {
        Task<List<InteractiveElement>> GetAllByLessonPartId(Guid lessonPartId, CancellationToken cancellationToken);
    }
}
