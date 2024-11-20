using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.Get;
public class GetSectionAfterInstructorLoginDTo
{
    public Guid Id { get; set; }
    public string TitleAr { get; set; }
    public string TitleEn { get; set; }
    public bool IsHidden { get; set; } = false;

    public Guid CourseId { get; set; }
    public List<GetLessonAfterInstructorLoginDto> Lessons { get; set; } = new();
    public List<QuizAfterInstructorLoginDto> Quizzes { get; set; } = new();
}
