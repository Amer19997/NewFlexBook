using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.StaticPages;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class AuthorizingTeamMemberConfiguration : IEntityTypeConfiguration<AuthorizingTeamMember>
{
    public void Configure(EntityTypeBuilder<AuthorizingTeamMember> builder)
    {
        // Define table name
        builder.ToTable("AuthorizingTeamMembers");

        // Define primary key
        builder.HasKey(atm => atm.Id);

        // Configure properties
        builder.Property(atm => atm.FirstNameAr)
            .HasMaxLength(100);

        builder.Property(atm => atm.FirstNameEn)
            .HasMaxLength(100);

        builder.Property(atm => atm.LastNameAr)
            .HasMaxLength(100);

        builder.Property(atm => atm.LastNameEn)
            .HasMaxLength(100);

        builder.Property(atm => atm.DescriptionAr)
            .IsRequired()
            .HasMaxLength(2000);

        builder.Property(atm => atm.DescriptionEn)
            .IsRequired()
            .HasMaxLength(2000);

        builder.Property(atm => atm.PhotoUrl)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(atm => atm.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()");
    }
}