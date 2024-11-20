using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos;
public class QuizDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    //public QuizType QuizType { get; set; }
    //public List<QuestionDto> Questions { get; set; } = new();
    //public Guid SectionId { get; set; }
}

