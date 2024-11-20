using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlexBook.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f239e6e-8dfc-4e19-8392-8284c4f67825"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("adb27ad2-341b-4e8d-8b74-87df756f35b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b103d1c6-8672-4228-b406-73ee1c3d3cd0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc9e8701-dfd3-49b6-8d6a-022e6148a612"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ecdeab71-5c44-4169-9b2b-7b4b0995cb22"));

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("a28744e6-541e-4aad-9918-f4b322f33223") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("c7855715-481d-4509-acad-86cb46907dc2") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("d94b5445-7088-4897-ab8a-2838d7652341") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("3d534569-ac30-4b29-beb6-befc4087fb17") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("51079a63-f613-4ceb-becb-a9bc39d91570") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96") });

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0f72603c-d267-45e5-a052-5bf91c5e452c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("10590ac4-88ec-4b3f-aa58-54f43a98eac0"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("14150028-52a4-4118-b28c-05dcf0423b38"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("145201b2-aa77-447b-aabb-3e8c5c289cde"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1615a84b-1c8b-47be-b9cb-f4819287c029"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("16f55cc9-4a74-4697-aea2-6f3bb7158ebc"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("184882d3-3bce-4bc5-b2b4-d3aee0591846"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("18c754c1-2c99-4b17-847c-ceb64bc6a700"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("19911b79-642e-414c-a59d-cc5c04016067"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1b8b73ce-056a-4ba4-9e28-d7bab86d4faa"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1bdb141d-37d2-4f75-8cdc-c32abe8209e0"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2091400d-7f7d-4b6b-930c-be59996e593e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("237a1ce0-720b-49d1-b85e-6a7c290c71d5"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("27641025-5a42-4d38-812e-3e3c57865b27"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2a473de6-2f17-4f36-88e6-e71d85fb06c4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2ccba897-652c-49d6-af78-5edbe3471fab"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2d900c24-e807-42f3-b758-135d552806c4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2ec49a19-be40-400d-b840-1f2c35bb0469"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3014c1a6-9fdb-461e-b576-0ca9baeafe56"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("327390b5-5540-4834-987c-35d10d537c3f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("35eca212-e9a0-48ba-87ac-9f56c91f51c3"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("390f381a-1d80-4e2a-8b37-77a79d142e16"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3976c9ca-1141-40ba-98d5-137f8cdee94d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3e3cb171-b737-448d-bb36-8d19d1390c64"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("40cc4a50-4b2c-470e-9d80-5ececa1801b6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("46fecc8c-23f9-43c2-8be8-9497d80a37c8"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("49a37e0e-8903-4d62-aa69-0913d0a606f3"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("4b6e40b8-8740-419d-a5bd-ba5b60acc5f1"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("4d152a0f-5689-4445-93ea-785baa165db8"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("518e800e-0b21-4721-8463-24368faa79f7"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("528811d4-f464-433b-920c-904b25e787c0"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("52885e9d-3928-4e2d-8b1e-09df431e0879"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("52d9b909-b32f-4594-a94c-e0dd533dd2f1"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("52f0a358-e4c5-4baa-b88d-87d765e3bf73"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("535ca71f-fe68-41b2-9274-edc6383de524"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("541da2fe-563b-4dca-b1ee-63aa98f76088"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("55f9bd09-3c5f-47b2-9b3b-d18590946a69"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5677309b-b39b-49fd-9856-f6c6d96dd4a0"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("567e964c-908f-48cb-a283-4e0141f1631c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5d547b7f-0622-4ff1-ad47-7e861a7c3b37"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6062d21f-7d6c-488b-a386-b210e024ff38"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("60c56344-a7df-4b00-905a-01fe4a27b8b1"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("70e50d69-afb9-4776-8a79-90be96a51cc1"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("74a44642-1e77-482b-9974-84ec8574c739"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7986afd1-f96c-4758-a2b5-c5c15dafaddc"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7c1ea148-f63a-432f-8ca8-7d1cfe9c6577"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7e5165d0-8651-4123-88ff-92cece04d95e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("811506a3-1937-4e0e-a188-df00165dfbdb"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("825aebb6-5d9f-4105-9a31-2b9e52627b7b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("8ee02126-bf38-4f9b-bc62-85599cad9d61"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("92006b61-5be5-4e45-b4fc-cf5436f80c26"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("93afe080-5c9a-4dfb-a8ca-0cbb84edbc22"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("93f8f33d-3fa2-445b-aafd-9f6aa8348f76"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("972e1c56-0e87-4905-8f73-9eb8ae948c10"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("991f6b18-8ad7-4950-908c-5151ed4362ee"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a0514b6d-004f-4a03-acab-2f25a5219e8d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a82f9f08-76fc-42b2-b76c-71fc928eaef4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a9fc463b-54ce-4c31-b118-ccf25a3d7003"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("aa8e4f44-f50a-4b34-b84d-a3dc15a87358"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b393e09d-23d9-4be1-82e2-7b626df76897"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b41c80c8-cc26-4b62-81b1-de60d2211ae8"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b6e30c97-e217-44b2-a238-431e0e2267de"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b72be05c-d5ef-4ca4-a3dd-5243d95f8779"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("bf513be0-2515-4894-b403-863bbc417ae8"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("bfed38cf-ab8f-49d6-a0cf-0283a416e739"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c2566bb1-d192-49dd-ab2b-9562969923a3"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c29ade20-740e-4147-872e-02812fdb86df"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("cad7f779-1edf-4e45-8dbb-b788d64961fd"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("cd81bacc-146d-435e-9144-4f0412a08ad3"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("cfdedcda-c84a-43ab-bd16-fdc7fe6349d4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("cfe1e150-62d7-483b-9118-0c426fc70b51"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("cfe6e81b-afcd-45ef-9047-7d0cae2b7077"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("cfec8431-ed45-4058-9906-24451c10c43a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d4b5a644-d9fa-49c9-b8cb-2687b9dcb0fd"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d5c12ad5-fe59-47f1-923a-495646dee91e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d820078f-eb5b-42f0-962b-c1b27ec2e58c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("dabfbb66-bf04-4e60-be19-69d14b4dd3f8"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("de77308c-2f22-497a-b646-6b2653f24760"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("deb93c86-39cd-4f9d-b46c-6378238055f5"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("dff3ecf5-f1a3-4b25-ac4c-26ee63786092"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e253806b-1b27-4241-ad2c-434efddbbe87"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e4e8db9f-56bd-415f-9522-2639447847fb"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e70b7825-307a-406d-b9e8-8404e7e99934"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e7db8864-f3b0-4b7e-9eff-1e16fb92af6d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e8aa7546-10b9-4d82-80aa-57103858629f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e964e35e-95a9-4cb1-8774-deecad271fd4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("eb829323-dbe9-4c11-b7f1-4ef3dbaa058b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f232792c-898f-46cf-8257-719aaeb5dd92"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f68d2484-5608-4bcd-81ee-229d9f9d7d17"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("fd457f14-f437-4cfc-af7a-7d4c832503b9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("01d1ee0e-4cba-42bd-8ae7-8472b9d75321"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("01ed758f-45db-4579-add3-11a32f48be8c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("02cf053f-820e-4b65-8531-7e555382b1d1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("04986a60-b6b8-4611-9068-7b90770c18c2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("066ad16e-2ea5-4640-901a-9354b76d4bc8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("06a7b504-1769-4ca6-a445-8eff6c7951cf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("09edb6e2-aa83-4922-9280-a78fbc30bc6b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0d072d48-4cb6-4007-ab63-a4a638f76097"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0f00bec2-8ff3-431e-b2e2-94474ba50e7f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("124b317a-76e3-4c2d-9098-0a7c91227db2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("12c4527f-7ad6-46a2-81c1-d6803ed84968"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("14384a4a-af15-44a2-9b84-d6038102c958"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("15910aa0-a270-435f-92ca-bb4f2855b274"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("15df547b-e3ed-4793-a99e-90b6750bddb8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("15ebf5a8-1964-4f98-9d96-4575c7335118"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1796e4bc-3c95-4ec4-8005-b5ba65fb458a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("17b41dbd-5e55-44e7-8828-9c76dd4c1568"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("17f2b4cc-1bd0-4d7b-9792-27ef17953468"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("199f008f-e27e-4f98-867e-aa3dfc893fb7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("19f9a649-4e1a-49cd-9be4-70a0c31644b8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1ac43a06-dd9f-44a6-9622-588af6dc7dd9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1b1cd0ed-fbde-4825-947d-d5b27f402db5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2635dc5a-6962-477f-adbd-b33b2191fc21"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("274e3d01-18bd-4f11-b1fb-2a9c73284226"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("280b59c1-b053-4c3f-be55-16dded58df7c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("291d2d50-0377-4d05-89f1-0023a0aa6ed1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("296688e2-2b8d-4e6e-b13a-4034a22ed6d7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2a3d9930-f591-4b74-b885-f61b2bfc8085"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2a471623-bdeb-4da5-9b14-79e644f53977"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2afefb55-b773-4967-9445-47706ec704b8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2cb0c98e-a9e5-47aa-b472-b0995e4ecf0b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2d1b0a3f-6845-4012-93f3-b2710415ab82"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2f1426fb-7dc7-48f6-89e0-b6457cd13dea"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("33690d11-2086-4270-ae1d-e89710424c04"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("34897f51-a162-43a4-a9ac-4cf9d594b781"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3494be46-9664-462e-9d68-aae0a7e085ca"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3603208f-e15f-4742-aff1-21e5a72d43c3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("36989235-3c71-4976-ab9c-ba2deb418841"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("37545957-e7f0-468b-9ff9-11fed505ae26"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("383c75cc-94fc-4356-a766-4c5ed164371e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("38a9d544-b9a8-41a7-ba9a-d739583903d5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("39b5958f-9dd1-431d-b362-be02c5dd08ce"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3ae907b1-60d6-4261-8262-392e70123ed5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3bb1a2dc-4a81-44c5-9b15-d72c4a431cdd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3c3a336a-7025-4d76-a344-f4c23e08f9c9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3d97055d-c5f9-42c0-9747-31107c8513dd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("40f6f73f-7a53-47cc-98bf-aba88a55b009"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("41f29ff3-cad4-4361-895c-4d86f03eb5e2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("47fa5bd5-9cc2-4059-9509-d288f0f40a68"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4802499b-1cc7-4692-833d-8e5c57dc15a5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4aff4a9a-ca64-4698-a92f-7c5be2b766f5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4f6f49f5-2893-42f2-9a3d-a192acbdeb47"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4fbcf302-7c2d-4b70-a4cc-c2fbeb6272a3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4fe9fb02-ae01-4b33-86bf-301ff6211763"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("52ed5b82-ccc9-49d4-bb5f-3e31d0584990"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("56ff671e-ac77-4520-a691-d6ca8b2d291d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("57ddf235-f7e4-406e-89f8-1a17872d958b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5862c235-2281-4451-beee-0d11235390a6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("587b28b6-5993-46f9-aff3-ef01636ac158"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5c6e012e-77fe-446e-b24c-8587c2145929"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5caced65-25a9-4bf8-840b-204375c202cb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5d9e5427-3cd9-47a0-b272-892eb3022e31"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5dcf29f4-40bc-44e2-bbaa-3c239d2c2d8f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5f87981d-0552-45de-865c-4da2d33d4047"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("604ee945-795e-40d8-b104-433361babc22"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("612f253c-ab0d-4392-8754-076ee9a424f3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("621e1a6b-980d-428d-913e-5b3b23d6c3b9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("659f31bb-5409-4fad-8823-3ded15ccb2ca"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("668c0ad2-8930-4228-a025-7d3b4214468a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6782bbe7-921f-4bab-89f3-4cbef33b03cd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6809add1-82a5-4e3b-99ce-fae20415b508"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("68247a5e-e4c5-4ed2-8b15-04eeeee046e9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6d6acc42-7125-4514-ade1-8b17ed1527eb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6e000f4d-e3b4-4c6c-9501-0e406e0e4672"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6ebbc8d4-c707-4252-a6d9-bea981545dd2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("70a80c77-f6f6-45af-87b7-440760edadd7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("73cb5df0-8776-43a3-a5e2-d0ba937849d2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("74eb50e6-803e-4119-b282-a691022db4fb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("795afa88-edc6-495a-bc46-a9fedfe89b4c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7a4ba1f9-ada5-4a2a-9a81-d805161afa69"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7b58c23e-1603-4c7d-90e5-839151d2de3e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7bb57a06-00c4-4d9e-ac57-4b21d4b4b0b7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7d0a3430-58bc-4af3-9cd8-4c6bafc47ace"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7d1cda8f-bd3d-46d4-82ab-9c683d2171ec"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7d9205f1-0135-4306-88c1-6d021a449376"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7dd4b326-a41e-43c4-945d-1c271caa9a3f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7ebb341e-6b64-4ac7-b225-a1bbf0791197"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7fb3e8ca-aa9a-404d-9873-b19170c4ecd2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("82681d10-186c-4f7d-a8a5-e15e3e28d845"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("82ebf70a-aa56-45cf-9b5b-14f26fd9a392"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("835df64e-8ea2-40ab-958b-94200097ca83"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("83ac33cd-dad3-487c-8c2f-5418d8e292bc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("869e74a6-6133-45cb-b757-72fee61d14a4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("899a70c9-e391-4662-8cb8-b04d764a00a5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8bfb6e32-95f5-4d65-b65d-d0060d47800a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8c395ac1-a14f-4db8-bd8a-eff7678f1de8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8c74a27e-b0af-42c5-bf2f-30269cc48908"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8c9865bb-f50d-4874-a297-d251191e7d76"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8e0aa9c1-5784-49fb-a1cd-f69297b6d5b1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8f100e1d-cece-4a19-9200-145e141506ec"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8f12d0ba-e5da-4d9d-83ce-5c05f77b7641"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("90c73c4c-f055-434e-ae01-595d988a81a1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("916be6c9-610b-44d6-af46-d119e8edff79"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9257f4a4-47b9-4129-818f-7d987bbf330e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("929110ef-d129-4a9e-b464-a0ab16648683"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("92b921e4-08ff-4f2c-8ddd-5ace3395d724"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("990804c9-769a-459a-8232-8e90ab809aeb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9ab4a4cd-2843-4206-aff1-91f76b922602"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9bb0b895-a028-4592-ab56-bcaa024603b7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9bc16b6e-1968-4dc6-9984-f0689bcca1c7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9c572038-79f5-4663-b390-91b02ca43f88"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9e00f01c-114c-494a-b0f2-e18e6cfe0658"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9e6d5049-074c-4b91-9e0c-c4483264daf2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9f13aec1-a798-477d-976c-00def1c43d36"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9f628546-63dc-47db-acec-77343351075b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a0012693-be29-4104-99c5-bd9a6bc92b4f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a08ac8b6-c4fa-4cb1-97cd-a33d59dc8fd0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a1eae3fe-c886-45c6-b790-5b6beb611b12"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a2cec2fa-8e1d-4f02-9744-abebebe1f1b5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a4d596c9-46af-414f-ac8b-a8a91acdbbb0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a71c3108-4329-4f0b-ad58-f144a99b4c49"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a9c4daad-e493-4376-b365-e85bf178081d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("aac9c189-683d-49a9-950f-355fbcf0f992"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ab9fec47-7bb8-4a48-bcd9-5576a1d6cb66"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("aba1dd7d-c8d5-4fbc-83fc-a0baa42a04b7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ac686b8c-e147-49d0-9061-42c6c01aefb2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("afdf1455-9c78-4ec0-a0eb-822b844a8f5c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b08081f7-d70e-418e-ac50-522febc3b525"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b56b610d-3803-4e50-9c78-2ee826675aba"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b5d82e13-5dc4-4897-9f6a-b76a15b2fc5b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b6e4e0c0-a2de-4c85-a868-88c8f06a938b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bb131091-a2bd-4325-b767-c76254fb66d1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bd6188bb-7e5a-416d-8e9e-671021d6a0d5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c03105ad-40f8-4bb3-afb4-634ee8ec2ffd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c048b37d-77d3-43f9-a804-786099b9f560"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c053e11b-4001-4d17-85a4-dc760ecaaee9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c091fbd7-7752-4353-b0d0-9571b4481601"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c0e97723-6663-4d7c-bfce-07d174e9df5c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c1e006f1-0edc-47b3-becb-e53ebfb520e2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c748f6a3-5fa8-4adc-90b2-08e0ec9bd606"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c8fb1fdf-50d8-41ef-8440-b764932dd8f9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ca5714a1-6667-4d49-acb5-4749d7b5b96b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cd7d966d-fc4f-4148-9f28-ec800864d6c0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cee48d09-1e17-4448-9b77-1e7715e5a118"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d02c91bc-449f-4687-ba2f-6f97d26dec0b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d05542a8-8111-41a3-8c6b-98c30ce05762"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d2a2df73-283d-42c5-99b7-af9525d13b9c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d5a00afc-3559-4968-92a6-1cf2cc4f7133"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d8799aec-ac08-4e70-b061-02dd771b68c3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d9a4e8d4-6cae-4546-aa86-df4c047c0b84"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("da55adb3-3f52-4225-9165-e200df33b69c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dc6cb4ff-303b-4069-b825-2eb4894cb016"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ddf171cf-1de3-43a9-9386-fc4726e828e4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e013db6b-8494-4044-afee-d1af7dafdbb5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e036e211-036b-42ae-a97a-1d1872cd1cab"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e11ef06a-0333-4d76-bad7-c390f0fee1d1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e261089f-3664-4c1f-9fd8-671ac07c79fb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e5959edf-a391-449b-bddf-eee4dd4f0585"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e5e78088-0099-4b76-83d0-ff679d541cea"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e6694028-9471-4b7e-921e-c0402c124f11"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e818aeeb-838a-4a2c-8206-1a45b006f184"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e99fc9cf-f544-4c9b-a1f2-f4d50cf86d1f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e9eb7675-0953-455f-aa11-87bb071503c3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ea4f96ab-b5ed-4f00-a750-4a399e41ccee"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ea5ed2cc-5d53-4b87-9cae-819c585d86a6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("eb2d0422-63d6-4d18-803e-1c8035b46552"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("eb58e5b6-7def-4334-bc16-d42aa74e258b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ebe72e74-4475-4a0b-b8d6-bc30c1244856"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ebf29c5a-8c91-474d-9c22-b033dd1de321"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ef758b0b-d3ae-425e-bd10-cdf49182670f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f0b610e0-7d72-4ede-94a0-e8a62a80bf71"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f30febd6-f122-439d-a5cd-3d395a1df439"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f5592fc6-7ef5-4dd7-bfd3-c184a54fec6f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f58eae5f-0235-48a7-bd9b-a7a8ae6c1565"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f5ad9149-959b-4e62-8a53-196c820d2568"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f6c50ada-fbaf-477b-a0ea-eb67c9ca7067"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f8d7ae4d-cba5-45e0-bf2b-11031a7bc62d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fcacbd99-cef0-4d7e-9801-8f60ebfc5635"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fd34f0d6-850e-4f40-8862-d89aaf795c9c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ffdac67b-67b9-4611-a6bd-3ba19d2cfad9"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("0df1b8c1-b48e-4578-8b00-fe85b6339d78"), new Guid("1a7ff869-9983-46e1-8cee-b0718dc5a7b3") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("2a935c92-870b-4724-8bc0-870f0ac64e8d"), new Guid("1a7ff869-9983-46e1-8cee-b0718dc5a7b3") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("2b5fcaf1-b71b-482b-b58a-c82dfe673410"), new Guid("1a7ff869-9983-46e1-8cee-b0718dc5a7b3") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("cbc954ce-9837-48ad-bf80-6700cdf00b0c"), new Guid("1a7ff869-9983-46e1-8cee-b0718dc5a7b3") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("dec54250-142c-455e-ba9a-72cbf317e23d"), new Guid("1a7ff869-9983-46e1-8cee-b0718dc5a7b3") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("0df1b8c1-b48e-4578-8b00-fe85b6339d78"), new Guid("76961ba4-289a-4df1-81ad-30425c35b228") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("2b5fcaf1-b71b-482b-b58a-c82dfe673410"), new Guid("76961ba4-289a-4df1-81ad-30425c35b228") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("cbc954ce-9837-48ad-bf80-6700cdf00b0c"), new Guid("76961ba4-289a-4df1-81ad-30425c35b228") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("2a935c92-870b-4724-8bc0-870f0ac64e8d"), new Guid("f7713714-6cb3-45e4-9ee2-fded40c1c113") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("dec54250-142c-455e-ba9a-72cbf317e23d"), new Guid("f7713714-6cb3-45e4-9ee2-fded40c1c113") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e2db0992-ac0f-415a-8fad-6125c3a9d8ee"));

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("02ac102b-8c02-4210-8452-0ebd526897bc") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("33004818-1f3c-40d8-af6a-fd726134ed72") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("c347acfc-c8a2-4104-9636-42b684839bf0") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("c8417977-5776-41b2-965f-784899f94fe4") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("2838009c-a115-418a-8b23-f916911955ad"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("8166108b-f853-415a-8388-5c4534377d68"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("808e2de7-1b11-4bf7-b623-7086847fadea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("b02b142e-63da-467d-bb42-f811de15a2f1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"), new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13f85501-5ba7-4730-a923-83c476c16c3e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1ba139a6-49c9-4dd7-8456-7433d99d1296"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1dd9d4bd-03c3-4d41-9d43-ccf7fa5df734"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("244e8b2d-ba79-47cf-a86b-92781a6ba867"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("334e56b7-b26c-4fb0-8d3c-f5c5b4471ddf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("36cdf7f5-8d68-42fa-9582-5ab14f67079f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("398da2cc-c7d7-43c7-9db8-d145e173e349"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b7de2d7-0c4c-4009-9dfa-6b87dfea7e70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3dde0e9b-8793-4917-92e3-ff9721b38732"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4b5babd9-73c6-4d90-90dd-1f70a5bc73a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ebef1ff-8ab9-45ee-b780-8f9ad9be3032"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5487f184-010c-4907-8ace-d7196f64f9c4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f3ad551-da27-4a8a-a377-c67267e1e0f6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7db42ab1-d649-4b0a-8a04-d0493c6be222"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88b16744-a5e3-45e6-9ae6-8e980be0d539"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("90506af4-9600-49c4-b188-0ace521eee40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("978258fc-943a-43fc-9583-2391a80317cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b7040a7-20d1-4202-83ef-abb128f12444"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a408fd07-57e5-4c64-91d1-22ce7877c89a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6cfdcad-b9c4-449d-8d78-ac2fcdab36ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b04a16d6-f40a-4452-9f74-e78cec196cb3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3330760-4238-454c-b164-9946ecae27b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c11e9462-6774-47b2-a47f-3f56d7705b36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c9c6bfe6-fc3e-4124-ae6e-b69663cf60b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d09c55cd-68d1-46ec-a2da-a612b65d1fde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4e4badc-a12f-4374-9b13-b47ab46ad6bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e30e4217-f605-4dc5-a2ed-c18544f3114a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5bc1e5e-0b3e-4451-81fc-a450a4d4c40f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e68e19f8-2e1d-4652-a5b1-5117f595b0a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2446225-a4c5-4287-9f9b-fae8577733e1"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("0df1b8c1-b48e-4578-8b00-fe85b6339d78"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2a935c92-870b-4724-8bc0-870f0ac64e8d"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2b5fcaf1-b71b-482b-b58a-c82dfe673410"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cbc954ce-9837-48ad-bf80-6700cdf00b0c"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("dec54250-142c-455e-ba9a-72cbf317e23d"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("01b506dc-4262-4d73-8300-7d8db793beda"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("04d0d2e7-bc1f-44b0-b36f-99c1078716f8"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("06df286e-efa3-49d2-b31c-b79b1486301b"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("0a48bd12-ee6b-4d06-8e39-d6ace0c336b2"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("0f988854-19b0-4fda-aa4f-9e30026d9471"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("14fa59fe-8b1e-4637-a78b-28a58da1a7d7"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("1bec66e0-d359-4eee-a1b5-df79f7c2b6a7"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("212e0a10-05d0-41b7-936f-65b13d866522"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("23196206-dba2-4056-985d-6609716d16ed"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("292546c7-fbd4-4345-bb30-f98911d02363"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("2a654b4f-98e4-4496-b8d0-429561643e25"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("2b296194-80b9-4d26-9c12-b04a8ff5f810"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("2fe351ac-1375-4627-8fe0-61e6ab11b06f"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("32025b55-428b-42d7-846c-e3f02356dd25"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("34c28cf2-640e-4485-b7ec-e2e43eeaf8c1"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("44d06181-aa4c-4953-a147-54f3a4f48ec0"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("4606c7ba-94f9-4263-b684-aa09a36ca1be"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("47444ea4-0231-4ab6-bfd0-e822225f0f57"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("4901702e-b3c2-4109-977c-e19c6af1c849"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("571704a5-609a-4927-8031-9ef5a31dcab6"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("57b5e201-6fc2-419b-8383-2045ebe25611"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("5a1b658b-c8e2-404b-b6c3-8393250cc404"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("5c58ecca-7883-4c58-a966-76a7d6acd059"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("6044851b-aee0-4cd9-b131-b31d0c4b72cc"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("6b835662-6be8-42ad-8c6d-bc36efbd8a42"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("7c1ab144-675b-49ff-ab04-2ff61517f3d3"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("7d29aabf-4c0a-46e9-85bf-334426cf6d18"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("7d8df9ad-c916-4512-9768-55791ef05904"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("83f4153f-728c-4bed-bd9e-01cdc70e850e"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("8c16224f-2d4b-438f-9ca3-69e9e28c6ec8"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("93fbe197-11de-4337-bc46-c8d894a7eacb"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("999838d1-185c-4cd3-82e9-c3f04ba44f53"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("9a8d51ee-5422-4ff1-9266-a8ddb9b28506"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("a396ee37-e6a6-4b76-a55a-dffb70d5245d"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("a3a8304b-c041-4c71-9240-4b8f2af44dfc"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("a5caf6f4-e240-480f-a940-11f4be61d107"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("a60c18d2-78f7-4d1c-acd2-26185305accf"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("b0e2cf24-5e3f-4d93-86cf-449b46e5f5de"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("b1992c59-6514-4a40-89ad-704026ae4f82"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("b25a9692-7ce7-45cc-89d5-f4618cc53c02"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("b851832d-5b9d-43d0-b87b-6de307de78f6"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("b855bcb8-b283-4e3e-a8a5-7637190148e3"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("bc4f42b6-39f4-4f1f-9920-a20e0c2cb19d"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("bd12c351-4457-4bcc-8a30-0f1c14e55c1f"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("bef1eabd-dd3b-4b44-a469-3f2e4787abdd"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("d2e82516-49d4-4d59-8b47-3cee3c6eaf1d"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("d38231d2-6066-4895-bdad-60ce107f924f"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("d4386136-0b0a-4be3-8a44-971dd2f44a27"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("d4ea0947-e774-4055-9e50-4649b1a29385"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("d58ccfb9-7a69-4948-8c96-2b94d4978189"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("daa59107-8ac1-4c99-b352-c0595b0a75ed"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("dd6c8b83-0d1f-472a-bc00-29b3cd72a58e"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("de3ee8e8-10e2-4a2a-8017-123a8319605d"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("df1157be-2bd1-430b-aa72-314f03c3e69a"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("e791e8c9-02cd-4bf2-b047-d37666d959a9"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("ebabd0c6-682f-46bc-9306-885b5dca0bca"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("f0757e6d-5c72-498e-9c05-cf85f9135293"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("f45444d9-4fe7-4e2e-8d30-ae02f3d2d9ab"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("f557fce5-1ac1-4041-8c75-e3e0eacc8f35"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("fcd6e363-e464-4dba-8a64-f74c0fa266a3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1a7ff869-9983-46e1-8cee-b0718dc5a7b3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("76961ba4-289a-4df1-81ad-30425c35b228"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f7713714-6cb3-45e4-9ee2-fded40c1c113"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("02ac102b-8c02-4210-8452-0ebd526897bc"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("22f0a9bc-756b-4a4e-8d74-cc4fdb714d65"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("25cf74d0-26d5-4ad2-99ff-f481f3fce80e"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("33004818-1f3c-40d8-af6a-fd726134ed72"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("95472cf2-514e-43b2-b40a-6f71f2e036dd"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("adcb5384-8a60-4327-b402-11f2eb6c4625"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("c347acfc-c8a2-4104-9636-42b684839bf0"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("c8417977-5776-41b2-965f-784899f94fe4"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("e8969cde-db23-41b8-ba08-b7a406b5f975"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("f1ea26bf-e416-4f1b-a3ec-9ed2d3f1c044"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("24d96fe7-3b6e-425f-8d5c-0db8123fdd75"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("4e73df4b-526f-416e-afd5-4cb0e4031f03"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("5e753484-1943-4ece-a7d7-820e9f4cc616"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("5eb3cf49-29de-45a4-a157-99014ef58ea3"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("a28744e6-541e-4aad-9918-f4b322f33223"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("ae2a3606-1039-4f10-86d2-0aa7dc863a39"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("b4ab1da7-dab6-4903-8cf0-ae0ed31b4e1e"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("c7855715-481d-4509-acad-86cb46907dc2"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("d15c1a7f-48e8-4cce-b178-eb871a11399a"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("d94b5445-7088-4897-ab8a-2838d7652341"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("056688fa-94cf-42f2-a54d-70f3054626c9"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("062020d3-9299-4e74-bf84-8bfb82503065"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("0e109ec5-ee7a-4681-aa91-c752483b4174"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("0e46e441-b493-47bb-a708-15c7415cd954"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("0fb9c271-b4df-4892-b5b6-65f33d0e5fb7"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("1fb1c633-7b55-481a-8595-f7b146b58e5f"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("2e484020-d62b-446f-871d-2c3b91009715"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("33cc1d8c-6d9d-40a9-80bd-520fab88d002"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("3424389a-d575-4fff-912f-21d1d451bd56"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("3aab9bb8-879a-44d9-9442-0b591ac536a9"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("499de49d-e97d-4dac-b770-d608a0be1593"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("54a2ab76-ceaf-41f4-9e3f-12720e3a3fc2"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("58122722-4219-4692-97cf-7b60eae672d2"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("5d91597a-5b9e-42c5-8877-d59269a01ef3"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("5e10d718-8807-4a88-9494-d92b16c8541d"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("61c5c878-7754-4ba9-ae4e-3315253fd125"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("6a0a5851-f2e8-4834-a567-5e79d05b0baa"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("72a5ffe0-2673-4329-a8a5-7a57994f3d63"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("7f84caf6-6ae3-4590-a65e-5f2926678bcf"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("990a9b94-e3d1-4e56-98d7-fbba69db6073"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("ab4c812f-c26a-4dda-8f1f-9d7414505e37"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("ac7a5082-8c88-48af-95a9-fe1abe78bf1e"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("b352cd33-b0d5-484e-8bd8-b4c2df8c571c"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("b81aac6b-f3bb-4961-9755-020e9d81912e"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("bd39fdf2-fd61-42f9-aaf5-eb81c45f4609"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("bdf521a7-72e0-49a9-a631-7e6488160004"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("bfd7416a-4493-4526-83b5-51292dc59566"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("e2bd22aa-2ff5-4ec7-a0cb-e016a874621a"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("f04d855b-efa8-4932-b88a-cd3bc1f514f0"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("f34febee-7825-49f5-94ea-b08d6871fb7b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("07d0d7ac-1ec0-43e6-97f1-8259eee70c7e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2838009c-a115-418a-8b23-f916911955ad"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3bbc9171-0495-4239-bfa9-32b7ed804ea1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3c9b919a-10ef-477d-ade8-fd93f59e0105"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8166108b-f853-415a-8388-5c4534377d68"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a3e408fd-b119-4c86-967f-182f2148d5b2"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("aa5c307f-ef48-4a64-bf54-7dee8b108b6f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("be729a1f-04e9-4af3-93f6-6e0014758b10"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c91dbc08-5ba8-44de-a989-c7c59ff2f5e9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d7e5c53d-6874-4106-ac5d-87f1a0fab462"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("1fb27ff4-710b-427f-abcc-1fc227feed5f"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("2acc468d-3848-486d-8be7-0c2e35df7bae"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("3d534569-ac30-4b29-beb6-befc4087fb17"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("48dc3af3-3255-4cbd-8c90-75a4d85a8934"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("51079a63-f613-4ceb-becb-a9bc39d91570"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("687a8872-19bd-4465-9760-0c4b01c0e72d"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("72fb3c52-fe25-4b56-97a0-d5e3e6b724dc"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("9d3873ac-23ca-47d1-b2bc-16047cd5aae0"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("eb791ba9-75e0-4be7-b55c-328d918e2524"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("f32b64c7-edd8-4590-8a70-ba53ee8d9a96"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2b3a8cd9-33eb-4b8e-a971-b3ced41fc952"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30ddcf91-ee89-43de-988a-b8885ce9889c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("416a7a0a-8fe5-40ee-bcf2-52bee7e59344"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ff3c47d-cbba-4caa-9b4a-c77385200763"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ea27783-866c-4a60-994b-e4ec07efeca3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74592176-ab98-482e-8f97-f78e77a22053"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79d717b2-2728-4f55-b05c-423650980479"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a10ae102-35bd-47b8-84ac-8ee526daa3a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab847495-0b58-4a26-ab79-fe44f23cb73a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd4b0c66-08ab-4b92-93a2-5714d49b6cd6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("bf9b6683-a2ae-449f-82ba-f16d21a62953"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("40a3aadb-bfd0-4362-8ec8-563c0418741e"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("415f8456-7a69-4cbc-91db-a5f6d1ccdddb"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("50503846-b7f1-4fc3-b434-9cc2f94e77c5"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("7fa97de3-d508-42aa-ab0a-d4acb2c5e6f0"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("808e2de7-1b11-4bf7-b623-7086847fadea"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("ab56194d-d86f-472e-bdd2-09e48722be6f"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("ad1c4ebc-9ef2-450e-8f07-ee0c71cd793a"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("b02b142e-63da-467d-bb42-f811de15a2f1"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("b26753ba-54e9-434d-8f87-8f9894f93d4a"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("d7adf1fe-cc8d-4d57-8b7f-72622f9e450d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("1781862c-ac1f-4352-b015-e9c78135d00c"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("23f1016d-c184-44fc-87ca-2b6492d0f757"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5b4b4a2d-25a0-4739-a273-b92892ec0da7"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("8de114c5-3bc2-4e78-a0eb-2484075a2550"));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Action", "Name", "Resource" },
                values: new object[,]
                {
                    { new Guid("15b40287-e1d0-4da5-8482-b44116d39068"), "Edit", "editcourses", "Courses" },
                    { new Guid("5af320c5-6103-49c5-aacf-704d5b601764"), "Delete", "deletecourses", "Courses" },
                    { new Guid("72b51535-da3d-4249-bf95-6370ca89641e"), "Manage", "managedashboard", "Dashboard" },
                    { new Guid("8d7094f9-f09e-45b4-931e-da3abff927c6"), "View", "viewusers", "Users" },
                    { new Guid("cd65d3fd-85c6-417c-b45f-292c0a6951cc"), "Create", "createcourses", "Courses" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0840c49f-cbf1-412c-a613-c2a7d6a283aa"), "Student" },
                    { new Guid("326de8ac-dd85-4aa2-8576-960fdfcf6740"), "DashboardUser" },
                    { new Guid("4dac6d1f-e5c7-47ef-80a8-4466a3e71d1b"), "Instructor" },
                    { new Guid("efa4df83-5507-4874-968e-decefcb037d6"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "IsActive", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0eccd409-3094-4c07-a8a3-db45fe8bef2d"), false, "هندسة البرمجيات", "Software Engineering" },
                    { new Guid("101831e0-cef1-4d35-8202-2441fbb01a7e"), false, "البرمجة", "Programming" },
                    { new Guid("2c040ccf-637d-4733-9cb7-4603691366c6"), false, "تحليل البيانات", "Data Analysis" },
                    { new Guid("cf4f8f8b-9813-4303-a5e6-3167c13c08c7"), false, "أمن المعلومات", "Information Security" },
                    { new Guid("cf761fb2-6d0a-4a98-a452-1fde6b00d80e"), false, "الذكاء الاصطناعي", "Artificial Intelligence" }
                });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "CountryId", "IsActive", "LookUpStatus", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66"), 9, false, 2, "جامعة فرنسا", "University of France" },
                    { new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0"), 5, false, 2, "جامعة الهند", "University of India" },
                    { new Guid("53ee465c-d532-49f5-8625-32c906fbe83a"), 4, false, 2, "جامعة أستراليا", "University of Australia" },
                    { new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183"), 2, false, 2, "جامعة المملكة المتحدة", "University of United Kingdom" },
                    { new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb"), 10, false, 2, "جامعة الإمارات العربية المتحدة", "University of United Arab Emirates" },
                    { new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331"), 3, false, 2, "جامعة كندا", "University of Canada" },
                    { new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1"), 1, false, 2, "جامعة الولايات المتحدة", "University of United States" },
                    { new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae"), 6, false, 2, "جامعة ألمانيا", "University of Germany" },
                    { new Guid("9b109cbd-764b-4f71-b310-15211af3b68a"), 7, false, 2, "جامعة البرازيل", "University of Brazil" },
                    { new Guid("af224645-999c-43a4-acc3-a125e04590ea"), 8, false, 2, "جامعة اليابان", "University of Japan" }
                });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("966f702e-7938-4585-b496-1342b90bbf52"), new Guid("9aea080b-3a54-4e0b-9a90-ba135389f009") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("2de18ca2-46f0-4ce4-9cc0-b3bb042c77c9"), new Guid("3bccfcb6-2a5b-4712-a00d-68f80e19b710") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("ad574fdd-1013-4ce3-a201-a396f30eeb48"), new Guid("655a2acd-3b41-4a77-85eb-40bd42ba31f1") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("549ea9a1-7ba1-42c2-91e0-40188035909c"), new Guid("8ad38ab7-6587-4fae-9df0-e67c24c26342") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("3f460378-116d-42ea-b25f-20fd9ff83ca5"), new Guid("41f13c7a-56ae-405a-b2f1-bb5e925c8622") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("379e01c3-91c6-4ac7-93b7-385d3fc8b0c5"), new Guid("4538fb2c-ab35-457f-88d0-199b71c51104") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("b09566b9-2076-445e-b7fc-2ed81b3fdbd3"), new Guid("19261c7e-a908-4cf2-a376-acafad6d727d") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("2d8e1569-523a-4694-bfbb-ae0da6aeae9d"), new Guid("82b4b58d-3338-472a-be92-28b1b0b1b765") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("0c76b7d3-15ed-40c1-a862-e5619cbd4565"), new Guid("9ee4620e-f6ec-41a3-8210-f75a3c9f643b") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("86518196-917c-47fc-b594-38d899ad2c62"), new Guid("4cb92ab9-bd2e-4585-a87a-07198a2bd8d9") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AcademicYear", "CountryId", "Created", "CreatedBy", "DepartmentId", "Email", "FacultyId", "FirstName", "LastModified", "LastModifiedBy", "LastModifiedStatus", "LastName", "MobileNumber", "Password", "RegisterAt", "RoleId", "SpecializationId", "Status", "StudyLevel", "UniversityId", "UserType" },
                values: new object[,]
                {
                    { new Guid("3303d430-0d8a-42e2-87fa-ad5419d6aa9e"), null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5963), null, null, "dashboarduser2@example.com", null, "DashBoardUserFirstName2", null, null, null, "DashBoardUserLastName2", "12345678922", "password22", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5959), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("66a5a5a1-db81-49d4-bbe6-43fe95b3ec5e"), null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5953), null, null, "dashboarduser1@example.com", null, "DashBoardUserFirstName1", null, null, null, "DashBoardUserLastName1", "12345678921", "password21", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5948), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("8b33fc71-eb96-4d45-be10-cba68cef09d8"), null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(6065), null, null, "dashboarduser8@example.com", null, "DashBoardUserFirstName8", null, null, null, "DashBoardUserLastName8", "12345678928", "password28", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(6061), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("99118280-50e8-4ce9-a633-b5134dd49719"), null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5981), null, null, "dashboarduser4@example.com", null, "DashBoardUserFirstName4", null, null, null, "DashBoardUserLastName4", "12345678924", "password24", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5977), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("9a79d410-33b8-419c-9b81-855e0a29e1e5"), null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(6034), null, null, "dashboarduser5@example.com", null, "DashBoardUserFirstName5", null, null, null, "DashBoardUserLastName5", "12345678925", "password25", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5987), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("b7d0fffa-2f54-4be9-bd40-c409e18af749"), null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5972), null, null, "dashboarduser3@example.com", null, "DashBoardUserFirstName3", null, null, null, "DashBoardUserLastName3", "12345678923", "password23", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5968), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("cc261130-57fe-4a5c-84cc-be5184cced51"), null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(6044), null, null, "dashboarduser6@example.com", null, "DashBoardUserFirstName6", null, null, null, "DashBoardUserLastName6", "12345678926", "password26", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(6040), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("cde5d825-fe22-4479-bcaa-86c84a631c5b"), null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(6056), null, null, "dashboarduser7@example.com", null, "DashBoardUserFirstName7", null, null, null, "DashBoardUserLastName7", "12345678927", "password27", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(6052), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("dcc4737f-5dec-4d77-8518-c1613134af46"), null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(6074), null, null, "dashboarduser9@example.com", null, "DashBoardUserFirstName9", null, null, null, "DashBoardUserLastName9", "12345678929", "password29", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(6070), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 },
                    { new Guid("eb5e603a-8860-4d9b-863b-f4c53795d1b9"), null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(6084), null, null, "dashboarduser10@example.com", null, "DashBoardUserFirstName10", null, null, null, "DashBoardUserLastName10", "12345678930", "password30", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(6080), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CoverPhoto", "IsActive", "NameAr", "NameEn", "TopicId" },
                values: new object[,]
                {
                    { new Guid("0c76b7d3-15ed-40c1-a862-e5619cbd4565"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 3 في الذكاء الاصطناعي", "Category 3 in Artificial Intelligence", new Guid("cf761fb2-6d0a-4a98-a452-1fde6b00d80e") },
                    { new Guid("1a18d609-a4f2-43af-8417-d08666e7ed22"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 1 في هندسة البرمجيات", "Category 1 in Software Engineering", new Guid("0eccd409-3094-4c07-a8a3-db45fe8bef2d") },
                    { new Guid("2d1e6312-d850-48e3-b6f9-31fac10996a1"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 3 في هندسة البرمجيات", "Category 3 in Software Engineering", new Guid("0eccd409-3094-4c07-a8a3-db45fe8bef2d") },
                    { new Guid("2d8e1569-523a-4694-bfbb-ae0da6aeae9d"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 2 في الذكاء الاصطناعي", "Category 2 in Artificial Intelligence", new Guid("cf761fb2-6d0a-4a98-a452-1fde6b00d80e") },
                    { new Guid("2de18ca2-46f0-4ce4-9cc0-b3bb042c77c9"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 2 في البرمجة", "Category 2 in Programming", new Guid("101831e0-cef1-4d35-8202-2441fbb01a7e") },
                    { new Guid("379e01c3-91c6-4ac7-93b7-385d3fc8b0c5"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 3 في تحليل البيانات", "Category 3 in Data Analysis", new Guid("2c040ccf-637d-4733-9cb7-4603691366c6") },
                    { new Guid("3f460378-116d-42ea-b25f-20fd9ff83ca5"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 2 في تحليل البيانات", "Category 2 in Data Analysis", new Guid("2c040ccf-637d-4733-9cb7-4603691366c6") },
                    { new Guid("549ea9a1-7ba1-42c2-91e0-40188035909c"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 1 في تحليل البيانات", "Category 1 in Data Analysis", new Guid("2c040ccf-637d-4733-9cb7-4603691366c6") },
                    { new Guid("86518196-917c-47fc-b594-38d899ad2c62"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 1 في أمن المعلومات", "Category 1 in Information Security", new Guid("cf4f8f8b-9813-4303-a5e6-3167c13c08c7") },
                    { new Guid("966f702e-7938-4585-b496-1342b90bbf52"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 1 في البرمجة", "Category 1 in Programming", new Guid("101831e0-cef1-4d35-8202-2441fbb01a7e") },
                    { new Guid("ad574fdd-1013-4ce3-a201-a396f30eeb48"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 3 في البرمجة", "Category 3 in Programming", new Guid("101831e0-cef1-4d35-8202-2441fbb01a7e") },
                    { new Guid("b09566b9-2076-445e-b7fc-2ed81b3fdbd3"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 1 في الذكاء الاصطناعي", "Category 1 in Artificial Intelligence", new Guid("cf761fb2-6d0a-4a98-a452-1fde6b00d80e") },
                    { new Guid("d790f07c-392f-4918-9451-606ef1f8ad91"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 3 في أمن المعلومات", "Category 3 in Information Security", new Guid("cf4f8f8b-9813-4303-a5e6-3167c13c08c7") },
                    { new Guid("e0631c91-607d-4e3f-b941-43d1446380db"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 2 في هندسة البرمجيات", "Category 2 in Software Engineering", new Guid("0eccd409-3094-4c07-a8a3-db45fe8bef2d") },
                    { new Guid("f32f5204-3dbb-45b5-a449-10511090e2a9"), "https://localhost:7030/images/book-01.jpg", false, "تصنيف 2 في أمن المعلومات", "Category 2 in Information Security", new Guid("cf4f8f8b-9813-4303-a5e6-3167c13c08c7") }
                });

            migrationBuilder.InsertData(
                table: "Faculty",
                columns: new[] { "Id", "IsActive", "LookUpStatus", "NameAr", "NameEn", "UniversityId" },
                values: new object[,]
                {
                    { new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b"), false, 2, "كلية الهندسة 4", "Engineering Faculty 4", new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") },
                    { new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d"), false, 2, "كلية الهندسة 3", "Engineering Faculty 3", new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") },
                    { new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a"), false, 2, "كلية الهندسة 5", "Engineering Faculty 5", new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") },
                    { new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73"), false, 2, "كلية الهندسة 10", "Engineering Faculty 10", new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") },
                    { new Guid("89297dc6-4f80-4661-9667-8e28f6b13721"), false, 2, "كلية الهندسة 6", "Engineering Faculty 6", new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") },
                    { new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115"), false, 2, "كلية الهندسة 9", "Engineering Faculty 9", new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") },
                    { new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e"), false, 2, "كلية الهندسة 8", "Engineering Faculty 8", new Guid("af224645-999c-43a4-acc3-a125e04590ea") },
                    { new Guid("a3e71022-3255-4454-88a7-031080443bce"), false, 2, "كلية الهندسة 2", "Engineering Faculty 2", new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") },
                    { new Guid("a52e1528-b1a2-40ab-9aaf-402304732459"), false, 2, "كلية الهندسة 1", "Engineering Faculty 1", new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") },
                    { new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757"), false, 2, "كلية الهندسة 7", "Engineering Faculty 7", new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("72b51535-da3d-4249-bf95-6370ca89641e"), new Guid("326de8ac-dd85-4aa2-8576-960fdfcf6740") },
                    { new Guid("8d7094f9-f09e-45b4-931e-da3abff927c6"), new Guid("326de8ac-dd85-4aa2-8576-960fdfcf6740") },
                    { new Guid("15b40287-e1d0-4da5-8482-b44116d39068"), new Guid("4dac6d1f-e5c7-47ef-80a8-4466a3e71d1b") },
                    { new Guid("5af320c5-6103-49c5-aacf-704d5b601764"), new Guid("4dac6d1f-e5c7-47ef-80a8-4466a3e71d1b") },
                    { new Guid("cd65d3fd-85c6-417c-b45f-292c0a6951cc"), new Guid("4dac6d1f-e5c7-47ef-80a8-4466a3e71d1b") },
                    { new Guid("15b40287-e1d0-4da5-8482-b44116d39068"), new Guid("efa4df83-5507-4874-968e-decefcb037d6") },
                    { new Guid("5af320c5-6103-49c5-aacf-704d5b601764"), new Guid("efa4df83-5507-4874-968e-decefcb037d6") },
                    { new Guid("72b51535-da3d-4249-bf95-6370ca89641e"), new Guid("efa4df83-5507-4874-968e-decefcb037d6") },
                    { new Guid("8d7094f9-f09e-45b4-931e-da3abff927c6"), new Guid("efa4df83-5507-4874-968e-decefcb037d6") },
                    { new Guid("cd65d3fd-85c6-417c-b45f-292c0a6951cc"), new Guid("efa4df83-5507-4874-968e-decefcb037d6") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AcademicYear", "CountryId", "Created", "CreatedBy", "DepartmentId", "Email", "FacultyId", "FirstName", "LastModified", "LastModifiedBy", "LastModifiedStatus", "LastName", "MobileNumber", "Password", "RegisterAt", "RoleId", "SpecializationId", "Status", "StudyLevel", "UniversityId", "UserType" },
                values: new object[,]
                {
                    { new Guid("10fdc47a-7c95-43fd-97aa-4dcf0db51011"), "Year 7", 7, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5900), null, null, "student7@example.com", null, "StudentFirstName7", null, null, null, "StudentLastName7", "12345678917", "password17", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5896), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 7", new Guid("9b109cbd-764b-4f71-b310-15211af3b68a"), 1 },
                    { new Guid("3d054e0a-7e77-44ef-a5af-95794dc88daa"), "Year 3", 3, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5806), null, null, "student3@example.com", null, "StudentFirstName3", null, null, null, "StudentLastName3", "12345678913", "password13", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5802), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 3", new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331"), 1 },
                    { new Guid("4af3593f-44ce-40af-a81f-9a6b433cc16b"), "Year 2", 2, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5795), null, null, "student2@example.com", null, "StudentFirstName2", null, null, null, "StudentLastName2", "12345678912", "password12", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5791), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 2", new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183"), 1 },
                    { new Guid("658a7a23-caaf-4d4e-a6ee-fe65c80ccdb7"), "Year 5", 5, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5828), null, null, "student5@example.com", null, "StudentFirstName5", null, null, null, "StudentLastName5", "12345678915", "password15", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5824), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 5", new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0"), 1 },
                    { new Guid("6921b69c-febf-453e-a2fb-60c634bb631c"), "Year 9", 9, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5927), null, null, "student9@example.com", null, "StudentFirstName9", null, null, null, "StudentLastName9", "12345678919", "password19", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5922), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 9", new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66"), 1 },
                    { new Guid("7a9c9716-c31c-4152-9ff2-744b53fe9cb9"), "Year 1", 1, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5782), null, null, "student1@example.com", null, "StudentFirstName1", null, null, null, "StudentLastName1", "12345678911", "password11", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5776), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 1", new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1"), 1 },
                    { new Guid("a3842b52-7160-4a0f-a0dc-787213ec76e1"), "Year 6", 6, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5888), null, null, "student6@example.com", null, "StudentFirstName6", null, null, null, "StudentLastName6", "12345678916", "password16", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 6", new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae"), 1 },
                    { new Guid("d4dfa26e-b7ce-4cd8-b67a-c9363a446bc3"), "Year 4", 4, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5817), null, null, "student4@example.com", null, "StudentFirstName4", null, null, null, "StudentLastName4", "12345678914", "password14", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5813), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 4", new Guid("53ee465c-d532-49f5-8625-32c906fbe83a"), 1 },
                    { new Guid("f625d2ab-9346-4151-856b-82072c7d3797"), "Year 8", 8, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5913), null, null, "student8@example.com", null, "StudentFirstName8", null, null, null, "StudentLastName8", "12345678918", "password18", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5909), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 8", new Guid("af224645-999c-43a4-acc3-a125e04590ea"), 1 },
                    { new Guid("fcc3c3b1-a37a-4dbe-8017-5824618bf8cf"), "Year 10", 10, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5938), null, null, "student10@example.com", null, "StudentFirstName10", null, null, null, "StudentLastName10", "12345678920", "password20", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5934), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, "Level 10", new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Code", "CoverPhoto", "DiscriptionAr", "DiscriptionEn", "IsActive", "NameAr", "NameEn", "TopicId" },
                values: new object[,]
                {
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("ad574fdd-1013-4ce3-a201-a396f30eeb48"), null, "https://localhost:7030/images/course6.jpg", "دورة 2 لتعليم الموضوع", "Course 2 for learning the subject", false, "دورة 2", "Course 2", new Guid("cf761fb2-6d0a-4a98-a452-1fde6b00d80e") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("2de18ca2-46f0-4ce4-9cc0-b3bb042c77c9"), null, "https://localhost:7030/images/course6.jpg", "دورة 1 لتعليم الموضوع", "Course 1 for learning the subject", false, "دورة 1", "Course 1", new Guid("2c040ccf-637d-4733-9cb7-4603691366c6") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("0c76b7d3-15ed-40c1-a862-e5619cbd4565"), null, "https://localhost:7030/images/course6.jpg", "دورة 8 لتعليم الموضوع", "Course 8 for learning the subject", false, "دورة 8", "Course 8", new Guid("cf4f8f8b-9813-4303-a5e6-3167c13c08c7") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("86518196-917c-47fc-b594-38d899ad2c62"), null, "https://localhost:7030/images/course6.jpg", "دورة 9 لتعليم الموضوع", "Course 9 for learning the subject", false, "دورة 9", "Course 9", new Guid("0eccd409-3094-4c07-a8a3-db45fe8bef2d") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("379e01c3-91c6-4ac7-93b7-385d3fc8b0c5"), null, "https://localhost:7030/images/course6.jpg", "دورة 5 لتعليم الموضوع", "Course 5 for learning the subject", false, "دورة 5", "Course 5", new Guid("101831e0-cef1-4d35-8202-2441fbb01a7e") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("b09566b9-2076-445e-b7fc-2ed81b3fdbd3"), null, "https://localhost:7030/images/course6.jpg", "دورة 6 لتعليم الموضوع", "Course 6 for learning the subject", false, "دورة 6", "Course 6", new Guid("2c040ccf-637d-4733-9cb7-4603691366c6") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("3f460378-116d-42ea-b25f-20fd9ff83ca5"), null, "https://localhost:7030/images/course6.jpg", "دورة 4 لتعليم الموضوع", "Course 4 for learning the subject", false, "دورة 4", "Course 4", new Guid("0eccd409-3094-4c07-a8a3-db45fe8bef2d") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("2d8e1569-523a-4694-bfbb-ae0da6aeae9d"), null, "https://localhost:7030/images/course6.jpg", "دورة 7 لتعليم الموضوع", "Course 7 for learning the subject", false, "دورة 7", "Course 7", new Guid("cf761fb2-6d0a-4a98-a452-1fde6b00d80e") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("549ea9a1-7ba1-42c2-91e0-40188035909c"), null, "https://localhost:7030/images/course6.jpg", "دورة 3 لتعليم الموضوع", "Course 3 for learning the subject", false, "دورة 3", "Course 3", new Guid("cf4f8f8b-9813-4303-a5e6-3167c13c08c7") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("f32f5204-3dbb-45b5-a449-10511090e2a9"), null, "https://localhost:7030/images/course6.jpg", "دورة 10 لتعليم الموضوع", "Course 10 for learning the subject", false, "دورة 10", "Course 10", new Guid("101831e0-cef1-4d35-8202-2441fbb01a7e") }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "FacultyId", "IsActive", "LookUpStatus", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459"), false, 2, "قسم الحاسوب 1", "Computer Science Department 1" },
                    { new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115"), false, 2, "قسم الحاسوب 9", "Computer Science Department 9" },
                    { new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d"), false, 2, "قسم الحاسوب 3", "Computer Science Department 3" },
                    { new Guid("560aa660-0449-4ae0-9269-1424d1415aac"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73"), false, 2, "قسم الحاسوب 10", "Computer Science Department 10" },
                    { new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757"), false, 2, "قسم الحاسوب 7", "Computer Science Department 7" },
                    { new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b"), false, 2, "قسم الحاسوب 4", "Computer Science Department 4" },
                    { new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37"), new Guid("a3e71022-3255-4454-88a7-031080443bce"), false, 2, "قسم الحاسوب 2", "Computer Science Department 2" },
                    { new Guid("90fbad11-1087-41e4-9564-6aaf09780c08"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721"), false, 2, "قسم الحاسوب 6", "Computer Science Department 6" },
                    { new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a"), false, 2, "قسم الحاسوب 5", "Computer Science Department 5" },
                    { new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e"), false, 2, "قسم الحاسوب 8", "Computer Science Department 8" }
                });

            migrationBuilder.InsertData(
                table: "DepartmentCourses",
                columns: new[] { "CoursesId", "DepartmentsId" },
                values: new object[,]
                {
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") }
                });

            migrationBuilder.InsertData(
                table: "FacultyCourses",
                columns: new[] { "CoursesId", "FacultiesId" },
                values: new object[,]
                {
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("a3e71022-3255-4454-88a7-031080443bce") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("a3e71022-3255-4454-88a7-031080443bce") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("a3e71022-3255-4454-88a7-031080443bce") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("a3e71022-3255-4454-88a7-031080443bce") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("a3e71022-3255-4454-88a7-031080443bce") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("a3e71022-3255-4454-88a7-031080443bce") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("a3e71022-3255-4454-88a7-031080443bce") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("a3e71022-3255-4454-88a7-031080443bce") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("a3e71022-3255-4454-88a7-031080443bce") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("a3e71022-3255-4454-88a7-031080443bce") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "CourseId", "IsActive", "TitleAr", "TitleEn" },
                values: new object[,]
                {
                    { new Guid("02d373b8-741d-4045-8f6d-dc7b8b7a606a"), new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), false, "الفصل 1 في دورة 7", "Section 1 in Course 7" },
                    { new Guid("1a99201e-35fe-4dda-a10e-b67373abca77"), new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), false, "الفصل 1 في دورة 2", "Section 1 in Course 2" },
                    { new Guid("29b76f14-dd5d-48c9-a24f-56882208da6c"), new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), false, "الفصل 3 في دورة 4", "Section 3 in Course 4" },
                    { new Guid("395c042f-c57b-427b-9704-bd5f394cf91f"), new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), false, "الفصل 3 في دورة 9", "Section 3 in Course 9" },
                    { new Guid("3a9390bf-fed5-4b1e-b31f-e13508551535"), new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), false, "الفصل 3 في دورة 1", "Section 3 in Course 1" },
                    { new Guid("42bc4fdb-169e-41ad-b1fa-237aef67f7e1"), new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), false, "الفصل 3 في دورة 6", "Section 3 in Course 6" },
                    { new Guid("4631e5f5-94d1-4065-a5a1-37b824adfe47"), new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), false, "الفصل 2 في دورة 9", "Section 2 in Course 9" },
                    { new Guid("4908263b-6175-4fcf-9655-8457dd27ea46"), new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), false, "الفصل 3 في دورة 7", "Section 3 in Course 7" },
                    { new Guid("4971725d-bf72-4d35-95b4-c692677094f7"), new Guid("f592431c-9057-45e7-872e-d81d347046f7"), false, "الفصل 3 في دورة 10", "Section 3 in Course 10" },
                    { new Guid("4d0c8db7-0501-45b6-8a3c-e0268275d01c"), new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), false, "الفصل 2 في دورة 5", "Section 2 in Course 5" },
                    { new Guid("4e6e96c5-c121-4b8e-a4b9-750884009e6f"), new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), false, "الفصل 3 في دورة 8", "Section 3 in Course 8" },
                    { new Guid("56ca78f5-e21c-484d-984e-1da68257a45d"), new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), false, "الفصل 2 في دورة 2", "Section 2 in Course 2" },
                    { new Guid("66a4610e-fd3c-430e-8128-56d44a38c2d6"), new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), false, "الفصل 1 في دورة 6", "Section 1 in Course 6" },
                    { new Guid("77181389-bdd4-4424-aa34-c312d1f86582"), new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), false, "الفصل 2 في دورة 7", "Section 2 in Course 7" },
                    { new Guid("7df77bb0-86ed-4cc0-947e-cd706c093d1f"), new Guid("f592431c-9057-45e7-872e-d81d347046f7"), false, "الفصل 2 في دورة 10", "Section 2 in Course 10" },
                    { new Guid("816b8d43-be29-476c-88c7-778e265093c6"), new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), false, "الفصل 2 في دورة 3", "Section 2 in Course 3" },
                    { new Guid("9ed14ada-e20b-4a79-8f28-8a299bf9b1ca"), new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), false, "الفصل 1 في دورة 3", "Section 1 in Course 3" },
                    { new Guid("a69f3cf2-8ed1-4c8c-b4bb-a1200b287b09"), new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), false, "الفصل 1 في دورة 8", "Section 1 in Course 8" },
                    { new Guid("a89ced5c-73ab-4b18-a4fd-a1cf11e37503"), new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), false, "الفصل 2 في دورة 1", "Section 2 in Course 1" },
                    { new Guid("aae8552d-7eb5-4200-b1da-7d022abbc0a7"), new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), false, "الفصل 1 في دورة 4", "Section 1 in Course 4" },
                    { new Guid("ae9959dc-c4b4-4562-b844-43d5d6d112f6"), new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), false, "الفصل 3 في دورة 3", "Section 3 in Course 3" },
                    { new Guid("b7e4c27b-9d02-4d4a-a7d6-aa3b527b1902"), new Guid("f592431c-9057-45e7-872e-d81d347046f7"), false, "الفصل 1 في دورة 10", "Section 1 in Course 10" },
                    { new Guid("bf12ebab-c723-4873-bcd1-c73f21e0db2e"), new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), false, "الفصل 2 في دورة 4", "Section 2 in Course 4" },
                    { new Guid("c1efe640-42dc-483a-beac-9edcbdddbd67"), new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), false, "الفصل 3 في دورة 2", "Section 3 in Course 2" },
                    { new Guid("d111d1cb-4cc4-4eda-8c17-09e82fbbff7f"), new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), false, "الفصل 2 في دورة 6", "Section 2 in Course 6" },
                    { new Guid("d44077c7-4c39-4e4e-a758-4dd4bda4e08c"), new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), false, "الفصل 1 في دورة 5", "Section 1 in Course 5" },
                    { new Guid("e36efc1f-26ca-4e9b-88df-f3a0b9fb571f"), new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), false, "الفصل 2 في دورة 8", "Section 2 in Course 8" },
                    { new Guid("f8d34ccf-3408-4454-bc70-faf3010b320e"), new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), false, "الفصل 3 في دورة 5", "Section 3 in Course 5" },
                    { new Guid("fb726ff2-716a-4540-8225-64dd0b8ef8b1"), new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), false, "الفصل 1 في دورة 9", "Section 1 in Course 9" },
                    { new Guid("fe29bc8b-b5a1-4ce7-b7a8-ab4ae5f221dd"), new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), false, "الفصل 1 في دورة 1", "Section 1 in Course 1" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "DepartmentId", "IsActive", "LookUpStatus", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37"), false, 2, "تخصص الذكاء الاصطناعي 2", "Artificial Intelligence Specialization 2" },
                    { new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d"), false, 2, "تخصص الذكاء الاصطناعي 5", "Artificial Intelligence Specialization 5" },
                    { new Guid("60943e28-b15a-4e29-a84c-aa15222a2191"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6"), false, 2, "تخصص الذكاء الاصطناعي 9", "Artificial Intelligence Specialization 9" },
                    { new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb"), false, 2, "تخصص الذكاء الاصطناعي 1", "Artificial Intelligence Specialization 1" },
                    { new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4"), false, 2, "تخصص الذكاء الاصطناعي 3", "Artificial Intelligence Specialization 3" },
                    { new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617"), false, 2, "تخصص الذكاء الاصطناعي 7", "Artificial Intelligence Specialization 7" },
                    { new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c"), false, 2, "تخصص الذكاء الاصطناعي 4", "Artificial Intelligence Specialization 4" },
                    { new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5"), false, 2, "تخصص الذكاء الاصطناعي 8", "Artificial Intelligence Specialization 8" },
                    { new Guid("dfb4b875-6234-473e-bf02-be1230c08a81"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08"), false, 2, "تخصص الذكاء الاصطناعي 6", "Artificial Intelligence Specialization 6" },
                    { new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac"), false, 2, "تخصص الذكاء الاصطناعي 10", "Artificial Intelligence Specialization 10" }
                });

            migrationBuilder.InsertData(
                table: "UniversityCourses",
                columns: new[] { "CoursesId", "UniversitiesId" },
                values: new object[,]
                {
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AcademicYear", "CountryId", "Created", "CreatedBy", "DepartmentId", "Email", "FacultyId", "FirstName", "LastModified", "LastModifiedBy", "LastModifiedStatus", "LastName", "MobileNumber", "Password", "RegisterAt", "RoleId", "SpecializationId", "Status", "StudyLevel", "UniversityId", "UserType" },
                values: new object[,]
                {
                    { new Guid("3bccfcb6-2a5b-4712-a00d-68f80e19b710"), null, 2, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5601), null, new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37"), "instructor_univ_dept2@example.com", null, "InstructorFirstName2", null, null, null, "InstructorLastName2", "1234567892", "password2", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5595), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183"), 2 },
                    { new Guid("41f13c7a-56ae-405a-b2f1-bb5e925c8622"), null, 5, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5638), null, new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d"), "instructor_univ_dept5@example.com", null, "InstructorFirstName5", null, null, null, "InstructorLastName5", "1234567895", "password5", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5633), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0"), 2 },
                    { new Guid("655a2acd-3b41-4a77-85eb-40bd42ba31f1"), null, 3, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5615), null, new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4"), "instructor_univ_dept3@example.com", null, "InstructorFirstName3", null, null, null, "InstructorLastName3", "1234567893", "password3", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5611), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331"), 2 },
                    { new Guid("8ad38ab7-6587-4fae-9df0-e67c24c26342"), null, 4, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5627), null, new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c"), "instructor_univ_dept4@example.com", null, "InstructorFirstName4", null, null, null, "InstructorLastName4", "1234567894", "password4", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5621), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, new Guid("53ee465c-d532-49f5-8625-32c906fbe83a"), 2 },
                    { new Guid("9aea080b-3a54-4e0b-9a90-ba135389f009"), null, 1, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5578), null, new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb"), "instructor_univ_dept1@example.com", null, "InstructorFirstName1", null, null, null, "InstructorLastName1", "1234567891", "password1", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5504), new TimeSpan(0, 2, 0, 0, 0)), null, null, 2, null, new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CodeEditorInitialCode", "CodeEditorLanguage", "CoverPhoto", "CreationDate", "DescriptionAr", "DescriptionEn", "HasCodeEditor", "IsActive", "NameAr", "NameEn", "Resources", "SectionId", "TitleAr", "TitleEn" },
                values: new object[,]
                {
                    { new Guid("01cab6e0-44fa-436a-9e50-ad5927e47ddc"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1229), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 3", "Lesson 3 in Section 3 in Course 3", null, new Guid("ae9959dc-c4b4-4562-b844-43d5d6d112f6"), null, null },
                    { new Guid("045c10d3-7dcc-4415-aa52-69550d2b254f"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(393), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 2", "Lesson 2 in Section 1 in Course 2", null, new Guid("1a99201e-35fe-4dda-a10e-b67373abca77"), null, null },
                    { new Guid("09406f69-e7f3-4606-8a08-f04d6aa68c87"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2653), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 6", "Lesson 2 in Section 2 in Course 6", null, new Guid("d111d1cb-4cc4-4eda-8c17-09e82fbbff7f"), null, null },
                    { new Guid("0dab353c-7132-4d97-babf-d90932b5e10a"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(9995), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 1", "Lesson 3 in Section 2 in Course 1", null, new Guid("a89ced5c-73ab-4b18-a4fd-a1cf11e37503"), null, null },
                    { new Guid("14fdb462-94a3-4153-b926-6c64332e983e"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(904), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 3", "Lesson 3 in Section 1 in Course 3", null, new Guid("9ed14ada-e20b-4a79-8f28-8a299bf9b1ca"), null, null },
                    { new Guid("1556589a-da18-4d98-9a0d-9c8e9728f9fa"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2875), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 6", "Lesson 3 in Section 3 in Course 6", null, new Guid("42bc4fdb-169e-41ad-b1fa-237aef67f7e1"), null, null },
                    { new Guid("1c29e702-ebae-407e-896d-20f216d88888"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(198), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 1", "Lesson 2 in Section 3 in Course 1", null, new Guid("3a9390bf-fed5-4b1e-b31f-e13508551535"), null, null },
                    { new Guid("1ed84cd0-3299-4edd-97cc-905b33c80128"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(203), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 1", "Lesson 3 in Section 3 in Course 1", null, new Guid("3a9390bf-fed5-4b1e-b31f-e13508551535"), null, null },
                    { new Guid("1f64c550-778c-41fc-9feb-1af0e02a7af6"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2862), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 6", "Lesson 1 in Section 3 in Course 6", null, new Guid("42bc4fdb-169e-41ad-b1fa-237aef67f7e1"), null, null },
                    { new Guid("20616c2d-f9ec-4368-8cce-be29e5deaaa8"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1814), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 4", "Lesson 2 in Section 3 in Course 4", null, new Guid("29b76f14-dd5d-48c9-a24f-56882208da6c"), null, null },
                    { new Guid("2099066a-f939-41ce-8165-100469e3ad15"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3952), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 8", "Lesson 2 in Section 3 in Course 8", null, new Guid("4e6e96c5-c121-4b8e-a4b9-750884009e6f"), null, null },
                    { new Guid("23453b6f-8a34-40db-9a8c-8c7ca70c9fd0"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2659), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 6", "Lesson 3 in Section 2 in Course 6", null, new Guid("d111d1cb-4cc4-4eda-8c17-09e82fbbff7f"), null, null },
                    { new Guid("260528cf-a786-41e1-800c-577a5fe723e6"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1432), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 4", "Lesson 3 in Section 1 in Course 4", null, new Guid("aae8552d-7eb5-4200-b1da-7d022abbc0a7"), null, null },
                    { new Guid("2651c4dc-5a35-4fb3-b275-397011cd593d"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(398), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 2", "Lesson 3 in Section 1 in Course 2", null, new Guid("1a99201e-35fe-4dda-a10e-b67373abca77"), null, null },
                    { new Guid("268ef601-1d71-42b8-b381-dbf104163992"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2309), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 5", "Lesson 1 in Section 3 in Course 5", null, new Guid("f8d34ccf-3408-4454-bc70-faf3010b320e"), null, null },
                    { new Guid("29419946-acf7-4667-9776-5c82ab1716f4"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3439), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 7", "Lesson 2 in Section 3 in Course 7", null, new Guid("4908263b-6175-4fcf-9655-8457dd27ea46"), null, null },
                    { new Guid("29fcaa8e-4c8c-4292-91f5-1abb9fc00c87"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4869), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 10", "Lesson 2 in Section 2 in Course 10", null, new Guid("7df77bb0-86ed-4cc0-947e-cd706c093d1f"), null, null },
                    { new Guid("2c55a785-9008-4c85-bbb9-7b7dee281572"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3814), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 8", "Lesson 2 in Section 2 in Course 8", null, new Guid("e36efc1f-26ca-4e9b-88df-f3a0b9fb571f"), null, null },
                    { new Guid("2d3823b8-4cf0-4e6d-b8b5-675a557e4003"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4322), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 9", "Lesson 1 in Section 2 in Course 9", null, new Guid("4631e5f5-94d1-4065-a5a1-37b824adfe47"), null, null },
                    { new Guid("2d978232-5137-454b-9b78-203e16ac11df"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(704), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 2", "Lesson 1 in Section 3 in Course 2", null, new Guid("c1efe640-42dc-483a-beac-9edcbdddbd67"), null, null },
                    { new Guid("32bd9caa-bcb5-4ecc-aa59-18bbe31519c4"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4157), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 9", "Lesson 3 in Section 1 in Course 9", null, new Guid("fb726ff2-716a-4540-8225-64dd0b8ef8b1"), null, null },
                    { new Guid("347c82e6-bbf2-410b-9db4-e256a260e561"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4458), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 9", "Lesson 1 in Section 3 in Course 9", null, new Guid("395c042f-c57b-427b-9704-bd5f394cf91f"), null, null },
                    { new Guid("36d34f3d-04ee-4292-8045-718bd1f67ada"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(5053), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 10", "Lesson 3 in Section 3 in Course 10", null, new Guid("4971725d-bf72-4d35-95b4-c692677094f7"), null, null },
                    { new Guid("3b507149-a283-4494-bff2-0eeb01e15617"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4690), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 10", "Lesson 2 in Section 1 in Course 10", null, new Guid("b7e4c27b-9d02-4d4a-a7d6-aa3b527b1902"), null, null },
                    { new Guid("44df0801-1224-4b16-9f04-7ff2721bd8f7"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1633), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 4", "Lesson 3 in Section 2 in Course 4", null, new Guid("bf12ebab-c723-4873-bcd1-c73f21e0db2e"), null, null },
                    { new Guid("47bd1217-d6a5-4d8d-b404-e4e9ba961eb2"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1960), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 5", "Lesson 3 in Section 1 in Course 5", null, new Guid("d44077c7-4c39-4e4e-a758-4dd4bda4e08c"), null, null },
                    { new Guid("492efa22-ee40-4f07-8fbb-beef32b21bdd"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4142), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 9", "Lesson 1 in Section 1 in Course 9", null, new Guid("fb726ff2-716a-4540-8225-64dd0b8ef8b1"), null, null },
                    { new Guid("4fa2f00f-8990-4fe5-a6fc-6e014f36ad23"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4466), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 9", "Lesson 2 in Section 3 in Course 9", null, new Guid("395c042f-c57b-427b-9704-bd5f394cf91f"), null, null },
                    { new Guid("502923ac-89e4-4326-9575-f03be6a320e5"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(385), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 2", "Lesson 1 in Section 1 in Course 2", null, new Guid("1a99201e-35fe-4dda-a10e-b67373abca77"), null, null },
                    { new Guid("510af08b-e245-40d3-a408-f01777fed964"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1223), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 3", "Lesson 2 in Section 3 in Course 3", null, new Guid("ae9959dc-c4b4-4562-b844-43d5d6d112f6"), null, null },
                    { new Guid("577cbb4d-b447-4a24-85d4-a278e28412f0"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3623), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 8", "Lesson 2 in Section 1 in Course 8", null, new Guid("a69f3cf2-8ed1-4c8c-b4bb-a1200b287b09"), null, null },
                    { new Guid("5df17b95-3099-49d9-9aa8-e28133804f42"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2449), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 6", "Lesson 1 in Section 1 in Course 6", null, new Guid("66a4610e-fd3c-430e-8128-56d44a38c2d6"), null, null },
                    { new Guid("6144a950-58e8-4cbe-83e3-85f059c4f11e"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(898), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 3", "Lesson 2 in Section 1 in Course 3", null, new Guid("9ed14ada-e20b-4a79-8f28-8a299bf9b1ca"), null, null },
                    { new Guid("63071dd4-d515-4d3e-b0c5-07b78f323b3f"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1081), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 3", "Lesson 2 in Section 2 in Course 3", null, new Guid("816b8d43-be29-476c-88c7-778e265093c6"), null, null },
                    { new Guid("65bd4fb5-bdf8-46f4-940b-d14c572e403c"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(710), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 2", "Lesson 2 in Section 3 in Course 2", null, new Guid("c1efe640-42dc-483a-beac-9edcbdddbd67"), null, null },
                    { new Guid("69c6ad9d-9a18-476a-b7ab-61159a548d38"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1819), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 4", "Lesson 3 in Section 3 in Course 4", null, new Guid("29b76f14-dd5d-48c9-a24f-56882208da6c"), null, null },
                    { new Guid("6a5e1fbc-1beb-492e-b990-b9d06729301f"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3058), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 7", "Lesson 1 in Section 1 in Course 7", null, new Guid("02d373b8-741d-4045-8f6d-dc7b8b7a606a"), null, null },
                    { new Guid("6b1a6aea-e609-4999-9b16-c5e851cfc880"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4695), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 10", "Lesson 3 in Section 1 in Course 10", null, new Guid("b7e4c27b-9d02-4d4a-a7d6-aa3b527b1902"), null, null },
                    { new Guid("6b89cf25-eac3-4d72-b6e0-6abf8ae3d81d"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4151), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 9", "Lesson 2 in Section 1 in Course 9", null, new Guid("fb726ff2-716a-4540-8225-64dd0b8ef8b1"), null, null },
                    { new Guid("6d52f7c7-0104-457e-b3d3-d1f010994dc5"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1628), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 4", "Lesson 2 in Section 2 in Course 4", null, new Guid("bf12ebab-c723-4873-bcd1-c73f21e0db2e"), null, null },
                    { new Guid("71328164-72a7-4728-82e0-7ecc53b202e6"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1215), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 3", "Lesson 1 in Section 3 in Course 3", null, new Guid("ae9959dc-c4b4-4562-b844-43d5d6d112f6"), null, null },
                    { new Guid("7197001c-8222-4a89-8611-822888a70b03"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2142), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 5", "Lesson 3 in Section 2 in Course 5", null, new Guid("4d0c8db7-0501-45b6-8a3c-e0268275d01c"), null, null },
                    { new Guid("75f5b328-210a-466a-9e38-7bc6669bdae9"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3444), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 7", "Lesson 3 in Section 3 in Course 7", null, new Guid("4908263b-6175-4fcf-9655-8457dd27ea46"), null, null },
                    { new Guid("76f800ef-bfc7-4efb-a3d4-f1de5953939e"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3206), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 7", "Lesson 2 in Section 2 in Course 7", null, new Guid("77181389-bdd4-4424-aa34-c312d1f86582"), null, null },
                    { new Guid("78af4b86-dac1-4c42-bcb4-4686a301d102"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4329), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 9", "Lesson 2 in Section 2 in Course 9", null, new Guid("4631e5f5-94d1-4065-a5a1-37b824adfe47"), null, null },
                    { new Guid("7c5fc05b-1525-4ea4-a7f9-44425e0300e5"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1807), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 4", "Lesson 1 in Section 3 in Course 4", null, new Guid("29b76f14-dd5d-48c9-a24f-56882208da6c"), null, null },
                    { new Guid("7fb60bdc-3ccd-49f6-be9c-aa8827d07956"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2323), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 5", "Lesson 3 in Section 3 in Course 5", null, new Guid("f8d34ccf-3408-4454-bc70-faf3010b320e"), null, null },
                    { new Guid("84737464-7220-43c2-aeed-5ae441d1ac89"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(573), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 2", "Lesson 2 in Section 2 in Course 2", null, new Guid("56ca78f5-e21c-484d-984e-1da68257a45d"), null, null },
                    { new Guid("856fbaac-ec06-47dd-a2f7-9fceef062084"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3630), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 8", "Lesson 3 in Section 1 in Course 8", null, new Guid("a69f3cf2-8ed1-4c8c-b4bb-a1200b287b09"), null, null },
                    { new Guid("87e95952-5449-4c61-94ef-1bfc582c0185"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2136), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 5", "Lesson 2 in Section 2 in Course 5", null, new Guid("4d0c8db7-0501-45b6-8a3c-e0268275d01c"), null, null },
                    { new Guid("8ec01a8c-84fa-4c41-86b8-57cd1a913fd2"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(5047), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 10", "Lesson 2 in Section 3 in Course 10", null, new Guid("4971725d-bf72-4d35-95b4-c692677094f7"), null, null },
                    { new Guid("946c762f-b674-4010-b2e8-467ec5c19d83"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1420), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 4", "Lesson 1 in Section 1 in Course 4", null, new Guid("aae8552d-7eb5-4200-b1da-7d022abbc0a7"), null, null },
                    { new Guid("949edc9a-0c5d-4ee8-8c73-276fe4de6232"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(9989), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 2 في دورة 1", "Lesson 2 in Section 2 in Course 1", null, new Guid("a89ced5c-73ab-4b18-a4fd-a1cf11e37503"), null, null },
                    { new Guid("971d328c-933d-4dc6-ab88-78fa02a0a0ed"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3211), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 7", "Lesson 3 in Section 2 in Course 7", null, new Guid("77181389-bdd4-4424-aa34-c312d1f86582"), null, null },
                    { new Guid("9784df96-94e0-41b8-bc21-3829409b48a4"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(9614), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 1", "Lesson 2 in Section 1 in Course 1", null, new Guid("fe29bc8b-b5a1-4ce7-b7a8-ab4ae5f221dd"), null, null },
                    { new Guid("97e4d9d3-4525-4c72-9213-ef032fbf2789"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(188), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 1", "Lesson 1 in Section 3 in Course 1", null, new Guid("3a9390bf-fed5-4b1e-b31f-e13508551535"), null, null },
                    { new Guid("98846af9-4346-414c-9579-26897ec3d283"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3429), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 7", "Lesson 1 in Section 3 in Course 7", null, new Guid("4908263b-6175-4fcf-9655-8457dd27ea46"), null, null },
                    { new Guid("9996d590-b522-4526-bb23-5a4e6346c1d3"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3820), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 8", "Lesson 3 in Section 2 in Course 8", null, new Guid("e36efc1f-26ca-4e9b-88df-f3a0b9fb571f"), null, null },
                    { new Guid("9bbe9321-29b4-4182-9ab1-5eec2d2b7687"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3072), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 7", "Lesson 3 in Section 1 in Course 7", null, new Guid("02d373b8-741d-4045-8f6d-dc7b8b7a606a"), null, null },
                    { new Guid("a1a5fa0d-f61a-4bb4-8056-536c51109908"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3067), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 7", "Lesson 2 in Section 1 in Course 7", null, new Guid("02d373b8-741d-4045-8f6d-dc7b8b7a606a"), null, null },
                    { new Guid("a3d6bb40-7b2c-45c3-9cdc-6915f57774db"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1086), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 3", "Lesson 3 in Section 2 in Course 3", null, new Guid("816b8d43-be29-476c-88c7-778e265093c6"), null, null },
                    { new Guid("ade7d45f-b8e7-4562-a2d6-56db6fdc3599"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(579), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 2", "Lesson 3 in Section 2 in Course 2", null, new Guid("56ca78f5-e21c-484d-984e-1da68257a45d"), null, null },
                    { new Guid("af3e8ff5-9421-4ece-a40c-88b986836661"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(9982), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 1", "Lesson 1 in Section 2 in Course 1", null, new Guid("a89ced5c-73ab-4b18-a4fd-a1cf11e37503"), null, null },
                    { new Guid("afdef2c1-b971-4a6d-9138-0d60f39d8123"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1618), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 4", "Lesson 1 in Section 2 in Course 4", null, new Guid("bf12ebab-c723-4873-bcd1-c73f21e0db2e"), null, null },
                    { new Guid("b02c9d22-914c-4fb5-b12e-e8f8e896dd52"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2869), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 6", "Lesson 2 in Section 3 in Course 6", null, new Guid("42bc4fdb-169e-41ad-b1fa-237aef67f7e1"), null, null },
                    { new Guid("b9579f53-539d-4bd4-a631-19058af2a259"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3615), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 8", "Lesson 1 in Section 1 in Course 8", null, new Guid("a69f3cf2-8ed1-4c8c-b4bb-a1200b287b09"), null, null },
                    { new Guid("bc522689-1cd5-4779-930d-ac6edf5f2823"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4860), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 10", "Lesson 1 in Section 2 in Course 10", null, new Guid("7df77bb0-86ed-4cc0-947e-cd706c093d1f"), null, null },
                    { new Guid("bd9afb73-f4bb-49c1-8e36-fccc57df4de4"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1954), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 5", "Lesson 2 in Section 1 in Course 5", null, new Guid("d44077c7-4c39-4e4e-a758-4dd4bda4e08c"), null, null },
                    { new Guid("bed28af3-00b0-46ac-92de-d28c3f96fb19"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3805), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 8", "Lesson 1 in Section 2 in Course 8", null, new Guid("e36efc1f-26ca-4e9b-88df-f3a0b9fb571f"), null, null },
                    { new Guid("c16b0faf-20b7-458e-b4ef-16580e379f52"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3200), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 7", "Lesson 1 in Section 2 in Course 7", null, new Guid("77181389-bdd4-4424-aa34-c312d1f86582"), null, null },
                    { new Guid("c2bb8a93-30fa-42e0-91bd-59561ebe7c0a"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(5000), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 10", "Lesson 1 in Section 3 in Course 10", null, new Guid("4971725d-bf72-4d35-95b4-c692677094f7"), null, null },
                    { new Guid("c40b5fc8-7ef0-4bf6-b1c5-7f5c5e27d99f"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1074), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 3", "Lesson 1 in Section 2 in Course 3", null, new Guid("816b8d43-be29-476c-88c7-778e265093c6"), null, null },
                    { new Guid("ce1c5822-a778-40a7-825f-237f1d115acb"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(524), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 2", "Lesson 1 in Section 2 in Course 2", null, new Guid("56ca78f5-e21c-484d-984e-1da68257a45d"), null, null },
                    { new Guid("d710199e-c89e-41c5-8dc1-799902b6215b"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4334), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 9", "Lesson 3 in Section 2 in Course 9", null, new Guid("4631e5f5-94d1-4065-a5a1-37b824adfe47"), null, null },
                    { new Guid("d80224ae-474b-460d-818f-409a6ccbbadf"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4683), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 10", "Lesson 1 in Section 1 in Course 10", null, new Guid("b7e4c27b-9d02-4d4a-a7d6-aa3b527b1902"), null, null },
                    { new Guid("d84dc5d0-4620-40bf-bc7e-c258dc1e190b"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3945), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 3 في دورة 8", "Lesson 1 in Section 3 in Course 8", null, new Guid("4e6e96c5-c121-4b8e-a4b9-750884009e6f"), null, null },
                    { new Guid("d9352996-f5f8-44dc-9964-ed78800186ea"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4512), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 9", "Lesson 3 in Section 3 in Course 9", null, new Guid("395c042f-c57b-427b-9704-bd5f394cf91f"), null, null },
                    { new Guid("dd9c2322-a27a-48f9-b409-2afbeb04496f"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1426), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 4", "Lesson 2 in Section 1 in Course 4", null, new Guid("aae8552d-7eb5-4200-b1da-7d022abbc0a7"), null, null },
                    { new Guid("dda13df1-840d-421a-85c8-4bbde1dea86f"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(717), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 2", "Lesson 3 in Section 3 in Course 2", null, new Guid("c1efe640-42dc-483a-beac-9edcbdddbd67"), null, null },
                    { new Guid("e6228ee8-eb00-4d3b-aab5-06568307aa40"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(3957), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 3 في دورة 8", "Lesson 3 in Section 3 in Course 8", null, new Guid("4e6e96c5-c121-4b8e-a4b9-750884009e6f"), null, null },
                    { new Guid("e90cf593-67a1-4664-9142-8a76d2e7a0c7"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(9597), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 1", "Lesson 1 in Section 1 in Course 1", null, new Guid("fe29bc8b-b5a1-4ce7-b7a8-ab4ae5f221dd"), null, null },
                    { new Guid("ea4c195d-85bc-4ef5-ab0e-086152204fea"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2517), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 6", "Lesson 3 in Section 1 in Course 6", null, new Guid("66a4610e-fd3c-430e-8128-56d44a38c2d6"), null, null },
                    { new Guid("edb33b67-a45b-41f1-87a8-c2cc20e57bfa"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(1946), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 5", "Lesson 1 in Section 1 in Course 5", null, new Guid("d44077c7-4c39-4e4e-a758-4dd4bda4e08c"), null, null },
                    { new Guid("efe60975-1cba-43ae-a2ad-c68acd715253"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2129), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 5", "Lesson 1 in Section 2 in Course 5", null, new Guid("4d0c8db7-0501-45b6-8a3c-e0268275d01c"), null, null },
                    { new Guid("f280ef64-a707-404b-af7f-9d44c1814ba6"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(4875), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 2 في دورة 10", "Lesson 3 in Section 2 in Course 10", null, new Guid("7df77bb0-86ed-4cc0-947e-cd706c093d1f"), null, null },
                    { new Guid("f3330534-ff77-4818-8cd9-b543ac7ca3e0"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2318), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 3 في دورة 5", "Lesson 2 in Section 3 in Course 5", null, new Guid("f8d34ccf-3408-4454-bc70-faf3010b320e"), null, null },
                    { new Guid("f61d8b83-350c-495f-a6f8-64b00c5ce40c"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(9621), "This is the description for Lesson 3.", null, false, false, "درس 3 في الفصل 1 في دورة 1", "Lesson 3 in Section 1 in Course 1", null, new Guid("fe29bc8b-b5a1-4ce7-b7a8-ab4ae5f221dd"), null, null },
                    { new Guid("f76cf2a9-9424-4596-bd31-fcde3e04078e"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2455), "This is the description for Lesson 2.", null, true, false, "درس 2 في الفصل 1 في دورة 6", "Lesson 2 in Section 1 in Course 6", null, new Guid("66a4610e-fd3c-430e-8128-56d44a38c2d6"), null, null },
                    { new Guid("f845c274-cbcd-4963-966a-b526a4d770f0"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(888), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 1 في دورة 3", "Lesson 1 in Section 1 in Course 3", null, new Guid("9ed14ada-e20b-4a79-8f28-8a299bf9b1ca"), null, null },
                    { new Guid("fa1ec07b-5888-4d27-89f4-5dd8606aef47"), null, null, null, new DateTime(2024, 11, 20, 16, 41, 46, 70, DateTimeKind.Local).AddTicks(2644), "This is the description for Lesson 1.", null, false, false, "درس 1 في الفصل 2 في دورة 6", "Lesson 1 in Section 2 in Course 6", null, new Guid("d111d1cb-4cc4-4eda-8c17-09e82fbbff7f"), null, null }
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "IsActive", "LessonId", "Name", "QuizType", "SectionId" },
                values: new object[,]
                {
                    { new Guid("065c75ad-d7bf-4b22-80ac-1950520e9ea2"), false, null, "Quiz 2 for Section 3 in Course 10", 0, new Guid("4971725d-bf72-4d35-95b4-c692677094f7") },
                    { new Guid("0844939b-87e4-4982-95c5-d101907a4542"), false, null, "Quiz 2 for Section 1 in Course 1", 0, new Guid("fe29bc8b-b5a1-4ce7-b7a8-ab4ae5f221dd") },
                    { new Guid("0a723220-439b-4909-a82d-e40d5bfa5336"), false, null, "Quiz 1 for Section 1 in Course 2", 0, new Guid("1a99201e-35fe-4dda-a10e-b67373abca77") },
                    { new Guid("0b9b5004-ad5a-440a-abd3-99631ba83e50"), false, null, "Quiz 2 for Section 1 in Course 4", 0, new Guid("aae8552d-7eb5-4200-b1da-7d022abbc0a7") },
                    { new Guid("198046a0-69d0-4052-8e37-c1d8bdd598fc"), false, null, "Quiz 1 for Section 1 in Course 10", 0, new Guid("b7e4c27b-9d02-4d4a-a7d6-aa3b527b1902") },
                    { new Guid("1d1c9f1a-03cf-4188-bdc6-9232388c1395"), false, null, "Quiz 1 for Section 2 in Course 10", 0, new Guid("7df77bb0-86ed-4cc0-947e-cd706c093d1f") },
                    { new Guid("29005fea-2c01-42f7-b2d9-c7d937d5b218"), false, null, "Quiz 2 for Section 3 in Course 9", 0, new Guid("395c042f-c57b-427b-9704-bd5f394cf91f") },
                    { new Guid("30d73c78-c26c-4ad5-b046-f35d3b6631de"), false, null, "Quiz 2 for Section 2 in Course 3", 0, new Guid("816b8d43-be29-476c-88c7-778e265093c6") },
                    { new Guid("38008b08-00aa-4176-9a45-ebf6e771d358"), false, null, "Quiz 1 for Section 1 in Course 7", 0, new Guid("02d373b8-741d-4045-8f6d-dc7b8b7a606a") },
                    { new Guid("3864cea2-4ac2-410d-be61-ec52d8948d5e"), false, null, "Quiz 2 for Section 1 in Course 6", 0, new Guid("66a4610e-fd3c-430e-8128-56d44a38c2d6") },
                    { new Guid("3a8d21d3-1527-4f10-ac78-17692fed12b2"), false, null, "Quiz 2 for Section 2 in Course 7", 0, new Guid("77181389-bdd4-4424-aa34-c312d1f86582") },
                    { new Guid("3fdbf32a-1280-4bd5-b69d-559791b5e6c2"), false, null, "Quiz 2 for Section 2 in Course 4", 0, new Guid("bf12ebab-c723-4873-bcd1-c73f21e0db2e") },
                    { new Guid("4058c788-a627-4824-b28c-25ab2fbaaa42"), false, null, "Quiz 2 for Section 1 in Course 10", 0, new Guid("b7e4c27b-9d02-4d4a-a7d6-aa3b527b1902") },
                    { new Guid("433afcbb-8925-4187-b516-ce971c850325"), false, null, "Quiz 1 for Section 2 in Course 7", 0, new Guid("77181389-bdd4-4424-aa34-c312d1f86582") },
                    { new Guid("468c74f3-7177-4a46-bf72-cdd183fb363a"), false, null, "Quiz 2 for Section 3 in Course 7", 0, new Guid("4908263b-6175-4fcf-9655-8457dd27ea46") },
                    { new Guid("4bb487c9-516d-4d22-951a-5f6ff383ad00"), false, null, "Quiz 1 for Section 1 in Course 9", 0, new Guid("fb726ff2-716a-4540-8225-64dd0b8ef8b1") },
                    { new Guid("50c99dac-4473-40c3-8fb8-1e595826d5b2"), false, null, "Quiz 2 for Section 1 in Course 3", 0, new Guid("9ed14ada-e20b-4a79-8f28-8a299bf9b1ca") },
                    { new Guid("52508fdf-7d5d-4290-afbb-2fddaf2e6756"), false, null, "Quiz 2 for Section 1 in Course 9", 0, new Guid("fb726ff2-716a-4540-8225-64dd0b8ef8b1") },
                    { new Guid("5670024b-6924-49ee-b09c-3bcc85833a07"), false, null, "Quiz 2 for Section 3 in Course 8", 0, new Guid("4e6e96c5-c121-4b8e-a4b9-750884009e6f") },
                    { new Guid("56dbef56-8fb7-4a05-9b8c-27a5b3a5a19b"), false, null, "Quiz 1 for Section 2 in Course 4", 0, new Guid("bf12ebab-c723-4873-bcd1-c73f21e0db2e") },
                    { new Guid("57d578a9-0ee1-4138-a060-bff69d1a132a"), false, null, "Quiz 2 for Section 2 in Course 8", 0, new Guid("e36efc1f-26ca-4e9b-88df-f3a0b9fb571f") },
                    { new Guid("59ea0e26-f45d-4220-b346-93675f590a07"), false, null, "Quiz 2 for Section 3 in Course 3", 0, new Guid("ae9959dc-c4b4-4562-b844-43d5d6d112f6") },
                    { new Guid("5a531256-adcc-4469-b3b9-3b4105402169"), false, null, "Quiz 1 for Section 1 in Course 6", 0, new Guid("66a4610e-fd3c-430e-8128-56d44a38c2d6") },
                    { new Guid("5efcabfe-5bf1-4dd0-9f87-9389175699b0"), false, null, "Quiz 1 for Section 2 in Course 5", 0, new Guid("4d0c8db7-0501-45b6-8a3c-e0268275d01c") },
                    { new Guid("644f1525-91b1-4def-bbd2-54fbb45bc9ba"), false, null, "Quiz 2 for Section 3 in Course 5", 0, new Guid("f8d34ccf-3408-4454-bc70-faf3010b320e") },
                    { new Guid("6c8a5363-71dc-4653-ba97-1126d313a5a8"), false, null, "Quiz 2 for Section 1 in Course 2", 0, new Guid("1a99201e-35fe-4dda-a10e-b67373abca77") },
                    { new Guid("70ea2387-6ed6-40ef-9adc-66ac1a76ab62"), false, null, "Quiz 1 for Section 2 in Course 3", 0, new Guid("816b8d43-be29-476c-88c7-778e265093c6") },
                    { new Guid("7a796cbe-c868-405f-998c-69d8137e5f5d"), false, null, "Quiz 1 for Section 3 in Course 7", 0, new Guid("4908263b-6175-4fcf-9655-8457dd27ea46") },
                    { new Guid("7a974643-05f0-42cb-8303-26c37643eb64"), false, null, "Quiz 1 for Section 2 in Course 6", 0, new Guid("d111d1cb-4cc4-4eda-8c17-09e82fbbff7f") },
                    { new Guid("7d472d7d-3b37-42d6-bf1c-19c01186899c"), false, null, "Quiz 1 for Section 2 in Course 2", 0, new Guid("56ca78f5-e21c-484d-984e-1da68257a45d") },
                    { new Guid("86db52e4-4c18-4048-8b30-e661d8e0ec8b"), false, null, "Quiz 1 for Section 1 in Course 8", 0, new Guid("a69f3cf2-8ed1-4c8c-b4bb-a1200b287b09") },
                    { new Guid("893b706a-1f72-4b6a-a54a-0c95ee8bb64e"), false, null, "Quiz 1 for Section 1 in Course 5", 0, new Guid("d44077c7-4c39-4e4e-a758-4dd4bda4e08c") },
                    { new Guid("8a775a72-bae6-4fbe-a020-824c5c3c2082"), false, null, "Quiz 1 for Section 2 in Course 9", 0, new Guid("4631e5f5-94d1-4065-a5a1-37b824adfe47") },
                    { new Guid("8c583205-7179-464d-a3e6-e39c94eaef15"), false, null, "Quiz 2 for Section 1 in Course 8", 0, new Guid("a69f3cf2-8ed1-4c8c-b4bb-a1200b287b09") },
                    { new Guid("91ba3464-f2de-462f-9511-b27e7fd4ae9e"), false, null, "Quiz 2 for Section 3 in Course 4", 0, new Guid("29b76f14-dd5d-48c9-a24f-56882208da6c") },
                    { new Guid("9a8f4060-2d8f-41a5-94a1-d4ee244cbf35"), false, null, "Quiz 1 for Section 3 in Course 5", 0, new Guid("f8d34ccf-3408-4454-bc70-faf3010b320e") },
                    { new Guid("9cb27ca8-b768-4410-b7fb-9fdf700b6035"), false, null, "Quiz 2 for Section 2 in Course 1", 0, new Guid("a89ced5c-73ab-4b18-a4fd-a1cf11e37503") },
                    { new Guid("9ede59f0-be75-4c13-aad1-5553ac9596b2"), false, null, "Quiz 2 for Section 2 in Course 10", 0, new Guid("7df77bb0-86ed-4cc0-947e-cd706c093d1f") },
                    { new Guid("9fbc3c17-0a6f-4563-a14c-4b6398a0505c"), false, null, "Quiz 1 for Section 1 in Course 3", 0, new Guid("9ed14ada-e20b-4a79-8f28-8a299bf9b1ca") },
                    { new Guid("a12fe5e0-7c97-43d6-bf49-f6601c605814"), false, null, "Quiz 1 for Section 3 in Course 9", 0, new Guid("395c042f-c57b-427b-9704-bd5f394cf91f") },
                    { new Guid("a18da225-0c7f-447c-850e-347b653fa693"), false, null, "Quiz 2 for Section 2 in Course 2", 0, new Guid("56ca78f5-e21c-484d-984e-1da68257a45d") },
                    { new Guid("bdd0379a-4429-45a5-88bf-f0d5817a1098"), false, null, "Quiz 1 for Section 3 in Course 2", 0, new Guid("c1efe640-42dc-483a-beac-9edcbdddbd67") },
                    { new Guid("be15065c-822e-4048-8422-93451727c528"), false, null, "Quiz 2 for Section 1 in Course 7", 0, new Guid("02d373b8-741d-4045-8f6d-dc7b8b7a606a") },
                    { new Guid("bf584167-5bb8-452a-96af-f33700516226"), false, null, "Quiz 1 for Section 3 in Course 1", 0, new Guid("3a9390bf-fed5-4b1e-b31f-e13508551535") },
                    { new Guid("c180d68a-1306-4240-bb46-7c93b2da1b85"), false, null, "Quiz 1 for Section 1 in Course 1", 0, new Guid("fe29bc8b-b5a1-4ce7-b7a8-ab4ae5f221dd") },
                    { new Guid("c43c1686-1691-4b50-a748-4e3f2bc25588"), false, null, "Quiz 1 for Section 3 in Course 8", 0, new Guid("4e6e96c5-c121-4b8e-a4b9-750884009e6f") },
                    { new Guid("c621c39f-7a4f-41c7-820d-62b4b7920944"), false, null, "Quiz 1 for Section 3 in Course 6", 0, new Guid("42bc4fdb-169e-41ad-b1fa-237aef67f7e1") },
                    { new Guid("c78f717f-0f8f-406c-a58b-f34b5a931f49"), false, null, "Quiz 1 for Section 2 in Course 1", 0, new Guid("a89ced5c-73ab-4b18-a4fd-a1cf11e37503") },
                    { new Guid("c8febd80-1d97-4529-8863-f3fc7d76c471"), false, null, "Quiz 1 for Section 3 in Course 3", 0, new Guid("ae9959dc-c4b4-4562-b844-43d5d6d112f6") },
                    { new Guid("cc750fc2-418a-4ef5-a4da-2606ae67e8f6"), false, null, "Quiz 2 for Section 2 in Course 6", 0, new Guid("d111d1cb-4cc4-4eda-8c17-09e82fbbff7f") },
                    { new Guid("d0b7c64d-46e4-4e32-b29c-0740c1065501"), false, null, "Quiz 2 for Section 2 in Course 5", 0, new Guid("4d0c8db7-0501-45b6-8a3c-e0268275d01c") },
                    { new Guid("d3a6039b-b47a-428d-bf54-bae0a4f41ff1"), false, null, "Quiz 2 for Section 3 in Course 1", 0, new Guid("3a9390bf-fed5-4b1e-b31f-e13508551535") },
                    { new Guid("d3a9e00f-8f9a-4e04-94cc-51d0c9664dd9"), false, null, "Quiz 2 for Section 3 in Course 2", 0, new Guid("c1efe640-42dc-483a-beac-9edcbdddbd67") },
                    { new Guid("ebb284dc-ea2d-4324-82e2-1f9069a84d30"), false, null, "Quiz 1 for Section 3 in Course 10", 0, new Guid("4971725d-bf72-4d35-95b4-c692677094f7") },
                    { new Guid("ed142f7b-079a-4d46-9820-1b009474755b"), false, null, "Quiz 1 for Section 3 in Course 4", 0, new Guid("29b76f14-dd5d-48c9-a24f-56882208da6c") },
                    { new Guid("eddfb3b3-1e6d-4c6a-ae26-0f4bb1d586c1"), false, null, "Quiz 1 for Section 2 in Course 8", 0, new Guid("e36efc1f-26ca-4e9b-88df-f3a0b9fb571f") },
                    { new Guid("eee7b325-04dc-4241-a2af-64773a7edd60"), false, null, "Quiz 2 for Section 2 in Course 9", 0, new Guid("4631e5f5-94d1-4065-a5a1-37b824adfe47") },
                    { new Guid("f6f9a4eb-06cf-42a0-ab01-67a7bae7ec00"), false, null, "Quiz 2 for Section 1 in Course 5", 0, new Guid("d44077c7-4c39-4e4e-a758-4dd4bda4e08c") },
                    { new Guid("f7dc9ddc-f59d-45d0-a7a4-376701f89a93"), false, null, "Quiz 1 for Section 1 in Course 4", 0, new Guid("aae8552d-7eb5-4200-b1da-7d022abbc0a7") },
                    { new Guid("f808f265-9dee-403b-8205-29ddec09a633"), false, null, "Quiz 2 for Section 3 in Course 6", 0, new Guid("42bc4fdb-169e-41ad-b1fa-237aef67f7e1") }
                });

            migrationBuilder.InsertData(
                table: "SpecializationCourses",
                columns: new[] { "CoursesId", "SpecializationsId" },
                values: new object[,]
                {
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") },
                    { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") },
                    { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") },
                    { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") },
                    { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") },
                    { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") },
                    { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") },
                    { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") },
                    { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") },
                    { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") },
                    { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AcademicYear", "CountryId", "Created", "CreatedBy", "DepartmentId", "Email", "FacultyId", "FirstName", "LastModified", "LastModifiedBy", "LastModifiedStatus", "LastName", "MobileNumber", "Password", "RegisterAt", "RoleId", "SpecializationId", "Status", "StudyLevel", "UniversityId", "UserType" },
                values: new object[,]
                {
                    { new Guid("19261c7e-a908-4cf2-a376-acafad6d727d"), null, 7, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5731), null, new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617"), "instructor_full7@example.com", new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757"), "InstructorFirstName7", null, null, null, "InstructorLastName7", "1234567897", "password7", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5724), new TimeSpan(0, 2, 0, 0, 0)), null, new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9"), 2, null, new Guid("9b109cbd-764b-4f71-b310-15211af3b68a"), 2 },
                    { new Guid("4538fb2c-ab35-457f-88d0-199b71c51104"), null, 6, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5655), null, new Guid("90fbad11-1087-41e4-9564-6aaf09780c08"), "instructor_full6@example.com", new Guid("89297dc6-4f80-4661-9667-8e28f6b13721"), "InstructorFirstName6", null, null, null, "InstructorLastName6", "1234567896", "password6", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5648), new TimeSpan(0, 2, 0, 0, 0)), null, new Guid("dfb4b875-6234-473e-bf02-be1230c08a81"), 2, null, new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae"), 2 },
                    { new Guid("4cb92ab9-bd2e-4585-a87a-07198a2bd8d9"), null, 10, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5765), null, new Guid("560aa660-0449-4ae0-9269-1424d1415aac"), "instructor_full10@example.com", new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73"), "InstructorFirstName10", null, null, null, "InstructorLastName10", "12345678910", "password10", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5760), new TimeSpan(0, 2, 0, 0, 0)), null, new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673"), 2, null, new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb"), 2 },
                    { new Guid("82b4b58d-3338-472a-be92-28b1b0b1b765"), null, 8, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5742), null, new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5"), "instructor_full8@example.com", new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e"), "InstructorFirstName8", null, null, null, "InstructorLastName8", "1234567898", "password8", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5737), new TimeSpan(0, 2, 0, 0, 0)), null, new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31"), 2, null, new Guid("af224645-999c-43a4-acc3-a125e04590ea"), 2 },
                    { new Guid("9ee4620e-f6ec-41a3-8210-f75a3c9f643b"), null, 9, new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Local).AddTicks(5752), null, new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6"), "instructor_full9@example.com", new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115"), "InstructorFirstName9", null, null, null, "InstructorLastName9", "1234567899", "password9", new DateTimeOffset(new DateTime(2024, 11, 20, 16, 41, 46, 69, DateTimeKind.Unspecified).AddTicks(5748), new TimeSpan(0, 2, 0, 0, 0)), null, new Guid("60943e28-b15a-4e29-a84c-aa15222a2191"), 2, null, new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Answer", "CorrectAnswers", "CorrectAnswersJson", "IsActive", "MatchingPairs", "MatchingPairsJson", "Options", "OptionsJson", "QuestionText", "QuestionType", "QuizId" },
                values: new object[,]
                {
                    { new Guid("007b407f-637e-4535-bd69-4441b746ee4d"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 3", 0, new Guid("9fbc3c17-0a6f-4563-a14c-4b6398a0505c") },
                    { new Guid("009fcd5f-695b-4300-a3d0-b8f21b4f4c2a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 9", 0, new Guid("29005fea-2c01-42f7-b2d9-c7d937d5b218") },
                    { new Guid("04886cf2-aab6-4302-a532-a128ca526350"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 10", 0, new Guid("1d1c9f1a-03cf-4188-bdc6-9232388c1395") },
                    { new Guid("072e3f5a-8ca2-4edb-bd99-22d622d28d73"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 4", 0, new Guid("56dbef56-8fb7-4a05-9b8c-27a5b3a5a19b") },
                    { new Guid("07b6c9d8-4997-489e-bf5f-6fd2e970b0cb"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 6", 0, new Guid("3864cea2-4ac2-410d-be61-ec52d8948d5e") },
                    { new Guid("08c127a9-62dd-4d8b-987a-7d4e4b94d815"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 5", 0, new Guid("d0b7c64d-46e4-4e32-b29c-0740c1065501") },
                    { new Guid("0b2afe6f-426b-460e-8a18-d2b52e095355"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 8", 0, new Guid("86db52e4-4c18-4048-8b30-e661d8e0ec8b") },
                    { new Guid("0b5b15ac-0d13-4d61-8eec-89d2abc96959"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 10", 0, new Guid("065c75ad-d7bf-4b22-80ac-1950520e9ea2") },
                    { new Guid("0ba0ff9f-a5d7-462f-bad2-bbf6adac81bf"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 9", 0, new Guid("8a775a72-bae6-4fbe-a020-824c5c3c2082") },
                    { new Guid("0cc6d988-e9a0-40a1-97e3-ddce9b36a518"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 4", 0, new Guid("56dbef56-8fb7-4a05-9b8c-27a5b3a5a19b") },
                    { new Guid("0f6e6974-6a2d-4ca3-a915-ec6b7f92408c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 4", 0, new Guid("0b9b5004-ad5a-440a-abd3-99631ba83e50") },
                    { new Guid("11c178c2-0aca-428f-96c3-816f8051a4b4"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 9", 0, new Guid("4bb487c9-516d-4d22-951a-5f6ff383ad00") },
                    { new Guid("167e877c-faf8-434c-a317-08355c23bb58"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 10", 0, new Guid("065c75ad-d7bf-4b22-80ac-1950520e9ea2") },
                    { new Guid("17f59e6f-5646-449e-b3d6-7ec8e4e15edc"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 9", 0, new Guid("8a775a72-bae6-4fbe-a020-824c5c3c2082") },
                    { new Guid("1b092379-08a2-4e01-8818-95d64d0bd6a4"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 7", 0, new Guid("be15065c-822e-4048-8422-93451727c528") },
                    { new Guid("1ce3cd3a-aedd-4753-b755-d4431a511e8d"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 8", 0, new Guid("57d578a9-0ee1-4138-a060-bff69d1a132a") },
                    { new Guid("1e75fe48-f2af-446b-b83b-ddba5004e04d"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 8", 0, new Guid("57d578a9-0ee1-4138-a060-bff69d1a132a") },
                    { new Guid("1e8f7e03-9607-4733-8f38-db1d41b398d1"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 7", 0, new Guid("468c74f3-7177-4a46-bf72-cdd183fb363a") },
                    { new Guid("1ef27fbf-9311-4751-94fc-c90812543d45"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 4", 0, new Guid("0b9b5004-ad5a-440a-abd3-99631ba83e50") },
                    { new Guid("1f41813e-b820-4cf1-a528-0f0996ac790f"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 1", 0, new Guid("c78f717f-0f8f-406c-a58b-f34b5a931f49") },
                    { new Guid("2124dac4-d39f-4d15-a407-dab8b3a8aa48"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 6", 0, new Guid("7a974643-05f0-42cb-8303-26c37643eb64") },
                    { new Guid("2143fe06-0247-4bdb-9296-2360adc3737a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 5", 0, new Guid("d0b7c64d-46e4-4e32-b29c-0740c1065501") },
                    { new Guid("222f4ace-c3ce-4772-9a34-2560c0b41150"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 1", 0, new Guid("bf584167-5bb8-452a-96af-f33700516226") },
                    { new Guid("24966a3f-5410-4b4e-8b41-378b594a105c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 4", 0, new Guid("ed142f7b-079a-4d46-9820-1b009474755b") },
                    { new Guid("2522ebb1-d4e7-4687-bf71-f348f0348787"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 7", 0, new Guid("38008b08-00aa-4176-9a45-ebf6e771d358") },
                    { new Guid("25b4595e-d2c7-45fa-8f99-9391dfa2825b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 3", 0, new Guid("30d73c78-c26c-4ad5-b046-f35d3b6631de") },
                    { new Guid("2634d06f-aff4-447d-b331-5376fa3dd0cd"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 7", 0, new Guid("3a8d21d3-1527-4f10-ac78-17692fed12b2") },
                    { new Guid("28aa318e-d9c2-400a-bc51-b514cd681908"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 7", 0, new Guid("7a796cbe-c868-405f-998c-69d8137e5f5d") },
                    { new Guid("290e4f74-e9e5-463c-a631-7cdd32cdbdfc"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 1", 0, new Guid("bf584167-5bb8-452a-96af-f33700516226") },
                    { new Guid("29707d8d-e342-456c-9a4e-efae253afee2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 7", 0, new Guid("be15065c-822e-4048-8422-93451727c528") },
                    { new Guid("29a18d1f-0a6c-4f2b-b627-0ad728d2c8a1"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 4", 0, new Guid("3fdbf32a-1280-4bd5-b69d-559791b5e6c2") },
                    { new Guid("29a872dc-7975-40d5-b422-b1360a3b2721"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 9", 0, new Guid("52508fdf-7d5d-4290-afbb-2fddaf2e6756") },
                    { new Guid("2c87b710-fdc9-45a3-a9d0-94a522c7418a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 1", 0, new Guid("c78f717f-0f8f-406c-a58b-f34b5a931f49") },
                    { new Guid("2e0bc79e-c715-42c7-89c9-a1c9bd127681"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 1", 0, new Guid("d3a6039b-b47a-428d-bf54-bae0a4f41ff1") },
                    { new Guid("2f37b43a-c6ea-4d33-94a4-997d1df3b006"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 2", 0, new Guid("6c8a5363-71dc-4653-ba97-1126d313a5a8") },
                    { new Guid("31e7b7ac-3b33-4592-9508-d1bb5260f395"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 10", 0, new Guid("198046a0-69d0-4052-8e37-c1d8bdd598fc") },
                    { new Guid("32c77c22-52eb-43a6-aecc-98158e9da898"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 7", 0, new Guid("468c74f3-7177-4a46-bf72-cdd183fb363a") },
                    { new Guid("32e452b6-35f5-48dc-84bb-2755f9f78884"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 3", 0, new Guid("50c99dac-4473-40c3-8fb8-1e595826d5b2") },
                    { new Guid("34a98a12-91db-4ed5-a09b-2b3f820c8da1"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 6", 0, new Guid("f808f265-9dee-403b-8205-29ddec09a633") },
                    { new Guid("384fffc5-67df-4536-82cf-6053d173b299"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 5", 0, new Guid("5efcabfe-5bf1-4dd0-9f87-9389175699b0") },
                    { new Guid("3854ca0a-be66-49d8-998d-486689566f65"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 7", 0, new Guid("be15065c-822e-4048-8422-93451727c528") },
                    { new Guid("395c4db3-b59e-452d-9ccc-96410071eb0e"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 5", 0, new Guid("9a8f4060-2d8f-41a5-94a1-d4ee244cbf35") },
                    { new Guid("3bf4df01-8e22-4972-a277-c2a5327bb57a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 6", 0, new Guid("7a974643-05f0-42cb-8303-26c37643eb64") },
                    { new Guid("3d068d28-b26d-4c25-ae95-298567f04e25"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 1", 0, new Guid("d3a6039b-b47a-428d-bf54-bae0a4f41ff1") },
                    { new Guid("420c0aa8-9689-49b4-a702-4f5372cb618f"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 3", 0, new Guid("59ea0e26-f45d-4220-b346-93675f590a07") },
                    { new Guid("43e9810b-0f09-4ed8-a37d-b84a0a965288"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 3", 0, new Guid("c8febd80-1d97-4529-8863-f3fc7d76c471") },
                    { new Guid("44466fcf-14fd-4380-b266-b3697e1f7f56"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 8", 0, new Guid("8c583205-7179-464d-a3e6-e39c94eaef15") },
                    { new Guid("470e79cb-da19-4f48-8228-ad5fb44fcc13"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 5", 0, new Guid("5efcabfe-5bf1-4dd0-9f87-9389175699b0") },
                    { new Guid("4712dc0d-f990-471e-8962-1cbadde3fdbc"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 4", 0, new Guid("ed142f7b-079a-4d46-9820-1b009474755b") },
                    { new Guid("477f4387-e383-4669-8eba-568b74c88399"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 9", 0, new Guid("52508fdf-7d5d-4290-afbb-2fddaf2e6756") },
                    { new Guid("4815c6ca-f8bb-4f56-8cde-6da748d7066b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 7", 0, new Guid("433afcbb-8925-4187-b516-ce971c850325") },
                    { new Guid("4a653f60-401d-4a53-87dc-657c87c819e8"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 6", 0, new Guid("f808f265-9dee-403b-8205-29ddec09a633") },
                    { new Guid("4ce5d359-cdc7-4874-90fe-a5c6cdfabe50"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 4", 0, new Guid("f7dc9ddc-f59d-45d0-a7a4-376701f89a93") },
                    { new Guid("51340ed1-49ca-4749-a35b-c9d8bb2d2cb5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 8", 0, new Guid("5670024b-6924-49ee-b09c-3bcc85833a07") },
                    { new Guid("5592063f-6944-4a2e-a4b0-6fafc9427d12"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 6", 0, new Guid("3864cea2-4ac2-410d-be61-ec52d8948d5e") },
                    { new Guid("55be335c-c4c9-4ecf-8a6e-4920d12f21fe"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 8", 0, new Guid("5670024b-6924-49ee-b09c-3bcc85833a07") },
                    { new Guid("56b673db-909a-48da-8eae-dacdee341436"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 8", 0, new Guid("8c583205-7179-464d-a3e6-e39c94eaef15") },
                    { new Guid("58990045-1121-4a0d-bc7c-12e23a451cac"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 4", 0, new Guid("3fdbf32a-1280-4bd5-b69d-559791b5e6c2") },
                    { new Guid("5904d186-7fcf-49f3-aa89-004ee65d94a5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 10", 0, new Guid("ebb284dc-ea2d-4324-82e2-1f9069a84d30") },
                    { new Guid("594c6b6a-3a7a-4844-8585-b92161f3f0c9"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 10", 0, new Guid("198046a0-69d0-4052-8e37-c1d8bdd598fc") },
                    { new Guid("59cec97b-8d2f-4a42-8dae-02299a2649f6"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 1", 0, new Guid("9cb27ca8-b768-4410-b7fb-9fdf700b6035") },
                    { new Guid("5aa83b8c-31cf-4640-985e-e576f13280e3"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 5", 0, new Guid("d0b7c64d-46e4-4e32-b29c-0740c1065501") },
                    { new Guid("5cf6686d-f920-421f-864a-7d367ca87623"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 6", 0, new Guid("5a531256-adcc-4469-b3b9-3b4105402169") },
                    { new Guid("5d51357d-bba0-484e-8e6b-b042b93f1370"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 10", 0, new Guid("4058c788-a627-4824-b28c-25ab2fbaaa42") },
                    { new Guid("61a5c3bc-2f72-4de8-be1d-879d42e90992"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 3", 0, new Guid("59ea0e26-f45d-4220-b346-93675f590a07") },
                    { new Guid("631f9b5f-e9a8-41a1-8624-d4321a00529b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 9", 0, new Guid("eee7b325-04dc-4241-a2af-64773a7edd60") },
                    { new Guid("6367f807-9a6e-4aa3-a09b-6013d5f1d5c8"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 1", 0, new Guid("0844939b-87e4-4982-95c5-d101907a4542") },
                    { new Guid("6538ab4a-c260-4eff-93fa-dff0efeaa57e"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 2", 0, new Guid("7d472d7d-3b37-42d6-bf1c-19c01186899c") },
                    { new Guid("65f9908c-2acb-453d-a428-cb8101425271"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 7", 0, new Guid("433afcbb-8925-4187-b516-ce971c850325") },
                    { new Guid("6828e548-384e-4c32-9872-0a03dfeb53e4"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 2", 0, new Guid("bdd0379a-4429-45a5-88bf-f0d5817a1098") },
                    { new Guid("68684651-b8e6-443c-b625-0be0aea356e3"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 6", 0, new Guid("5a531256-adcc-4469-b3b9-3b4105402169") },
                    { new Guid("69cda6b1-865e-4391-ad9b-8cdf635d57c5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 9", 0, new Guid("29005fea-2c01-42f7-b2d9-c7d937d5b218") },
                    { new Guid("6a2ef993-ab9c-44ab-bcb9-760efd2b951a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 3", 0, new Guid("9fbc3c17-0a6f-4563-a14c-4b6398a0505c") },
                    { new Guid("6a51052e-16dc-41a2-abde-e8e96eee569c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 5", 0, new Guid("644f1525-91b1-4def-bbd2-54fbb45bc9ba") },
                    { new Guid("6c6b11c6-288f-4c34-baba-62a77ee6cbab"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 2", 0, new Guid("6c8a5363-71dc-4653-ba97-1126d313a5a8") },
                    { new Guid("6cee3d9b-3502-4e1f-80b1-1fb4085b9fbc"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 3", 0, new Guid("9fbc3c17-0a6f-4563-a14c-4b6398a0505c") },
                    { new Guid("6dd440ea-7389-4cd6-8877-26d548bb675c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 2", 0, new Guid("bdd0379a-4429-45a5-88bf-f0d5817a1098") },
                    { new Guid("6e241c8b-90ee-4967-8cbd-813dc70875e0"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 2", 0, new Guid("d3a9e00f-8f9a-4e04-94cc-51d0c9664dd9") },
                    { new Guid("6e36086a-828b-4fb7-a645-b3192e61c883"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 9", 0, new Guid("a12fe5e0-7c97-43d6-bf49-f6601c605814") },
                    { new Guid("70ec4eb6-a98a-442f-8b40-30c47f3d2a49"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 2", 0, new Guid("a18da225-0c7f-447c-850e-347b653fa693") },
                    { new Guid("74d900b1-fc80-4ea5-a2d6-c48df25d2aa2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 2", 0, new Guid("7d472d7d-3b37-42d6-bf1c-19c01186899c") },
                    { new Guid("76640009-93ac-4a93-a5b5-b416892a9c3b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 1", 0, new Guid("c180d68a-1306-4240-bb46-7c93b2da1b85") },
                    { new Guid("779b9dd9-b769-40b2-9167-b157e7b28521"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 2", 0, new Guid("d3a9e00f-8f9a-4e04-94cc-51d0c9664dd9") },
                    { new Guid("77db5382-c1e5-4603-af01-6a75dd948c58"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 6", 0, new Guid("7a974643-05f0-42cb-8303-26c37643eb64") },
                    { new Guid("786dda77-44ec-4a40-897c-2ce7413efb47"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 7", 0, new Guid("38008b08-00aa-4176-9a45-ebf6e771d358") },
                    { new Guid("794fae67-bf16-47c5-ac52-112683752e51"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 9", 0, new Guid("4bb487c9-516d-4d22-951a-5f6ff383ad00") },
                    { new Guid("7a2e36ea-25b2-4cc5-96db-89dca1901c8b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 5", 0, new Guid("5efcabfe-5bf1-4dd0-9f87-9389175699b0") },
                    { new Guid("7dca59d0-582e-4d68-8932-8e3ecf9d7bec"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 6", 0, new Guid("cc750fc2-418a-4ef5-a4da-2606ae67e8f6") },
                    { new Guid("7e26ae49-24ef-4ddd-a8b3-189882f7ca8e"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 7", 0, new Guid("7a796cbe-c868-405f-998c-69d8137e5f5d") },
                    { new Guid("7e7a0de6-ba66-4a0b-8b1f-6d44fe19901d"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 5", 0, new Guid("f6f9a4eb-06cf-42a0-ab01-67a7bae7ec00") },
                    { new Guid("81509a76-88ae-427b-86fb-5ec0f00cfc43"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 8", 0, new Guid("86db52e4-4c18-4048-8b30-e661d8e0ec8b") },
                    { new Guid("81f817cf-7be3-436e-b22b-18a5494953bb"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 5", 0, new Guid("9a8f4060-2d8f-41a5-94a1-d4ee244cbf35") },
                    { new Guid("82644960-96f4-43ba-9890-044fb04ca3e6"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 3", 0, new Guid("50c99dac-4473-40c3-8fb8-1e595826d5b2") },
                    { new Guid("828107e7-db4f-4e47-8eef-79eb9f833e09"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 8", 0, new Guid("5670024b-6924-49ee-b09c-3bcc85833a07") },
                    { new Guid("8349a45c-66f9-4e66-b2f5-d72cc5c490b5"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 4", 0, new Guid("f7dc9ddc-f59d-45d0-a7a4-376701f89a93") },
                    { new Guid("8552012c-719a-4b35-b283-b0eee487cf20"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 5", 0, new Guid("893b706a-1f72-4b6a-a54a-0c95ee8bb64e") },
                    { new Guid("87d40ca7-8171-46ec-be8a-190620731d8e"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 6", 0, new Guid("cc750fc2-418a-4ef5-a4da-2606ae67e8f6") },
                    { new Guid("895123ff-43cb-4fa2-b8a9-49a118734671"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 7", 0, new Guid("7a796cbe-c868-405f-998c-69d8137e5f5d") },
                    { new Guid("8a518833-a06d-486e-8e8a-0b33dafb0860"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 6", 0, new Guid("5a531256-adcc-4469-b3b9-3b4105402169") },
                    { new Guid("914bd6dc-a70a-41d4-8db5-47dde7244124"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 1", 0, new Guid("0844939b-87e4-4982-95c5-d101907a4542") },
                    { new Guid("9271b3dc-bc29-4385-9369-f0e25c5653f0"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 9", 0, new Guid("eee7b325-04dc-4241-a2af-64773a7edd60") },
                    { new Guid("93436282-7c66-4228-98bb-f83416ddb269"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 2", 0, new Guid("7d472d7d-3b37-42d6-bf1c-19c01186899c") },
                    { new Guid("96a40598-7ef6-47f9-b07c-324199803636"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 3", 0, new Guid("30d73c78-c26c-4ad5-b046-f35d3b6631de") },
                    { new Guid("97e774b5-c763-4b6e-8e6f-743ac91ea480"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 3", 0, new Guid("c8febd80-1d97-4529-8863-f3fc7d76c471") },
                    { new Guid("9ab99ed6-c0b1-45b0-9b4f-27b7c5c439fd"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 1", 0, new Guid("bf584167-5bb8-452a-96af-f33700516226") },
                    { new Guid("9b7019c1-0cbf-43e6-b835-efabe43f445d"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 10", 0, new Guid("065c75ad-d7bf-4b22-80ac-1950520e9ea2") },
                    { new Guid("9b99c69f-a677-4320-a19f-aaf77a10f094"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 1", 0, new Guid("c180d68a-1306-4240-bb46-7c93b2da1b85") },
                    { new Guid("9bc938fe-cb0a-4e20-b884-e1c3f0a0f64a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 8", 0, new Guid("c43c1686-1691-4b50-a748-4e3f2bc25588") },
                    { new Guid("9ce7e22b-4fad-4707-9e5e-1e4e5bfbf1eb"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 8", 0, new Guid("8c583205-7179-464d-a3e6-e39c94eaef15") },
                    { new Guid("a05ca0f7-85b5-44f3-8d81-83724402ce59"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 3", 0, new Guid("70ea2387-6ed6-40ef-9adc-66ac1a76ab62") },
                    { new Guid("a2da49f9-ed73-4e79-bd5b-ce37d0aa4171"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 10", 0, new Guid("ebb284dc-ea2d-4324-82e2-1f9069a84d30") },
                    { new Guid("a54fd59e-b512-43d5-8ce3-94f4db5bbd9d"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 9", 0, new Guid("eee7b325-04dc-4241-a2af-64773a7edd60") },
                    { new Guid("a57abc77-3657-4652-9fe5-e172096de113"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 5", 0, new Guid("893b706a-1f72-4b6a-a54a-0c95ee8bb64e") },
                    { new Guid("a9dab550-a0c8-410f-95a8-4a106ba3b016"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 4", 0, new Guid("ed142f7b-079a-4d46-9820-1b009474755b") },
                    { new Guid("abb133b6-5a8a-4056-b336-63086d39d731"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 2", 0, new Guid("0a723220-439b-4909-a82d-e40d5bfa5336") },
                    { new Guid("acb03b89-3075-4b78-a736-16a5947ff75f"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 6", 0, new Guid("3864cea2-4ac2-410d-be61-ec52d8948d5e") },
                    { new Guid("aee07ac0-7cb1-40d2-895c-3c2be8320970"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 1", 0, new Guid("9cb27ca8-b768-4410-b7fb-9fdf700b6035") },
                    { new Guid("afc20e60-fdec-4591-ba99-bc4d288b46f0"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 6", 0, new Guid("f808f265-9dee-403b-8205-29ddec09a633") },
                    { new Guid("afcdeed0-98e3-4f4a-ba04-da227b5afba7"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 2", 0, new Guid("6c8a5363-71dc-4653-ba97-1126d313a5a8") },
                    { new Guid("b782dc3e-1b74-47fd-ac02-f09446b22a29"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 10", 0, new Guid("1d1c9f1a-03cf-4188-bdc6-9232388c1395") },
                    { new Guid("b7ab4dd8-c83d-45f8-8570-97fd72ea529c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 9", 0, new Guid("4bb487c9-516d-4d22-951a-5f6ff383ad00") },
                    { new Guid("b7fbfcf3-0797-4927-a17c-2f354b0fc342"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 10", 0, new Guid("1d1c9f1a-03cf-4188-bdc6-9232388c1395") },
                    { new Guid("b8b70a21-6efe-4fe5-ab4a-02dfbc05b635"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 3", 0, new Guid("70ea2387-6ed6-40ef-9adc-66ac1a76ab62") },
                    { new Guid("b9410478-7100-441b-8a35-55cbe260ce11"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 9", 0, new Guid("a12fe5e0-7c97-43d6-bf49-f6601c605814") },
                    { new Guid("b9be7ee3-b541-496f-bbd1-816fdc5b8a8a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 2", 0, new Guid("d3a9e00f-8f9a-4e04-94cc-51d0c9664dd9") },
                    { new Guid("ba21e612-19f6-4abf-902b-22a0f3199bc7"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 4", 0, new Guid("91ba3464-f2de-462f-9511-b27e7fd4ae9e") },
                    { new Guid("bad16c83-c176-4a47-ad8d-8a50e4f7fb57"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 5", 0, new Guid("893b706a-1f72-4b6a-a54a-0c95ee8bb64e") },
                    { new Guid("bc46f809-b24a-4a57-a6f8-24821c31b49b"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 6", 0, new Guid("c621c39f-7a4f-41c7-820d-62b4b7920944") },
                    { new Guid("bca2a332-d395-4b24-99b4-247897e4e8c2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 4", 0, new Guid("0b9b5004-ad5a-440a-abd3-99631ba83e50") },
                    { new Guid("bd9564df-4bb9-4df3-862e-eaa30ad0ba44"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 3", 0, new Guid("70ea2387-6ed6-40ef-9adc-66ac1a76ab62") },
                    { new Guid("bdf93bcc-382d-4364-a757-81d0a41e74ae"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 5", 0, new Guid("644f1525-91b1-4def-bbd2-54fbb45bc9ba") },
                    { new Guid("c115fa68-fc19-435a-a97a-67207a037e32"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 2", 0, new Guid("bdd0379a-4429-45a5-88bf-f0d5817a1098") },
                    { new Guid("c11bade4-fc34-4fa5-8b9c-368eb20d4905"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 6", 0, new Guid("cc750fc2-418a-4ef5-a4da-2606ae67e8f6") },
                    { new Guid("c31f7116-a554-4e43-ad61-f806a724bc5c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 4", 0, new Guid("56dbef56-8fb7-4a05-9b8c-27a5b3a5a19b") },
                    { new Guid("c4f79446-a321-4f9c-a511-dcc134c2b1a2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 1", 0, new Guid("d3a6039b-b47a-428d-bf54-bae0a4f41ff1") },
                    { new Guid("c54350fb-1c77-4946-84be-e100aad1a8f0"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 8", 0, new Guid("86db52e4-4c18-4048-8b30-e661d8e0ec8b") },
                    { new Guid("c5490cb0-61a3-48ea-9b9e-5eb51fd99be4"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 10", 0, new Guid("ebb284dc-ea2d-4324-82e2-1f9069a84d30") },
                    { new Guid("caad08bd-f701-4758-9e77-31bb4da1a5d1"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 8", 0, new Guid("57d578a9-0ee1-4138-a060-bff69d1a132a") },
                    { new Guid("cd6bf58f-5874-4787-9552-32e882858da1"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 4", 0, new Guid("f7dc9ddc-f59d-45d0-a7a4-376701f89a93") },
                    { new Guid("cdaf0dee-546a-44ee-a097-3da95ec3f691"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 1 in Course 2", 0, new Guid("0a723220-439b-4909-a82d-e40d5bfa5336") },
                    { new Guid("cef57848-8ea0-4997-82a2-9799cfad423c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 10", 0, new Guid("9ede59f0-be75-4c13-aad1-5553ac9596b2") },
                    { new Guid("cf0cf008-185d-43cf-9607-57cf24efdd8f"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 1", 0, new Guid("c180d68a-1306-4240-bb46-7c93b2da1b85") },
                    { new Guid("cf0f188d-ab12-4885-8c80-857297329324"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 6", 0, new Guid("c621c39f-7a4f-41c7-820d-62b4b7920944") },
                    { new Guid("cf4b5345-1d4e-4ebf-8877-2e4d71285247"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 2 in Course 8", 0, new Guid("eddfb3b3-1e6d-4c6a-ae26-0f4bb1d586c1") },
                    { new Guid("d1388d92-caf7-4bbf-bd0b-811c7d144ec2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 9", 0, new Guid("8a775a72-bae6-4fbe-a020-824c5c3c2082") },
                    { new Guid("d2106f5a-fc9e-4514-95b4-d5cdfc9db238"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 1", 0, new Guid("9cb27ca8-b768-4410-b7fb-9fdf700b6035") },
                    { new Guid("d2ee3c38-12ff-4db4-8419-10ebc5033157"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 8", 0, new Guid("c43c1686-1691-4b50-a748-4e3f2bc25588") },
                    { new Guid("d53418cd-de86-43af-b30a-635af222e2b8"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 3", 0, new Guid("c8febd80-1d97-4529-8863-f3fc7d76c471") },
                    { new Guid("db4038b1-d69a-43b0-89f1-c3f01c594fe3"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 7", 0, new Guid("433afcbb-8925-4187-b516-ce971c850325") },
                    { new Guid("db931fc3-5be3-4bab-8ab1-a3eec9130b9d"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 10", 0, new Guid("9ede59f0-be75-4c13-aad1-5553ac9596b2") },
                    { new Guid("dcb95d55-26c5-40fd-9f59-e597a8b7ce6f"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 5", 0, new Guid("f6f9a4eb-06cf-42a0-ab01-67a7bae7ec00") },
                    { new Guid("dd0ff16c-8f4e-4e9d-aa0a-0d61ee45ec95"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 9", 0, new Guid("29005fea-2c01-42f7-b2d9-c7d937d5b218") },
                    { new Guid("dd2de7b6-cd47-4ebe-bbfb-615b8f33be48"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 1 in Course 1", 0, new Guid("0844939b-87e4-4982-95c5-d101907a4542") },
                    { new Guid("dde3712c-1bea-46bd-9452-caea39878513"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 10", 0, new Guid("198046a0-69d0-4052-8e37-c1d8bdd598fc") },
                    { new Guid("de412af7-e346-4196-992e-72b9e03307a9"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 2", 0, new Guid("a18da225-0c7f-447c-850e-347b653fa693") },
                    { new Guid("de7dcc28-1b98-4af9-9271-4054b75a1888"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 8", 0, new Guid("eddfb3b3-1e6d-4c6a-ae26-0f4bb1d586c1") },
                    { new Guid("dff11058-5ea3-4e18-beca-b88306b6ed7c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 3", 0, new Guid("50c99dac-4473-40c3-8fb8-1e595826d5b2") },
                    { new Guid("e057bb9d-c9cb-4725-b23a-6acf02616ecd"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 7", 0, new Guid("3a8d21d3-1527-4f10-ac78-17692fed12b2") },
                    { new Guid("e1d860c5-87b2-4a0a-8760-22fd9a56fb51"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 1 in Course 7", 0, new Guid("38008b08-00aa-4176-9a45-ebf6e771d358") },
                    { new Guid("e2772bfd-f46e-46ee-926f-3d504059eb6c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 2 in Course 1", 0, new Guid("c78f717f-0f8f-406c-a58b-f34b5a931f49") },
                    { new Guid("e51f5dde-faa5-4df7-b02f-690cdd7e9291"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 10", 0, new Guid("9ede59f0-be75-4c13-aad1-5553ac9596b2") },
                    { new Guid("e5a9cae7-21c1-46d9-9e3b-27b46cdff496"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 2 in Course 4", 0, new Guid("3fdbf32a-1280-4bd5-b69d-559791b5e6c2") },
                    { new Guid("e9a7acb9-115f-4080-b13b-1af5209a7775"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 2 in Course 8", 0, new Guid("eddfb3b3-1e6d-4c6a-ae26-0f4bb1d586c1") },
                    { new Guid("ea6410d5-2548-4dbd-8ba9-0e2ef94cd96a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 7", 0, new Guid("3a8d21d3-1527-4f10-ac78-17692fed12b2") },
                    { new Guid("ee054b7f-3a54-4a99-881c-32a9f16cfa1a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 1 in Course 10", 0, new Guid("4058c788-a627-4824-b28c-25ab2fbaaa42") },
                    { new Guid("eff89076-3bf1-4c32-94e4-8ac5b549c794"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 9", 0, new Guid("52508fdf-7d5d-4290-afbb-2fddaf2e6756") },
                    { new Guid("f07758e5-e509-4466-9846-ba727395c07a"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 3 in Course 4", 0, new Guid("91ba3464-f2de-462f-9511-b27e7fd4ae9e") },
                    { new Guid("f0f92c72-f942-4763-a6ed-871dfef334e0"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 1 in Course 2", 0, new Guid("0a723220-439b-4909-a82d-e40d5bfa5336") },
                    { new Guid("f249e784-a07c-4239-a7ba-909549503f3c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 5", 0, new Guid("f6f9a4eb-06cf-42a0-ab01-67a7bae7ec00") },
                    { new Guid("f452004a-7c73-499d-aed8-004e8f9c4eff"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 7", 0, new Guid("468c74f3-7177-4a46-bf72-cdd183fb363a") },
                    { new Guid("f5246a68-d2c5-4845-b2ba-940a727a534c"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 1 for Section 3 in Course 8", 0, new Guid("c43c1686-1691-4b50-a748-4e3f2bc25588") },
                    { new Guid("f5612cda-7f88-4cba-9123-f7a99caaa3ba"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 9", 0, new Guid("a12fe5e0-7c97-43d6-bf49-f6601c605814") },
                    { new Guid("f59a283d-4717-4567-9637-da2d5abcfdce"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 3 in Course 3", 0, new Guid("59ea0e26-f45d-4220-b346-93675f590a07") },
                    { new Guid("f6a99b7b-2fe9-4f37-8f4d-bdec556e314e"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 2 for Section 2 in Course 2", 0, new Guid("a18da225-0c7f-447c-850e-347b653fa693") },
                    { new Guid("f6c12a98-bc8e-4752-84b9-dbf149ecf2fa"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 4", 0, new Guid("91ba3464-f2de-462f-9511-b27e7fd4ae9e") },
                    { new Guid("f7636700-633f-4a05-bd1c-b43967f487e7"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 1 for Section 3 in Course 6", 0, new Guid("c621c39f-7a4f-41c7-820d-62b4b7920944") },
                    { new Guid("f87b5982-6da3-447f-8782-ea3d3300940e"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 1 for Quiz 1 for Section 3 in Course 5", 0, new Guid("9a8f4060-2d8f-41a5-94a1-d4ee244cbf35") },
                    { new Guid("f9b54487-1137-4c25-8dea-0e0a49742ba8"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 2 for Quiz 2 for Section 1 in Course 10", 0, new Guid("4058c788-a627-4824-b28c-25ab2fbaaa42") },
                    { new Guid("fda77d92-e467-4c67-b106-89c724b63e15"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 3 in Course 5", 0, new Guid("644f1525-91b1-4def-bbd2-54fbb45bc9ba") },
                    { new Guid("fe4c08e8-5e7f-4eb1-8e5b-b55746c876d2"), null, "[\"Option 1\",\"Option 2\"]", "[\"Option 1\",\"Option 2\"]", false, "{}", null, "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "[\"Option 1\",\"Option 2\",\"Option 3\",\"Option 4\"]", "Question 3 for Quiz 2 for Section 2 in Course 3", 0, new Guid("30d73c78-c26c-4ad5-b046-f35d3b6631de") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a18d609-a4f2-43af-8417-d08666e7ed22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d1e6312-d850-48e3-b6f9-31fac10996a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("966f702e-7938-4585-b496-1342b90bbf52"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d790f07c-392f-4918-9451-606ef1f8ad91"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e0631c91-607d-4e3f-b941-43d1446380db"));

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("560aa660-0449-4ae0-9269-1424d1415aac") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("90fbad11-1087-41e4-9564-6aaf09780c08") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d") });

            migrationBuilder.DeleteData(
                table: "DepartmentCourses",
                keyColumns: new[] { "CoursesId", "DepartmentsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("a3e71022-3255-4454-88a7-031080443bce") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("a3e71022-3255-4454-88a7-031080443bce") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("a3e71022-3255-4454-88a7-031080443bce") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("a3e71022-3255-4454-88a7-031080443bce") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("a3e71022-3255-4454-88a7-031080443bce") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("a3e71022-3255-4454-88a7-031080443bce") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("a3e71022-3255-4454-88a7-031080443bce") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("a3e71022-3255-4454-88a7-031080443bce") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("a3e71022-3255-4454-88a7-031080443bce") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("89297dc6-4f80-4661-9667-8e28f6b13721") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("a3e71022-3255-4454-88a7-031080443bce") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("a52e1528-b1a2-40ab-9aaf-402304732459") });

            migrationBuilder.DeleteData(
                table: "FacultyCourses",
                keyColumns: new[] { "CoursesId", "FacultiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757") });

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("01cab6e0-44fa-436a-9e50-ad5927e47ddc"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("045c10d3-7dcc-4415-aa52-69550d2b254f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("09406f69-e7f3-4606-8a08-f04d6aa68c87"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("0dab353c-7132-4d97-babf-d90932b5e10a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("14fdb462-94a3-4153-b926-6c64332e983e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1556589a-da18-4d98-9a0d-9c8e9728f9fa"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1c29e702-ebae-407e-896d-20f216d88888"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1ed84cd0-3299-4edd-97cc-905b33c80128"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("1f64c550-778c-41fc-9feb-1af0e02a7af6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("20616c2d-f9ec-4368-8cce-be29e5deaaa8"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2099066a-f939-41ce-8165-100469e3ad15"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("23453b6f-8a34-40db-9a8c-8c7ca70c9fd0"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("260528cf-a786-41e1-800c-577a5fe723e6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2651c4dc-5a35-4fb3-b275-397011cd593d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("268ef601-1d71-42b8-b381-dbf104163992"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("29419946-acf7-4667-9776-5c82ab1716f4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("29fcaa8e-4c8c-4292-91f5-1abb9fc00c87"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2c55a785-9008-4c85-bbb9-7b7dee281572"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2d3823b8-4cf0-4e6d-b8b5-675a557e4003"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("2d978232-5137-454b-9b78-203e16ac11df"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("32bd9caa-bcb5-4ecc-aa59-18bbe31519c4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("347c82e6-bbf2-410b-9db4-e256a260e561"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("36d34f3d-04ee-4292-8045-718bd1f67ada"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("3b507149-a283-4494-bff2-0eeb01e15617"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("44df0801-1224-4b16-9f04-7ff2721bd8f7"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("47bd1217-d6a5-4d8d-b404-e4e9ba961eb2"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("492efa22-ee40-4f07-8fbb-beef32b21bdd"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("4fa2f00f-8990-4fe5-a6fc-6e014f36ad23"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("502923ac-89e4-4326-9575-f03be6a320e5"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("510af08b-e245-40d3-a408-f01777fed964"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("577cbb4d-b447-4a24-85d4-a278e28412f0"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("5df17b95-3099-49d9-9aa8-e28133804f42"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6144a950-58e8-4cbe-83e3-85f059c4f11e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("63071dd4-d515-4d3e-b0c5-07b78f323b3f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("65bd4fb5-bdf8-46f4-940b-d14c572e403c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("69c6ad9d-9a18-476a-b7ab-61159a548d38"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6a5e1fbc-1beb-492e-b990-b9d06729301f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6b1a6aea-e609-4999-9b16-c5e851cfc880"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6b89cf25-eac3-4d72-b6e0-6abf8ae3d81d"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("6d52f7c7-0104-457e-b3d3-d1f010994dc5"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("71328164-72a7-4728-82e0-7ecc53b202e6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7197001c-8222-4a89-8611-822888a70b03"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("75f5b328-210a-466a-9e38-7bc6669bdae9"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("76f800ef-bfc7-4efb-a3d4-f1de5953939e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("78af4b86-dac1-4c42-bcb4-4686a301d102"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7c5fc05b-1525-4ea4-a7f9-44425e0300e5"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("7fb60bdc-3ccd-49f6-be9c-aa8827d07956"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("84737464-7220-43c2-aeed-5ae441d1ac89"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("856fbaac-ec06-47dd-a2f7-9fceef062084"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("87e95952-5449-4c61-94ef-1bfc582c0185"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("8ec01a8c-84fa-4c41-86b8-57cd1a913fd2"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("946c762f-b674-4010-b2e8-467ec5c19d83"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("949edc9a-0c5d-4ee8-8c73-276fe4de6232"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("971d328c-933d-4dc6-ab88-78fa02a0a0ed"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9784df96-94e0-41b8-bc21-3829409b48a4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("97e4d9d3-4525-4c72-9213-ef032fbf2789"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("98846af9-4346-414c-9579-26897ec3d283"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9996d590-b522-4526-bb23-5a4e6346c1d3"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("9bbe9321-29b4-4182-9ab1-5eec2d2b7687"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a1a5fa0d-f61a-4bb4-8056-536c51109908"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("a3d6bb40-7b2c-45c3-9cdc-6915f57774db"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ade7d45f-b8e7-4562-a2d6-56db6fdc3599"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("af3e8ff5-9421-4ece-a40c-88b986836661"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("afdef2c1-b971-4a6d-9138-0d60f39d8123"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b02c9d22-914c-4fb5-b12e-e8f8e896dd52"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("b9579f53-539d-4bd4-a631-19058af2a259"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("bc522689-1cd5-4779-930d-ac6edf5f2823"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("bd9afb73-f4bb-49c1-8e36-fccc57df4de4"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("bed28af3-00b0-46ac-92de-d28c3f96fb19"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c16b0faf-20b7-458e-b4ef-16580e379f52"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c2bb8a93-30fa-42e0-91bd-59561ebe7c0a"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("c40b5fc8-7ef0-4bf6-b1c5-7f5c5e27d99f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ce1c5822-a778-40a7-825f-237f1d115acb"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d710199e-c89e-41c5-8dc1-799902b6215b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d80224ae-474b-460d-818f-409a6ccbbadf"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d84dc5d0-4620-40bf-bc7e-c258dc1e190b"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("d9352996-f5f8-44dc-9964-ed78800186ea"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("dd9c2322-a27a-48f9-b409-2afbeb04496f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("dda13df1-840d-421a-85c8-4bbde1dea86f"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e6228ee8-eb00-4d3b-aab5-06568307aa40"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("e90cf593-67a1-4664-9142-8a76d2e7a0c7"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("ea4c195d-85bc-4ef5-ab0e-086152204fea"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("edb33b67-a45b-41f1-87a8-c2cc20e57bfa"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("efe60975-1cba-43ae-a2ad-c68acd715253"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f280ef64-a707-404b-af7f-9d44c1814ba6"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f3330534-ff77-4818-8cd9-b543ac7ca3e0"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f61d8b83-350c-495f-a6f8-64b00c5ce40c"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f76cf2a9-9424-4596-bd31-fcde3e04078e"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("f845c274-cbcd-4963-966a-b526a4d770f0"));

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: new Guid("fa1ec07b-5888-4d27-89f4-5dd8606aef47"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("007b407f-637e-4535-bd69-4441b746ee4d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("009fcd5f-695b-4300-a3d0-b8f21b4f4c2a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("04886cf2-aab6-4302-a532-a128ca526350"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("072e3f5a-8ca2-4edb-bd99-22d622d28d73"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("07b6c9d8-4997-489e-bf5f-6fd2e970b0cb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("08c127a9-62dd-4d8b-987a-7d4e4b94d815"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0b2afe6f-426b-460e-8a18-d2b52e095355"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0b5b15ac-0d13-4d61-8eec-89d2abc96959"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0ba0ff9f-a5d7-462f-bad2-bbf6adac81bf"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0cc6d988-e9a0-40a1-97e3-ddce9b36a518"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0f6e6974-6a2d-4ca3-a915-ec6b7f92408c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("11c178c2-0aca-428f-96c3-816f8051a4b4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("167e877c-faf8-434c-a317-08355c23bb58"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("17f59e6f-5646-449e-b3d6-7ec8e4e15edc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1b092379-08a2-4e01-8818-95d64d0bd6a4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1ce3cd3a-aedd-4753-b755-d4431a511e8d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1e75fe48-f2af-446b-b83b-ddba5004e04d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1e8f7e03-9607-4733-8f38-db1d41b398d1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1ef27fbf-9311-4751-94fc-c90812543d45"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1f41813e-b820-4cf1-a528-0f0996ac790f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2124dac4-d39f-4d15-a407-dab8b3a8aa48"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2143fe06-0247-4bdb-9296-2360adc3737a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("222f4ace-c3ce-4772-9a34-2560c0b41150"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("24966a3f-5410-4b4e-8b41-378b594a105c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2522ebb1-d4e7-4687-bf71-f348f0348787"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("25b4595e-d2c7-45fa-8f99-9391dfa2825b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2634d06f-aff4-447d-b331-5376fa3dd0cd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("28aa318e-d9c2-400a-bc51-b514cd681908"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("290e4f74-e9e5-463c-a631-7cdd32cdbdfc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("29707d8d-e342-456c-9a4e-efae253afee2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("29a18d1f-0a6c-4f2b-b627-0ad728d2c8a1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("29a872dc-7975-40d5-b422-b1360a3b2721"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2c87b710-fdc9-45a3-a9d0-94a522c7418a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2e0bc79e-c715-42c7-89c9-a1c9bd127681"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2f37b43a-c6ea-4d33-94a4-997d1df3b006"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("31e7b7ac-3b33-4592-9508-d1bb5260f395"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("32c77c22-52eb-43a6-aecc-98158e9da898"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("32e452b6-35f5-48dc-84bb-2755f9f78884"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("34a98a12-91db-4ed5-a09b-2b3f820c8da1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("384fffc5-67df-4536-82cf-6053d173b299"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3854ca0a-be66-49d8-998d-486689566f65"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("395c4db3-b59e-452d-9ccc-96410071eb0e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3bf4df01-8e22-4972-a277-c2a5327bb57a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3d068d28-b26d-4c25-ae95-298567f04e25"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("420c0aa8-9689-49b4-a702-4f5372cb618f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("43e9810b-0f09-4ed8-a37d-b84a0a965288"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("44466fcf-14fd-4380-b266-b3697e1f7f56"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("470e79cb-da19-4f48-8228-ad5fb44fcc13"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4712dc0d-f990-471e-8962-1cbadde3fdbc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("477f4387-e383-4669-8eba-568b74c88399"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4815c6ca-f8bb-4f56-8cde-6da748d7066b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4a653f60-401d-4a53-87dc-657c87c819e8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4ce5d359-cdc7-4874-90fe-a5c6cdfabe50"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("51340ed1-49ca-4749-a35b-c9d8bb2d2cb5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5592063f-6944-4a2e-a4b0-6fafc9427d12"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("55be335c-c4c9-4ecf-8a6e-4920d12f21fe"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("56b673db-909a-48da-8eae-dacdee341436"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("58990045-1121-4a0d-bc7c-12e23a451cac"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5904d186-7fcf-49f3-aa89-004ee65d94a5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("594c6b6a-3a7a-4844-8585-b92161f3f0c9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("59cec97b-8d2f-4a42-8dae-02299a2649f6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5aa83b8c-31cf-4640-985e-e576f13280e3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5cf6686d-f920-421f-864a-7d367ca87623"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5d51357d-bba0-484e-8e6b-b042b93f1370"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("61a5c3bc-2f72-4de8-be1d-879d42e90992"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("631f9b5f-e9a8-41a1-8624-d4321a00529b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6367f807-9a6e-4aa3-a09b-6013d5f1d5c8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6538ab4a-c260-4eff-93fa-dff0efeaa57e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("65f9908c-2acb-453d-a428-cb8101425271"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6828e548-384e-4c32-9872-0a03dfeb53e4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("68684651-b8e6-443c-b625-0be0aea356e3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("69cda6b1-865e-4391-ad9b-8cdf635d57c5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6a2ef993-ab9c-44ab-bcb9-760efd2b951a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6a51052e-16dc-41a2-abde-e8e96eee569c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6c6b11c6-288f-4c34-baba-62a77ee6cbab"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6cee3d9b-3502-4e1f-80b1-1fb4085b9fbc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6dd440ea-7389-4cd6-8877-26d548bb675c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6e241c8b-90ee-4967-8cbd-813dc70875e0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("6e36086a-828b-4fb7-a645-b3192e61c883"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("70ec4eb6-a98a-442f-8b40-30c47f3d2a49"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("74d900b1-fc80-4ea5-a2d6-c48df25d2aa2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("76640009-93ac-4a93-a5b5-b416892a9c3b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("779b9dd9-b769-40b2-9167-b157e7b28521"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("77db5382-c1e5-4603-af01-6a75dd948c58"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("786dda77-44ec-4a40-897c-2ce7413efb47"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("794fae67-bf16-47c5-ac52-112683752e51"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7a2e36ea-25b2-4cc5-96db-89dca1901c8b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7dca59d0-582e-4d68-8932-8e3ecf9d7bec"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7e26ae49-24ef-4ddd-a8b3-189882f7ca8e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("7e7a0de6-ba66-4a0b-8b1f-6d44fe19901d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("81509a76-88ae-427b-86fb-5ec0f00cfc43"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("81f817cf-7be3-436e-b22b-18a5494953bb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("82644960-96f4-43ba-9890-044fb04ca3e6"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("828107e7-db4f-4e47-8eef-79eb9f833e09"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8349a45c-66f9-4e66-b2f5-d72cc5c490b5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8552012c-719a-4b35-b283-b0eee487cf20"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("87d40ca7-8171-46ec-be8a-190620731d8e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("895123ff-43cb-4fa2-b8a9-49a118734671"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8a518833-a06d-486e-8e8a-0b33dafb0860"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("914bd6dc-a70a-41d4-8db5-47dde7244124"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9271b3dc-bc29-4385-9369-f0e25c5653f0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("93436282-7c66-4228-98bb-f83416ddb269"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("96a40598-7ef6-47f9-b07c-324199803636"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("97e774b5-c763-4b6e-8e6f-743ac91ea480"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9ab99ed6-c0b1-45b0-9b4f-27b7c5c439fd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9b7019c1-0cbf-43e6-b835-efabe43f445d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9b99c69f-a677-4320-a19f-aaf77a10f094"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9bc938fe-cb0a-4e20-b884-e1c3f0a0f64a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9ce7e22b-4fad-4707-9e5e-1e4e5bfbf1eb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a05ca0f7-85b5-44f3-8d81-83724402ce59"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a2da49f9-ed73-4e79-bd5b-ce37d0aa4171"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a54fd59e-b512-43d5-8ce3-94f4db5bbd9d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a57abc77-3657-4652-9fe5-e172096de113"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a9dab550-a0c8-410f-95a8-4a106ba3b016"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("abb133b6-5a8a-4056-b336-63086d39d731"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("acb03b89-3075-4b78-a736-16a5947ff75f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("aee07ac0-7cb1-40d2-895c-3c2be8320970"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("afc20e60-fdec-4591-ba99-bc4d288b46f0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("afcdeed0-98e3-4f4a-ba04-da227b5afba7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b782dc3e-1b74-47fd-ac02-f09446b22a29"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b7ab4dd8-c83d-45f8-8570-97fd72ea529c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b7fbfcf3-0797-4927-a17c-2f354b0fc342"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b8b70a21-6efe-4fe5-ab4a-02dfbc05b635"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b9410478-7100-441b-8a35-55cbe260ce11"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b9be7ee3-b541-496f-bbd1-816fdc5b8a8a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ba21e612-19f6-4abf-902b-22a0f3199bc7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bad16c83-c176-4a47-ad8d-8a50e4f7fb57"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bc46f809-b24a-4a57-a6f8-24821c31b49b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bca2a332-d395-4b24-99b4-247897e4e8c2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bd9564df-4bb9-4df3-862e-eaa30ad0ba44"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bdf93bcc-382d-4364-a757-81d0a41e74ae"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c115fa68-fc19-435a-a97a-67207a037e32"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c11bade4-fc34-4fa5-8b9c-368eb20d4905"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c31f7116-a554-4e43-ad61-f806a724bc5c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c4f79446-a321-4f9c-a511-dcc134c2b1a2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c54350fb-1c77-4946-84be-e100aad1a8f0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c5490cb0-61a3-48ea-9b9e-5eb51fd99be4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("caad08bd-f701-4758-9e77-31bb4da1a5d1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cd6bf58f-5874-4787-9552-32e882858da1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cdaf0dee-546a-44ee-a097-3da95ec3f691"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cef57848-8ea0-4997-82a2-9799cfad423c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cf0cf008-185d-43cf-9607-57cf24efdd8f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cf0f188d-ab12-4885-8c80-857297329324"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cf4b5345-1d4e-4ebf-8877-2e4d71285247"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d1388d92-caf7-4bbf-bd0b-811c7d144ec2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d2106f5a-fc9e-4514-95b4-d5cdfc9db238"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d2ee3c38-12ff-4db4-8419-10ebc5033157"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d53418cd-de86-43af-b30a-635af222e2b8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("db4038b1-d69a-43b0-89f1-c3f01c594fe3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("db931fc3-5be3-4bab-8ab1-a3eec9130b9d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dcb95d55-26c5-40fd-9f59-e597a8b7ce6f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dd0ff16c-8f4e-4e9d-aa0a-0d61ee45ec95"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dd2de7b6-cd47-4ebe-bbfb-615b8f33be48"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dde3712c-1bea-46bd-9452-caea39878513"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("de412af7-e346-4196-992e-72b9e03307a9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("de7dcc28-1b98-4af9-9271-4054b75a1888"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dff11058-5ea3-4e18-beca-b88306b6ed7c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e057bb9d-c9cb-4725-b23a-6acf02616ecd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e1d860c5-87b2-4a0a-8760-22fd9a56fb51"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e2772bfd-f46e-46ee-926f-3d504059eb6c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e51f5dde-faa5-4df7-b02f-690cdd7e9291"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e5a9cae7-21c1-46d9-9e3b-27b46cdff496"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e9a7acb9-115f-4080-b13b-1af5209a7775"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ea6410d5-2548-4dbd-8ba9-0e2ef94cd96a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ee054b7f-3a54-4a99-881c-32a9f16cfa1a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("eff89076-3bf1-4c32-94e4-8ac5b549c794"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f07758e5-e509-4466-9846-ba727395c07a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f0f92c72-f942-4763-a6ed-871dfef334e0"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f249e784-a07c-4239-a7ba-909549503f3c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f452004a-7c73-499d-aed8-004e8f9c4eff"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f5246a68-d2c5-4845-b2ba-940a727a534c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f5612cda-7f88-4cba-9123-f7a99caaa3ba"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f59a283d-4717-4567-9637-da2d5abcfdce"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f6a99b7b-2fe9-4f37-8f4d-bdec556e314e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f6c12a98-bc8e-4752-84b9-dbf149ecf2fa"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f7636700-633f-4a05-bd1c-b43967f487e7"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f87b5982-6da3-447f-8782-ea3d3300940e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f9b54487-1137-4c25-8dea-0e0a49742ba8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fda77d92-e467-4c67-b106-89c724b63e15"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fe4c08e8-5e7f-4eb1-8e5b-b55746c876d2"));

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("72b51535-da3d-4249-bf95-6370ca89641e"), new Guid("326de8ac-dd85-4aa2-8576-960fdfcf6740") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("8d7094f9-f09e-45b4-931e-da3abff927c6"), new Guid("326de8ac-dd85-4aa2-8576-960fdfcf6740") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("15b40287-e1d0-4da5-8482-b44116d39068"), new Guid("4dac6d1f-e5c7-47ef-80a8-4466a3e71d1b") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("5af320c5-6103-49c5-aacf-704d5b601764"), new Guid("4dac6d1f-e5c7-47ef-80a8-4466a3e71d1b") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("cd65d3fd-85c6-417c-b45f-292c0a6951cc"), new Guid("4dac6d1f-e5c7-47ef-80a8-4466a3e71d1b") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("15b40287-e1d0-4da5-8482-b44116d39068"), new Guid("efa4df83-5507-4874-968e-decefcb037d6") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("5af320c5-6103-49c5-aacf-704d5b601764"), new Guid("efa4df83-5507-4874-968e-decefcb037d6") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("72b51535-da3d-4249-bf95-6370ca89641e"), new Guid("efa4df83-5507-4874-968e-decefcb037d6") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("8d7094f9-f09e-45b4-931e-da3abff927c6"), new Guid("efa4df83-5507-4874-968e-decefcb037d6") });

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { new Guid("cd65d3fd-85c6-417c-b45f-292c0a6951cc"), new Guid("efa4df83-5507-4874-968e-decefcb037d6") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0840c49f-cbf1-412c-a613-c2a7d6a283aa"));

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("60943e28-b15a-4e29-a84c-aa15222a2191") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("dfb4b875-6234-473e-bf02-be1230c08a81") });

            migrationBuilder.DeleteData(
                table: "SpecializationCourses",
                keyColumns: new[] { "CoursesId", "SpecializationsId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("53ee465c-d532-49f5-8625-32c906fbe83a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("9b109cbd-764b-4f71-b310-15211af3b68a") });

            migrationBuilder.DeleteData(
                table: "UniversityCourses",
                keyColumns: new[] { "CoursesId", "UniversitiesId" },
                keyValues: new object[] { new Guid("f592431c-9057-45e7-872e-d81d347046f7"), new Guid("af224645-999c-43a4-acc3-a125e04590ea") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("10fdc47a-7c95-43fd-97aa-4dcf0db51011"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("19261c7e-a908-4cf2-a376-acafad6d727d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3303d430-0d8a-42e2-87fa-ad5419d6aa9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3bccfcb6-2a5b-4712-a00d-68f80e19b710"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d054e0a-7e77-44ef-a5af-95794dc88daa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41f13c7a-56ae-405a-b2f1-bb5e925c8622"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4538fb2c-ab35-457f-88d0-199b71c51104"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4af3593f-44ce-40af-a81f-9a6b433cc16b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cb92ab9-bd2e-4585-a87a-07198a2bd8d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("655a2acd-3b41-4a77-85eb-40bd42ba31f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("658a7a23-caaf-4d4e-a6ee-fe65c80ccdb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66a5a5a1-db81-49d4-bbe6-43fe95b3ec5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6921b69c-febf-453e-a2fb-60c634bb631c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a9c9716-c31c-4152-9ff2-744b53fe9cb9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("82b4b58d-3338-472a-be92-28b1b0b1b765"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ad38ab7-6587-4fae-9df0-e67c24c26342"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b33fc71-eb96-4d45-be10-cba68cef09d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99118280-50e8-4ce9-a633-b5134dd49719"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9a79d410-33b8-419c-9b81-855e0a29e1e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9aea080b-3a54-4e0b-9a90-ba135389f009"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ee4620e-f6ec-41a3-8210-f75a3c9f643b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3842b52-7160-4a0f-a0dc-787213ec76e1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7d0fffa-2f54-4be9-bd40-c409e18af749"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc261130-57fe-4a5c-84cc-be5184cced51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cde5d825-fe22-4479-bcaa-86c84a631c5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4dfa26e-b7ce-4cd8-b67a-c9363a446bc3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dcc4737f-5dec-4d77-8518-c1613134af46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eb5e603a-8860-4d9b-863b-f4c53795d1b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f625d2ab-9346-4151-856b-82072c7d3797"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcc3c3b1-a37a-4dbe-8017-5824618bf8cf"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("15b40287-e1d0-4da5-8482-b44116d39068"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5af320c5-6103-49c5-aacf-704d5b601764"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("72b51535-da3d-4249-bf95-6370ca89641e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8d7094f9-f09e-45b4-931e-da3abff927c6"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("cd65d3fd-85c6-417c-b45f-292c0a6951cc"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("065c75ad-d7bf-4b22-80ac-1950520e9ea2"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("0844939b-87e4-4982-95c5-d101907a4542"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("0a723220-439b-4909-a82d-e40d5bfa5336"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("0b9b5004-ad5a-440a-abd3-99631ba83e50"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("198046a0-69d0-4052-8e37-c1d8bdd598fc"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("1d1c9f1a-03cf-4188-bdc6-9232388c1395"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("29005fea-2c01-42f7-b2d9-c7d937d5b218"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("30d73c78-c26c-4ad5-b046-f35d3b6631de"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("38008b08-00aa-4176-9a45-ebf6e771d358"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("3864cea2-4ac2-410d-be61-ec52d8948d5e"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("3a8d21d3-1527-4f10-ac78-17692fed12b2"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("3fdbf32a-1280-4bd5-b69d-559791b5e6c2"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("4058c788-a627-4824-b28c-25ab2fbaaa42"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("433afcbb-8925-4187-b516-ce971c850325"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("468c74f3-7177-4a46-bf72-cdd183fb363a"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("4bb487c9-516d-4d22-951a-5f6ff383ad00"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("50c99dac-4473-40c3-8fb8-1e595826d5b2"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("52508fdf-7d5d-4290-afbb-2fddaf2e6756"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("5670024b-6924-49ee-b09c-3bcc85833a07"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("56dbef56-8fb7-4a05-9b8c-27a5b3a5a19b"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("57d578a9-0ee1-4138-a060-bff69d1a132a"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("59ea0e26-f45d-4220-b346-93675f590a07"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("5a531256-adcc-4469-b3b9-3b4105402169"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("5efcabfe-5bf1-4dd0-9f87-9389175699b0"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("644f1525-91b1-4def-bbd2-54fbb45bc9ba"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("6c8a5363-71dc-4653-ba97-1126d313a5a8"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("70ea2387-6ed6-40ef-9adc-66ac1a76ab62"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("7a796cbe-c868-405f-998c-69d8137e5f5d"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("7a974643-05f0-42cb-8303-26c37643eb64"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("7d472d7d-3b37-42d6-bf1c-19c01186899c"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("86db52e4-4c18-4048-8b30-e661d8e0ec8b"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("893b706a-1f72-4b6a-a54a-0c95ee8bb64e"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("8a775a72-bae6-4fbe-a020-824c5c3c2082"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("8c583205-7179-464d-a3e6-e39c94eaef15"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("91ba3464-f2de-462f-9511-b27e7fd4ae9e"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("9a8f4060-2d8f-41a5-94a1-d4ee244cbf35"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("9cb27ca8-b768-4410-b7fb-9fdf700b6035"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("9ede59f0-be75-4c13-aad1-5553ac9596b2"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("9fbc3c17-0a6f-4563-a14c-4b6398a0505c"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("a12fe5e0-7c97-43d6-bf49-f6601c605814"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("a18da225-0c7f-447c-850e-347b653fa693"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("bdd0379a-4429-45a5-88bf-f0d5817a1098"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("be15065c-822e-4048-8422-93451727c528"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("bf584167-5bb8-452a-96af-f33700516226"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("c180d68a-1306-4240-bb46-7c93b2da1b85"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("c43c1686-1691-4b50-a748-4e3f2bc25588"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("c621c39f-7a4f-41c7-820d-62b4b7920944"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("c78f717f-0f8f-406c-a58b-f34b5a931f49"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("c8febd80-1d97-4529-8863-f3fc7d76c471"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("cc750fc2-418a-4ef5-a4da-2606ae67e8f6"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("d0b7c64d-46e4-4e32-b29c-0740c1065501"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("d3a6039b-b47a-428d-bf54-bae0a4f41ff1"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("d3a9e00f-8f9a-4e04-94cc-51d0c9664dd9"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("ebb284dc-ea2d-4324-82e2-1f9069a84d30"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("ed142f7b-079a-4d46-9820-1b009474755b"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("eddfb3b3-1e6d-4c6a-ae26-0f4bb1d586c1"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("eee7b325-04dc-4241-a2af-64773a7edd60"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("f6f9a4eb-06cf-42a0-ab01-67a7bae7ec00"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("f7dc9ddc-f59d-45d0-a7a4-376701f89a93"));

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: new Guid("f808f265-9dee-403b-8205-29ddec09a633"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("326de8ac-dd85-4aa2-8576-960fdfcf6740"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4dac6d1f-e5c7-47ef-80a8-4466a3e71d1b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efa4df83-5507-4874-968e-decefcb037d6"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("10567111-ee5f-4e75-a4e0-4b3d03d62ce9"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("2ed05007-5998-4e09-a139-19ffa7fce1bb"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("60943e28-b15a-4e29-a84c-aa15222a2191"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("63a1aaa1-0302-42f5-8e25-c2a5baf12250"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("85b5daf3-7626-484b-9c72-fa7d01c66985"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("93dc8936-6cdd-4ca1-b833-7c925010f3e9"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("c5d5a551-e86e-4fc8-903c-ccd1f5c34216"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("c9c0d5c8-1f57-4598-a255-f1df99825f31"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("dfb4b875-6234-473e-bf02-be1230c08a81"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("f3abc891-caa7-46b9-97dc-6da9f3ad2673"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("3acced16-6bcb-4f77-9bca-09676e14a8bb"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("3b28fdf9-c45c-40d3-94cd-06ca4efa17c6"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("4e247a36-cc55-4791-b12e-4fefbc5f46f4"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("560aa660-0449-4ae0-9269-1424d1415aac"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("6d59db3f-5b17-43cb-89c7-318bf731b617"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("80ce34b2-63af-47fb-b30f-a71e6c9e3f5c"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("89f5bb51-b477-4e1c-b9b9-7a2f1ab99a37"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("90fbad11-1087-41e4-9564-6aaf09780c08"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("99b7ac48-8ff4-4275-84e9-876f62a9f78d"));

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: new Guid("d5b53d3a-070f-4838-a7ee-1b98b8c30fc5"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("02d373b8-741d-4045-8f6d-dc7b8b7a606a"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("1a99201e-35fe-4dda-a10e-b67373abca77"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("29b76f14-dd5d-48c9-a24f-56882208da6c"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("395c042f-c57b-427b-9704-bd5f394cf91f"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("3a9390bf-fed5-4b1e-b31f-e13508551535"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("42bc4fdb-169e-41ad-b1fa-237aef67f7e1"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("4631e5f5-94d1-4065-a5a1-37b824adfe47"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("4908263b-6175-4fcf-9655-8457dd27ea46"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("4971725d-bf72-4d35-95b4-c692677094f7"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("4d0c8db7-0501-45b6-8a3c-e0268275d01c"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("4e6e96c5-c121-4b8e-a4b9-750884009e6f"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("56ca78f5-e21c-484d-984e-1da68257a45d"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("66a4610e-fd3c-430e-8128-56d44a38c2d6"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("77181389-bdd4-4424-aa34-c312d1f86582"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("7df77bb0-86ed-4cc0-947e-cd706c093d1f"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("816b8d43-be29-476c-88c7-778e265093c6"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("9ed14ada-e20b-4a79-8f28-8a299bf9b1ca"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("a69f3cf2-8ed1-4c8c-b4bb-a1200b287b09"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("a89ced5c-73ab-4b18-a4fd-a1cf11e37503"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("aae8552d-7eb5-4200-b1da-7d022abbc0a7"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("ae9959dc-c4b4-4562-b844-43d5d6d112f6"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("b7e4c27b-9d02-4d4a-a7d6-aa3b527b1902"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("bf12ebab-c723-4873-bcd1-c73f21e0db2e"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("c1efe640-42dc-483a-beac-9edcbdddbd67"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("d111d1cb-4cc4-4eda-8c17-09e82fbbff7f"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("d44077c7-4c39-4e4e-a758-4dd4bda4e08c"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("e36efc1f-26ca-4e9b-88df-f3a0b9fb571f"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("f8d34ccf-3408-4454-bc70-faf3010b320e"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("fb726ff2-716a-4540-8225-64dd0b8ef8b1"));

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: new Guid("fe29bc8b-b5a1-4ce7-b7a8-ab4ae5f221dd"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0ca87174-8e17-480b-bc62-8ae35cacdb24"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("110d4ea0-2ecd-4183-acf0-231c170610f7"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("21450fc1-2dbd-4064-afd4-2d7551da9ebe"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5fc4e88c-b4d1-4340-aaa9-557b62c9b213"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6ad6b3c7-a92d-4c99-b6de-ad88401773ca"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6efe7941-1ed0-497e-81f6-fc4751c22420"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9b310fcc-c015-4e8a-af56-7f389018411f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b08c2450-ea1d-4f35-be5e-d3c0915ff92a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e216bb3c-9ff0-4cac-9cc7-a72753cbc588"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f592431c-9057-45e7-872e-d81d347046f7"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("1ae7fd16-cf44-471e-9310-309d8a3aec5b"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("28302e7c-ed10-4fdd-af11-c36ec293521d"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("66c645b3-1d1b-4a3c-97d8-8f9e64dfeb5a"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("7c2dec47-8b56-4021-81f4-a64d69273c73"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("89297dc6-4f80-4661-9667-8e28f6b13721"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("9b548bc6-5a59-43dc-8608-6d98651ac115"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("9f6a7612-93fe-48d8-8aa9-fc984ae04a4e"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("a3e71022-3255-4454-88a7-031080443bce"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("a52e1528-b1a2-40ab-9aaf-402304732459"));

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: new Guid("fefd7e0e-e4e8-4582-b86f-74be276b7757"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0c76b7d3-15ed-40c1-a862-e5619cbd4565"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2d8e1569-523a-4694-bfbb-ae0da6aeae9d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2de18ca2-46f0-4ce4-9cc0-b3bb042c77c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("379e01c3-91c6-4ac7-93b7-385d3fc8b0c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f460378-116d-42ea-b25f-20fd9ff83ca5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("549ea9a1-7ba1-42c2-91e0-40188035909c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("86518196-917c-47fc-b594-38d899ad2c62"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad574fdd-1013-4ce3-a201-a396f30eeb48"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b09566b9-2076-445e-b7fc-2ed81b3fdbd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f32f5204-3dbb-45b5-a449-10511090e2a9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0eccd409-3094-4c07-a8a3-db45fe8bef2d"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("0e583556-3a3d-4052-9756-bb09a8f90e66"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("0ead7e77-d608-4222-ac22-b0c2c46bdac0"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("53ee465c-d532-49f5-8625-32c906fbe83a"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("6988b8cc-0f16-4f6a-9895-d4b1f96d0183"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("742fbb4c-b4e0-44d7-b32c-e939b94a01cb"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("806598a3-b2f5-4781-b5b8-41d1db2e2331"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("8fc71da3-a69b-49ee-a879-a2632c2a7bb1"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("9356b94f-26a8-4126-9ae1-bc01a114daae"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("9b109cbd-764b-4f71-b310-15211af3b68a"));

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "Id",
                keyValue: new Guid("af224645-999c-43a4-acc3-a125e04590ea"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("101831e0-cef1-4d35-8202-2441fbb01a7e"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("2c040ccf-637d-4733-9cb7-4603691366c6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("cf4f8f8b-9813-4303-a5e6-3167c13c08c7"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("cf761fb2-6d0a-4a98-a452-1fde6b00d80e"));

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

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("bc9e8701-dfd3-49b6-8d6a-022e6148a612"), new Guid("1dd9d4bd-03c3-4d41-9d43-ccf7fa5df734") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("4ff3c47d-cbba-4caa-9b4a-c77385200763"), new Guid("e5bc1e5e-0b3e-4451-81fc-a450a4d4c40f") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("a10ae102-35bd-47b8-84ac-8ee526daa3a3"), new Guid("5487f184-010c-4907-8ace-d7196f64f9c4") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("74592176-ab98-482e-8f97-f78e77a22053"), new Guid("90506af4-9600-49c4-b188-0ace521eee40") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("ab847495-0b58-4a26-ab79-fe44f23cb73a"), new Guid("36cdf7f5-8d68-42fa-9582-5ab14f67079f") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("79d717b2-2728-4f55-b05c-423650980479"), new Guid("9b7040a7-20d1-4202-83ef-abb128f12444") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("5ea27783-866c-4a60-994b-e4ec07efeca3"), new Guid("b3330760-4238-454c-b164-9946ecae27b9") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("30ddcf91-ee89-43de-988a-b8885ce9889c"), new Guid("4b5babd9-73c6-4d90-90dd-1f70a5bc73a8") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("bd4b0c66-08ab-4b92-93a2-5714d49b6cd6"), new Guid("398da2cc-c7d7-43c7-9db8-d145e173e349") });

            migrationBuilder.UpdateData(
                table: "UserInterstes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "UserId" },
                values: new object[] { new Guid("416a7a0a-8fe5-40ee-bcf2-52bee7e59344"), new Guid("a6cfdcad-b9c4-449d-8d78-ac2fcdab36ff") });

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
        }
    }
}
