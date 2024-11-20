using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Domain.Entities.UsersAggregate;
public class UserInterstes:BaseEntity<int>
{
    public Guid UserId { get; set; }
    public User User {  get; set; }
    public Guid CategoryId { get; set; }
    public Category Category{  get; set; }
}
