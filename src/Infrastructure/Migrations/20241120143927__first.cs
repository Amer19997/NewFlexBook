using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlexBook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicIntegrities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderTitleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderTitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderDescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderDescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicIntegrities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccessCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorizingTeamMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstNameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FirstNameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastNameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastNameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DescriptionAr = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizingTeamMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstructorCourseOverrides",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstructorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LessonPartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QuizId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InteractiveElementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomLessonDescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomLessonDescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomTitleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomTitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomLessonPartContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HideSection = table.Column<bool>(type: "bit", nullable: true),
                    HideLesson = table.Column<bool>(type: "bit", nullable: true),
                    HideLessonPart = table.Column<bool>(type: "bit", nullable: true),
                    HideFile = table.Column<bool>(type: "bit", nullable: true),
                    HideCodeEditor = table.Column<bool>(type: "bit", nullable: true),
                    HideInteractiveElement = table.Column<bool>(type: "bit", nullable: true),
                    HideQuiz = table.Column<bool>(type: "bit", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorCourseOverrides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterestsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestsList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Resource = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResearchEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChartImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchEntries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentSuccessStories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UniversityNameAr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UniversityNameEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSuccessStories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LookUpStatus = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Universities_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoverPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LookUpStatus = table.Column<int>(type: "int", nullable: false),
                    UniversityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faculty_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DiscriptionAr = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DiscriptionEn = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoverPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TopicId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LookUpStatus = table.Column<int>(type: "int", nullable: false),
                    FacultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FacultyCourses",
                columns: table => new
                {
                    CoursesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacultiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultyCourses", x => new { x.CoursesId, x.FacultiesId });
                    table.ForeignKey(
                        name: "FK_FacultyCourses_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacultyCourses_Faculty_FacultiesId",
                        column: x => x.FacultiesId,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UniversityCourses",
                columns: table => new
                {
                    CoursesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UniversitiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityCourses", x => new { x.CoursesId, x.UniversitiesId });
                    table.ForeignKey(
                        name: "FK_UniversityCourses_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UniversityCourses_Universities_UniversitiesId",
                        column: x => x.UniversitiesId,
                        principalTable: "Universities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentCourses",
                columns: table => new
                {
                    CoursesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentCourses", x => new { x.CoursesId, x.DepartmentsId });
                    table.ForeignKey(
                        name: "FK_DepartmentCourses_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentCourses_Department_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LookUpStatus = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specializations_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TitleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resources = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasCodeEditor = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodeEditorLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeEditorInitialCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecializationCourses",
                columns: table => new
                {
                    CoursesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecializationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecializationCourses", x => new { x.CoursesId, x.SpecializationsId });
                    table.ForeignKey(
                        name: "FK_SpecializationCourses_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecializationCourses_Specializations_SpecializationsId",
                        column: x => x.SpecializationsId,
                        principalTable: "Specializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastModifiedStatus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegisterAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsSuperAdmin = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    UniversityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FacultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SpecializationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AcademicYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Universities_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "Universities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LessonParts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartNumber = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonParts_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QuizType = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quizzes_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Quizzes_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstructorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Syllabus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Classes_Users_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstructorCourses",
                columns: table => new
                {
                    InstructorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorCourses", x => new { x.InstructorId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_InstructorCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstructorCourses_Users_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAvailableCourses",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAvailableCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentAvailableCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAvailableCourses_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCourses",
                columns: table => new
                {
                    CoursesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstructorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCourses", x => new { x.CoursesId, x.InstructorsId });
                    table.ForeignKey(
                        name: "FK_UserCourses_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCourses_Users_InstructorsId",
                        column: x => x.InstructorsId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInterstes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InterestsListId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInterstes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInterstes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInterstes_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserInterstes_InterestsList_InterestsListId",
                        column: x => x.InterestsListId,
                        principalTable: "InterestsList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserInterstes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InteractiveElements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ElementNumber = table.Column<int>(type: "int", nullable: false),
                    ZipUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    LessonPartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InteractiveElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InteractiveElements_LessonParts_LessonPartId",
                        column: x => x.LessonPartId,
                        principalTable: "LessonParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionType = table.Column<int>(type: "int", nullable: false),
                    OptionsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectAnswersJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Options = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectAnswers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatchingPairsJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatchingPairs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuizId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassRequests_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassRequests_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassStudents",
                columns: table => new
                {
                    ClassesEnrolledId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassStudents", x => new { x.ClassesEnrolledId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_ClassStudents_Classes_ClassesEnrolledId",
                        column: x => x.ClassesEnrolledId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassStudents_Users_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "IsActive", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, false, "الولايات المتحدة", "United States" },
                    { 2, false, "المملكة المتحدة", "United Kingdom" },
                    { 3, false, "كندا", "Canada" },
                    { 4, false, "أستراليا", "Australia" },
                    { 5, false, "الهند", "India" },
                    { 6, false, "ألمانيا", "Germany" },
                    { 7, false, "البرازيل", "Brazil" },
                    { 8, false, "اليابان", "Japan" },
                    { 9, false, "فرنسا", "France" },
                    { 10, false, "الإمارات العربية المتحدة", "United Arab Emirates" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Action", "Name", "Resource" },
                values: new object[,]
                {
                    { new Guid("0df1b8c1-b48e-4578-8b00-fe85b6339d78"), "Create", "createcourses", "Courses" },
                    { new Guid("2a935c92-870b-4724-8bc0-870f0ac64e8d"), "Manage", "managedashboard", "Dashboard" },
                    { new Guid("2b5fcaf1-b71b-482b-b58a-c82dfe673410"), "Edit", "editcourses", "Courses" },
                    { new Guid("cbc954ce-9837-48ad-bf80-6700cdf00b0c"), "Delete", "deletecourses", "Courses" },
                    { new Guid("dec54250-142c-455e-ba9a-72cbf317e23d"), "View", "viewusers", "Users" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1a7ff869-9983-46e1-8cee-b0718dc5a7b3"), "Admin" },
                    { new Guid("76961ba4-289a-4df1-81ad-30425c35b228"), "Instructor" },
                    { new Guid("e2db0992-ac0f-415a-8fad-6125c3a9d8ee"), "Student" },
                    { new Guid("f7713714-6cb3-45e4-9ee2-fded40c1c113"), "DashboardUser" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "IsActive", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("1781862c-ac1f-4352-b015-e9c78135d00c"), false, "البرمجة", "Programming" },
                    { new Guid("23f1016d-c184-44fc-87ca-2b6492d0f757"), false, "أمن المعلومات", "Information Security" },
                    { new Guid("5b4b4a2d-25a0-4739-a273-b92892ec0da7"), false, "تحليل البيانات", "Data Analysis" },
                    { new Guid("8de114c5-3bc2-4e78-a0eb-2484075a2550"), false, "الذكاء الاصطناعي", "Artificial Intelligence" },
                    { new Guid("bf9b6683-a2ae-449f-82ba-f16d21a62953"), false, "هندسة البرمجيات", "Software Engineering" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AcademicYear", "CountryId", "Created", "CreatedBy", "DepartmentId", "Email", "FacultyId", "FirstName", "LastModified", "LastModifiedBy", "LastModifiedStatus", "LastName", "MobileNumber", "Password", "RegisterAt", "RoleId", "SpecializationId", "Status", "StudyLevel", "UniversityId", "UserType" },
                values: new object[,]
                {
                    { new Guid("13f85501-5ba7-4730-a923-83c476c16c3e"), null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1219), null, null, "dashboarduser9@example.com", null, "DashBoardUserFirstName9", null, null, null, "DashBoardUserLastName9", "12345678929", "password29", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1214), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("1ba139a6-49c9-4dd7-8456-7433d99d1296"), null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1173), null, null, "dashboarduser5@example.com", null, "DashBoardUserFirstName5", null, null, null, "DashBoardUserLastName5", "12345678925", "password25", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1146), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("244e8b2d-ba79-47cf-a86b-92781a6ba867"), null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1209), null, null, "dashboarduser8@example.com", null, "DashBoardUserFirstName8", null, null, null, "DashBoardUserLastName8", "12345678928", "password28", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1203), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("334e56b7-b26c-4fb0-8d3c-f5c5b4471ddf"), null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1255), null, null, "dashboarduser10@example.com", null, "DashBoardUserFirstName10", null, null, null, "DashBoardUserLastName10", "12345678930", "password30", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1226), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("4ebef1ff-8ab9-45ee-b780-8f9ad9be3032"), null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1184), null, null, "dashboarduser6@example.com", null, "DashBoardUserFirstName6", null, null, null, "DashBoardUserLastName6", "12345678926", "password26", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1179), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("5f3ad551-da27-4a8a-a377-c67267e1e0f6"), null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1112), null, null, "dashboarduser2@example.com", null, "DashBoardUserFirstName2", null, null, null, "DashBoardUserLastName2", "12345678922", "password22", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1107), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("7db42ab1-d649-4b0a-8a04-d0493c6be222"), null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1123), null, null, "dashboarduser3@example.com", null, "DashBoardUserFirstName3", null, null, null, "DashBoardUserLastName3", "12345678923", "password23", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1118), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("88b16744-a5e3-45e6-9ae6-8e980be0d539"), null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1134), null, null, "dashboarduser4@example.com", null, "DashBoardUserFirstName4", null, null, null, "DashBoardUserLastName4", "12345678924", "password24", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1130), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("a408fd07-57e5-4c64-91d1-22ce7877c89a"), null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1195), null, null, "dashboarduser7@example.com", null, "DashBoardUserFirstName7", null, null, null, "DashBoardUserLastName7", "12345678927", "password27", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("c9c6bfe6-fc3e-4124-ae6e-b69663cf60b2"), null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1099), null, null, "dashboarduser1@example.com", null, "DashBoardUserFirstName1", null, null, null, "DashBoardUserLastName1", "12345678921", "password21", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1050), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CoverPhoto", "IsActive", "NameAr", "NameEn", "TopicId" },
                values: new object[,]
                {
                    { new Guid("2b3a8cd9-33eb-4b8e-a971-b3ced41fc952"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 2 في أمن المعلومات", "Category 2 in Information Security", new Guid("23f1016d-c184-44fc-87ca-2b6492d0f757") },
                    { new Guid("30ddcf91-ee89-43de-988a-b8885ce9889c"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 2 في الذكاء الاصطناعي", "Category 2 in Artificial Intelligence", new Guid("8de114c5-3bc2-4e78-a0eb-2484075a2550") },
                    { new Guid("416a7a0a-8fe5-40ee-bcf2-52bee7e59344"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 1 في أمن المعلومات", "Category 1 in Information Security", new Guid("23f1016d-c184-44fc-87ca-2b6492d0f757") },
                    { new Guid("4ff3c47d-cbba-4caa-9b4a-c77385200763"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 2 في البرمجة", "Category 2 in Programming", new Guid("1781862c-ac1f-4352-b015-e9c78135d00c") },
                    { new Guid("5ea27783-866c-4a60-994b-e4ec07efeca3"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 1 في الذكاء الاصطناعي", "Category 1 in Artificial Intelligence", new Guid("8de114c5-3bc2-4e78-a0eb-2484075a2550") },
                    { new Guid("6f239e6e-8dfc-4e19-8392-8284c4f67825"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 2 في هندسة البرمجيات", "Category 2 in Software Engineering", new Guid("bf9b6683-a2ae-449f-82ba-f16d21a62953") },
                    { new Guid("74592176-ab98-482e-8f97-f78e77a22053"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 1 في تحليل البيانات", "Category 1 in Data Analysis", new Guid("5b4b4a2d-25a0-4739-a273-b92892ec0da7") },
                    { new Guid("79d717b2-2728-4f55-b05c-423650980479"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 3 في تحليل البيانات", "Category 3 in Data Analysis", new Guid("5b4b4a2d-25a0-4739-a273-b92892ec0da7") },
                    { new Guid("a10ae102-35bd-47b8-84ac-8ee526daa3a3"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 3 في البرمجة", "Category 3 in Programming", new Guid("1781862c-ac1f-4352-b015-e9c78135d00c") },
                    { new Guid("ab847495-0b58-4a26-ab79-fe44f23cb73a"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 2 في تحليل البيانات", "Category 2 in Data Analysis", new Guid("5b4b4a2d-25a0-4739-a273-b92892ec0da7") },
                    { new Guid("adb27ad2-341b-4e8d-8b74-87df756f35b4"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 1 في هندسة البرمجيات", "Category 1 in Software Engineering", new Guid("bf9b6683-a2ae-449f-82ba-f16d21a62953") },
                    { new Guid("b103d1c6-8672-4228-b406-73ee1c3d3cd0"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 3 في أمن المعلومات", "Category 3 in Information Security", new Guid("23f1016d-c184-44fc-87ca-2b6492d0f757") },
                    { new Guid("bc9e8701-dfd3-49b6-8d6a-022e6148a612"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 1 في البرمجة", "Category 1 in Programming", new Guid("1781862c-ac1f-4352-b015-e9c78135d00c") },
                    { new Guid("bd4b0c66-08ab-4b92-93a2-5714d49b6cd6"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 3 في الذكاء الاصطناعي", "Category 3 in Artificial Intelligence", new Guid("8de114c5-3bc2-4e78-a0eb-2484075a2550") },
                    { new Guid("ecdeab71-5c44-4169-9b2b-7b4b0995cb22"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 3 في هندسة البرمجيات", "Category 3 in Software Engineering", new Guid("bf9b6683-a2ae-449f-82ba-f16d21a62953") }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0df1b8c1-b48e-4578-8b00-fe85b6339d78"), new Guid("1a7ff869-9983-46e1-8cee-b0718dc5a7b3") },
                    { new Guid("2a935c92-870b-4724-8bc0-870f0ac64e8d"), new Guid("1a7ff869-9983-46e1-8cee-b0718dc5a7b3") },
                    { new Guid("2b5fcaf1-b71b-482b-b58a-c82dfe673410"), new Guid("1a7ff869-9983-46e1-8cee-b0718dc5a7b3") },
                    { new Guid("cbc954ce-9837-48ad-bf80-6700cdf00b0c"), new Guid("1a7ff869-9983-46e1-8cee-b0718dc5a7b3") },
                    { new Guid("dec54250-142c-455e-ba9a-72cbf317e23d"), new Guid("1a7ff869-9983-46e1-8cee-b0718dc5a7b3") },
                    { new Guid("0df1b8c1-b48e-4578-8b00-fe85b6339d78"), new Guid("76961ba4-289a-4df1-81ad-30425c35b228") },
                    { new Guid("2b5fcaf1-b71b-482b-b58a-c82dfe673410"), new Guid("76961ba4-289a-4df1-81ad-30425c35b228") },
                    { new Guid("cbc954ce-9837-48ad-bf80-6700cdf00b0c"), new Guid("76961ba4-289a-4df1-81ad-30425c35b228") },
                    { new Guid("2a935c92-870b-4724-8bc0-870f0ac64e8d"), new Guid("f7713714-6cb3-45e4-9ee2-fded40c1c113") },
                    { new Guid("dec54250-142c-455e-ba9a-72cbf317e23d"), new Guid("f7713714-6cb3-45e4-9ee2-fded40c1c113") }
                });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "CountryId", "IsActive", "LookUpStatus", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e"), 5, false, 2, "جامعة الهند", "University of India" },
                    { new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb"), 2, false, 2, "جامعة المملكة المتحدة", "University of United Kingdom" },
                    { new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5"), 7, false, 2, "جامعة البرازيل", "University of Brazil" },
                    { new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0"), 4, false, 2, "جامعة أستراليا", "University of Australia" },
                    { new Guid("808e2de7-1b11-4bf7-b623-7086847fadea"), 8, false, 2, "جامعة اليابان", "University of Japan" },
                    { new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f"), 3, false, 2, "جامعة كندا", "University of Canada" },
                    { new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a"), 9, false, 2, "جامعة فرنسا", "University of France" },
                    { new Guid("b02b142e-63da-467d-bb42-f811de15a2f1"), 10, false, 2, "جامعة الإمارات العربية المتحدة", "University of United Arab Emirates" },
                    { new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a"), 6, false, 2, "جامعة ألمانيا", "University of Germany" },
                    { new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d"), 1, false, 2, "جامعة الولايات المتحدة", "University of United States" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Code", "CoverPhoto", "DiscriptionAr", "DiscriptionEn", "IsActive", "NameAr", "NameEn", "TopicId" },
                values: new object[,]
                {
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("5ea27783-866c-4a60-994b-e4ec07efeca3"), null, "https://localhost:7030/images/course6.jpg", "دورة 6 لتعليم الموضوع", "Course 6 for learning the subject", false, "دورة 6", "Course 6", new Guid("5b4b4a2d-25a0-4739-a273-b92892ec0da7") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("74592176-ab98-482e-8f97-f78e77a22053"), null, "https://localhost:7030/images/course6.jpg", "دورة 3 لتعليم الموضوع", "Course 3 for learning the subject", false, "دورة 3", "Course 3", new Guid("23f1016d-c184-44fc-87ca-2b6492d0f757") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("4ff3c47d-cbba-4caa-9b4a-c77385200763"), null, "https://localhost:7030/images/course6.jpg", "دورة 1 لتعليم الموضوع", "Course 1 for learning the subject", false, "دورة 1", "Course 1", new Guid("5b4b4a2d-25a0-4739-a273-b92892ec0da7") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("a10ae102-35bd-47b8-84ac-8ee526daa3a3"), null, "https://localhost:7030/images/course6.jpg", "دورة 2 لتعليم الموضوع", "Course 2 for learning the subject", false, "دورة 2", "Course 2", new Guid("8de114c5-3bc2-4e78-a0eb-2484075a2550") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("ab847495-0b58-4a26-ab79-fe44f23cb73a"), null, "https://localhost:7030/images/course6.jpg", "دورة 4 لتعليم الموضوع", "Course 4 for learning the subject", false, "دورة 4", "Course 4", new Guid("bf9b6683-a2ae-449f-82ba-f16d21a62953") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("30ddcf91-ee89-43de-988a-b8885ce9889c"), null, "https://localhost:7030/images/course6.jpg", "دورة 7 لتعليم الموضوع", "Course 7 for learning the subject", false, "دورة 7", "Course 7", new Guid("8de114c5-3bc2-4e78-a0eb-2484075a2550") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("2b3a8cd9-33eb-4b8e-a971-b3ced41fc952"), null, "https://localhost:7030/images/course6.jpg", "دورة 10 لتعليم الموضوع", "Course 10 for learning the subject", false, "دورة 10", "Course 10", new Guid("1781862c-ac1f-4352-b015-e9c78135d00c") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("bd4b0c66-08ab-4b92-93a2-5714d49b6cd6"), null, "https://localhost:7030/images/course6.jpg", "دورة 8 لتعليم الموضوع", "Course 8 for learning the subject", false, "دورة 8", "Course 8", new Guid("23f1016d-c184-44fc-87ca-2b6492d0f757") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("79d717b2-2728-4f55-b05c-423650980479"), null, "https://localhost:7030/images/course6.jpg", "دورة 5 لتعليم الموضوع", "Course 5 for learning the subject", false, "دورة 5", "Course 5", new Guid("1781862c-ac1f-4352-b015-e9c78135d00c") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("416a7a0a-8fe5-40ee-bcf2-52bee7e59344"), null, "https://localhost:7030/images/course6.jpg", "دورة 9 لتعليم الموضوع", "Course 9 for learning the subject", false, "دورة 9", "Course 9", new Guid("bf9b6683-a2ae-449f-82ba-f16d21a62953") }
                });

            migrationBuilder.InsertData(
                table: "Faculty",
                columns: new[] { "Id", "IsActive", "LookUpStatus", "NameAr", "NameEn", "UniversityId" },
                values: new object[,]
                {
                    { new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f"), false, 2, "كلية الهندسة 4", "Engineering Faculty 4", new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") },
                    { new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae"), false, 2, "كلية الهندسة 2", "Engineering Faculty 2", new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") },
                    { new Guid("3d534569-ac30-4b29-beb6-befc4087fb17"), false, 2, "كلية الهندسة 7", "Engineering Faculty 7", new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") },
                    { new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934"), false, 2, "كلية الهندسة 10", "Engineering Faculty 10", new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") },
                    { new Guid("51079a63-f613-4ceb-becb-a9bc39d91570"), false, 2, "كلية الهندسة 3", "Engineering Faculty 3", new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") },
                    { new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d"), false, 2, "كلية الهندسة 1", "Engineering Faculty 1", new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") },
                    { new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc"), false, 2, "كلية الهندسة 6", "Engineering Faculty 6", new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") },
                    { new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0"), false, 2, "كلية الهندسة 9", "Engineering Faculty 9", new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") },
                    { new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524"), false, 2, "كلية الهندسة 5", "Engineering Faculty 5", new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") },
                    { new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96"), false, 2, "كلية الهندسة 8", "Engineering Faculty 8", new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AcademicYear", "CountryId", "Created", "CreatedBy", "DepartmentId", "Email", "FacultyId", "FirstName", "LastModified", "LastModifiedBy", "LastModifiedStatus", "LastName", "MobileNumber", "Password", "RegisterAt", "RoleId", "SpecializationId", "Status", "StudyLevel", "UniversityId", "UserType" },
                values: new object[,]
                {
                    { new Guid("3b7de2d7-0c4c-4009-9dfa-6b87dfea7e70"), "Year 7", 7, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(996), null, null, "student7@example.com", null, "StudentFirstName7", null, null, null, "StudentLastName7", "12345678917", "password17", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(990), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 7", new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5"), 1 },
                    { new Guid("3dde0e9b-8793-4917-92e3-ff9721b38732"), "Year 5", 5, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(964), null, null, "student5@example.com", null, "StudentFirstName5", null, null, null, "StudentLastName5", "12345678915", "password15", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(956), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 5", new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e"), 1 },
                    { new Guid("978258fc-943a-43fc-9583-2391a80317cc"), "Year 4", 4, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(948), null, null, "student4@example.com", null, "StudentFirstName4", null, null, null, "StudentLastName4", "12345678914", "password14", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(943), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 4", new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0"), 1 },
                    { new Guid("b04a16d6-f40a-4452-9f74-e78cec196cb3"), "Year 10", 10, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1039), null, null, "student10@example.com", null, "StudentFirstName10", null, null, null, "StudentLastName10", "12345678920", "password20", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1034), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 10", new Guid("b02b142e-63da-467d-bb42-f811de15a2f1"), 1 },
                    { new Guid("c11e9462-6774-47b2-a47f-3f56d7705b36"), "Year 6", 6, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(983), null, null, "student6@example.com", null, "StudentFirstName6", null, null, null, "StudentLastName6", "12345678916", "password16", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(977), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 6", new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a"), 1 },
                    { new Guid("d09c55cd-68d1-46ec-a2da-a612b65d1fde"), "Year 9", 9, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1023), null, null, "student9@example.com", null, "StudentFirstName9", null, null, null, "StudentLastName9", "12345678919", "password19", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 9", new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a"), 1 },
                    { new Guid("d4e4badc-a12f-4374-9b13-b47ab46ad6bb"), "Year 2", 2, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(875), null, null, "student2@example.com", null, "StudentFirstName2", null, null, null, "StudentLastName2", "12345678912", "password12", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(870), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 2", new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb"), 1 },
                    { new Guid("e30e4217-f605-4dc5-a2ed-c18544f3114a"), "Year 3", 3, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(935), null, null, "student3@example.com", null, "StudentFirstName3", null, null, null, "StudentLastName3", "12345678913", "password13", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(929), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 3", new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f"), 1 },
                    { new Guid("e68e19f8-2e1d-4652-a5b1-5117f595b0a3"), "Year 8", 8, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(1010), null, null, "student8@example.com", null, "StudentFirstName8", null, null, null, "StudentLastName8", "12345678918", "password18", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(1005), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 8", new Guid("808e2de7-1b11-4bf7-b623-7086847fadea"), 1 },
                    { new Guid("f2446225-a4c5-4287-9f9b-fae8577733e1"), "Year 1", 1, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(857), null, null, "student1@example.com", null, "StudentFirstName1", null, null, null, "StudentLastName1", "12345678911", "password11", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(850), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 1", new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "FacultyId", "IsActive", "LookUpStatus", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0"), false, 2, "قسم الحاسوب 9", "Computer Science Department 9" },
                    { new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934"), false, 2, "قسم الحاسوب 10", "Computer Science Department 10" },
                    { new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17"), false, 2, "قسم الحاسوب 7", "Computer Science Department 7" },
                    { new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d"), false, 2, "قسم الحاسوب 1", "Computer Science Department 1" },
                    { new Guid("a28744e6-541e-4aad-9918-f4b322f33223"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc"), false, 2, "قسم الحاسوب 6", "Computer Science Department 6" },
                    { new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524"), false, 2, "قسم الحاسوب 5", "Computer Science Department 5" },
                    { new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570"), false, 2, "قسم الحاسوب 3", "Computer Science Department 3" },
                    { new Guid("c7855715-481d-4509-acad-86cb46907dc2"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96"), false, 2, "قسم الحاسوب 8", "Computer Science Department 8" },
                    { new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae"), false, 2, "قسم الحاسوب 2", "Computer Science Department 2" },
                    { new Guid("d94b5445-7088-4897-ab8a-2838d7652341"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f"), false, 2, "قسم الحاسوب 4", "Computer Science Department 4" }
                });

            migrationBuilder.InsertData(
                table: "FacultyCourses",
                columns: new[] { "CoursesId", "FacultiesId" },
                values: new object[,]
                {
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "CourseId", "IsActive", "TitleAr", "TitleEn" },
                values: new object[,]
                {
                    { new Guid("056688fa-94cf-42f2-a54d-70f3054626c9"), new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), false, "الفصل 3 في دورة 2", "Section 3 in Course 2" },
                    { new Guid("062020d3-9299-4e74-bf84-8bfb82503065"), new Guid("2838009c-a115-418a-8b23-f916911955ad"), false, "الفصل 2 في دورة 3", "Section 2 in Course 3" },
                    { new Guid("0e109ec5-ee7a-4681-aa91-c752483b4174"), new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), false, "الفصل 1 في دورة 1", "Section 1 in Course 1" },
                    { new Guid("0e46e441-b493-47bb-a708-15c7415cd954"), new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), false, "الفصل 3 في دورة 1", "Section 3 in Course 1" },
                    { new Guid("0fb9c271-b4df-4892-b5b6-65f33d0e5fb7"), new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), false, "الفصل 3 في دورة 9", "Section 3 in Course 9" },
                    { new Guid("1fb1c633-7b55-481a-8595-f7b146b58e5f"), new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), false, "الفصل 2 في دورة 7", "Section 2 in Course 7" },
                    { new Guid("2e484020-d62b-446f-871d-2c3b91009715"), new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), false, "الفصل 2 في دورة 5", "Section 2 in Course 5" },
                    { new Guid("33cc1d8c-6d9d-40a9-80bd-520fab88d002"), new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), false, "الفصل 1 في دورة 2", "Section 1 in Course 2" },
                    { new Guid("3424389a-d575-4fff-912f-21d1d451bd56"), new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), false, "الفصل 3 في دورة 10", "Section 3 in Course 10" },
                    { new Guid("3aab9bb8-879a-44d9-9442-0b591ac536a9"), new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), false, "الفصل 1 في دورة 10", "Section 1 in Course 10" },
                    { new Guid("499de49d-e97d-4dac-b770-d608a0be1593"), new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), false, "الفصل 1 في دورة 8", "Section 1 in Course 8" },
                    { new Guid("54a2ab76-ceaf-41f4-9e3f-12720e3a3fc2"), new Guid("8166108b-f853-415a-8388-5c4534377d68"), false, "الفصل 3 في دورة 4", "Section 3 in Course 4" },
                    { new Guid("58122722-4219-4692-97cf-7b60eae672d2"), new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), false, "الفصل 3 في دورة 7", "Section 3 in Course 7" },
                    { new Guid("5d91597a-5b9e-42c5-8877-d59269a01ef3"), new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), false, "الفصل 1 في دورة 9", "Section 1 in Course 9" },
                    { new Guid("5e10d718-8807-4a88-9494-d92b16c8541d"), new Guid("2838009c-a115-418a-8b23-f916911955ad"), false, "الفصل 1 في دورة 3", "Section 1 in Course 3" },
                    { new Guid("61c5c878-7754-4ba9-ae4e-3315253fd125"), new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), false, "الفصل 2 في دورة 2", "Section 2 in Course 2" },
                    { new Guid("6a0a5851-f2e8-4834-a567-5e79d05b0baa"), new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), false, "الفصل 1 في دورة 6", "Section 1 in Course 6" },
                    { new Guid("72a5ffe0-2673-4329-a8a5-7a57994f3d63"), new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), false, "الفصل 1 في دورة 7", "Section 1 in Course 7" },
                    { new Guid("7f84caf6-6ae3-4590-a65e-5f2926678bcf"), new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), false, "الفصل 3 في دورة 6", "Section 3 in Course 6" },
                    { new Guid("990a9b94-e3d1-4e56-98d7-fbba69db6073"), new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), false, "الفصل 1 في دورة 5", "Section 1 in Course 5" },
                    { new Guid("ab4c812f-c26a-4dda-8f1f-9d7414505e37"), new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), false, "الفصل 2 في دورة 10", "Section 2 in Course 10" },
                    { new Guid("ac7a5082-8c88-48af-95a9-fe1abe78bf1e"), new Guid("8166108b-f853-415a-8388-5c4534377d68"), false, "الفصل 1 في دورة 4", "Section 1 in Course 4" },
                    { new Guid("b352cd33-b0d5-484e-8bd8-b4c2df8c571c"), new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), false, "الفصل 2 في دورة 1", "Section 2 in Course 1" },
                    { new Guid("b81aac6b-f3bb-4961-9755-020e9d81912e"), new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), false, "الفصل 2 في دورة 6", "Section 2 in Course 6" },
                    { new Guid("bd39fdf2-fd61-42f9-aaf5-eb81c45f4609"), new Guid("2838009c-a115-418a-8b23-f916911955ad"), false, "الفصل 3 في دورة 3", "Section 3 in Course 3" },
                    { new Guid("bdf521a7-72e0-49a9-a631-7e6488160004"), new Guid("8166108b-f853-415a-8388-5c4534377d68"), false, "الفصل 2 في دورة 4", "Section 2 in Course 4" },
                    { new Guid("bfd7416a-4493-4526-83b5-51292dc59566"), new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), false, "الفصل 2 في دورة 9", "Section 2 in Course 9" },
                    { new Guid("e2bd22aa-2ff5-4ec7-a0cb-e016a874621a"), new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), false, "الفصل 3 في دورة 8", "Section 3 in Course 8" },
                    { new Guid("f04d855b-efa8-4932-b88a-cd3bc1f514f0"), new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), false, "الفصل 2 في دورة 8", "Section 2 in Course 8" },
                    { new Guid("f34febee-7825-49f5-94ea-b08d6871fb7b"), new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), false, "الفصل 3 في دورة 5", "Section 3 in Course 5" }
                });

            migrationBuilder.InsertData(
                table: "UniversityCourses",
                columns: new[] { "CoursesId", "UniversitiesId" },
                values: new object[,]
                {
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") }
                });

            migrationBuilder.InsertData(
                table: "DepartmentCourses",
                columns: new[] { "CoursesId", "DepartmentsId" },
                values: new object[,]
                {
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CodeEditorInitialCode", "CodeEditorLanguage", "CoverPhoto", "CreationDate", "DescriptionAr", "DescriptionEn", "HasCodeEditor", "IsActive", "NameAr", "NameEn", "Resources", "SectionId", "TitleAr", "TitleEn" },
                values: new object[,]
                {
                    { new Guid("0f72603c-d267-45e5-a052-5bf91c5e452c"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9667), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 6", "Lesson 2 in Section 2 in Course 6", null, new Guid("b81aac6b-f3bb-4961-9755-020e9d81912e"), null, null },
                    { new Guid("10590ac4-88ec-4b3f-aa58-54f43a98eac0"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(7428), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 3", "Lesson 2 in Section 1 in Course 3", null, new Guid("5e10d718-8807-4a88-9494-d92b16c8541d"), null, null },
                    { new Guid("14150028-52a4-4118-b28c-05dcf0423b38"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(5647), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 1", "Lesson 1 in Section 1 in Course 1", null, new Guid("0e109ec5-ee7a-4681-aa91-c752483b4174"), null, null },
                    { new Guid("145201b2-aa77-447b-aabb-3e8c5c289cde"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9203), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 5", "Lesson 3 in Section 3 in Course 5", null, new Guid("f34febee-7825-49f5-94ea-b08d6871fb7b"), null, null },
                    { new Guid("1615a84b-1c8b-47be-b9cb-f4819287c029"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(343), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 7", "Lesson 3 in Section 2 in Course 7", null, new Guid("1fb1c633-7b55-481a-8595-f7b146b58e5f"), null, null },
                    { new Guid("16f55cc9-4a74-4697-aea2-6f3bb7158ebc"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(7877), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 3", "Lesson 2 in Section 3 in Course 3", null, new Guid("bd39fdf2-fd61-42f9-aaf5-eb81c45f4609"), null, null },
                    { new Guid("184882d3-3bce-4bc5-b2b4-d3aee0591846"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1224), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 8", "Lesson 2 in Section 3 in Course 8", null, new Guid("e2bd22aa-2ff5-4ec7-a0cb-e016a874621a"), null, null },
                    { new Guid("18c754c1-2c99-4b17-847c-ceb64bc6a700"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(6251), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 1", "Lesson 3 in Section 2 in Course 1", null, new Guid("b352cd33-b0d5-484e-8bd8-b4c2df8c571c"), null, null },
                    { new Guid("19911b79-642e-414c-a59d-cc5c04016067"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1011), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 8", "Lesson 3 in Section 2 in Course 8", null, new Guid("f04d855b-efa8-4932-b88a-cd3bc1f514f0"), null, null },
                    { new Guid("1b8b73ce-056a-4ba4-9e28-d7bab86d4faa"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1001), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 8", "Lesson 2 in Section 2 in Course 8", null, new Guid("f04d855b-efa8-4932-b88a-cd3bc1f514f0"), null, null },
                    { new Guid("1bdb141d-37d2-4f75-8cdc-c32abe8209e0"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(5666), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 1", "Lesson 2 in Section 1 in Course 1", null, new Guid("0e109ec5-ee7a-4681-aa91-c752483b4174"), null, null },
                    { new Guid("2091400d-7f7d-4b6b-930c-be59996e593e"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(335), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 7", "Lesson 2 in Section 2 in Course 7", null, new Guid("1fb1c633-7b55-481a-8595-f7b146b58e5f"), null, null },
                    { new Guid("237a1ce0-720b-49d1-b85e-6a7c290c71d5"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9022), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 5", "Lesson 3 in Section 2 in Course 5", null, new Guid("2e484020-d62b-446f-871d-2c3b91009715"), null, null },
                    { new Guid("27641025-5a42-4d38-812e-3e3c57865b27"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8141), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 4", "Lesson 2 in Section 1 in Course 4", null, new Guid("ac7a5082-8c88-48af-95a9-fe1abe78bf1e"), null, null },
                    { new Guid("2a473de6-2f17-4f36-88e6-e71d85fb06c4"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9434), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 6", "Lesson 3 in Section 1 in Course 6", null, new Guid("6a0a5851-f2e8-4834-a567-5e79d05b0baa"), null, null },
                    { new Guid("2ccba897-652c-49d6-af78-5edbe3471fab"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1452), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 9", "Lesson 3 in Section 1 in Course 9", null, new Guid("5d91597a-5b9e-42c5-8877-d59269a01ef3"), null, null },
                    { new Guid("2d900c24-e807-42f3-b758-135d552806c4"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(7239), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 2", "Lesson 2 in Section 3 in Course 2", null, new Guid("056688fa-94cf-42f2-a54d-70f3054626c9"), null, null },
                    { new Guid("2ec49a19-be40-400d-b840-1f2c35bb0469"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9842), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 6", "Lesson 1 in Section 3 in Course 6", null, new Guid("7f84caf6-6ae3-4590-a65e-5f2926678bcf"), null, null },
                    { new Guid("3014c1a6-9fdb-461e-b576-0ca9baeafe56"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(6232), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 1", "Lesson 1 in Section 2 in Course 1", null, new Guid("b352cd33-b0d5-484e-8bd8-b4c2df8c571c"), null, null },
                    { new Guid("327390b5-5540-4834-987c-35d10d537c3f"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(6421), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 1", "Lesson 2 in Section 3 in Course 1", null, new Guid("0e46e441-b493-47bb-a708-15c7415cd954"), null, null },
                    { new Guid("35eca212-e9a0-48ba-87ac-9f56c91f51c3"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(5677), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 1", "Lesson 3 in Section 1 in Course 1", null, new Guid("0e109ec5-ee7a-4681-aa91-c752483b4174"), null, null },
                    { new Guid("390f381a-1d80-4e2a-8b37-77a79d142e16"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(7229), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 2", "Lesson 1 in Section 3 in Course 2", null, new Guid("056688fa-94cf-42f2-a54d-70f3054626c9"), null, null },
                    { new Guid("3976c9ca-1141-40ba-98d5-137f8cdee94d"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(6973), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 2", "Lesson 2 in Section 2 in Course 2", null, new Guid("61c5c878-7754-4ba9-ae4e-3315253fd125"), null, null },
                    { new Guid("3e3cb171-b737-448d-bb36-8d19d1390c64"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(124), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 7", "Lesson 3 in Section 1 in Course 7", null, new Guid("72a5ffe0-2673-4329-a8a5-7a57994f3d63"), null, null },
                    { new Guid("40cc4a50-4b2c-470e-9d80-5ececa1801b6"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(7420), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 3", "Lesson 1 in Section 1 in Course 3", null, new Guid("5e10d718-8807-4a88-9494-d92b16c8541d"), null, null },
                    { new Guid("46fecc8c-23f9-43c2-8be8-9497d80a37c8"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(6748), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 2", "Lesson 2 in Section 1 in Course 2", null, new Guid("33cc1d8c-6d9d-40a9-80bd-520fab88d002"), null, null },
                    { new Guid("49a37e0e-8903-4d62-aa69-0913d0a606f3"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1891), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 9", "Lesson 2 in Section 3 in Course 9", null, new Guid("0fb9c271-b4df-4892-b5b6-65f33d0e5fb7"), null, null },
                    { new Guid("4b6e40b8-8740-419d-a5bd-ba5b60acc5f1"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9595), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 6", "Lesson 1 in Section 2 in Course 6", null, new Guid("b81aac6b-f3bb-4961-9755-020e9d81912e"), null, null },
                    { new Guid("4d152a0f-5689-4445-93ea-785baa165db8"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(105), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 7", "Lesson 1 in Section 1 in Course 7", null, new Guid("72a5ffe0-2673-4329-a8a5-7a57994f3d63"), null, null },
                    { new Guid("518e800e-0b21-4721-8463-24368faa79f7"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(518), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 7", "Lesson 3 in Section 3 in Course 7", null, new Guid("58122722-4219-4692-97cf-7b60eae672d2"), null, null },
                    { new Guid("528811d4-f464-433b-920c-904b25e787c0"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(509), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 7", "Lesson 2 in Section 3 in Course 7", null, new Guid("58122722-4219-4692-97cf-7b60eae672d2"), null, null },
                    { new Guid("52885e9d-3928-4e2d-8b1e-09df431e0879"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9427), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 6", "Lesson 2 in Section 1 in Course 6", null, new Guid("6a0a5851-f2e8-4834-a567-5e79d05b0baa"), null, null },
                    { new Guid("52d9b909-b32f-4594-a94c-e0dd533dd2f1"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8808), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 5", "Lesson 3 in Section 1 in Course 5", null, new Guid("990a9b94-e3d1-4e56-98d7-fbba69db6073"), null, null },
                    { new Guid("52f0a358-e4c5-4baa-b88d-87d765e3bf73"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8789), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 5", "Lesson 1 in Section 1 in Course 5", null, new Guid("990a9b94-e3d1-4e56-98d7-fbba69db6073"), null, null },
                    { new Guid("535ca71f-fe68-41b2-9274-edc6383de524"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8336), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 4", "Lesson 1 in Section 2 in Course 4", null, new Guid("bdf521a7-72e0-49a9-a631-7e6488160004"), null, null },
                    { new Guid("541da2fe-563b-4dca-b1ee-63aa98f76088"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(6964), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 2", "Lesson 1 in Section 2 in Course 2", null, new Guid("61c5c878-7754-4ba9-ae4e-3315253fd125"), null, null },
                    { new Guid("55f9bd09-3c5f-47b2-9b3b-d18590946a69"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(2329), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 10", "Lesson 2 in Section 1 in Course 10", null, new Guid("3aab9bb8-879a-44d9-9442-0b591ac536a9"), null, null },
                    { new Guid("5677309b-b39b-49fd-9856-f6c6d96dd4a0"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9851), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 6", "Lesson 2 in Section 3 in Course 6", null, new Guid("7f84caf6-6ae3-4590-a65e-5f2926678bcf"), null, null },
                    { new Guid("567e964c-908f-48cb-a283-4e0141f1631c"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(2737), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 10", "Lesson 1 in Section 3 in Course 10", null, new Guid("3424389a-d575-4fff-912f-21d1d451bd56"), null, null },
                    { new Guid("5d547b7f-0622-4ff1-ad47-7e861a7c3b37"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(2267), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 10", "Lesson 1 in Section 1 in Course 10", null, new Guid("3aab9bb8-879a-44d9-9442-0b591ac536a9"), null, null },
                    { new Guid("6062d21f-7d6c-488b-a386-b210e024ff38"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(6242), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 1", "Lesson 2 in Section 2 in Course 1", null, new Guid("b352cd33-b0d5-484e-8bd8-b4c2df8c571c"), null, null },
                    { new Guid("60c56344-a7df-4b00-905a-01fe4a27b8b1"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(326), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 7", "Lesson 1 in Section 2 in Course 7", null, new Guid("1fb1c633-7b55-481a-8595-f7b146b58e5f"), null, null },
                    { new Guid("70e50d69-afb9-4776-8a79-90be96a51cc1"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1901), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 9", "Lesson 3 in Section 3 in Course 9", null, new Guid("0fb9c271-b4df-4892-b5b6-65f33d0e5fb7"), null, null },
                    { new Guid("74a44642-1e77-482b-9974-84ec8574c739"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1629), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 9", "Lesson 3 in Section 2 in Course 9", null, new Guid("bfd7416a-4493-4526-83b5-51292dc59566"), null, null },
                    { new Guid("7986afd1-f96c-4758-a2b5-c5c15dafaddc"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(115), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 7", "Lesson 2 in Section 1 in Course 7", null, new Guid("72a5ffe0-2673-4329-a8a5-7a57994f3d63"), null, null },
                    { new Guid("7c1ea148-f63a-432f-8ca8-7d1cfe9c6577"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8574), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 4", "Lesson 2 in Section 3 in Course 4", null, new Guid("54a2ab76-ceaf-41f4-9e3f-12720e3a3fc2"), null, null },
                    { new Guid("7e5165d0-8651-4123-88ff-92cece04d95e"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1214), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 8", "Lesson 1 in Section 3 in Course 8", null, new Guid("e2bd22aa-2ff5-4ec7-a0cb-e016a874621a"), null, null },
                    { new Guid("811506a3-1937-4e0e-a188-df00165dfbdb"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9193), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 5", "Lesson 2 in Section 3 in Course 5", null, new Guid("f34febee-7825-49f5-94ea-b08d6871fb7b"), null, null },
                    { new Guid("825aebb6-5d9f-4105-9a31-2b9e52627b7b"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(754), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 8", "Lesson 2 in Section 1 in Course 8", null, new Guid("499de49d-e97d-4dac-b770-d608a0be1593"), null, null },
                    { new Guid("8ee02126-bf38-4f9b-bc62-85599cad9d61"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1622), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 9", "Lesson 2 in Section 2 in Course 9", null, new Guid("bfd7416a-4493-4526-83b5-51292dc59566"), null, null },
                    { new Guid("92006b61-5be5-4e45-b4fc-cf5436f80c26"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(6412), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 1", "Lesson 1 in Section 3 in Course 1", null, new Guid("0e46e441-b493-47bb-a708-15c7415cd954"), null, null },
                    { new Guid("93afe080-5c9a-4dfb-a8ca-0cbb84edbc22"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(7248), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 2", "Lesson 3 in Section 3 in Course 2", null, new Guid("056688fa-94cf-42f2-a54d-70f3054626c9"), null, null },
                    { new Guid("93f8f33d-3fa2-445b-aafd-9f6aa8348f76"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(745), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 8", "Lesson 1 in Section 1 in Course 8", null, new Guid("499de49d-e97d-4dac-b770-d608a0be1593"), null, null },
                    { new Guid("972e1c56-0e87-4905-8f73-9eb8ae948c10"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1231), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 8", "Lesson 3 in Section 3 in Course 8", null, new Guid("e2bd22aa-2ff5-4ec7-a0cb-e016a874621a"), null, null },
                    { new Guid("991f6b18-8ad7-4950-908c-5151ed4362ee"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8581), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 4", "Lesson 3 in Section 3 in Course 4", null, new Guid("54a2ab76-ceaf-41f4-9e3f-12720e3a3fc2"), null, null },
                    { new Guid("a0514b6d-004f-4a03-acab-2f25a5219e8d"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8163), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 4", "Lesson 3 in Section 1 in Course 4", null, new Guid("ac7a5082-8c88-48af-95a9-fe1abe78bf1e"), null, null },
                    { new Guid("a82f9f08-76fc-42b2-b76c-71fc928eaef4"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(2337), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 10", "Lesson 3 in Section 1 in Course 10", null, new Guid("3aab9bb8-879a-44d9-9442-0b591ac536a9"), null, null },
                    { new Guid("a9fc463b-54ce-4c31-b118-ccf25a3d7003"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(7868), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 3", "Lesson 1 in Section 3 in Course 3", null, new Guid("bd39fdf2-fd61-42f9-aaf5-eb81c45f4609"), null, null },
                    { new Guid("aa8e4f44-f50a-4b34-b84d-a3dc15a87358"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8354), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 4", "Lesson 3 in Section 2 in Course 4", null, new Guid("bdf521a7-72e0-49a9-a631-7e6488160004"), null, null },
                    { new Guid("b393e09d-23d9-4be1-82e2-7b626df76897"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(6474), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 1", "Lesson 3 in Section 3 in Course 1", null, new Guid("0e46e441-b493-47bb-a708-15c7415cd954"), null, null },
                    { new Guid("b41c80c8-cc26-4b62-81b1-de60d2211ae8"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(2500), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 10", "Lesson 1 in Section 2 in Course 10", null, new Guid("ab4c812f-c26a-4dda-8f1f-9d7414505e37"), null, null },
                    { new Guid("b6e30c97-e217-44b2-a238-431e0e2267de"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1881), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 9", "Lesson 1 in Section 3 in Course 9", null, new Guid("0fb9c271-b4df-4892-b5b6-65f33d0e5fb7"), null, null },
                    { new Guid("b72be05c-d5ef-4ca4-a3dd-5243d95f8779"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(7887), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 3", "Lesson 3 in Section 3 in Course 3", null, new Guid("bd39fdf2-fd61-42f9-aaf5-eb81c45f4609"), null, null },
                    { new Guid("bf513be0-2515-4894-b403-863bbc417ae8"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(767), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 8", "Lesson 3 in Section 1 in Course 8", null, new Guid("499de49d-e97d-4dac-b770-d608a0be1593"), null, null },
                    { new Guid("bfed38cf-ab8f-49d6-a0cf-0283a416e739"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9418), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 6", "Lesson 1 in Section 1 in Course 6", null, new Guid("6a0a5851-f2e8-4834-a567-5e79d05b0baa"), null, null },
                    { new Guid("c2566bb1-d192-49dd-ab2b-9562969923a3"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(500), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 7", "Lesson 1 in Section 3 in Course 7", null, new Guid("58122722-4219-4692-97cf-7b60eae672d2"), null, null },
                    { new Guid("c29ade20-740e-4147-872e-02812fdb86df"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(7657), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 3", "Lesson 3 in Section 2 in Course 3", null, new Guid("062020d3-9299-4e74-bf84-8bfb82503065"), null, null },
                    { new Guid("cad7f779-1edf-4e45-8dbb-b788d64961fd"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(7641), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 3", "Lesson 1 in Section 2 in Course 3", null, new Guid("062020d3-9299-4e74-bf84-8bfb82503065"), null, null },
                    { new Guid("cd81bacc-146d-435e-9144-4f0412a08ad3"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8345), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 4", "Lesson 2 in Section 2 in Course 4", null, new Guid("bdf521a7-72e0-49a9-a631-7e6488160004"), null, null },
                    { new Guid("cfdedcda-c84a-43ab-bd16-fdc7fe6349d4"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(2753), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 10", "Lesson 3 in Section 3 in Course 10", null, new Guid("3424389a-d575-4fff-912f-21d1d451bd56"), null, null },
                    { new Guid("cfe1e150-62d7-483b-9118-0c426fc70b51"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8565), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 4", "Lesson 1 in Section 3 in Course 4", null, new Guid("54a2ab76-ceaf-41f4-9e3f-12720e3a3fc2"), null, null },
                    { new Guid("cfe6e81b-afcd-45ef-9047-7d0cae2b7077"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8972), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 5", "Lesson 2 in Section 2 in Course 5", null, new Guid("2e484020-d62b-446f-871d-2c3b91009715"), null, null },
                    { new Guid("cfec8431-ed45-4058-9906-24451c10c43a"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(7651), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 3", "Lesson 2 in Section 2 in Course 3", null, new Guid("062020d3-9299-4e74-bf84-8bfb82503065"), null, null },
                    { new Guid("d4b5a644-d9fa-49c9-b8cb-2687b9dcb0fd"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9677), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 6", "Lesson 3 in Section 2 in Course 6", null, new Guid("b81aac6b-f3bb-4961-9755-020e9d81912e"), null, null },
                    { new Guid("d5c12ad5-fe59-47f1-923a-495646dee91e"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9185), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 5", "Lesson 1 in Section 3 in Course 5", null, new Guid("f34febee-7825-49f5-94ea-b08d6871fb7b"), null, null },
                    { new Guid("d820078f-eb5b-42f0-962b-c1b27ec2e58c"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8799), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 5", "Lesson 2 in Section 1 in Course 5", null, new Guid("990a9b94-e3d1-4e56-98d7-fbba69db6073"), null, null },
                    { new Guid("dabfbb66-bf04-4e60-be19-69d14b4dd3f8"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1398), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 9", "Lesson 2 in Section 1 in Course 9", null, new Guid("5d91597a-5b9e-42c5-8877-d59269a01ef3"), null, null },
                    { new Guid("de77308c-2f22-497a-b646-6b2653f24760"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(2746), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 10", "Lesson 2 in Section 3 in Course 10", null, new Guid("3424389a-d575-4fff-912f-21d1d451bd56"), null, null },
                    { new Guid("deb93c86-39cd-4f9d-b46c-6378238055f5"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1389), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 9", "Lesson 1 in Section 1 in Course 9", null, new Guid("5d91597a-5b9e-42c5-8877-d59269a01ef3"), null, null },
                    { new Guid("dff3ecf5-f1a3-4b25-ac4c-26ee63786092"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(6982), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 2", "Lesson 3 in Section 2 in Course 2", null, new Guid("61c5c878-7754-4ba9-ae4e-3315253fd125"), null, null },
                    { new Guid("e253806b-1b27-4241-ad2c-434efddbbe87"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(7438), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 3", "Lesson 3 in Section 1 in Course 3", null, new Guid("5e10d718-8807-4a88-9494-d92b16c8541d"), null, null },
                    { new Guid("e4e8db9f-56bd-415f-9522-2639447847fb"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(6739), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 2", "Lesson 1 in Section 1 in Course 2", null, new Guid("33cc1d8c-6d9d-40a9-80bd-520fab88d002"), null, null },
                    { new Guid("e70b7825-307a-406d-b9e8-8404e7e99934"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(991), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 8", "Lesson 1 in Section 2 in Course 8", null, new Guid("f04d855b-efa8-4932-b88a-cd3bc1f514f0"), null, null },
                    { new Guid("e7db8864-f3b0-4b7e-9eff-1e16fb92af6d"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(9858), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 6", "Lesson 3 in Section 3 in Course 6", null, new Guid("7f84caf6-6ae3-4590-a65e-5f2926678bcf"), null, null },
                    { new Guid("e8aa7546-10b9-4d82-80aa-57103858629f"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8964), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 5", "Lesson 1 in Section 2 in Course 5", null, new Guid("2e484020-d62b-446f-871d-2c3b91009715"), null, null },
                    { new Guid("e964e35e-95a9-4cb1-8774-deecad271fd4"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(8086), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 4", "Lesson 1 in Section 1 in Course 4", null, new Guid("ac7a5082-8c88-48af-95a9-fe1abe78bf1e"), null, null },
                    { new Guid("eb829323-dbe9-4c11-b7f1-4ef3dbaa058b"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(6755), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 2", "Lesson 3 in Section 1 in Course 2", null, new Guid("33cc1d8c-6d9d-40a9-80bd-520fab88d002"), null, null },
                    { new Guid("f232792c-898f-46cf-8257-719aaeb5dd92"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(1614), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 9", "Lesson 1 in Section 2 in Course 9", null, new Guid("bfd7416a-4493-4526-83b5-51292dc59566"), null, null },
                    { new Guid("f68d2484-5608-4bcd-81ee-229d9f9d7d17"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(2508), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 10", "Lesson 2 in Section 2 in Course 10", null, new Guid("ab4c812f-c26a-4dda-8f1f-9d7414505e37"), null, null },
                    { new Guid("fd457f14-f437-4cfc-af7a-7d4c832503b9"), null, null, null, new DateTime(2024, 11, 20, 16, 39, 26, 385, DateTimeKind.Local).AddTicks(2518), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 10", "Lesson 3 in Section 2 in Course 10", null, new Guid("ab4c812f-c26a-4dda-8f1f-9d7414505e37"), null, null }
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "IsActive", "LessonId", "Name", "QuizType", "SectionId" },
                values: new object[,]
                {
                    { new Guid("01b506dc-4262-4d73-8300-7d8db793beda"), false, null, "Quiz 1 for Section 2 in Course 7", 0, new Guid("1fb1c633-7b55-481a-8595-f7b146b58e5f") },
                    { new Guid("04d0d2e7-bc1f-44b0-b36f-99c1078716f8"), false, null, "Quiz 1 for Section 1 in Course 1", 0, new Guid("0e109ec5-ee7a-4681-aa91-c752483b4174") },
                    { new Guid("06df286e-efa3-49d2-b31c-b79b1486301b"), false, null, "Quiz 1 for Section 2 in Course 3", 0, new Guid("062020d3-9299-4e74-bf84-8bfb82503065") },
                    { new Guid("0a48bd12-ee6b-4d06-8e39-d6ace0c336b2"), false, null, "Quiz 1 for Section 1 in Course 4", 0, new Guid("ac7a5082-8c88-48af-95a9-fe1abe78bf1e") },
                    { new Guid("0f988854-19b0-4fda-aa4f-9e30026d9471"), false, null, "Quiz 2 for Section 3 in Course 5", 0, new Guid("f34febee-7825-49f5-94ea-b08d6871fb7b") },
                    { new Guid("14fa59fe-8b1e-4637-a78b-28a58da1a7d7"), false, null, "Quiz 1 for Section 2 in Course 4", 0, new Guid("bdf521a7-72e0-49a9-a631-7e6488160004") },
                    { new Guid("1bec66e0-d359-4eee-a1b5-df79f7c2b6a7"), false, null, "Quiz 1 for Section 3 in Course 10", 0, new Guid("3424389a-d575-4fff-912f-21d1d451bd56") },
                    { new Guid("212e0a10-05d0-41b7-936f-65b13d866522"), false, null, "Quiz 2 for Section 2 in Course 1", 0, new Guid("b352cd33-b0d5-484e-8bd8-b4c2df8c571c") },
                    { new Guid("23196206-dba2-4056-985d-6609716d16ed"), false, null, "Quiz 2 for Section 1 in Course 7", 0, new Guid("72a5ffe0-2673-4329-a8a5-7a57994f3d63") },
                    { new Guid("292546c7-fbd4-4345-bb30-f98911d02363"), false, null, "Quiz 1 for Section 1 in Course 2", 0, new Guid("33cc1d8c-6d9d-40a9-80bd-520fab88d002") },
                    { new Guid("2a654b4f-98e4-4496-b8d0-429561643e25"), false, null, "Quiz 2 for Section 1 in Course 3", 0, new Guid("5e10d718-8807-4a88-9494-d92b16c8541d") },
                    { new Guid("2b296194-80b9-4d26-9c12-b04a8ff5f810"), false, null, "Quiz 2 for Section 1 in Course 1", 0, new Guid("0e109ec5-ee7a-4681-aa91-c752483b4174") },
                    { new Guid("2fe351ac-1375-4627-8fe0-61e6ab11b06f"), false, null, "Quiz 2 for Section 1 in Course 5", 0, new Guid("990a9b94-e3d1-4e56-98d7-fbba69db6073") },
                    { new Guid("32025b55-428b-42d7-846c-e3f02356dd25"), false, null, "Quiz 2 for Section 2 in Course 7", 0, new Guid("1fb1c633-7b55-481a-8595-f7b146b58e5f") },
                    { new Guid("34c28cf2-640e-4485-b7ec-e2e43eeaf8c1"), false, null, "Quiz 2 for Section 3 in Course 8", 0, new Guid("e2bd22aa-2ff5-4ec7-a0cb-e016a874621a") },
                    { new Guid("44d06181-aa4c-4953-a147-54f3a4f48ec0"), false, null, "Quiz 1 for Section 2 in Course 10", 0, new Guid("ab4c812f-c26a-4dda-8f1f-9d7414505e37") },
                    { new Guid("4606c7ba-94f9-4263-b684-aa09a36ca1be"), false, null, "Quiz 2 for Section 1 in Course 6", 0, new Guid("6a0a5851-f2e8-4834-a567-5e79d05b0baa") },
                    { new Guid("47444ea4-0231-4ab6-bfd0-e822225f0f57"), false, null, "Quiz 2 for Section 2 in Course 10", 0, new Guid("ab4c812f-c26a-4dda-8f1f-9d7414505e37") },
                    { new Guid("4901702e-b3c2-4109-977c-e19c6af1c849"), false, null, "Quiz 1 for Section 1 in Course 7", 0, new Guid("72a5ffe0-2673-4329-a8a5-7a57994f3d63") },
                    { new Guid("571704a5-609a-4927-8031-9ef5a31dcab6"), false, null, "Quiz 1 for Section 3 in Course 5", 0, new Guid("f34febee-7825-49f5-94ea-b08d6871fb7b") },
                    { new Guid("57b5e201-6fc2-419b-8383-2045ebe25611"), false, null, "Quiz 1 for Section 3 in Course 7", 0, new Guid("58122722-4219-4692-97cf-7b60eae672d2") },
                    { new Guid("5a1b658b-c8e2-404b-b6c3-8393250cc404"), false, null, "Quiz 1 for Section 1 in Course 3", 0, new Guid("5e10d718-8807-4a88-9494-d92b16c8541d") },
                    { new Guid("5c58ecca-7883-4c58-a966-76a7d6acd059"), false, null, "Quiz 1 for Section 1 in Course 6", 0, new Guid("6a0a5851-f2e8-4834-a567-5e79d05b0baa") },
                    { new Guid("6044851b-aee0-4cd9-b131-b31d0c4b72cc"), false, null, "Quiz 2 for Section 3 in Course 2", 0, new Guid("056688fa-94cf-42f2-a54d-70f3054626c9") },
                    { new Guid("6b835662-6be8-42ad-8c6d-bc36efbd8a42"), false, null, "Quiz 2 for Section 1 in Course 10", 0, new Guid("3aab9bb8-879a-44d9-9442-0b591ac536a9") },
                    { new Guid("7c1ab144-675b-49ff-ab04-2ff61517f3d3"), false, null, "Quiz 2 for Section 2 in Course 4", 0, new Guid("bdf521a7-72e0-49a9-a631-7e6488160004") },
                    { new Guid("7d29aabf-4c0a-46e9-85bf-334426cf6d18"), false, null, "Quiz 2 for Section 3 in Course 9", 0, new Guid("0fb9c271-b4df-4892-b5b6-65f33d0e5fb7") },
                    { new Guid("7d8df9ad-c916-4512-9768-55791ef05904"), false, null, "Quiz 2 for Section 2 in Course 9", 0, new Guid("bfd7416a-4493-4526-83b5-51292dc59566") },
                    { new Guid("83f4153f-728c-4bed-bd9e-01cdc70e850e"), false, null, "Quiz 1 for Section 3 in Course 2", 0, new Guid("056688fa-94cf-42f2-a54d-70f3054626c9") },
                    { new Guid("8c16224f-2d4b-438f-9ca3-69e9e28c6ec8"), false, null, "Quiz 2 for Section 2 in Course 3", 0, new Guid("062020d3-9299-4e74-bf84-8bfb82503065") },
                    { new Guid("93fbe197-11de-4337-bc46-c8d894a7eacb"), false, null, "Quiz 2 for Section 1 in Course 2", 0, new Guid("33cc1d8c-6d9d-40a9-80bd-520fab88d002") },
                    { new Guid("999838d1-185c-4cd3-82e9-c3f04ba44f53"), false, null, "Quiz 2 for Section 3 in Course 10", 0, new Guid("3424389a-d575-4fff-912f-21d1d451bd56") },
                    { new Guid("9a8d51ee-5422-4ff1-9266-a8ddb9b28506"), false, null, "Quiz 1 for Section 3 in Course 3", 0, new Guid("bd39fdf2-fd61-42f9-aaf5-eb81c45f4609") },
                    { new Guid("a396ee37-e6a6-4b76-a55a-dffb70d5245d"), false, null, "Quiz 2 for Section 3 in Course 4", 0, new Guid("54a2ab76-ceaf-41f4-9e3f-12720e3a3fc2") },
                    { new Guid("a3a8304b-c041-4c71-9240-4b8f2af44dfc"), false, null, "Quiz 1 for Section 3 in Course 6", 0, new Guid("7f84caf6-6ae3-4590-a65e-5f2926678bcf") },
                    { new Guid("a5caf6f4-e240-480f-a940-11f4be61d107"), false, null, "Quiz 1 for Section 2 in Course 1", 0, new Guid("b352cd33-b0d5-484e-8bd8-b4c2df8c571c") },
                    { new Guid("a60c18d2-78f7-4d1c-acd2-26185305accf"), false, null, "Quiz 2 for Section 1 in Course 4", 0, new Guid("ac7a5082-8c88-48af-95a9-fe1abe78bf1e") },
                    { new Guid("b0e2cf24-5e3f-4d93-86cf-449b46e5f5de"), false, null, "Quiz 1 for Section 1 in Course 8", 0, new Guid("499de49d-e97d-4dac-b770-d608a0be1593") },
                    { new Guid("b1992c59-6514-4a40-89ad-704026ae4f82"), false, null, "Quiz 1 for Section 1 in Course 9", 0, new Guid("5d91597a-5b9e-42c5-8877-d59269a01ef3") },
                    { new Guid("b25a9692-7ce7-45cc-89d5-f4618cc53c02"), false, null, "Quiz 2 for Section 2 in Course 5", 0, new Guid("2e484020-d62b-446f-871d-2c3b91009715") },
                    { new Guid("b851832d-5b9d-43d0-b87b-6de307de78f6"), false, null, "Quiz 1 for Section 2 in Course 2", 0, new Guid("61c5c878-7754-4ba9-ae4e-3315253fd125") },
                    { new Guid("b855bcb8-b283-4e3e-a8a5-7637190148e3"), false, null, "Quiz 2 for Section 3 in Course 1", 0, new Guid("0e46e441-b493-47bb-a708-15c7415cd954") },
                    { new Guid("bc4f42b6-39f4-4f1f-9920-a20e0c2cb19d"), false, null, "Quiz 2 for Section 3 in Course 7", 0, new Guid("58122722-4219-4692-97cf-7b60eae672d2") },
                    { new Guid("bd12c351-4457-4bcc-8a30-0f1c14e55c1f"), false, null, "Quiz 2 for Section 2 in Course 2", 0, new Guid("61c5c878-7754-4ba9-ae4e-3315253fd125") },
                    { new Guid("bef1eabd-dd3b-4b44-a469-3f2e4787abdd"), false, null, "Quiz 1 for Section 3 in Course 1", 0, new Guid("0e46e441-b493-47bb-a708-15c7415cd954") },
                    { new Guid("d2e82516-49d4-4d59-8b47-3cee3c6eaf1d"), false, null, "Quiz 2 for Section 3 in Course 3", 0, new Guid("bd39fdf2-fd61-42f9-aaf5-eb81c45f4609") },
                    { new Guid("d38231d2-6066-4895-bdad-60ce107f924f"), false, null, "Quiz 2 for Section 2 in Course 8", 0, new Guid("f04d855b-efa8-4932-b88a-cd3bc1f514f0") },
                    { new Guid("d4386136-0b0a-4be3-8a44-971dd2f44a27"), false, null, "Quiz 1 for Section 3 in Course 9", 0, new Guid("0fb9c271-b4df-4892-b5b6-65f33d0e5fb7") },
                    { new Guid("d4ea0947-e774-4055-9e50-4649b1a29385"), false, null, "Quiz 1 for Section 1 in Course 5", 0, new Guid("990a9b94-e3d1-4e56-98d7-fbba69db6073") },
                    { new Guid("d58ccfb9-7a69-4948-8c96-2b94d4978189"), false, null, "Quiz 1 for Section 2 in Course 6", 0, new Guid("b81aac6b-f3bb-4961-9755-020e9d81912e") },
                    { new Guid("daa59107-8ac1-4c99-b352-c0595b0a75ed"), false, null, "Quiz 1 for Section 2 in Course 5", 0, new Guid("2e484020-d62b-446f-871d-2c3b91009715") },
                    { new Guid("dd6c8b83-0d1f-472a-bc00-29b3cd72a58e"), false, null, "Quiz 1 for Section 3 in Course 4", 0, new Guid("54a2ab76-ceaf-41f4-9e3f-12720e3a3fc2") },
                    { new Guid("de3ee8e8-10e2-4a2a-8017-123a8319605d"), false, null, "Quiz 2 for Section 2 in Course 6", 0, new Guid("b81aac6b-f3bb-4961-9755-020e9d81912e") },
                    { new Guid("df1157be-2bd1-430b-aa72-314f03c3e69a"), false, null, "Quiz 1 for Section 2 in Course 9", 0, new Guid("bfd7416a-4493-4526-83b5-51292dc59566") },
                    { new Guid("e791e8c9-02cd-4bf2-b047-d37666d959a9"), false, null, "Quiz 2 for Section 1 in Course 8", 0, new Guid("499de49d-e97d-4dac-b770-d608a0be1593") },
                    { new Guid("ebabd0c6-682f-46bc-9306-885b5dca0bca"), false, null, "Quiz 2 for Section 1 in Course 9", 0, new Guid("5d91597a-5b9e-42c5-8877-d59269a01ef3") },
                    { new Guid("f0757e6d-5c72-498e-9c05-cf85f9135293"), false, null, "Quiz 1 for Section 2 in Course 8", 0, new Guid("f04d855b-efa8-4932-b88a-cd3bc1f514f0") },
                    { new Guid("f45444d9-4fe7-4e2e-8d30-ae02f3d2d9ab"), false, null, "Quiz 2 for Section 3 in Course 6", 0, new Guid("7f84caf6-6ae3-4590-a65e-5f2926678bcf") },
                    { new Guid("f557fce5-1ac1-4041-8c75-e3e0eacc8f35"), false, null, "Quiz 1 for Section 1 in Course 10", 0, new Guid("3aab9bb8-879a-44d9-9442-0b591ac536a9") },
                    { new Guid("fcd6e363-e464-4dba-8a64-f74c0fa266a3"), false, null, "Quiz 1 for Section 3 in Course 8", 0, new Guid("e2bd22aa-2ff5-4ec7-a0cb-e016a874621a") }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "DepartmentId", "IsActive", "LookUpStatus", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("02ac102b-8c02-4210-8452-0ebd526897bc"), new Guid("c7855715-481d-4509-acad-86cb46907dc2"), false, 2, "تخصص الذكاء الاصطناعي 8", "Artificial Intelligence Specialization 8" },
                    { new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75"), false, 2, "تخصص الذكاء الاصطناعي 9", "Artificial Intelligence Specialization 9" },
                    { new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3"), false, 2, "تخصص الذكاء الاصطناعي 1", "Artificial Intelligence Specialization 1" },
                    { new Guid("33004818-1f3c-40d8-af6a-fd726134ed72"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e"), false, 2, "تخصص الذكاء الاصطناعي 3", "Artificial Intelligence Specialization 3" },
                    { new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223"), false, 2, "تخصص الذكاء الاصطناعي 6", "Artificial Intelligence Specialization 6" },
                    { new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a"), false, 2, "تخصص الذكاء الاصطناعي 2", "Artificial Intelligence Specialization 2" },
                    { new Guid("c347acfc-c8a2-4104-9636-42b684839bf0"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39"), false, 2, "تخصص الذكاء الاصطناعي 5", "Artificial Intelligence Specialization 5" },
                    { new Guid("c8417977-5776-41b2-965f-784899f94fe4"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03"), false, 2, "تخصص الذكاء الاصطناعي 10", "Artificial Intelligence Specialization 10" },
                    { new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616"), false, 2, "تخصص الذكاء الاصطناعي 7", "Artificial Intelligence Specialization 7" },
                    { new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341"), false, 2, "تخصص الذكاء الاصطناعي 4", "Artificial Intelligence Specialization 4" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AcademicYear", "CountryId", "Created", "CreatedBy", "DepartmentId", "Email", "FacultyId", "FirstName", "LastModified", "LastModifiedBy", "LastModifiedStatus", "LastName", "MobileNumber", "Password", "RegisterAt", "RoleId", "SpecializationId", "Status", "StudyLevel", "UniversityId", "UserType" },
                values: new object[,]
                {
                    { new Guid("1dd9d4bd-03c3-4d41-9d43-ccf7fa5df734"), null, 1, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(612), null, new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3"), "instructor_univ_dept1@example.com", null, "InstructorFirstName1", null, null, null, "InstructorLastName1", "1234567891", "password1", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(517), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d"), 2 },
                    { new Guid("36cdf7f5-8d68-42fa-9582-5ab14f67079f"), null, 5, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(735), null, new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39"), "instructor_univ_dept5@example.com", null, "InstructorFirstName5", null, null, null, "InstructorLastName5", "1234567895", "password5", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(726), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e"), 2 },
                    { new Guid("5487f184-010c-4907-8ace-d7196f64f9c4"), null, 3, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(697), null, new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e"), "instructor_univ_dept3@example.com", null, "InstructorFirstName3", null, null, null, "InstructorLastName3", "1234567893", "password3", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(645), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f"), 2 },
                    { new Guid("90506af4-9600-49c4-b188-0ace521eee40"), null, 4, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(719), null, new Guid("d94b5445-7088-4897-ab8a-2838d7652341"), "instructor_univ_dept4@example.com", null, "InstructorFirstName4", null, null, null, "InstructorLastName4", "1234567894", "password4", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(713), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0"), 2 },
                    { new Guid("e5bc1e5e-0b3e-4451-81fc-a450a4d4c40f"), null, 2, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(639), null, new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a"), "instructor_univ_dept2@example.com", null, "InstructorFirstName2", null, null, null, "InstructorLastName2", "1234567892", "password2", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(633), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Answer", "CorrectAnswers", "CorrectAnswersJson", "IsActive", "MatchingPairs", "MatchingPairsJson", "Options", "OptionsJson", "QuestionText", "QuestionType", "QuizId" },
                values: new object[,]
                {
                    { new Guid("01d1ee0e-4cba-42bd-8ae7-8472b9d75321"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 7", 0, new Guid("57b5e201-6fc2-419b-8383-2045ebe25611") },
                    { new Guid("01ed758f-45db-4579-add3-11a32f48be8c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 5", 0, new Guid("2fe351ac-1375-4627-8fe0-61e6ab11b06f") },
                    { new Guid("02cf053f-820e-4b65-8531-7e555382b1d1"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 10", 0, new Guid("999838d1-185c-4cd3-82e9-c3f04ba44f53") },
                    { new Guid("04986a60-b6b8-4611-9068-7b90770c18c2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 4", 0, new Guid("7c1ab144-675b-49ff-ab04-2ff61517f3d3") },
                    { new Guid("066ad16e-2ea5-4640-901a-9354b76d4bc8"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 9", 0, new Guid("df1157be-2bd1-430b-aa72-314f03c3e69a") },
                    { new Guid("06a7b504-1769-4ca6-a445-8eff6c7951cf"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 7", 0, new Guid("01b506dc-4262-4d73-8300-7d8db793beda") },
                    { new Guid("09edb6e2-aa83-4922-9280-a78fbc30bc6b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 9", 0, new Guid("7d29aabf-4c0a-46e9-85bf-334426cf6d18") },
                    { new Guid("0d072d48-4cb6-4007-ab63-a4a638f76097"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 4", 0, new Guid("0a48bd12-ee6b-4d06-8e39-d6ace0c336b2") },
                    { new Guid("0f00bec2-8ff3-431e-b2e2-94474ba50e7f"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 4", 0, new Guid("14fa59fe-8b1e-4637-a78b-28a58da1a7d7") },
                    { new Guid("124b317a-76e3-4c2d-9098-0a7c91227db2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 7", 0, new Guid("23196206-dba2-4056-985d-6609716d16ed") },
                    { new Guid("12c4527f-7ad6-46a2-81c1-d6803ed84968"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 8", 0, new Guid("fcd6e363-e464-4dba-8a64-f74c0fa266a3") },
                    { new Guid("14384a4a-af15-44a2-9b84-d6038102c958"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 2", 0, new Guid("93fbe197-11de-4337-bc46-c8d894a7eacb") },
                    { new Guid("15910aa0-a270-435f-92ca-bb4f2855b274"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 7", 0, new Guid("57b5e201-6fc2-419b-8383-2045ebe25611") },
                    { new Guid("15df547b-e3ed-4793-a99e-90b6750bddb8"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 6", 0, new Guid("f45444d9-4fe7-4e2e-8d30-ae02f3d2d9ab") },
                    { new Guid("15ebf5a8-1964-4f98-9d96-4575c7335118"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 6", 0, new Guid("a3a8304b-c041-4c71-9240-4b8f2af44dfc") },
                    { new Guid("1796e4bc-3c95-4ec4-8005-b5ba65fb458a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 7", 0, new Guid("57b5e201-6fc2-419b-8383-2045ebe25611") },
                    { new Guid("17b41dbd-5e55-44e7-8828-9c76dd4c1568"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 3", 0, new Guid("9a8d51ee-5422-4ff1-9266-a8ddb9b28506") },
                    { new Guid("17f2b4cc-1bd0-4d7b-9792-27ef17953468"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 10", 0, new Guid("f557fce5-1ac1-4041-8c75-e3e0eacc8f35") },
                    { new Guid("199f008f-e27e-4f98-867e-aa3dfc893fb7"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 6", 0, new Guid("f45444d9-4fe7-4e2e-8d30-ae02f3d2d9ab") },
                    { new Guid("19f9a649-4e1a-49cd-9be4-70a0c31644b8"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 6", 0, new Guid("de3ee8e8-10e2-4a2a-8017-123a8319605d") },
                    { new Guid("1ac43a06-dd9f-44a6-9622-588af6dc7dd9"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 5", 0, new Guid("b25a9692-7ce7-45cc-89d5-f4618cc53c02") },
                    { new Guid("1b1cd0ed-fbde-4825-947d-d5b27f402db5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 2", 0, new Guid("b851832d-5b9d-43d0-b87b-6de307de78f6") },
                    { new Guid("2635dc5a-6962-477f-adbd-b33b2191fc21"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 10", 0, new Guid("6b835662-6be8-42ad-8c6d-bc36efbd8a42") },
                    { new Guid("274e3d01-18bd-4f11-b1fb-2a9c73284226"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 2", 0, new Guid("93fbe197-11de-4337-bc46-c8d894a7eacb") },
                    { new Guid("280b59c1-b053-4c3f-be55-16dded58df7c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 2", 0, new Guid("b851832d-5b9d-43d0-b87b-6de307de78f6") },
                    { new Guid("291d2d50-0377-4d05-89f1-0023a0aa6ed1"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 8", 0, new Guid("fcd6e363-e464-4dba-8a64-f74c0fa266a3") },
                    { new Guid("296688e2-2b8d-4e6e-b13a-4034a22ed6d7"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 6", 0, new Guid("4606c7ba-94f9-4263-b684-aa09a36ca1be") },
                    { new Guid("2a3d9930-f591-4b74-b885-f61b2bfc8085"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 1", 0, new Guid("a5caf6f4-e240-480f-a940-11f4be61d107") },
                    { new Guid("2a471623-bdeb-4da5-9b14-79e644f53977"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 4", 0, new Guid("a60c18d2-78f7-4d1c-acd2-26185305accf") },
                    { new Guid("2afefb55-b773-4967-9445-47706ec704b8"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 9", 0, new Guid("d4386136-0b0a-4be3-8a44-971dd2f44a27") },
                    { new Guid("2cb0c98e-a9e5-47aa-b472-b0995e4ecf0b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 1", 0, new Guid("bef1eabd-dd3b-4b44-a469-3f2e4787abdd") },
                    { new Guid("2d1b0a3f-6845-4012-93f3-b2710415ab82"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 3", 0, new Guid("9a8d51ee-5422-4ff1-9266-a8ddb9b28506") },
                    { new Guid("2f1426fb-7dc7-48f6-89e0-b6457cd13dea"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 7", 0, new Guid("23196206-dba2-4056-985d-6609716d16ed") },
                    { new Guid("33690d11-2086-4270-ae1d-e89710424c04"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 5", 0, new Guid("b25a9692-7ce7-45cc-89d5-f4618cc53c02") },
                    { new Guid("34897f51-a162-43a4-a9ac-4cf9d594b781"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 4", 0, new Guid("a60c18d2-78f7-4d1c-acd2-26185305accf") },
                    { new Guid("3494be46-9664-462e-9d68-aae0a7e085ca"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 9", 0, new Guid("7d8df9ad-c916-4512-9768-55791ef05904") },
                    { new Guid("3603208f-e15f-4742-aff1-21e5a72d43c3"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 10", 0, new Guid("44d06181-aa4c-4953-a147-54f3a4f48ec0") },
                    { new Guid("36989235-3c71-4976-ab9c-ba2deb418841"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 3", 0, new Guid("8c16224f-2d4b-438f-9ca3-69e9e28c6ec8") },
                    { new Guid("37545957-e7f0-468b-9ff9-11fed505ae26"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 6", 0, new Guid("a3a8304b-c041-4c71-9240-4b8f2af44dfc") },
                    { new Guid("383c75cc-94fc-4356-a766-4c5ed164371e"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 3", 0, new Guid("5a1b658b-c8e2-404b-b6c3-8393250cc404") },
                    { new Guid("38a9d544-b9a8-41a7-ba9a-d739583903d5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 9", 0, new Guid("ebabd0c6-682f-46bc-9306-885b5dca0bca") },
                    { new Guid("39b5958f-9dd1-431d-b362-be02c5dd08ce"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 8", 0, new Guid("b0e2cf24-5e3f-4d93-86cf-449b46e5f5de") },
                    { new Guid("3ae907b1-60d6-4261-8262-392e70123ed5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 4", 0, new Guid("0a48bd12-ee6b-4d06-8e39-d6ace0c336b2") },
                    { new Guid("3bb1a2dc-4a81-44c5-9b15-d72c4a431cdd"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 6", 0, new Guid("d58ccfb9-7a69-4948-8c96-2b94d4978189") },
                    { new Guid("3c3a336a-7025-4d76-a344-f4c23e08f9c9"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 8", 0, new Guid("34c28cf2-640e-4485-b7ec-e2e43eeaf8c1") },
                    { new Guid("3d97055d-c5f9-42c0-9747-31107c8513dd"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 7", 0, new Guid("32025b55-428b-42d7-846c-e3f02356dd25") },
                    { new Guid("40f6f73f-7a53-47cc-98bf-aba88a55b009"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 10", 0, new Guid("1bec66e0-d359-4eee-a1b5-df79f7c2b6a7") },
                    { new Guid("41f29ff3-cad4-4361-895c-4d86f03eb5e2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 9", 0, new Guid("7d8df9ad-c916-4512-9768-55791ef05904") },
                    { new Guid("47fa5bd5-9cc2-4059-9509-d288f0f40a68"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 4", 0, new Guid("0a48bd12-ee6b-4d06-8e39-d6ace0c336b2") },
                    { new Guid("4802499b-1cc7-4692-833d-8e5c57dc15a5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 3", 0, new Guid("8c16224f-2d4b-438f-9ca3-69e9e28c6ec8") },
                    { new Guid("4aff4a9a-ca64-4698-a92f-7c5be2b766f5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 4", 0, new Guid("dd6c8b83-0d1f-472a-bc00-29b3cd72a58e") },
                    { new Guid("4f6f49f5-2893-42f2-9a3d-a192acbdeb47"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 5", 0, new Guid("daa59107-8ac1-4c99-b352-c0595b0a75ed") },
                    { new Guid("4fbcf302-7c2d-4b70-a4cc-c2fbeb6272a3"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 1", 0, new Guid("b855bcb8-b283-4e3e-a8a5-7637190148e3") },
                    { new Guid("4fe9fb02-ae01-4b33-86bf-301ff6211763"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 6", 0, new Guid("a3a8304b-c041-4c71-9240-4b8f2af44dfc") },
                    { new Guid("52ed5b82-ccc9-49d4-bb5f-3e31d0584990"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 1", 0, new Guid("b855bcb8-b283-4e3e-a8a5-7637190148e3") },
                    { new Guid("56ff671e-ac77-4520-a691-d6ca8b2d291d"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 10", 0, new Guid("6b835662-6be8-42ad-8c6d-bc36efbd8a42") },
                    { new Guid("57ddf235-f7e4-406e-89f8-1a17872d958b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 8", 0, new Guid("b0e2cf24-5e3f-4d93-86cf-449b46e5f5de") },
                    { new Guid("5862c235-2281-4451-beee-0d11235390a6"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 8", 0, new Guid("e791e8c9-02cd-4bf2-b047-d37666d959a9") },
                    { new Guid("587b28b6-5993-46f9-aff3-ef01636ac158"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 4", 0, new Guid("7c1ab144-675b-49ff-ab04-2ff61517f3d3") },
                    { new Guid("5c6e012e-77fe-446e-b24c-8587c2145929"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 4", 0, new Guid("a60c18d2-78f7-4d1c-acd2-26185305accf") },
                    { new Guid("5caced65-25a9-4bf8-840b-204375c202cb"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 7", 0, new Guid("4901702e-b3c2-4109-977c-e19c6af1c849") },
                    { new Guid("5d9e5427-3cd9-47a0-b272-892eb3022e31"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 7", 0, new Guid("32025b55-428b-42d7-846c-e3f02356dd25") },
                    { new Guid("5dcf29f4-40bc-44e2-bbaa-3c239d2c2d8f"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 5", 0, new Guid("0f988854-19b0-4fda-aa4f-9e30026d9471") },
                    { new Guid("5f87981d-0552-45de-865c-4da2d33d4047"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 9", 0, new Guid("df1157be-2bd1-430b-aa72-314f03c3e69a") },
                    { new Guid("604ee945-795e-40d8-b104-433361babc22"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 6", 0, new Guid("f45444d9-4fe7-4e2e-8d30-ae02f3d2d9ab") },
                    { new Guid("612f253c-ab0d-4392-8754-076ee9a424f3"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 3", 0, new Guid("d2e82516-49d4-4d59-8b47-3cee3c6eaf1d") },
                    { new Guid("621e1a6b-980d-428d-913e-5b3b23d6c3b9"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 2", 0, new Guid("93fbe197-11de-4337-bc46-c8d894a7eacb") },
                    { new Guid("659f31bb-5409-4fad-8823-3ded15ccb2ca"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 8", 0, new Guid("e791e8c9-02cd-4bf2-b047-d37666d959a9") },
                    { new Guid("668c0ad2-8930-4228-a025-7d3b4214468a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 10", 0, new Guid("47444ea4-0231-4ab6-bfd0-e822225f0f57") },
                    { new Guid("6782bbe7-921f-4bab-89f3-4cbef33b03cd"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 3", 0, new Guid("5a1b658b-c8e2-404b-b6c3-8393250cc404") },
                    { new Guid("6809add1-82a5-4e3b-99ce-fae20415b508"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 6", 0, new Guid("4606c7ba-94f9-4263-b684-aa09a36ca1be") },
                    { new Guid("68247a5e-e4c5-4ed2-8b15-04eeeee046e9"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 4", 0, new Guid("dd6c8b83-0d1f-472a-bc00-29b3cd72a58e") },
                    { new Guid("6d6acc42-7125-4514-ade1-8b17ed1527eb"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 10", 0, new Guid("f557fce5-1ac1-4041-8c75-e3e0eacc8f35") },
                    { new Guid("6e000f4d-e3b4-4c6c-9501-0e406e0e4672"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 2", 0, new Guid("83f4153f-728c-4bed-bd9e-01cdc70e850e") },
                    { new Guid("6ebbc8d4-c707-4252-a6d9-bea981545dd2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 6", 0, new Guid("5c58ecca-7883-4c58-a966-76a7d6acd059") },
                    { new Guid("70a80c77-f6f6-45af-87b7-440760edadd7"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 7", 0, new Guid("23196206-dba2-4056-985d-6609716d16ed") },
                    { new Guid("73cb5df0-8776-43a3-a5e2-d0ba937849d2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 6", 0, new Guid("d58ccfb9-7a69-4948-8c96-2b94d4978189") },
                    { new Guid("74eb50e6-803e-4119-b282-a691022db4fb"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 5", 0, new Guid("2fe351ac-1375-4627-8fe0-61e6ab11b06f") },
                    { new Guid("795afa88-edc6-495a-bc46-a9fedfe89b4c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 1", 0, new Guid("04d0d2e7-bc1f-44b0-b36f-99c1078716f8") },
                    { new Guid("7a4ba1f9-ada5-4a2a-9a81-d805161afa69"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 7", 0, new Guid("bc4f42b6-39f4-4f1f-9920-a20e0c2cb19d") },
                    { new Guid("7b58c23e-1603-4c7d-90e5-839151d2de3e"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 4", 0, new Guid("a396ee37-e6a6-4b76-a55a-dffb70d5245d") },
                    { new Guid("7bb57a06-00c4-4d9e-ac57-4b21d4b4b0b7"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 10", 0, new Guid("1bec66e0-d359-4eee-a1b5-df79f7c2b6a7") },
                    { new Guid("7d0a3430-58bc-4af3-9cd8-4c6bafc47ace"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 6", 0, new Guid("4606c7ba-94f9-4263-b684-aa09a36ca1be") },
                    { new Guid("7d1cda8f-bd3d-46d4-82ab-9c683d2171ec"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 7", 0, new Guid("4901702e-b3c2-4109-977c-e19c6af1c849") },
                    { new Guid("7d9205f1-0135-4306-88c1-6d021a449376"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 1", 0, new Guid("212e0a10-05d0-41b7-936f-65b13d866522") },
                    { new Guid("7dd4b326-a41e-43c4-945d-1c271caa9a3f"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 1", 0, new Guid("212e0a10-05d0-41b7-936f-65b13d866522") },
                    { new Guid("7ebb341e-6b64-4ac7-b225-a1bbf0791197"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 9", 0, new Guid("b1992c59-6514-4a40-89ad-704026ae4f82") },
                    { new Guid("7fb3e8ca-aa9a-404d-9873-b19170c4ecd2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 1", 0, new Guid("04d0d2e7-bc1f-44b0-b36f-99c1078716f8") },
                    { new Guid("82681d10-186c-4f7d-a8a5-e15e3e28d845"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 6", 0, new Guid("d58ccfb9-7a69-4948-8c96-2b94d4978189") },
                    { new Guid("82ebf70a-aa56-45cf-9b5b-14f26fd9a392"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 3", 0, new Guid("2a654b4f-98e4-4496-b8d0-429561643e25") },
                    { new Guid("835df64e-8ea2-40ab-958b-94200097ca83"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 2", 0, new Guid("292546c7-fbd4-4345-bb30-f98911d02363") },
                    { new Guid("83ac33cd-dad3-487c-8c2f-5418d8e292bc"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 4", 0, new Guid("a396ee37-e6a6-4b76-a55a-dffb70d5245d") },
                    { new Guid("869e74a6-6133-45cb-b757-72fee61d14a4"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 1", 0, new Guid("04d0d2e7-bc1f-44b0-b36f-99c1078716f8") },
                    { new Guid("899a70c9-e391-4662-8cb8-b04d764a00a5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 5", 0, new Guid("d4ea0947-e774-4055-9e50-4649b1a29385") },
                    { new Guid("8bfb6e32-95f5-4d65-b65d-d0060d47800a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 3", 0, new Guid("d2e82516-49d4-4d59-8b47-3cee3c6eaf1d") },
                    { new Guid("8c395ac1-a14f-4db8-bd8a-eff7678f1de8"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 8", 0, new Guid("d38231d2-6066-4895-bdad-60ce107f924f") },
                    { new Guid("8c74a27e-b0af-42c5-bf2f-30269cc48908"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 9", 0, new Guid("ebabd0c6-682f-46bc-9306-885b5dca0bca") },
                    { new Guid("8c9865bb-f50d-4874-a297-d251191e7d76"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 9", 0, new Guid("df1157be-2bd1-430b-aa72-314f03c3e69a") },
                    { new Guid("8e0aa9c1-5784-49fb-a1cd-f69297b6d5b1"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 3", 0, new Guid("5a1b658b-c8e2-404b-b6c3-8393250cc404") },
                    { new Guid("8f100e1d-cece-4a19-9200-145e141506ec"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 5", 0, new Guid("d4ea0947-e774-4055-9e50-4649b1a29385") },
                    { new Guid("8f12d0ba-e5da-4d9d-83ce-5c05f77b7641"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 10", 0, new Guid("47444ea4-0231-4ab6-bfd0-e822225f0f57") },
                    { new Guid("90c73c4c-f055-434e-ae01-595d988a81a1"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 1", 0, new Guid("bef1eabd-dd3b-4b44-a469-3f2e4787abdd") },
                    { new Guid("916be6c9-610b-44d6-af46-d119e8edff79"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 3", 0, new Guid("06df286e-efa3-49d2-b31c-b79b1486301b") },
                    { new Guid("9257f4a4-47b9-4129-818f-7d987bbf330e"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 1", 0, new Guid("a5caf6f4-e240-480f-a940-11f4be61d107") },
                    { new Guid("929110ef-d129-4a9e-b464-a0ab16648683"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 3", 0, new Guid("2a654b4f-98e4-4496-b8d0-429561643e25") },
                    { new Guid("92b921e4-08ff-4f2c-8ddd-5ace3395d724"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 4", 0, new Guid("14fa59fe-8b1e-4637-a78b-28a58da1a7d7") },
                    { new Guid("990804c9-769a-459a-8232-8e90ab809aeb"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 7", 0, new Guid("32025b55-428b-42d7-846c-e3f02356dd25") },
                    { new Guid("9ab4a4cd-2843-4206-aff1-91f76b922602"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 2", 0, new Guid("bd12c351-4457-4bcc-8a30-0f1c14e55c1f") },
                    { new Guid("9bb0b895-a028-4592-ab56-bcaa024603b7"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 7", 0, new Guid("bc4f42b6-39f4-4f1f-9920-a20e0c2cb19d") },
                    { new Guid("9bc16b6e-1968-4dc6-9984-f0689bcca1c7"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 9", 0, new Guid("7d8df9ad-c916-4512-9768-55791ef05904") },
                    { new Guid("9c572038-79f5-4663-b390-91b02ca43f88"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 3", 0, new Guid("d2e82516-49d4-4d59-8b47-3cee3c6eaf1d") },
                    { new Guid("9e00f01c-114c-494a-b0f2-e18e6cfe0658"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 2", 0, new Guid("6044851b-aee0-4cd9-b131-b31d0c4b72cc") },
                    { new Guid("9e6d5049-074c-4b91-9e0c-c4483264daf2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 1", 0, new Guid("bef1eabd-dd3b-4b44-a469-3f2e4787abdd") },
                    { new Guid("9f13aec1-a798-477d-976c-00def1c43d36"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 1", 0, new Guid("2b296194-80b9-4d26-9c12-b04a8ff5f810") },
                    { new Guid("9f628546-63dc-47db-acec-77343351075b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 4", 0, new Guid("7c1ab144-675b-49ff-ab04-2ff61517f3d3") },
                    { new Guid("a0012693-be29-4104-99c5-bd9a6bc92b4f"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 10", 0, new Guid("47444ea4-0231-4ab6-bfd0-e822225f0f57") },
                    { new Guid("a08ac8b6-c4fa-4cb1-97cd-a33d59dc8fd0"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 8", 0, new Guid("e791e8c9-02cd-4bf2-b047-d37666d959a9") },
                    { new Guid("a1eae3fe-c886-45c6-b790-5b6beb611b12"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 4", 0, new Guid("a396ee37-e6a6-4b76-a55a-dffb70d5245d") },
                    { new Guid("a2cec2fa-8e1d-4f02-9744-abebebe1f1b5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 7", 0, new Guid("01b506dc-4262-4d73-8300-7d8db793beda") },
                    { new Guid("a4d596c9-46af-414f-ac8b-a8a91acdbbb0"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 6", 0, new Guid("5c58ecca-7883-4c58-a966-76a7d6acd059") },
                    { new Guid("a71c3108-4329-4f0b-ad58-f144a99b4c49"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 9", 0, new Guid("b1992c59-6514-4a40-89ad-704026ae4f82") },
                    { new Guid("a9c4daad-e493-4376-b365-e85bf178081d"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 5", 0, new Guid("d4ea0947-e774-4055-9e50-4649b1a29385") },
                    { new Guid("aac9c189-683d-49a9-950f-355fbcf0f992"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 8", 0, new Guid("d38231d2-6066-4895-bdad-60ce107f924f") },
                    { new Guid("ab9fec47-7bb8-4a48-bcd9-5576a1d6cb66"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 2", 0, new Guid("b851832d-5b9d-43d0-b87b-6de307de78f6") },
                    { new Guid("aba1dd7d-c8d5-4fbc-83fc-a0baa42a04b7"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 6", 0, new Guid("de3ee8e8-10e2-4a2a-8017-123a8319605d") },
                    { new Guid("ac686b8c-e147-49d0-9061-42c6c01aefb2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 2", 0, new Guid("83f4153f-728c-4bed-bd9e-01cdc70e850e") },
                    { new Guid("afdf1455-9c78-4ec0-a0eb-822b844a8f5c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 2", 0, new Guid("6044851b-aee0-4cd9-b131-b31d0c4b72cc") },
                    { new Guid("b08081f7-d70e-418e-ac50-522febc3b525"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 2", 0, new Guid("83f4153f-728c-4bed-bd9e-01cdc70e850e") },
                    { new Guid("b56b610d-3803-4e50-9c78-2ee826675aba"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 1", 0, new Guid("2b296194-80b9-4d26-9c12-b04a8ff5f810") },
                    { new Guid("b5d82e13-5dc4-4897-9f6a-b76a15b2fc5b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 8", 0, new Guid("f0757e6d-5c72-498e-9c05-cf85f9135293") },
                    { new Guid("b6e4e0c0-a2de-4c85-a868-88c8f06a938b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 8", 0, new Guid("34c28cf2-640e-4485-b7ec-e2e43eeaf8c1") },
                    { new Guid("bb131091-a2bd-4325-b767-c76254fb66d1"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 5", 0, new Guid("0f988854-19b0-4fda-aa4f-9e30026d9471") },
                    { new Guid("bd6188bb-7e5a-416d-8e9e-671021d6a0d5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 2", 0, new Guid("292546c7-fbd4-4345-bb30-f98911d02363") },
                    { new Guid("c03105ad-40f8-4bb3-afb4-634ee8ec2ffd"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 10", 0, new Guid("1bec66e0-d359-4eee-a1b5-df79f7c2b6a7") },
                    { new Guid("c048b37d-77d3-43f9-a804-786099b9f560"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 5", 0, new Guid("2fe351ac-1375-4627-8fe0-61e6ab11b06f") },
                    { new Guid("c053e11b-4001-4d17-85a4-dc760ecaaee9"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 8", 0, new Guid("f0757e6d-5c72-498e-9c05-cf85f9135293") },
                    { new Guid("c091fbd7-7752-4353-b0d0-9571b4481601"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 1", 0, new Guid("b855bcb8-b283-4e3e-a8a5-7637190148e3") },
                    { new Guid("c0e97723-6663-4d7c-bfce-07d174e9df5c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 8", 0, new Guid("f0757e6d-5c72-498e-9c05-cf85f9135293") },
                    { new Guid("c1e006f1-0edc-47b3-becb-e53ebfb520e2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 9", 0, new Guid("b1992c59-6514-4a40-89ad-704026ae4f82") },
                    { new Guid("c748f6a3-5fa8-4adc-90b2-08e0ec9bd606"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 3", 0, new Guid("8c16224f-2d4b-438f-9ca3-69e9e28c6ec8") },
                    { new Guid("c8fb1fdf-50d8-41ef-8440-b764932dd8f9"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 10", 0, new Guid("f557fce5-1ac1-4041-8c75-e3e0eacc8f35") },
                    { new Guid("ca5714a1-6667-4d49-acb5-4749d7b5b96b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 1", 0, new Guid("212e0a10-05d0-41b7-936f-65b13d866522") },
                    { new Guid("cd7d966d-fc4f-4148-9f28-ec800864d6c0"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 8", 0, new Guid("b0e2cf24-5e3f-4d93-86cf-449b46e5f5de") },
                    { new Guid("cee48d09-1e17-4448-9b77-1e7715e5a118"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 8", 0, new Guid("d38231d2-6066-4895-bdad-60ce107f924f") },
                    { new Guid("d02c91bc-449f-4687-ba2f-6f97d26dec0b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 2", 0, new Guid("292546c7-fbd4-4345-bb30-f98911d02363") },
                    { new Guid("d05542a8-8111-41a3-8c6b-98c30ce05762"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 6", 0, new Guid("5c58ecca-7883-4c58-a966-76a7d6acd059") },
                    { new Guid("d2a2df73-283d-42c5-99b7-af9525d13b9c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 10", 0, new Guid("44d06181-aa4c-4953-a147-54f3a4f48ec0") },
                    { new Guid("d5a00afc-3559-4968-92a6-1cf2cc4f7133"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 5", 0, new Guid("571704a5-609a-4927-8031-9ef5a31dcab6") },
                    { new Guid("d8799aec-ac08-4e70-b061-02dd771b68c3"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 3", 0, new Guid("2a654b4f-98e4-4496-b8d0-429561643e25") },
                    { new Guid("d9a4e8d4-6cae-4546-aa86-df4c047c0b84"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 8", 0, new Guid("fcd6e363-e464-4dba-8a64-f74c0fa266a3") },
                    { new Guid("da55adb3-3f52-4225-9165-e200df33b69c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 5", 0, new Guid("0f988854-19b0-4fda-aa4f-9e30026d9471") },
                    { new Guid("dc6cb4ff-303b-4069-b825-2eb4894cb016"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 7", 0, new Guid("bc4f42b6-39f4-4f1f-9920-a20e0c2cb19d") },
                    { new Guid("ddf171cf-1de3-43a9-9386-fc4726e828e4"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 2", 0, new Guid("bd12c351-4457-4bcc-8a30-0f1c14e55c1f") },
                    { new Guid("e013db6b-8494-4044-afee-d1af7dafdbb5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 4", 0, new Guid("14fa59fe-8b1e-4637-a78b-28a58da1a7d7") },
                    { new Guid("e036e211-036b-42ae-a97a-1d1872cd1cab"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 5", 0, new Guid("571704a5-609a-4927-8031-9ef5a31dcab6") },
                    { new Guid("e11ef06a-0333-4d76-bad7-c390f0fee1d1"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 8", 0, new Guid("34c28cf2-640e-4485-b7ec-e2e43eeaf8c1") },
                    { new Guid("e261089f-3664-4c1f-9fd8-671ac07c79fb"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 10", 0, new Guid("6b835662-6be8-42ad-8c6d-bc36efbd8a42") },
                    { new Guid("e5959edf-a391-449b-bddf-eee4dd4f0585"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 1", 0, new Guid("a5caf6f4-e240-480f-a940-11f4be61d107") },
                    { new Guid("e5e78088-0099-4b76-83d0-ff679d541cea"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 7", 0, new Guid("4901702e-b3c2-4109-977c-e19c6af1c849") },
                    { new Guid("e6694028-9471-4b7e-921e-c0402c124f11"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 5", 0, new Guid("b25a9692-7ce7-45cc-89d5-f4618cc53c02") },
                    { new Guid("e818aeeb-838a-4a2c-8206-1a45b006f184"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 5", 0, new Guid("571704a5-609a-4927-8031-9ef5a31dcab6") },
                    { new Guid("e99fc9cf-f544-4c9b-a1f2-f4d50cf86d1f"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 2", 0, new Guid("bd12c351-4457-4bcc-8a30-0f1c14e55c1f") },
                    { new Guid("e9eb7675-0953-455f-aa11-87bb071503c3"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 9", 0, new Guid("d4386136-0b0a-4be3-8a44-971dd2f44a27") },
                    { new Guid("ea4f96ab-b5ed-4f00-a750-4a399e41ccee"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 3", 0, new Guid("9a8d51ee-5422-4ff1-9266-a8ddb9b28506") },
                    { new Guid("ea5ed2cc-5d53-4b87-9cae-819c585d86a6"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 9", 0, new Guid("ebabd0c6-682f-46bc-9306-885b5dca0bca") },
                    { new Guid("eb2d0422-63d6-4d18-803e-1c8035b46552"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 10", 0, new Guid("44d06181-aa4c-4953-a147-54f3a4f48ec0") },
                    { new Guid("eb58e5b6-7def-4334-bc16-d42aa74e258b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 5", 0, new Guid("daa59107-8ac1-4c99-b352-c0595b0a75ed") },
                    { new Guid("ebe72e74-4475-4a0b-b8d6-bc30c1244856"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 1", 0, new Guid("2b296194-80b9-4d26-9c12-b04a8ff5f810") },
                    { new Guid("ebf29c5a-8c91-474d-9c22-b033dd1de321"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 9", 0, new Guid("d4386136-0b0a-4be3-8a44-971dd2f44a27") },
                    { new Guid("ef758b0b-d3ae-425e-bd10-cdf49182670f"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 2", 0, new Guid("6044851b-aee0-4cd9-b131-b31d0c4b72cc") },
                    { new Guid("f0b610e0-7d72-4ede-94a0-e8a62a80bf71"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 5", 0, new Guid("daa59107-8ac1-4c99-b352-c0595b0a75ed") },
                    { new Guid("f30febd6-f122-439d-a5cd-3d395a1df439"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 3", 0, new Guid("06df286e-efa3-49d2-b31c-b79b1486301b") },
                    { new Guid("f5592fc6-7ef5-4dd7-bfd3-c184a54fec6f"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 9", 0, new Guid("7d29aabf-4c0a-46e9-85bf-334426cf6d18") },
                    { new Guid("f58eae5f-0235-48a7-bd9b-a7a8ae6c1565"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 6", 0, new Guid("de3ee8e8-10e2-4a2a-8017-123a8319605d") },
                    { new Guid("f5ad9149-959b-4e62-8a53-196c820d2568"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 9", 0, new Guid("7d29aabf-4c0a-46e9-85bf-334426cf6d18") },
                    { new Guid("f6c50ada-fbaf-477b-a0ea-eb67c9ca7067"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 10", 0, new Guid("999838d1-185c-4cd3-82e9-c3f04ba44f53") },
                    { new Guid("f8d7ae4d-cba5-45e0-bf2b-11031a7bc62d"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 7", 0, new Guid("01b506dc-4262-4d73-8300-7d8db793beda") },
                    { new Guid("fcacbd99-cef0-4d7e-9801-8f60ebfc5635"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 3", 0, new Guid("06df286e-efa3-49d2-b31c-b79b1486301b") },
                    { new Guid("fd34f0d6-850e-4f40-8862-d89aaf795c9c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 10", 0, new Guid("999838d1-185c-4cd3-82e9-c3f04ba44f53") },
                    { new Guid("ffdac67b-67b9-4611-a6bd-3ba19d2cfad9"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 4", 0, new Guid("dd6c8b83-0d1f-472a-bc00-29b3cd72a58e") }
                });

            migrationBuilder.InsertData(
                table: "SpecializationCourses",
                columns: new[] { "CoursesId", "SpecializationsId" },
                values: new object[,]
                {
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") },
                    { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") },
                    { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") },
                    { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") },
                    { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") },
                    { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") },
                    { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") },
                    { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") },
                    { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") },
                    { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") },
                    { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") }
                });

            migrationBuilder.InsertData(
                table: "UserInterstes",
                columns: new[] { "Id", "CategoryId", "CourseId", "InterestsListId", "IsActive", "UserId" },
                values: new object[,]
                {
                    { 1, new Guid("bc9e8701-dfd3-49b6-8d6a-022e6148a612"), null, null, false, new Guid("1dd9d4bd-03c3-4d41-9d43-ccf7fa5df734") },
                    { 2, new Guid("4ff3c47d-cbba-4caa-9b4a-c77385200763"), null, null, false, new Guid("e5bc1e5e-0b3e-4451-81fc-a450a4d4c40f") },
                    { 3, new Guid("a10ae102-35bd-47b8-84ac-8ee526daa3a3"), null, null, false, new Guid("5487f184-010c-4907-8ace-d7196f64f9c4") },
                    { 4, new Guid("74592176-ab98-482e-8f97-f78e77a22053"), null, null, false, new Guid("90506af4-9600-49c4-b188-0ace521eee40") },
                    { 5, new Guid("ab847495-0b58-4a26-ab79-fe44f23cb73a"), null, null, false, new Guid("36cdf7f5-8d68-42fa-9582-5ab14f67079f") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AcademicYear", "CountryId", "Created", "CreatedBy", "DepartmentId", "Email", "FacultyId", "FirstName", "LastModified", "LastModifiedBy", "LastModifiedStatus", "LastName", "MobileNumber", "Password", "RegisterAt", "RoleId", "SpecializationId", "Status", "StudyLevel", "UniversityId", "UserType" },
                values: new object[,]
                {
                    { new Guid("398da2cc-c7d7-43c7-9db8-d145e173e349"), null, 9, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(825), null, new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75"), "instructor_full9@example.com", new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0"), "InstructorFirstName9", null, null, null, "InstructorLastName9", "1234567899", "password9", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(820), new TimeSpan(0, 2, 0, 0, 0)), null, new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65"), 2, null, new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a"), 2 },
                    { new Guid("4b5babd9-73c6-4d90-90dd-1f70a5bc73a8"), null, 8, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(813), null, new Guid("c7855715-481d-4509-acad-86cb46907dc2"), "instructor_full8@example.com", new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96"), "InstructorFirstName8", null, null, null, "InstructorLastName8", "1234567898", "password8", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(803), new TimeSpan(0, 2, 0, 0, 0)), null, new Guid("02ac102b-8c02-4210-8452-0ebd526897bc"), 2, null, new Guid("808e2de7-1b11-4bf7-b623-7086847fadea"), 2 },
                    { new Guid("9b7040a7-20d1-4202-83ef-abb128f12444"), null, 6, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(783), null, new Guid("a28744e6-541e-4aad-9918-f4b322f33223"), "instructor_full6@example.com", new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc"), "InstructorFirstName6", null, null, null, "InstructorLastName6", "1234567896", "password6", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(773), new TimeSpan(0, 2, 0, 0, 0)), null, new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd"), 2, null, new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a"), 2 },
                    { new Guid("a6cfdcad-b9c4-449d-8d78-ac2fcdab36ff"), null, 10, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(840), null, new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03"), "instructor_full10@example.com", new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934"), "InstructorFirstName10", null, null, null, "InstructorLastName10", "12345678910", "password10", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(834), new TimeSpan(0, 2, 0, 0, 0)), null, new Guid("c8417977-5776-41b2-965f-784899f94fe4"), 2, null, new Guid("b02b142e-63da-467d-bb42-f811de15a2f1"), 2 },
                    { new Guid("b3330760-4238-454c-b164-9946ecae27b9"), null, 7, new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Local).AddTicks(796), null, new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616"), "instructor_full7@example.com", new Guid("3d534569-ac30-4b29-beb6-befc4087fb17"), "InstructorFirstName7", null, null, null, "InstructorLastName7", "1234567897", "password7", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 39, 26, 384, DateTimeKind.Unspecified).AddTicks(791), new TimeSpan(0, 2, 0, 0, 0)), null, new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975"), 2, null, new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5"), 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInterstes",
                columns: new[] { "Id", "CategoryId", "CourseId", "InterestsListId", "IsActive", "UserId" },
                values: new object[,]
                {
                    { 6, new Guid("79d717b2-2728-4f55-b05c-423650980479"), null, null, false, new Guid("9b7040a7-20d1-4202-83ef-abb128f12444") },
                    { 7, new Guid("5ea27783-866c-4a60-994b-e4ec07efeca3"), null, null, false, new Guid("b3330760-4238-454c-b164-9946ecae27b9") },
                    { 8, new Guid("30ddcf91-ee89-43de-988a-b8885ce9889c"), null, null, false, new Guid("4b5babd9-73c6-4d90-90dd-1f70a5bc73a8") },
                    { 9, new Guid("bd4b0c66-08ab-4b92-93a2-5714d49b6cd6"), null, null, false, new Guid("398da2cc-c7d7-43c7-9db8-d145e173e349") },
                    { 10, new Guid("416a7a0a-8fe5-40ee-bcf2-52bee7e59344"), null, null, false, new Guid("a6cfdcad-b9c4-449d-8d78-ac2fcdab36ff") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TopicId",
                table: "Categories",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_CourseId",
                table: "Classes",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_InstructorId",
                table: "Classes",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRequests_ClassId",
                table: "ClassRequests",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRequests_StudentId",
                table: "ClassRequests",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudents_StudentsId",
                table: "ClassStudents",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Code",
                table: "Courses",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicId",
                table: "Courses",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_FacultyId",
                table: "Department",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCourses_DepartmentsId",
                table: "DepartmentCourses",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_UniversityId",
                table: "Faculty",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_FacultyCourses_FacultiesId",
                table: "FacultyCourses",
                column: "FacultiesId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCourses_CourseId",
                table: "InstructorCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCourses_InstructorId",
                table: "InstructorCourses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_InteractiveElements_LessonPartId_ElementNumber",
                table: "InteractiveElements",
                columns: new[] { "LessonPartId", "ElementNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LessonParts_LessonId_PartNumber",
                table: "LessonParts",
                columns: new[] { "LessonId", "PartNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_SectionId",
                table: "Lessons",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizId",
                table: "Questions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_LessonId",
                table: "Quizzes",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_SectionId",
                table: "Quizzes",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CourseId",
                table: "Sections",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecializationCourses_SpecializationsId",
                table: "SpecializationCourses",
                column: "SpecializationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Specializations_DepartmentId",
                table: "Specializations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAvailableCourses_CourseId",
                table: "StudentAvailableCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Universities_CountryId",
                table: "Universities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityCourses_UniversitiesId",
                table: "UniversityCourses",
                column: "UniversitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCourses_InstructorsId",
                table: "UserCourses",
                column: "InstructorsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInterstes_CategoryId",
                table: "UserInterstes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInterstes_CourseId",
                table: "UserInterstes",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInterstes_InterestsListId",
                table: "UserInterstes",
                column: "InterestsListId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInterstes_UserId",
                table: "UserInterstes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryId",
                table: "Users",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentId",
                table: "Users",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_FacultyId",
                table: "Users",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SpecializationId",
                table: "Users",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UniversityId",
                table: "Users",
                column: "UniversityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicIntegrities");

            migrationBuilder.DropTable(
                name: "AccessCodes");

            migrationBuilder.DropTable(
                name: "AuthorizingTeamMembers");

            migrationBuilder.DropTable(
                name: "ClassRequests");

            migrationBuilder.DropTable(
                name: "ClassStudents");

            migrationBuilder.DropTable(
                name: "DepartmentCourses");

            migrationBuilder.DropTable(
                name: "FacultyCourses");

            migrationBuilder.DropTable(
                name: "InstructorCourseOverrides");

            migrationBuilder.DropTable(
                name: "InstructorCourses");

            migrationBuilder.DropTable(
                name: "InteractiveElements");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "ResearchEntries");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "SpecializationCourses");

            migrationBuilder.DropTable(
                name: "StudentAvailableCourses");

            migrationBuilder.DropTable(
                name: "StudentSuccessStories");

            migrationBuilder.DropTable(
                name: "UniversityCourses");

            migrationBuilder.DropTable(
                name: "UserCourses");

            migrationBuilder.DropTable(
                name: "UserInterstes");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "LessonParts");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "InterestsList");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Universities");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
