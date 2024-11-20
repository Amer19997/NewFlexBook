using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class StudentAvailableCoursesConfiguration : IEntityTypeConfiguration<StudentAvailableCourse>
{
    public void Configure(EntityTypeBuilder<StudentAvailableCourse> builder)
    {
        builder.ToTable("StudentAvailableCourses");

        builder.HasKey(sc => new { sc.StudentId, sc.CourseId });

        builder.HasOne(sc => sc.Student)
            .WithMany()
            .HasForeignKey(sc => sc.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(sc => sc.Course)
            .WithMany()
            .HasForeignKey(sc => sc.CourseId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}