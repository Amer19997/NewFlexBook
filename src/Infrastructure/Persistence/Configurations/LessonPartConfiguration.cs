using FlexBook.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlexBook.Infrastructure.Persistence.Configurations
{
    public class LessonPartConfiguration : IEntityTypeConfiguration<LessonPart>
    {
        public void Configure(EntityTypeBuilder<LessonPart> builder)
        {
            // Set table name
            builder.ToTable("LessonParts");

            // Set primary key
            builder.HasKey(lp => lp.Id);

            // Set relationship with Lesson entity
            builder.HasOne(lp => lp.Lesson)
                   .WithMany(l => l.LessonParts)
                   .HasForeignKey(lp => lp.LessonId)
                   .OnDelete(DeleteBehavior.Cascade); // Deletes associated lesson parts when a lesson is deleted

            // Set unique constraint on PartNumber within each Lesson
            builder.Property(lp => lp.PartNumber)
                   .IsRequired();

            builder.HasIndex(lp => new { lp.LessonId, lp.PartNumber })
                   .IsUnique();

            // Set Content properties
            builder.Property(lp => lp.Content)
                   .IsRequired()
                   .HasMaxLength(5000); // Maximum length for text content
        }
    }
}
