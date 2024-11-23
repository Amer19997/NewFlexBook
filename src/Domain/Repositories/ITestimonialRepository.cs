using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.StaticPages;

namespace FlexBook.Domain.Repositories;
public interface ITestimonialRepository : IRepository<Testimonial>
{
    // Additional testimonial-specific methods can be added here
}
