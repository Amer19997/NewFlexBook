using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.StaticPages;
using X.PagedList;

namespace FlexBook.Domain.Repositories;
public interface IStudentSuccessStoryRepository : IRepository<StudentSuccessStory>
{
    //Task<IPagedList<StudentSuccessStory>> GetPagedStoriesAsync(
    //    string? search,
    //    int pageNumber,
    //    int pageSize,
    //    CancellationToken cancellationToken = default);
    Task<IPagedList<StudentSuccessStory>> GetPaginatedStoriesWithFilterAsync(
          string search,
          int pageNumber,
          int pageSize,
          string sortBy,
          string sortDirection,
          CancellationToken cancellationToken = default
      );

    Task<int> CountStoriesWithFilterAsync(
        string search,
        CancellationToken cancellationToken = default
    );
}
