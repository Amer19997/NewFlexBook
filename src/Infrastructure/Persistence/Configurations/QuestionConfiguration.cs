using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.ToTable("Questions");

        builder.HasKey(q => q.Id); // Primary key

        builder.Property(q => q.QuestionText)
               .IsRequired();

        builder.Property(q => q.QuestionType)
               .IsRequired();

        // Configure JSON columns for SQL Server (use nvarchar(max) to store JSON)
        builder.Property(q => q.OptionsJson)
               .HasColumnType("nvarchar(max)");  // Use nvarchar(max) for SQL Server

        builder.Property(q => q.CorrectAnswersJson)
               .HasColumnType("nvarchar(max)");

        builder.Property(q => q.MatchingPairsJson)
               .HasColumnType("nvarchar(max)");

        // Many-to-One: Question to Quiz
        builder.HasOne(q => q.Quiz)
               .WithMany(qz => qz.Questions)
               .HasForeignKey(q => q.QuizId)
               .OnDelete(DeleteBehavior.Cascade); // Cascade delete when a quiz is deleted
    }
}