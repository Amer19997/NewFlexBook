using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Repositories;

namespace FlexBook.Infrastructure.Persistence.Repositories;

public class SpecializationRepository : Repository<Specialization>, ISpecializationRepository
{
    public SpecializationRepository(FlexBookDbContext dbContext) : base(dbContext)
    {
    }
}