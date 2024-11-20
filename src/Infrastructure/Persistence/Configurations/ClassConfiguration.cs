using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Entities.LookUps;
using IdentityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlexBook.Infrastructure.Persistence.Configurations;
public class ClassConfiguration : IEntityTypeConfiguration<Class>

{
 

    public void Configure(EntityTypeBuilder<Class> builder)
    {
        // Configure Class entity
      
            builder.ToTable("Classes");

            builder.HasKey(c => c.Id);

        builder.HasOne(c => c.Course)
                  .WithMany(c => c.Classes) // Assuming Course entity has a collection of classes
                  .HasForeignKey(c => c.CourseId)
                  .OnDelete(DeleteBehavior.Cascade);
        // Each Class has one Instructor (User with UserTypeEnum.Instructor)
        builder.HasOne(c => c.Instructor)
              .WithMany(u => u.ClassesCreated)  // Each User (Instructor) can create many classes
              .HasForeignKey(c => c.InstructorId)
              .OnDelete(DeleteBehavior.Restrict);  // Prevent instructor deletion from removing the class

        // Each Class has many Students (Users with UserTypeEnum.Student)
        builder.HasMany(c => c.Students)
              .WithMany(u => u.ClassesEnrolled)  // Each User (Student) can be enrolled in many classes
              .UsingEntity(j => j.ToTable("ClassStudents"));  // Junction table for the many-to-many relationship

    }
}
