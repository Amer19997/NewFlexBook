using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Repositories
{
    public class HomePageSectionRepository : Repository<HomePageSection>, IHomePageSectionRepository
    {
        private readonly FlexBookDbContext _dbContext;

        public HomePageSectionRepository(FlexBookDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<HomePageSection?> GetHomePageSectionAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.HomePageSections
                .Include(section => section.HighlightedCourses)
                .FirstOrDefaultAsync(cancellationToken);
        }
    }
}
