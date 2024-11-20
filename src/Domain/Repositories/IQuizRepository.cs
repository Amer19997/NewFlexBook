using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;

namespace FlexBook.Domain.Repositories;
public interface IQuizRepository : IRepository<Quiz>
{
    Task<List<Quiz>> GetQuizzesBySectionIdAsync(Guid sectionId, CancellationToken cancellationToken);
    Task<Quiz> GetQuizWithQuestionsAsync(Guid quizId);
}
