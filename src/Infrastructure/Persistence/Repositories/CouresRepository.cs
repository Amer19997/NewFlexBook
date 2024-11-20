using Microsoft.Extensions.Options;
using FlexBook.Application.Common.Helpers;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using FlexBook.Domain.Entities.Catalog;

namespace FlexBook.Infrastructure.Persistence.Repositories;
public class CouresRepository : Repository<Course>, ICouresRepository
{
    public CouresRepository(FlexBookDbContext dbContext) : base(dbContext) { }

    // Method for fetching courses ACby university, faculty, department, and specialization (dashboard case)

    // Method for fetching courses by university, faculty, department, and specialization (dashboard case)
    public IQueryable<Course> GetCoursesByConditions(Guid? universityId, Guid? facultyId, Guid? departmentId, Guid?  specializationId)
    {
        return dbContext.Courses
            .Where(c => c.Universities.Any(u => u.Id == universityId) &&
                        c.Faculties.Any(f => f.Id == facultyId) &&
                        c.Departments.Any(d => d.Id == departmentId) &&
                        c.Specializations.Any(s => s.Id == specializationId));
    }
    // Get all sections for a specific course
    public async Task<List<Section>> GetSectionsByCourseIdAsync(Guid courseId, CancellationToken cancellationToken)
    {
        return await dbContext.Sections
            .Where(s => s.CourseId == courseId)
            .Include(s => s.Lessons)
            .Include(s => s.Quizzes)
            .ThenInclude(q => q.Questions)
            .ToListAsync(cancellationToken);
    }
    // Method for fetching courses by university and department only (portal case)
    public IQueryable<Course> GetCoursesByUniversityAndDepartment(Guid? universityId, Guid? departmentId)
    {
        return dbContext.Courses
            .Where(c => c.Universities.Any(u => u.Id == universityId) &&
                        c.Departments.Any(d => d.Id == departmentId));
    }
    public async Task<List<Course>> GetCoursesWithFilterAsync(Guid? topicId, Guid? categoryId, string keyword, CancellationToken cancellationToken)
    {
        IQueryable<Course> query = dbContext.Courses.Include(c => c.Sections);

        // Filter by TopicId
        if (topicId.HasValue)
        {
            query = query.Where(c => c.TopicId == topicId.Value);
        }

        // Filter by CategoryId
        if (categoryId.HasValue)
        {
            query = query.Where(c => c.CategoryId == categoryId.Value);
        }

        // Filter by Keyword (search in Name and Description in both Arabic and English)
        if (!string.IsNullOrEmpty(keyword))
        {
            keyword = keyword.ToLower(); // Case-insensitive search

            query = query.Where(c => c.NameAr.ToLower().Contains(keyword) ||
                                     c.NameEn.ToLower().Contains(keyword) ||
                                     c.DiscriptionAr.ToLower().Contains(keyword) ||
                                     c.DiscriptionEn.ToLower().Contains(keyword));
        }
         // Return the filtered courses
        return await query.Include(c => c.Category)
                          .Include(c => c.Topic)
                          .ToListAsync(cancellationToken);
    }

    public async Task<IPagedList<Course>> GetPaginatedCoursesWithFilterAsync(
        Guid? topicId,
        Guid? categoryId,
        string keyword,
        int pageNumber = 1,
        int pageSize = 10,
        string sortBy = "NameEn",  // Default sorting field
        string sortDirection = "asc",  // Default sorting direction

        CancellationToken cancellationToken = default)
    {
        IQueryable<Course> query = dbContext.Courses;

        // Filter by TopicId
        if (topicId.HasValue)
        {
            query = query.Where(c => c.TopicId == topicId.Value);
        }

        // Filter by CategoryId
        if (categoryId.HasValue)
        {
            query = query.Where(c => c.CategoryId == categoryId.Value);
        }

        // Filter by Keyword (search in Name and Description in both Arabic and English)
        if (!string.IsNullOrEmpty(keyword))
        {
            keyword = keyword.ToLower(); // Case-insensitive search

            query = query.Where(c => c.NameAr.ToLower().Contains(keyword) ||
                                     c.NameEn.ToLower().Contains(keyword) ||
                                     c.DiscriptionAr.ToLower().Contains(keyword) ||
                                     c.DiscriptionEn.ToLower().Contains(keyword));
        }

        // Apply ordering based on sortBy and sortDirection
        query = ApplyOrdering(query, sortBy, sortDirection);

        // Apply pagination
        pageNumber = pageNumber < 1 ? 1 : pageNumber;
        IPagedList<Course> pagedList = await query.ToPagedListAsync(pageNumber, pageSize);

        return pagedList;
    }

    private IQueryable<Course> ApplyOrdering(IQueryable<Course> query, string sortBy, string sortDirection)
    {
        // Check the sort direction (ascending or descending)
        bool isDescending = sortDirection.Equals("desc", StringComparison.OrdinalIgnoreCase);

        // Apply sorting based on the field
        switch (sortBy.ToLower())
        {
            case "namear":
                query = isDescending ? query.OrderByDescending(c => c.NameAr) : query.OrderBy(c => c.NameAr);
                break;
            case "nameen":
                query = isDescending ? query.OrderByDescending(c => c.NameEn) : query.OrderBy(c => c.NameEn);
                break;
            //case "createddate":
            //    query = isDescending ? query.OrderByDescending(c => c.CreatedDate) : query.OrderBy(c => c.CreatedDate);
            //    break;
            default:
                // Default sorting by NameEn
                query = isDescending ? query.OrderByDescending(c => c.NameEn) : query.OrderBy(c => c.NameEn);
                break;
        }

        return query;
    }
    // New CountAsync method to count courses based on filters
    public async Task<int> CountCoursesAsync(Guid? topicId, Guid? categoryId, string keyword, CancellationToken cancellationToken = default)
    {
        IQueryable<Course> query = dbContext.Courses;

        // Filter by TopicId
        if (topicId.HasValue)
        {
            query = query.Where(c => c.TopicId == topicId.Value);
        }

        // Filter by CategoryId
        if (categoryId.HasValue)
        {
            query = query.Where(c => c.CategoryId == categoryId.Value);
        }

        // Filter by Keyword (search in Name and Description in both Arabic and English)
        if (!string.IsNullOrEmpty(keyword))
        {
            keyword = keyword.ToLower(); // Case-insensitive search

            query = query.Where(c => c.NameAr.ToLower().Contains(keyword) ||
                                     c.NameEn.ToLower().Contains(keyword) ||
                                     c.DiscriptionAr.ToLower().Contains(keyword) ||
                                     c.DiscriptionEn.ToLower().Contains(keyword));
        }

        // Return the count of matching courses
        return await query.CountAsync(cancellationToken);
    }
}