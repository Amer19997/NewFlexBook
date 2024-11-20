using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.LookUps;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class SpecializationConfiguration : IEntityTypeConfiguration<Specialization>
{
    public void Configure(EntityTypeBuilder<Specialization> builder)
    {
        builder.ToTable("Specializations");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.NameAr).IsRequired().HasMaxLength(150);
        builder.Property(s => s.NameEn).IsRequired().HasMaxLength(150);

        // Department relationship
        builder.HasOne(s => s.Department)
               .WithMany(d => d.Specializations)
               .HasForeignKey(s => s.DepartmentId);

        // Many-to-many relationship with Courses
        builder.HasMany(s => s.Courses)
               .WithMany(c => c.Specializations)
               .UsingEntity(j => j.ToTable("SpecializationCourses"));  // Junction table for Specializations and Courses

    }
}
