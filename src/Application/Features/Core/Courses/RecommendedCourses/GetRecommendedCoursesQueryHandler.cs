using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.Core.Courses.RecommendedCourses;
using FlexBook.Domain;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Enums;
using FlexBook.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Application.Features.Core.Courses.Queries
{
    public class GetRecommendedCoursesQueryHandler : IRequestHandler<GetRecommendedCoursesQuery, TResponse<object>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUserService _currentUserService;
        private readonly IResourceService _resourceService;

        public GetRecommendedCoursesQueryHandler(
            IUnitOfWork unitOfWork,
            ICurrentUserService currentUserService,
            IResourceService resourceService)
        {
            _unitOfWork = unitOfWork;
            _currentUserService = currentUserService;
            _resourceService = resourceService;
        }

        public async Task<TResponse<object>> Handle(GetRecommendedCoursesQuery request, CancellationToken cancellationToken)
        {
            // Check if the user is authenticated
            var userId = _currentUserService.UserId;
            if (string.IsNullOrEmpty(userId))
            {
                return TResponse<object>.Failure(
                    new[] { _resourceService.GetError("UnauthorizedAccess") },
                    _resourceService.GetError("UnauthorizedAccess"),
                    401);
            }

            var userGuid = Guid.Parse(userId);
            // Retrieve user with UserInterstesList included
            var user = await _unitOfWork.Users.GetByIdAsync(
                u => u.Id == userGuid,
                includeProperties: "UserInterstesList",
                cancellationToken: cancellationToken
            );

            if (user == null)
            {
                return TResponse<object>.Failure(
                    new[] { _resourceService.GetError("UserNotFound") },
                    _resourceService.GetError("UserNotFound"),
                    404);
            }

            // Get user interest category IDs
            var interestCategoryIds = user.UserInterstesList.Select(ui => ui.CategoryId).ToList();

            // Define filter for courses with matching categories
            Expression<Func<Course, bool>> filter = c => interestCategoryIds.Contains(c.CategoryId);

            // Apply sorting
            Func<IQueryable<Course>, IOrderedQueryable<Course>> orderBy = null;
            if (!string.IsNullOrEmpty(request.SortBy))
            {
                orderBy = request.SortDirection.ToLower() == "desc"
                    ? (query => query.OrderByDescending(c => EF.Property<object>(c, request.SortBy)))
                    : (query => query.OrderBy(c => EF.Property<object>(c, request.SortBy)));
            }

            // Fetch paginated list of recommended courses
            var pagedCourses = await _unitOfWork.CouresRepository.FindPagedList(
                filter,
                orderBy,
                request.PageNumber,
                request.PageSize,
                includeProperties: "Category" // Include Category if needed for DTO
            );

            // Total count of recommended courses without pagination
            var totalCount = await _unitOfWork.CouresRepository.CountAsync(filter);

            // Convert the results to DTOs
            var courseDtos = pagedCourses.Select(course => new
            {
                CourseId = course.Id,
                CourseNameEn = course.NameEn,
                CourseNameAr = course.NameAr,
                CourseDescriptionEn = course.DiscriptionEn,
                CourseDescriptionAr = course.DiscriptionAr,
                CourseCode = course.Code,
                CoverPhoto = course.CoverPhoto
            }).ToList<object>();

            // Prepare the final result structure
            var result = new
            {
                CoursesList = courseDtos,
                TotalCount = totalCount,
                PageNumber = request.PageNumber,
                PageSize = request.PageSize
            };

            return TResponse<object>.Success(result);
        }
    }
}
