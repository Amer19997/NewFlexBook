using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;

namespace FlexBook.Domain.Repositories;
public interface IQuestionRepository : IRepository<Question>
{
    Task<List<Question>> GetQuestionsByQuizIdAsync(Guid quizId, CancellationToken cancellationToken);
}