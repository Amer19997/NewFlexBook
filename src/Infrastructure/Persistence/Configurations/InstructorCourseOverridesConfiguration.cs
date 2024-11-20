using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class InstructorCourseOverridesConfiguration
{
    public void Configure(EntityTypeBuilder<InstructorCourseOverride> builder)
    {
        // Configure Class entity

        builder.ToTable("InstructorCourseOverrides");

        builder.HasKey(c => c.Id);

       
    }
}
