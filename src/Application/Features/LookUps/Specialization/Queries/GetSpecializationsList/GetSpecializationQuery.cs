using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.LookUps.Faculty.Queries.GetFacultyList;
using MediatR;

namespace FlexBook.Application.Features.LookUps.Specialization.Queries.GetSpecializationsList;
    public record GetSpecializationQuery(Guid? DepartmentId) : IRequest<TResponse<GetSpecializationResult>>;

