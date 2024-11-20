using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FlexBook.Domain.Entities.LookUps;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class UniversityConfiguration : IEntityTypeConfiguration<University>
{
    public void Configure(EntityTypeBuilder<University> builder)
    {
        builder.ToTable("Universities");
        builder.Property(u => u.NameAr).IsRequired().HasMaxLength(150);
        builder.Property(u => u.NameEn).IsRequired().HasMaxLength(150);


        builder.HasKey(c => c.Id);
        builder.HasOne(m => m.Country)
               .WithMany(m => m.UniversityList)
               .HasForeignKey(m=>m.CountryId);

        // Many-to-many relationship with Courses
        builder.HasMany(u => u.Courses)
               .WithMany(c => c.Universities)
               .UsingEntity(j => j.ToTable("UniversityCourses"));  // Junction table for Universities and Courses

    }
}
