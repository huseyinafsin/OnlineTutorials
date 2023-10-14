using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BrightAkademi.Data.Migrations
{
    /// <inheritdoc />
    public partial class teachercourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeacherCourses",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCourses", x => new { x.CourseId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_TeacherCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherCourses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9134), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9141), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9143), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9144), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9146), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9148), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9903), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2492), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2511), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2517), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2522), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2526), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2532), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2558), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2563), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2568), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2573), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2578), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(1799), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(1804), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(1806), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(8842), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(8847), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(8849), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(8850), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7120), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7127), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7129), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7131), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7133), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7188), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7191), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7193), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7194), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7196), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId", "CreatedDate", "Id", "IsActive", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2022), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2027) },
                    { 2, 1, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2029), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2030) },
                    { 3, 1, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2031), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2031) },
                    { 4, 2, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2032), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2033) },
                    { 5, 2, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2034), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2034) },
                    { 6, 2, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2035), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2035) },
                    { 7, 3, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2036), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2037) },
                    { 8, 3, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2038), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2038) },
                    { 9, 3, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2039), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2039) },
                    { 10, 4, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2040), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2041) },
                    { 11, 4, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2042), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2042) },
                    { 12, 4, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2043), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2043) },
                    { 13, 5, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2044), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2045) },
                    { 14, 5, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2045), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2046) },
                    { 15, 5, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2047), 0, true, false, new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2047) }
                });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(986), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(998), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(1000), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(1003), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(1005), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7384), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7400), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7402), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7404), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7409), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7410), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7412), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7413), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7415), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7417), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7418), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7419), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7421), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7423), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7425), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7426), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 10, 14, 14, 26, 48, 569, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7968), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7970), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7972), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7974), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7976), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7978), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7980), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7981), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7983), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7985), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7988), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7990), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7992), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7993), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7995), new DateTime(2023, 10, 14, 14, 26, 48, 571, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourses_TeacherId",
                table: "TeacherCourses",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherCourses");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6016), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6023), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6025), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6026), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6028), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6030), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6796), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8900), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8924), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8930), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8934), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8940), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8946), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8950), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8957), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8963), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8969), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8976), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8984), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8989), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8997), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(9002), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8069), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8074), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8076), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5697), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5702), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5705), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4202), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4206), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4208), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4212), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4214), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4215), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4217), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7429), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7436), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7440), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7443), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7445), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4311), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4328), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4330), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4332), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4333), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4335), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4336), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4338), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4339), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4341), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4343), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4345), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4346), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4348), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4349), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4351), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4352), new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4977), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4982), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4984), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4986), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4988), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4989), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4991), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4992), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4994), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4996), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4997), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5000), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5003), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5007), new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5007) });
        }
    }
}
