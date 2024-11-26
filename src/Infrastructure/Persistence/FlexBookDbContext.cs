using MediatR;
using Microsoft.EntityFrameworkCore;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Entities.UsersAggregate;
using FlexBook.Infrastructure.Persistence.Interceptors;
using FlexBook.Domain.Entities.Catalog;
using System.Reflection.Emit;
using FlexBook.Domain.Entities.Authorization;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using FlexBook.Domain.Entities.StaticPages;

namespace FlexBook.Infrastructure.Persistence;
public class FlexBookDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    private readonly IMediator _mediator;
    private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;

    public FlexBookDbContext(
        IConfiguration configuration,
        DbContextOptions<FlexBookDbContext> options,
        AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor)
        : base(options)
    {
        _auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
        _configuration = configuration;


    }

    public DbSet<User> Users { get; set; } = default!;
    public DbSet<Country> Country { get; set; } = default!;
    public DbSet<University> Universities { get; set; } = default!;
    public DbSet<Faculty> Faculty { get; set; } = default!;
    public DbSet<Department> Department { get; set; } = default!;
    public DbSet<InterestsList> InterestsList { get; set; } = default!;
    public DbSet<UserInterstes> UserInterstes { get; set; } = default!;
    public DbSet<Course> Courses { get; set; } = default!;

    public DbSet<Section> Sections { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Question> Questions { get; set; }

    public DbSet<Topic> Topics { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
    public DbSet<Specialization> Specializations { get; set; }
    public DbSet<Class> Classes { get; set; } = default!;
    public DbSet<InstructorCourseOverride> InstructorCourseOverrides { get; set; }
    public DbSet<InstructorAvailableCourse> InstructorCourses { get; set; } = default!;
    public DbSet<StudentAvailableCourse> StudentAvailableCourses { get; set; } = default!;
    public DbSet<LessonPart> LessonParts { get; set; } = default!;
    public DbSet<InteractiveElement> InteractiveElements { get; set; } = default!;
     

    public DbSet<ClassRequest> ClassRequests { get; set; } = default!;
     
            public DbSet<AccessCode> AccessCodes { get; set; } = default!;
    public DbSet<AuthorizingTeamMember> AuthorizingTeamMembers { get; set; } = default!;
    public DbSet<StudentSuccessStory> StudentSuccessStories { get; set; } = default!;
    public DbSet<ResearchEntry> ResearchEntries { get; set; } = default!;
    public DbSet<AcademicIntegrity> AcademicIntegrities { get; set; } = default!;
    public DbSet<InstructorSuccessStory> InstructorSuccessStories { get; set; } = default!;
    public DbSet<StudentsGettingStartedArticle> StudentsGettingStartedArticles { get; set; } = default!;
    public DbSet<EvaluatingAdoptingArticle> EvaluatingAdoptingArticles { get; set; } = default!;
    public DbSet<TeachersGettingStartedArticle> TeachersGettingStartedArticles { get; set; } = default!;
    public DbSet<InstructorCommunityEntry> InstructorCommunityEntries { get; set; } = default!;
    public DbSet<AboutUsSection> AboutUsSections { get; set; } = default!;
    public DbSet<Testimonial> Testimonials { get; set; } = default!;
    public DbSet<HomePageSection> HomePageSections { get; set; } = default!;

    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        builder.Entity<Question>()
      .Ignore(q => q.Options)
      .Ignore(q => q.CorrectAnswers)
      .Ignore(q => q.MatchingPairs);

        // Correct JSON conversion for List<string> Resources in the Lesson entity
        builder.Entity<Lesson>()
            .Property(l => l.Resources)
            .HasConversion(
                v => v == null ? "[]" : JsonSerializer.Serialize(v, (JsonSerializerOptions)null), // Serialize List<string> to JSON
                v => string.IsNullOrEmpty(v) ? new List<string>() : JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null) ?? new List<string>() // Deserialize JSON to List<string>
            );

        // Correct JSON conversion for OptionsJson in the Question entity
        builder.Entity<Question>()
            .Property(q => q.Options)
            .HasConversion(
                v => v == null ? "[]" : JsonSerializer.Serialize(v, (JsonSerializerOptions)null), // Serialize List<string> to JSON
                v => string.IsNullOrEmpty(v) ? new List<string>() : JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null) ?? new List<string>() // Deserialize JSON to List<string>
            );

        // Correct JSON conversion for CorrectAnswersJson in the Question entity
        builder.Entity<Question>()
            .Property(q => q.CorrectAnswers)
            .HasConversion(
                v => v == null ? "[]" : JsonSerializer.Serialize(v, (JsonSerializerOptions)null), // Serialize List<string> to JSON
                v => string.IsNullOrEmpty(v) ? new List<string>() : JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null) ?? new List<string>() // Deserialize JSON to List<string>
            );

        // Correct JSON conversion for MatchingPairsJson in the Question entity
        builder.Entity<Question>()
            .Property(q => q.MatchingPairs)
            .HasConversion(
                v => v == null ? "{}" : JsonSerializer.Serialize(v, (JsonSerializerOptions)null), // Serialize Dictionary<string, string> to JSON
                v => string.IsNullOrEmpty(v) ? new Dictionary<string, string>() : JsonSerializer.Deserialize<Dictionary<string, string>>(v, (JsonSerializerOptions)null) ?? new Dictionary<string, string>() // Deserialize JSON to Dictionary<string, string>
            );

        base.OnModelCreating(builder);

        // Seed data
        //DataSeeder.Seed(builder, _configuration);
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_auditableEntitySaveChangesInterceptor);
 
    }


}
