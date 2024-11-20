using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.Catalog;
public class CodeEditor
{
    public string Language { get; set; } // e.g., C#, Python
    public string InitialCode { get; set; } // Initial code for students
}
