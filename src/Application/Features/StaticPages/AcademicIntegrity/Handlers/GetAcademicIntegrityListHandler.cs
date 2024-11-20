using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AcademicIntegrity.Commands;
using FlexBook.Domain;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;
using X.PagedList;
using IResourceService = FlexBook.Application.Common.Interfaces.IResourceService;

namespace FlexBook.Application.Features.StaticPages.AcademicIntegrity.Handlers
{
    public class GetAcademicIntegrityListHandler : IRequestHandler<GetAcademicIntegrityListQuery, TResponse<IPagedList<AcademicIntegrityDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IResourceService _resourceService;

        public GetAcademicIntegrityListHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
        {
            _unitOfWork = unitOfWork;
            _resourceService = resourceService;
        }

        public async Task<TResponse<IPagedList<AcademicIntegrityDto>>> Handle(GetAcademicIntegrityListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                // Retrieve filtered and paginated list
                var pagedIntegrityEntries = await _unitOfWork.AcademicIntegrityrRepository.FindPagedList(
                    filter: entry =>
                        string.IsNullOrWhiteSpace(request.Search) ||
                        entry.TitleAr.Contains(request.Search) ||
                        entry.TitleEn.Contains(request.Search),
                    orderBy: request.SortDirection.ToLower() == "desc"
                        ? query => query.OrderByDescending(GetSortExpression(request.SortBy))
                        : query => query.OrderBy(GetSortExpression(request.SortBy)),
                    pageNumber: request.PageNumber,
                    pageSize: request.PageSize
                );

                // Map to DTOs
                var integrityDtos = pagedIntegrityEntries.Select(entry => new AcademicIntegrityDto
                {
                    Id = entry.Id,
                    TitleAr = entry.TitleAr,
                    TitleEn = entry.TitleEn,
                    DescriptionAr = entry.DescriptionAr,
                    DescriptionEn = entry.DescriptionEn,
                    HeaderTitleAr = entry.HeaderTitleAr,
                    HeaderTitleEn = entry.HeaderTitleEn,
                    HeaderDescriptionAr = entry.HeaderDescriptionAr,
                    HeaderDescriptionEn = entry.HeaderDescriptionEn,
                    ImageUrl = entry.ImageUrl
                }).ToList();

                return TResponse<IPagedList<AcademicIntegrityDto>>.Success(new StaticPagedList<AcademicIntegrityDto>(integrityDtos, pagedIntegrityEntries.PageNumber, pagedIntegrityEntries.PageSize, pagedIntegrityEntries.TotalItemCount));
            }
            catch (Exception ex)
            {
                return TResponse<IPagedList<AcademicIntegrityDto>>.Failure(new[] { _resourceService.GetError("Error retrieving research entries") }, ex.Message);
            }
        }
 
        private static System.Linq.Expressions.Expression<Func<FlexBook.Domain.Entities.StaticPages.AcademicIntegrity, object>> GetSortExpression(string sortBy)
        {
            return sortBy.ToLower() switch
            {
                "titlear" => entry => entry.TitleAr,
                "titleen" => entry => entry.TitleEn,
                _ => entry => entry.CreatedAt // Default sort
            };
        }
    }
}
