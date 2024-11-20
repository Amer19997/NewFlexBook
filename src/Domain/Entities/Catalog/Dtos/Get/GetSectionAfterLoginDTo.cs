using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.Get;
public class GetSectionAfterLoginDTo
{
    public Guid Id { get; set; }
    public string TitleAr { get; set; }
    public string TitleEn { get; set; }
    public bool IsHidden { get; set; } = false;

    public Guid CourseId { get; set; }
    public List<GetLessonAfterLoginDto> Lessons { get; set; } = new();
    public List<GetQuizAfterInstructorLoginDto> Quizzes { get; set; } = new();
}
