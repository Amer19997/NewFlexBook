using System;
using System.Collections.Generic;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Entities.Authorization;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Entities.UsersAggregate;
using FlexBook.Domain.Enums;
using IdentityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace FlexBook.Infrastructure
{
    public static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder, IConfiguration configuration)
        {
            string baseImageUrl = configuration["AppSettings:FileSettings:BaseImageUrl"];
            string DevBaseImageUrl = configuration["AppSettings:FileSettings:DevBaseImageUrl"];

             
            // Seeding Countries
            var countries = new List<Country>
            {
                new Country { Id = 1, NameAr = "الولايات المتحدة", NameEn = "United States" },
                new Country { Id = 2, NameAr = "المملكة المتحدة", NameEn = "United Kingdom" },
                new Country { Id = 3, NameAr = "كندا", NameEn = "Canada" },
                new Country { Id = 4, NameAr = "أستراليا", NameEn = "Australia" },
                new Country { Id = 5, NameAr = "الهند", NameEn = "India" },
                new Country { Id = 6, NameAr = "ألمانيا", NameEn = "Germany" },
                new Country { Id = 7, NameAr = "البرازيل", NameEn = "Brazil" },
                new Country { Id = 8, NameAr = "اليابان", NameEn = "Japan" },
                new Country { Id = 9, NameAr = "فرنسا", NameEn = "France" },
                new Country { Id = 10, NameAr = "الإمارات العربية المتحدة", NameEn = "United Arab Emirates" }
            };
            modelBuilder.Entity<Country>().HasData(countries);

            // Seeding Topics
            var topics = new List<Topic>
            {
                new Topic { Id = Guid.NewGuid(), NameAr = "البرمجة", NameEn = "Programming" },
                new Topic { Id = Guid.NewGuid(), NameAr = "تحليل البيانات", NameEn = "Data Analysis" },
                new Topic { Id = Guid.NewGuid(), NameAr = "الذكاء الاصطناعي", NameEn = "Artificial Intelligence" },
                new Topic { Id = Guid.NewGuid(), NameAr = "أمن المعلومات", NameEn = "Information Security" },
                new Topic { Id = Guid.NewGuid(), NameAr = "هندسة البرمجيات", NameEn = "Software Engineering" }
            };
            modelBuilder.Entity<Topic>().HasData(topics);

            // Seeding Categories
            var categories = new List<Category>();
            foreach (var topic in topics)
            {
                for (int i = 1; i <= 3; i++)
                {
                    categories.Add(new Category
                    {
                        Id = Guid.NewGuid(),
                        NameAr = $"تصنيف {i} في {topic.NameAr}",
                        NameEn = $"Category {i} in {topic.NameEn}",
                        TopicId = topic.Id,
                        CoverPhoto = $"{baseImageUrl}book-01.jpg"

                    });
                }
            }
            modelBuilder.Entity<Category>().HasData(categories);

            // Seeding Universities
            var universities = new List<University>();
            for (int i = 1; i <= 10; i++)
            {
                universities.Add(new University
                {
                    Id = Guid.NewGuid(),
                    NameAr = $"جامعة {countries[i - 1].NameAr}",
                    NameEn = $"University of {countries[i - 1].NameEn}",
                    LookUpStatus = LookUpStatus.Active,
                    CountryId = countries[i - 1].Id
                });
            }
            modelBuilder.Entity<University>().HasData(universities);

            // Seeding Faculties and Departments
            var faculties = new List<Faculty>();
            var departments = new List<Department>();
            for (int i = 1; i <= 10; i++)
            {
                var faculty = new Faculty
                {
                    Id = Guid.NewGuid(),
                    NameAr = $"كلية الهندسة {i}",
                    NameEn = $"Engineering Faculty {i}",
                    UniversityId = universities[i - 1].Id,
                    LookUpStatus = LookUpStatus.Active
                };
                faculties.Add(faculty);

                var department = new Department
                {
                    Id = Guid.NewGuid(),
                    NameAr = $"قسم الحاسوب {i}",
                    NameEn = $"Computer Science Department {i}",
                    FacultyId = faculty.Id,
                    LookUpStatus = LookUpStatus.Active
                };
                departments.Add(department);
            }
            modelBuilder.Entity<Faculty>().HasData(faculties);
            modelBuilder.Entity<Department>().HasData(departments);

            // Seeding Specializations
            var specializations = new List<Specialization>();
            for (int i = 1; i <= 10; i++)
            {
                specializations.Add(new Specialization
                {
                    Id = Guid.NewGuid(),
                    NameAr = $"تخصص الذكاء الاصطناعي {i}",
                    NameEn = $"Artificial Intelligence Specialization {i}",
                    DepartmentId = departments[i - 1].Id,
                    LookUpStatus = LookUpStatus.Active

                });
            }
            modelBuilder.Entity<Specialization>().HasData(specializations);

            // Seeding Roles
            var roles = new List<Role>
            {
                new Role { Id = Guid.NewGuid(), Name = "Admin" },
                new Role { Id = Guid.NewGuid(), Name = "Instructor" },
                new Role { Id = Guid.NewGuid(), Name = "Student" },
                new Role { Id = Guid.NewGuid(), Name = "DashboardUser" }
            };
            modelBuilder.Entity<Role>().HasData(roles);

            // Seeding Permissions
            var permissions = new List<Permission>
            {
                new Permission("Create", "Courses"),
                new Permission("Edit", "Courses"),
                new Permission("Delete", "Courses"),
                new Permission("View", "Users"),
                new Permission("Manage", "Dashboard")
            };
            modelBuilder.Entity<Permission>().HasData(permissions);

            // Seeding Users (Instructors, Students, Dashboard Users)
            var users = new List<User>();

            // Some instructors only have university and department
            for (int i = 1; i <= 5; i++) // Seeding 5 instructors with only university and department
            {
                users.Add(new User(
                    Guid.NewGuid(),
                    $"InstructorFirstName{i}",
                    $"InstructorLastName{i}",
                    $"123456789{i}",
                    $"instructor_univ_dept{i}@example.com",  // Unique email for this type
                    DateTimeOffset.Now,
                    UserStatus.Active,
                    i,
                    universities[i - 1].Id,
                    null, // No faculty
                    departments[i - 1].Id,
                    null, // No specialization
                    UserTypeEnum.Instructor,
                    $"password{i}"
                ));
            }

            // Seeding instructors with full associations (university, faculty, department, and specialization)
            for (int i = 6; i <= 10; i++) // Seeding 5 instructors with full associations
            {
                users.Add(new User(
                    Guid.NewGuid(),
                    $"InstructorFirstName{i}",
                    $"InstructorLastName{i}",
                    $"123456789{i}",
                    $"instructor_full{i}@example.com",  // Unique email for this type
                    DateTimeOffset.Now,
                    UserStatus.Active,
                    i,
                    universities[i - 1].Id,
                    faculties[i - 1].Id,
                    departments[i - 1].Id,
                    specializations[i - 1].Id,
                    UserTypeEnum.Instructor,
                    $"password{i}"
                ));
            }

            // Seeding Students and Dashboard Users (similar as before)
            // Seeding Students
            for (int i = 1; i <= 10; i++)
            {
                users.Add(new User(
                    Guid.NewGuid(),
                    $"StudentFirstName{i}",
                    $"StudentLastName{i}",
                    $"123456789{i + 10}",
                    $"student{i}@example.com",  // Unique email for students
                    DateTimeOffset.Now,
                    UserStatus.Active,
                    i,  // Country ID
                    universities[i - 1].Id,  // Each student belongs to a university
                    null, // No faculty
                    null, // No department
                    null, // No specialization
                    UserTypeEnum.Student,
                    $"password{i + 10}"
                )
                {
                    // Set AcademicYear and StudyLevel for each student
                    AcademicYear = $"Year {i}",     // Example: Year 1, Year 2, etc.
                    StudyLevel = $"Level {i}"       // Example: Level 1, Level 2, etc.
                });
            }


            // Seeding Dashboard Users
            for (int i = 1; i <= 10; i++)
            {
                users.Add(new User(
                    Guid.NewGuid(),
                    $"DashBoardUserFirstName{i}",
                    $"DashBoardUserLastName{i}",
                    $"123456789{i + 20}",
                    $"dashboarduser{i}@example.com",  // Unique email for dashboard users
                    DateTimeOffset.Now,
                    UserStatus.Active,
                    null,
                    null,  // No university, faculty, department, or specialization
                    null,
                    null,
                    null,
                    UserTypeEnum.DashboardUser,
                    $"password{i + 20}"
                ));
            }
            modelBuilder.Entity<User>().HasData(users);

            // Seeding Courses
            var courses = new List<Course>();
            for (int i = 1; i <= 10; i++)
            {
                var course = new Course
                {
                    Id = Guid.NewGuid(),
                    NameAr = $"دورة {i}",
                    NameEn = $"Course {i}",
                    DiscriptionAr = $"دورة {i} لتعليم الموضوع",
                    DiscriptionEn = $"Course {i} for learning the subject",
                    CategoryId = categories[i % categories.Count].Id,
                    TopicId = topics[i % topics.Count].Id,
                    CoverPhoto = $"{baseImageUrl}course6.jpg"
                };

                courses.Add(course);

                // Linking courses to universities, faculties, departments, and specializations
                foreach (var university in universities)
                {
                    modelBuilder.Entity("CourseUniversity").HasData(new { CoursesId = course.Id, UniversitiesId = university.Id });
                }

                foreach (var faculty in faculties)
                {
                    modelBuilder.Entity("CourseFaculty").HasData(new { CoursesId = course.Id, FacultiesId = faculty.Id });
                }

                foreach (var department in departments)
                {
                    modelBuilder.Entity("CourseDepartment").HasData(new { CoursesId = course.Id, DepartmentsId = department.Id });
                }

                foreach (var specialization in specializations)
                {
                    modelBuilder.Entity("CourseSpecialization").HasData(new { CoursesId = course.Id, SpecializationsId = specialization.Id });
                }
            }
            modelBuilder.Entity<Course>().HasData(courses);

            // Seeding User Interests (Many-to-Many relationship between Users and Courses)
            var userInterests = new List<UserInterstes>();
            for (int i = 0; i < 10; i++) // Link 10 instructors with different courses
            {
                userInterests.Add(new UserInterstes
                {
                    Id = i + 1,
                    UserId = users[i].Id, // Instructor IDs
                    CategoryId = categories[i % categories.Count].Id // Different courses for different instructors
                });
            }
            modelBuilder.Entity<UserInterstes>().HasData(userInterests);
            // Seeding sections, lessons, quizzes, and questions
            var sections = new List<Section>();
            var lessons = new List<Lesson>();
            var quizzes = new List<Quiz>();
            var questions = new List<Question>();

            foreach (var course in courses)
            {
                // Seeding sections for each course
                for (int sectionIndex = 1; sectionIndex <= 3; sectionIndex++) // 3 sections per course
                {
                    var section = new Section
                    {
                        Id = Guid.NewGuid(),
                        TitleAr = $"الفصل {sectionIndex} في {course.NameAr}",
                        TitleEn = $"Section {sectionIndex} in {course.NameEn}",
                        CourseId = course.Id
                    };
                    sections.Add(section);

                    // Seeding lessons for each section
                    for (int lessonIndex = 1; lessonIndex <= 3; lessonIndex++) // 3 lessons per section
                    {
                        lessons.Add(new Lesson
                        {
                            Id = Guid.NewGuid(),
                            NameAr = $"درس {lessonIndex} في {section.TitleAr}",
                            NameEn = $"Lesson {lessonIndex} in {section.TitleEn}",
                            DescriptionAr = $"This is the description for Lesson {lessonIndex}.",
                            //ResourceUrl = $"https://example.com/resources/{lessonIndex}",
                            CreationDate = DateTime.Now,
                            HasCodeEditor = lessonIndex % 2 == 0, // Every second lesson has a code editor
                            //VideoUrl = $"https://example.com/videos/lesson-{lessonIndex}.mp4",
                            //VideoDuration = TimeSpan.FromMinutes(10 * lessonIndex),
                            SectionId = section.Id
                        });
                    }

                    // Seeding quizzes for each section
                    for (int quizIndex = 1; quizIndex <= 2; quizIndex++) // 2 quizzes per section
                    {
                        var quiz = new Quiz
                        {
                            Id = Guid.NewGuid(),
                            Name = $"Quiz {quizIndex} for {section.TitleEn}",
                            SectionId = section.Id,
                            QuizType = QuizType.MultipleChoice
                        };
                        quizzes.Add(quiz);

                        // Seeding questions for each quiz
                        for (int questionIndex = 1; questionIndex <= 3; questionIndex++) // 3 questions per quiz
                        {
                            questions.Add(new Question
                            {
                                Id = Guid.NewGuid(),
                                QuestionText = $"Question {questionIndex} for {quiz.Name}",
                                QuestionType = QuestionType.MultipleChoice,
                                OptionsJson = JsonSerializer.Serialize(new List<string> { "Option 1", "Option 2", "Option 3", "Option 4" }),
                                CorrectAnswersJson = JsonSerializer.Serialize(new List<string> { "Option 1", "Option 2" }),
                                QuizId = quiz.Id
                            });
                        }
                    }
                }
            }

            // Adding the seeded data to the ModelBuilder
            modelBuilder.Entity<Section>().HasData(sections);
            modelBuilder.Entity<Lesson>().HasData(lessons);
            modelBuilder.Entity<Quiz>().HasData(quizzes);
            modelBuilder.Entity<Question>().HasData(questions);
            // Seeding RolePermissions (Many-to-Many relationship between Roles and Permissions)
            var rolePermissions = new List<RolePermission>
            {
                new RolePermission { RoleId = roles[0].Id, PermissionId = permissions[0].Id },
                new RolePermission { RoleId = roles[0].Id, PermissionId = permissions[1].Id },
                new RolePermission { RoleId = roles[0].Id, PermissionId = permissions[2].Id },
                new RolePermission { RoleId = roles[0].Id, PermissionId = permissions[3].Id },
                new RolePermission { RoleId = roles[0].Id, PermissionId = permissions[4].Id },

                new RolePermission { RoleId = roles[1].Id, PermissionId = permissions[0].Id },
                new RolePermission { RoleId = roles[1].Id, PermissionId = permissions[1].Id },
                new RolePermission { RoleId = roles[1].Id, PermissionId = permissions[2].Id },

                new RolePermission { RoleId = roles[3].Id, PermissionId = permissions[3].Id },
                new RolePermission { RoleId = roles[3].Id, PermissionId = permissions[4].Id }
            };
            modelBuilder.Entity<RolePermission>().HasData(rolePermissions);
            // Seed Courses

        }
    }
}
