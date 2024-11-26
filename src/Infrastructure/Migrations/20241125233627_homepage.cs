using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlexBook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class homepage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HomePageSectionId",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HomePageSections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BooksTitleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BooksTitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BooksDescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BooksDescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstFeatureTitleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstFeatureTitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstFeatureDescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstFeatureDescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeconedFeatureTitleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeconedFeatureTitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeconedFeatureDescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeconedFeatureDescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeaturedImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrowthTitleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrowthTitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrowthDescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrowthDescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrowthImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighlightedBooksTitleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighlightedBooksTitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighlightedBooksDescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighlightedBooksDescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoTitleAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoTitleEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoDescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoDescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageSections", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_Courses_HomePageSectionId",
                table: "Courses",
                column: "HomePageSectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_HomePageSections_HomePageSectionId",
                table: "Courses",
                column: "HomePageSectionId",
                principalTable: "HomePageSections",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_HomePageSections_HomePageSectionId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "HomePageSections");

            migrationBuilder.DropTable(
                name: "ResearchEntries");

            migrationBuilder.DropIndex(
                name: "IX_Courses_HomePageSectionId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "HomePageSectionId",
                table: "Courses");
        }
    }
}
