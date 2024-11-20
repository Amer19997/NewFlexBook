using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.UsersAggregate;

namespace FlexBook.Domain.Entities.Catalog.Dtos;
public class ClassRequestDto
{
    public Guid RequestId { get; set; }
    public Guid ClassId { get; set; }
    public Guid StudentId { get; set; }
    public string Status { get; set; } = string.Empty;
    public User? Student { get; set; }
}