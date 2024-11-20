using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class InstructorCoursesConfiguration : IEntityTypeConfiguration<InstructorAvailableCourse>
{
    public void Configure(EntityTypeBuilder<InstructorAvailableCourse> builder)
    {
        // Specify the table name
        builder.ToTable("InstructorCourses");

        // Set a composite primary key on InstructorId and CourseId
        builder.HasKey(ic => new { ic.InstructorId, ic.CourseId });

        // Configure the relationship between InstructorCourse and User (Instructor)
        builder.HasOne(ic => ic.Instructor)
               .WithMany(u => u.InstructorAvailableCourse)
               .HasForeignKey(ic => ic.InstructorId)
               .OnDelete(DeleteBehavior.Cascade); // Optional, cascade delete if an instructor is removed

        // Configure the relationship between InstructorCourse and Course
        builder.HasOne(ic => ic.Course)
               .WithMany(c => c.InstructorAvailableCourse)
               .HasForeignKey(ic => ic.CourseId)
               .OnDelete(DeleteBehavior.Cascade); // Optional, cascade delete if a course is removed


        // Set indexes for quick look-up if needed
        builder.HasIndex(ic => ic.InstructorId);
        builder.HasIndex(ic => ic.CourseId);
    }
}
