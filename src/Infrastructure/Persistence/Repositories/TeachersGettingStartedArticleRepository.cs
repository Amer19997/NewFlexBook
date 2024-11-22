using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain.Repositories;

namespace FlexBook.Infrastructure.Persistence.Repositories;
public class TeachersGettingStartedArticleRepository : Repository<TeachersGettingStartedArticle>, ITeachersGettingStartedArticleRepository
{
    public TeachersGettingStartedArticleRepository(FlexBookDbContext dbContext) : base(dbContext)
    {
    }
}
