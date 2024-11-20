using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos.Get.Instructor;
using MediatR;

namespace FlexBook.Application.Features.Core.Classes.Quieries.GetClassesForInstructor;
public class GetClassesForInstructorQuery : IRequest<TResponse<List<GetInstructorClassDto>>>
{
}
