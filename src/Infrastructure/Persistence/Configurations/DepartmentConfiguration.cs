using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("Department");

        builder.HasKey(c => c.Id);
        builder.Property(d => d.NameAr).IsRequired().HasMaxLength(150);
        builder.Property(d => d.NameEn).IsRequired().HasMaxLength(150);

        builder.HasOne(m => m.Faculty)
               .WithMany(m => m.DepartmentList)
               .HasForeignKey(m => m.FacultyId);
        // Many-to-many relationship with Courses
        builder.HasMany(d => d.Courses)
               .WithMany(c => c.Departments)
               .UsingEntity(j => j.ToTable("DepartmentCourses"));  // Junction table for Departments and Courses

    }
}
