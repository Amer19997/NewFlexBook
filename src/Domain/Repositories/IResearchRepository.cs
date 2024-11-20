using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.StaticPages;

namespace FlexBook.Domain.Repositories;
public interface IResearchRepository : IRepository<ResearchEntry>
{
    // Add any custom methods specific to AuthorizingTeamMember if required in the future
}
