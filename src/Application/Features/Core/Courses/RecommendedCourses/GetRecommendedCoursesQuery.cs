using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using MediatR;

namespace FlexBook.Application.Features.Core.Courses.RecommendedCourses;
public class GetRecommendedCoursesQuery : IRequest<TResponse<object>>
{
    public string Keyword { get; set; } = "";
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string SortBy { get; set; } = "NameEn";
    public string SortDirection { get; set; } = "asc";
}
