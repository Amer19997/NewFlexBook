using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Repositories;
public class QuizRepository : Repository<Quiz>, IQuizRepository
{
    public QuizRepository(FlexBookDbContext dbContext) : base(dbContext) { }

    public async Task<List<Quiz>> GetQuizzesBySectionIdAsync(Guid sectionId, CancellationToken cancellationToken)
    {
        return await dbContext.Quizzes
            .Where(q => q.SectionId == sectionId)
            .ToListAsync(cancellationToken);
    }

    public async Task<Quiz> GetQuizWithQuestionsAsync(Guid quizId)
    {
        return await dbContext.Quizzes
            .Include(q => q.Questions)
            .FirstOrDefaultAsync(q => q.Id == quizId);
    }
}
