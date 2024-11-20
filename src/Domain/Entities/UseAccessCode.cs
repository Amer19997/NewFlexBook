using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities;
public class UseAccessCode
{
    public Guid ClassId { get; set; } // The ID of the class the student is trying to join
    public string AccessCode { get; set; } // The access code to use

}
