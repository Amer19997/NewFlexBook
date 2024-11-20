using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexBook.Domain.Entities.StaticPages.Dtos;
public class AuthorizingTeamMemberDto
{
    public Guid Id { get; set; }
    public string? FirstNameAr { get; set; } = default!;
    public string? FirstNameEn { get; set; } = default!;
    public string? LastNameAr { get; set; } = default!;
    public string? LastNameEn { get; set; } = default!;
    public string DescriptionAr { get; set; } = default!;
    public string DescriptionEn { get; set; } = default!;
    public string PhotoUrl { get; set; }
}
