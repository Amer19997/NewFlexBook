using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain.Repositories;

namespace FlexBook.Infrastructure.Persistence.Repositories;

public class InstructorSuccessStoryRepository : Repository<InstructorSuccessStory>, IInstructorSuccessStoryRepository
{
    public InstructorSuccessStoryRepository(FlexBookDbContext dbContext) : base(dbContext)
    {
    }
}
