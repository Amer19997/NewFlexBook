using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.StudentStories.Queries;
using FlexBook.Domain;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain.Repositories;
using MediatR;
using X.PagedList;

namespace FlexBook.Application.Features.StaticPages.StudentStories.Handlers
{
    public class GetStudentSuccessStoriesQueryHandler : IRequestHandler<GetStudentSuccessStoriesQuery, TResponse<IPagedList<StudentSuccessStoryDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetStudentSuccessStoriesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<TResponse<IPagedList<StudentSuccessStoryDto>>> Handle(GetStudentSuccessStoriesQuery request, CancellationToken cancellationToken)
        {
            // Fetch paginated and filtered success stories from the repository
            var pagedStories = await _unitOfWork.StudentSuccessStoryRepository.GetPaginatedWithFilterAsync(
                filter: string.IsNullOrWhiteSpace(request.Search) ? null :
                    story => story.NameAr.Contains(request.Search) ||
                             story.NameEn.Contains(request.Search) ||
                             story.UniversityNameAr.Contains(request.Search) ||
                             story.UniversityNameEn.Contains(request.Search),
                orderBy: request.SortDirection.ToLower() == "desc"
                    ? query => query.OrderByDescending(GetSortExpression(request.SortBy))
                    : query => query.OrderBy(GetSortExpression(request.SortBy)),
                pageNumber: request.PageNumber,
                pageSize: request.PageSize,
                cancellationToken: cancellationToken
            );

            // Map paged result to DTOs
            var storiesResult = _mapper.Map<IPagedList<StudentSuccessStoryDto>>(pagedStories);

            // Return the response
            return TResponse<IPagedList<StudentSuccessStoryDto>>.Success(storiesResult);
        }

        private static System.Linq.Expressions.Expression<System.Func<StudentSuccessStory, object>> GetSortExpression(string sortBy)
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
}
