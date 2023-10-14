using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrightAkademi.Data.Migrations
{
    /// <inheritdoc />
    public partial class teachercourse2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(6195), new DateTime(2023, 10, 14, 14, 34, 23, 411, DateTimeKind.Local).AddTicks(6195) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2022), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2029), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2031), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2032), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2034), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2035), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 7, 3 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2036), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2038), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 9, 3 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2039), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 10, 4 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2040), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 11, 4 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2042), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 12, 4 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 13, 5 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2044), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 14, 5 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2045), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "TeacherCourses",
                keyColumns: new[] { "CourseId", "TeacherId" },
                keyValues: new object[] { 15, 5 },
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2047), new DateTime(2023, 10, 14, 14, 26, 48, 572, DateTimeKind.Local).AddTicks(2047) });

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
        }
    }
}
