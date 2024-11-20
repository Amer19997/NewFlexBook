using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;

namespace FlexBook.Domain.Repositories
{
    public interface ILessonPartRepository : IRepository<LessonPart>
    {
        Task<List<LessonPart>> GetAllByLessonId(Guid lessonId, CancellationToken cancellationToken);
    }
}
