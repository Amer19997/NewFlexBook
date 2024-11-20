using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;

namespace FlexBook.Domain.Entities.Catalog.Dtos;
public class SectionDto
{
    public Guid Id { get; set; }
    public string TitleAr { get; set; }
    public string TitleEn { get; set; }
    public Guid CourseId { get; set; }
    public List<LessonDto> Lessons { get; set; } = new();
    public List<QuizDto> Quizzes { get; set; } = new();
}
