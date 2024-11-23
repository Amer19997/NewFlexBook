using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Repositories;
public class AboutUsSectionRepository : Repository<AboutUsSection>, IAboutUsSectionRepository
{
    private readonly FlexBookDbContext _dbContext;

    public AboutUsSectionRepository(FlexBookDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    // Fetch a section along with its related testimonials
    public async Task<AboutUsSection?> GetSectionWithTestimonialsAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _dbContext.AboutUsSections
            .Include(section => section.Testimonials)
            .FirstOrDefaultAsync(section => section.Id == id, cancellationToken);
    }
}