using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Repositories;
public class QuestionRepository : Repository<Question>, IQuestionRepository
{
    public QuestionRepository(FlexBookDbContext dbContext) : base(dbContext) { }

    public async Task<List<Question>> GetQuestionsByQuizIdAsync(Guid quizId, CancellationToken cancellationToken)
    {
        return await dbContext.Questions
            .Where(q => q.QuizId == quizId)
            .ToListAsync(cancellationToken);
    }
}

