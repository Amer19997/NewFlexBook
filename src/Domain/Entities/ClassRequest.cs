using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Entities.UsersAggregate;

namespace FlexBook.Domain.Entities;
public class ClassRequest : BaseEntity<Guid>
{
    public Guid ClassId { get; set; }
    public Class Class { get; set; } = default!;

    public Guid StudentId { get; set; }
    public User Student { get; set; } = default!;

    public RequestStatus Status { get; set; } = RequestStatus.Pending;
}
