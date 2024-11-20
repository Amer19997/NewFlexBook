using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using MediatR;

namespace FlexBook.Application.Features.Core.Classes.Quieries.CoursesOfJoinedClasses;
/// <summary>
/// Query to get courses of joined classes for the logged-in student.
/// </summary>
public class GetCoursesOfJoinedClassesQuery : IRequest<TResponse<List<CoursesOfJoinedClassDto>>>
{
    // No additional parameters needed, as we get the student ID from ICurrentUserService
}
