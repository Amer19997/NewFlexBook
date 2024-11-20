using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;

namespace FlexBook.Domain.Repositories;
public interface ISectionRepository : IRepository<Section>
{
    Task<List<Section>> GetSectionsByCourseIdAsync(Guid courseId, CancellationToken cancellationToken);
}
