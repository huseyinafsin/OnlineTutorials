using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrightAkademi.Data.Migrations
{
    /// <inheritdoc />
    public partial class revise_role_names : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(5827), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(5834), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(5836), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(5837), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(5839), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(5841), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(6542), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8666), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8684), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8689), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8694), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8699), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8704), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8762), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8768), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8772), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8776), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8786), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8791), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8795), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8011), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8016), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8018), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(5679), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(5685), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(5687), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(5687), "Trainer" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(5688), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2475), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2497), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2499), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2501), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2503), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2505), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2507), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2508), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2510), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2512), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9202), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9209), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9211), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9211) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9212), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9214), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9215), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 7, 3 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9216), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9266), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 9, 3 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9268), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 10, 4 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9269), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 11, 4 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9271), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 12, 4 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9272), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 13, 5 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9273), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 14, 5 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9274), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 15, 5 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9276), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(7270), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(7280), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(7283), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(7285), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(7287), new DateTime(2023, 10, 14, 14, 55, 6, 66, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4140), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4155), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4157), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4158), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4160), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4162), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4163), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4165), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4167), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4168), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4169) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4170), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4171), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4173), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4174), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4176), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4178), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4179), new DateTime(2023, 10, 14, 14, 55, 6, 65, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4753), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4761), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4763), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4765), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4767), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4769), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4770), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4772), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4774), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4776), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4777), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4779), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4781), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4783), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4784), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4786), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4788), new DateTime(2023, 10, 14, 14, 55, 6, 68, DateTimeKind.Local).AddTicks(4788) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3048), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3056), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3058), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3059), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3061), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3063), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3797), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6448), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6473), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6478), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6483), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6487), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6492), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6497), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6501), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6505), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6509), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6584), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6590), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6594), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6599), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6604), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(5422), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(5428), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(5429), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(6187), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(6193), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate", "Name" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(6195), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(6195), "Trainees" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(6196), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3616), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3627), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3629), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3631), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3633), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3634), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3636), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3638), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3639), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3641), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(291), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(297), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(299), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(301), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(302), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(304), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 7, 3 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(305), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(307), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 9, 3 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(308), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 10, 4 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(310), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 11, 4 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(311), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 12, 4 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 13, 5 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(314), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 14, 5 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 15, 5 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(317), new DateTime(2023, 10, 14, 14, 34, 23, 412, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(3670), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(3686), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(3689), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(3692), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(3694), new DateTime(2023, 10, 14, 14, 34, 23, 410, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1345), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1363), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1365), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1367), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1368), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1370), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1371), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1374), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1376), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1377), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1379), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1380), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1382), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1382) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1383), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1385), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1386), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1388), new DateTime(2023, 10, 14, 14, 34, 23, 408, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4589), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4595), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4597), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4599), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4600), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4602), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4603), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4605), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4609), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4611), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4612), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4614), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4616), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4618), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4620), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4622), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(4623) });
        }
    }
}
