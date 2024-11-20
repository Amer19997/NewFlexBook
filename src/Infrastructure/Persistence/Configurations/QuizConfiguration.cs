using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder)
    {
        builder.ToTable("Quizzes");

        // Primary key
        builder.HasKey(q => q.Id);

        // Properties
        builder.Property(q => q.Name)
               .IsRequired()
               .HasMaxLength(150);

        // Section relationship: Many Quizzes to one Section
        builder.HasOne(q => q.Section)
               .WithMany(s => s.Quizzes)
               .HasForeignKey(q => q.SectionId)
               .OnDelete(DeleteBehavior.Cascade);  // Cascade delete when a section is deleted

        // QuizType
        builder.Property(q => q.QuizType)
               .IsRequired();
    }
}