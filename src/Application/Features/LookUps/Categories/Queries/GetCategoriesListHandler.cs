using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.LookUps.Courses.Queries.GetCoursesBasicListQuery;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.LookUps.Categories.Queries;

public class GetCategoriesListHandler : IRequestHandler<GetCategoriesListQuery, TResponse<GetCategoriestResult>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetCategoriesListHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse<GetCategoriestResult>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.CategoryRepository
                                      .FindAsync(null,
                                                 orderBy: q => q.OrderBy(r => r.NameEn),
                                                 includeProperties: ""); // No need for includes if only fetching simple properties

        var courseList = result.Select(m => new CategoryItem
        {
            Id = m.Id,
            NameAr = m.NameAr,
            NameEn = m.NameEn,
            CoverPhoto = m.CoverPhoto // Assuming the Course entity has a CoverPhoto field
        }).ToList();

        return TResponse<GetCategoriestResult>.Success(new GetCategoriestResult
        {
            CategoriesList = courseList
        });
    }
}
public class CategoryItem
{
    public Guid Id { get; set; }
    public string NameAr { get; set; }
    public string NameEn { get; set; }
    public string CoverPhoto { get; set; } // Assuming you have a cover photo field
}
