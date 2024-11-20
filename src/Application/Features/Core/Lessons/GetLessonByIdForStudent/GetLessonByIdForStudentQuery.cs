using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace FlexBook.Application.Features.Core.Lessons.GetLessonByIdForStudent;
public class GetLessonByIdForStudentQuery : IRequest<object>
{
    public Guid StudentId { get; set; }
    public Guid ClassId { get; set; }
    public Guid LessonId { get; set; }
}