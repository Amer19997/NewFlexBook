using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Application.Features.LookUps.Specialization.Queries.GetSpecializationsList;

public class GetSpecializationResult
{
    public List<SpecializationItem> SpecializationList { get; set; }

}
public class SpecializationItem
{
    public Guid Id { get; set; }
    public string NameAr { get; set; }
    public string NameEn { get; set; }
    public Guid DepartmentId { get; set; }
    public string DepartmentNameAr { get; set; }
    public string DepartmentNameEn { get; set; }

    public bool IsActive { get; set; }

}