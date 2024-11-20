using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog.Dtos.Get;
public class QuizAfterInstructorLoginDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    //public QuizType? QuizType { get; set; }
    //public ICollection<GetQuestionForInstructorDto> Questions { get; set; }
    //public Guid SectionId { get; set; }
}
