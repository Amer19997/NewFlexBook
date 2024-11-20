using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.LookUps.Faculty.Queries.GetFacultyList;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.LookUps.Specialization.Queries.GetSpecializationsList;

public class GetSpecializationQueryHandler : IRequestHandler<GetSpecializationQuery, TResponse<GetSpecializationResult>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetSpecializationQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse<GetSpecializationResult>> Handle(GetSpecializationQuery request, CancellationToken cancellationToken)
    {
        // Get paginated list with filter
        var result = await _unitOfWork.SpecializationRepository.FindPagedList(
            filters: filter(request.DepartmentId),
            includeProperties: "Department"
        );

        // Map to DTO
        var specializationList = result.Select(s => new SpecializationItem
        {
            Id = s.Id,
            NameAr = s.NameAr,
            NameEn = s.NameEn,
            DepartmentId = s.DepartmentId,
            DepartmentNameAr = s.Department?.NameAr,
            DepartmentNameEn = s.Department?.NameEn,

            IsActive = s.IsActive
        }).ToList();

        // Return the response with mapped list
        return TResponse<GetSpecializationResult>.Success(new GetSpecializationResult
        {
            SpecializationList = specializationList
        });
    }

    // Filter to include only active specializations and optionally filter by DepartmentId
    private IEnumerable<Expression<Func<Domain.Entities.LookUps.Specialization, bool>>> filter(Guid? departmentId)
    {
        var filters = new List<Expression<Func<Domain.Entities.LookUps.Specialization, bool>>>
            {
                x => x.LookUpStatus == Domain.Enums.LookUpStatus.Active
            };

        if (departmentId.HasValue)
        {
            filters.Add(x => x.DepartmentId == departmentId.Value);
        }

        return filters;
    }
}

