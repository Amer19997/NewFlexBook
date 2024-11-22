using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain.Repositories;

namespace FlexBook.Infrastructure.Persistence.Repositories;
public class StudentsGettingStartedArticleRepository : Repository<StudentsGettingStartedArticle>, IStudentsGettingStartedArticleRepository
{
    public StudentsGettingStartedArticleRepository(FlexBookDbContext dbContext) : base(dbContext)
    {
    }
}