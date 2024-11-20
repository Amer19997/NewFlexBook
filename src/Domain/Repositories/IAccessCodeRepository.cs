using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;

namespace FlexBook.Domain.Repositories;
public interface IAccessCodeRepository : IRepository<AccessCode>
{
    Task<AccessCode?> GetValidAccessCodeAsync(Guid studentId, string code, CancellationToken cancellationToken);
}
