using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.ToTable("Lessons");

        // Primary key
        builder.HasKey(l => l.Id);

        // Properties
        builder.Property(l => l.NameAr)
               .IsRequired()
               .HasMaxLength(150);

        builder.Property(l => l.NameEn)
               .IsRequired()
               .HasMaxLength(150);

        //builder.Property(l => l.Description)
        //       .IsRequired()
        //       .HasMaxLength(500);

        builder.Property(l => l.CreationDate)
               .IsRequired();

        builder.Property(l => l.HasCodeEditor)
               .IsRequired();

        // Section relationship: Many Lessons to one Section
        builder.HasOne(l => l.Section)
               .WithMany(s => s.Lessons)
               .HasForeignKey(l => l.SectionId)
               .OnDelete(DeleteBehavior.Cascade);  // Cascade delete when a section is deleted

        //// Owned type: Media
        //builder.OwnsOne(l => l.Media);

        //// Owned type: CodeEditor
        //builder.OwnsOne(l => l.CodeEditor);

    }
}
