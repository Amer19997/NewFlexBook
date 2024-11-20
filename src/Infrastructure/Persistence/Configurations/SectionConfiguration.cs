using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FlexBook.Domain.Entities.Catalog;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class SectionConfiguration : IEntityTypeConfiguration<Section>
{
    public void Configure(EntityTypeBuilder<Section> builder)
    {
        builder.ToTable("Sections");

        // Primary key
        builder.HasKey(s => s.Id);

        // Properties
        builder.Property(s => s.TitleAr)
               .IsRequired()
               .HasMaxLength(150);

        builder.Property(s => s.TitleEn)
               .IsRequired()
               .HasMaxLength(150);

        // Course relationship: Many Sections to one Course
        builder.HasOne(s => s.Course)
               .WithMany(c => c.Sections)
               .HasForeignKey(s => s.CourseId)
               .OnDelete(DeleteBehavior.Cascade);  // Cascade delete when a course is deleted

        // Lessons relationship: One Section can have many Lessons
        builder.HasMany(s => s.Lessons)
               .WithOne(l => l.Section)
               .HasForeignKey(l => l.SectionId)
               .OnDelete(DeleteBehavior.Cascade);  // Cascade delete when a section is deleted

        // Quizzes relationship: One Section can have many Quizzes
        builder.HasMany(s => s.Quizzes)
               .WithOne(q => q.Section)
               .HasForeignKey(q => q.SectionId)
               .OnDelete(DeleteBehavior.Cascade);  // Cascade delete when a section is deleted
    }
}