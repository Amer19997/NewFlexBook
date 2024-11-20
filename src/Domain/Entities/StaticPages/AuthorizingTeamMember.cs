using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.StaticPages;
public class AuthorizingTeamMember : BaseEntity<Guid>
{
    public string? FirstNameAr { get; set; } = default!;
    public string?FirstNameEn { get; set; } = default!;
    public string?LastNameAr { get; set; } = default!;
    public string?LastNameEn { get; set; } = default!;
    public string DescriptionAr { get; set; } = default!;
    public string DescriptionEn { get; set; } = default!;
    public string PhotoUrl { get; set; } // Photo URL for the team member
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}