using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.StaticPages;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class StudentSuccessStoryConfiguration : IEntityTypeConfiguration<StudentSuccessStory>
{
    public void Configure(EntityTypeBuilder<StudentSuccessStory> builder)
    {
        // Define table name
        builder.ToTable("StudentSuccessStories");

        // Define primary key
        builder.HasKey(sss => sss.Id);

        // Configure properties
        builder.Property(sss => sss.NameAr)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(sss => sss.NameEn)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(sss => sss.UniversityNameAr)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(sss => sss.UniversityNameEn)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(sss => sss.DescriptionAr)
            .IsRequired()
            .HasMaxLength(2000);

        builder.Property(sss => sss.DescriptionEn)
            .IsRequired()
            .HasMaxLength(2000);

        builder.Property(sss => sss.VideoUrl)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(sss => sss.ImageUrl)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(sss => sss.LastUpdated)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");
    }
}