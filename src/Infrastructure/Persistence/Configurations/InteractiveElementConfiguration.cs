using FlexBook.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlexBook.Infrastructure.Persistence.Configurations
{
    public class InteractiveElementConfiguration : IEntityTypeConfiguration<InteractiveElement>
    {
        public void Configure(EntityTypeBuilder<InteractiveElement> builder)
        {
            // Set table name
            builder.ToTable("InteractiveElements");

            // Set primary key
            builder.HasKey(ie => ie.Id);

            // Set relationship with LessonPart entity
            builder.HasOne(ie => ie.LessonPart)
                   .WithMany(lp => lp.InteractiveElements)
                   .HasForeignKey(ie => ie.LessonPartId)
                   .OnDelete(DeleteBehavior.Cascade); // Deletes associated interactive elements when a lesson part is deleted

            // Set unique constraint on ElementNumber within each LessonPart
            builder.Property(ie => ie.ElementNumber)
                   .IsRequired();

            builder.HasIndex(ie => new { ie.LessonPartId, ie.ElementNumber })
                   .IsUnique();

            // Set ZipUrl properties
            builder.Property(ie => ie.ZipUrl)
                   .IsRequired()
                   .HasMaxLength(1000); // Maximum length for URL
        }
    }
}
