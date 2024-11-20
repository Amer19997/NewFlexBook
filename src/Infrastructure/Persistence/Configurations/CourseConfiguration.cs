using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Courses");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.NameAr).IsRequired().HasMaxLength(150);
        builder.Property(c => c.NameEn).IsRequired().HasMaxLength(150);
        builder.Property(c => c.DiscriptionAr).HasMaxLength(500);
        builder.Property(c => c.DiscriptionEn).HasMaxLength(500);


        // Configure the unique code for the course
        //builder.Property(c => c.Code).IsRequired().HasMaxLength(50);
        builder.HasIndex(c => c.Code).IsUnique();  // Ensure the course code is unique



        // Category relationship - Cascade delete is allowed here
        builder.HasOne(c => c.Category)
               .WithMany(c => c.Courses)
               .HasForeignKey(c => c.CategoryId)
               .OnDelete(DeleteBehavior.Cascade);

        // Topic relationship - Use Restrict to avoid multiple cascade paths
        builder.HasOne(c => c.Topic)
               .WithMany(t => t.Courses)
               .HasForeignKey(c => c.TopicId)
               .OnDelete(DeleteBehavior.Restrict); // No cascading on delete

        // Sections relationship: One Course can have many Sections
        builder.HasMany(c => c.Sections)
               .WithOne(s => s.Course)
               .HasForeignKey(s => s.CourseId)
               .OnDelete(DeleteBehavior.Cascade);  // Cascade delete when a course is deleted




        // Many-to-many relationships with Universities, Faculties, Departments, and Specializations
        builder.HasMany(c => c.Universities)
               .WithMany(u => u.Courses)
               .UsingEntity(j => j.ToTable("CourseUniversities"));  // Junction table for Courses and Universities

        builder.HasMany(c => c.Faculties)
               .WithMany(f => f.Courses)
               .UsingEntity(j => j.ToTable("CourseFaculties"));  // Junction table for Courses and Faculties

        builder.HasMany(c => c.Departments)
               .WithMany(d => d.Courses)
               .UsingEntity(j => j.ToTable("CourseDepartments"));  // Junction table for Courses and Departments

        builder.HasMany(c => c.Specializations)
               .WithMany(s => s.Courses)
               .UsingEntity(j => j.ToTable("CourseSpecializations"));  // Junction table for Courses and Specializations















    }
}
