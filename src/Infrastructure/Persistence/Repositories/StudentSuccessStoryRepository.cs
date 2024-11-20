using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace FlexBook.Infrastructure.Persistence.Repositories;
 public class StudentSuccessStoryRepository : Repository<StudentSuccessStory>, IStudentSuccessStoryRepository
    {
        public StudentSuccessStoryRepository(FlexBookDbContext dbContext) : base(dbContext)
        {
        }
    public async Task<IPagedList<StudentSuccessStory>> GetPaginatedStoriesWithFilterAsync(
        string search,
        int pageNumber,
        int pageSize,
        string sortBy,
        string sortDirection,
        CancellationToken cancellationToken = default)
    {
        var query = dbContext.Set<StudentSuccessStory>().AsQueryable();

        // Apply search filter
        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(story =>
                story.NameAr.Contains(search) ||
                story.NameEn.Contains(search) ||
                story.UniversityNameAr.Contains(search) ||
                story.UniversityNameEn.Contains(search));
        }

        // Apply sorting
        query = sortDirection.ToLower() == "desc"
            ? query.OrderByDescending(GetSortExpression(sortBy))
            : query.OrderBy(GetSortExpression(sortBy));

        // Apply pagination
        return await query.ToPagedListAsync(pageNumber, pageSize, cancellationToken);
    }

    public async Task<int> CountStoriesWithFilterAsync(string search, CancellationToken cancellationToken = default)
    {
        var query = dbContext.Set<StudentSuccessStory>().AsQueryable();

        // Apply search filter
        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(story =>
                story.NameAr.Contains(search) ||
                story.NameEn.Contains(search) ||
                story.UniversityNameAr.Contains(search) ||
                story.UniversityNameEn.Contains(search));
        }

        return await query.CountAsync(cancellationToken);
    }

    private static Expression<Func<StudentSuccessStory, object>> GetSortExpression(string sortBy)
    {
        return sortBy.ToLower() switch
        {
            "namear" => story => story.NameAr,
            "nameen" => story => story.NameEn,
            "universitynamear" => story => story.UniversityNameAr,
            "universitynameen" => story => story.UniversityNameEn,
            _ => story => story.LastUpdated // Default sorting by LastUpdated
        };
    }
}
    
    