using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities;
public class AccessCode : BaseEntity<Guid>
{
    public Guid ClassId { get; set; }
    public Guid StudentId { get; set; }
    public string Code { get; set; } = default!;
    public bool IsUsed { get; set; } = false;
    public DateTime ExpiryDate { get; set; }
}
