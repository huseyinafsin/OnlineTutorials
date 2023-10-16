using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BrightAkademi.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    About = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Firstname = table.Column<string>(type: "TEXT", nullable: false),
                    Lastname = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    EducationalStatus = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Profession = table.Column<string>(type: "TEXT", nullable: true),
                    Experience = table.Column<string>(type: "TEXT", nullable: true),
                    EducationInfo = table.Column<string>(type: "TEXT", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    TotalCourseHours = table.Column<string>(type: "TEXT", nullable: true),
                    HowManyMonths = table.Column<string>(type: "TEXT", nullable: true),
                    StartCourseTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FinishCourseTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<int>(type: "INTEGER", nullable: true),
                    Experience = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    LevelId = table.Column<int>(type: "INTEGER", nullable: true),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudents",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudents", x => new { x.CourseId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_CourseStudents_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(9679), "Kategorisi silinenleri buraya atacağız", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(9698), "Genel", "genel" },
                    { 2, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(9704), "Full Stack Web Developer", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(9704), "Full Stack Web Developer", "full-stack-web-developer" },
                    { 3, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(9706), "IOS Developer", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(9707), "IOS Developer", "ios-developer" },
                    { 4, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(9709), "BackEnd Developer", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(9710), "BackEnd Developer", "backend-developer" },
                    { 5, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(9711), "FrontEnd Developer", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(9712), "FrontEnd Developer", "frontend-developer" },
                    { 6, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(9713), "Java Developer", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(9714), "Java Developer", "java-developer" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "About", "Address", "CreatedDate", "Email", "IsActive", "IsDeleted", "ModifiedDate", "Name", "PhoneNumber" },
                values: new object[] { 1, "Yazılım eğitimi veren ana kucağı", "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(6497), "info.wissenakademie.com", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(6510), "Wissen Akademie", "1234567890" });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(9561), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(9563), "Easy" },
                    { 2, new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(9566), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(9566), "Medium" },
                    { 3, new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(9567), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(9568), "Senior" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(9418), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(9421), "Super Admin" },
                    { 2, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(9423), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(9424), "Admin" },
                    { 3, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(9425), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(9425), "Trainer" },
                    { 4, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(9426), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(9427), "Trainee" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Firstname", "IsActive", "IsDeleted", "Lastname", "ModifiedDate", "Password", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8228), "Mücahit", true, false, "Admin", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8231), "superadmin", "superadmin" },
                    { 2, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8235), "Mücahit", true, false, "Admin", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8235), "admin", "admin" },
                    { 3, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8237), "Ramiz", true, false, "Karaeski", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8238), "ramizkaraeski", "ramizkaraeski" },
                    { 4, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8240), "Kenan", true, false, "Birkan", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8240), "kenanbirkan", "kenanbirkan" },
                    { 5, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8242), "Ezel", true, false, "Bayraktar", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8242), "ezelbayraktar", "ezelbayraktar" },
                    { 6, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8244), "Serdar", true, false, "Tezcan", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8244), "serdartezcan", "serdartezcan" },
                    { 7, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8246), "Selma", true, false, "Hünel", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8246), "selmahunel", "selmahunel" },
                    { 8, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8248), "Eyşan", true, false, "Atay", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8249), "eysanatay", "eysanatay" },
                    { 9, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8250), "Ali", true, false, "Kırgız", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8251), "alikizgin", "alikizgin" },
                    { 10, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8252), "Teyfik", true, false, "Zaim", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8253), "teyfikzaim", "teyfikzaim" },
                    { 11, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8254), "Hayratlı", true, false, "Eskikabadayı", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8255), "hayratlieskikabadayi", "hayratlieskikabadayi" },
                    { 12, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8256), "Cengiz", true, false, "Atay", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8257), "cengizatay", "cengizatay" },
                    { 13, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8258), "Bade", true, false, "Garson", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8259), "badegarson", "badegarson" },
                    { 14, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8260), "Şebnem", true, false, "Sertuna", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8260), "sebnemsertuna", "sebnemsertuna" },
                    { 15, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8262), "Temmuz", true, false, "Kocaoğlu", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8262), "temmuzkocaoglu", "temmuzkocaoglu" },
                    { 16, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8264), "Bahar", true, false, "Tezcan", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8264), "bahartezcan", "bahartezcan" },
                    { 17, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8266), "Azad", true, false, "Karaeski", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(8266), "azadkaraeski", "azadkaraeski" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedDate", "EducationalStatus", "IsActive", "IsDeleted", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7194), "Kayıtlı öğrenci başlayacak.", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7200), 8 },
                    { 2, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7203), "Kayıtlı öğrenci başlayacak.", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7203), 9 },
                    { 3, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7204), "Kayıtlı öğrenci başlayacak.", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7205), 10 },
                    { 4, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7206), "Kayıtlı öğrenci başlayacak.", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7206), 11 },
                    { 5, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7207), "Kayıtlı öğrenci başlayacak.", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7208), 12 },
                    { 6, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7209), "Kayıtlı öğrenci başlayacak.", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7209), 13 },
                    { 7, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7210), "Kayıtlı öğrenci başlayacak.", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7210), 14 },
                    { 8, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7211), "Kayıtlı öğrenci başlayacak.", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7212), 15 },
                    { 9, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7213), "Kayıtlı öğrenci başlayacak.", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7213), 16 },
                    { 10, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7214), "Kayıtlı öğrenci başlayacak.", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(7214), 17 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Comment", "CreatedDate", "EducationInfo", "Experience", "IsActive", "IsDeleted", "ModifiedDate", "Profession", "UserId" },
                values: new object[,]
                {
                    { 1, "10 puan", new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(8569), "Zonguldak Bilgisayar Öğretmenliği", "30", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(8573), "Full Stack Web Developer", 3 },
                    { 2, "10 puan", new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(8577), "Eskişehir Bilgisayar Mühendisliği", "10", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(8578), "IOS Developer", 4 },
                    { 3, "10 puan", new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(8580), "Bahçeşehir Üniversitesi Yazılım Mühendisliği", "2", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(8580), "Backend Developer", 5 },
                    { 4, "10 puan", new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(8582), "Arel Üniversitesi Elektronik Haberleşme Mühendisliği", "2", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(8582), "Frontend Developer", 6 },
                    { 5, "10 puan", new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(8584), "Doğuş Üniversitesi", "2", true, false, new DateTime(2023, 10, 16, 0, 9, 4, 879, DateTimeKind.Local).AddTicks(8584), "Java Developer", 7 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "RoleId", "TeacherId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4063), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4076), 1, null, 1 },
                    { 2, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4232), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4234), 2, null, 2 },
                    { 3, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4239), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4241), 3, null, 3 },
                    { 4, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4244), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4246), 3, null, 4 },
                    { 5, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4249), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4251), 3, null, 5 },
                    { 6, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4254), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4256), 3, null, 6 },
                    { 7, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4260), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4262), 3, null, 7 },
                    { 8, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4265), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4267), 4, null, 8 },
                    { 9, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4270), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4273), 4, null, 9 },
                    { 10, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4276), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4278), 4, null, 10 },
                    { 11, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4281), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4283), 4, null, 11 },
                    { 12, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4286), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4289), 4, null, 12 },
                    { 13, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4292), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4294), 4, null, 13 },
                    { 14, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4297), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4299), 4, null, 14 },
                    { 15, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4303), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4305), 4, null, 15 },
                    { 16, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4308), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4310), 4, null, 16 },
                    { 17, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4314), true, false, new DateTime(2023, 10, 16, 0, 9, 4, 875, DateTimeKind.Local).AddTicks(4316), 4, null, 17 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Address", "CategoryId", "Comment", "CompanyId", "Content", "CreatedDate", "Description", "Experience", "FinishCourseTime", "HowManyMonths", "IsActive", "IsDeleted", "LevelId", "ModifiedDate", "Name", "Price", "StartCourseTime", "Status", "TeacherId", "TotalCourseHours" },
                values: new object[,]
                {
                    { 1, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 2, "Çok iyi bir kurs 10 puan", 1, "html css bootstrap react react native c# .net javascript node.js ajax", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(866), "Full Stack Developer eğitimi kapsamlı bir eğitim.", "Bu eğitim sayesinde;Temel ve ileri veritabanı mantığını, Web’in ve yazılımın çalışma prensibini ve tüm süreçlerini, Yeni nesil tüm programlama araç ve dillerini, Back end programlamayı ve API yazmayı, Uçtan uca bir proje geliştirmeyi öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", false, false, 1, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(869), "Full Stack Web Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 1, "200" },
                    { 2, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 2, "Çok iyi bir kurs 10 puan", 1, "html css bootstrap react react native c# .net javascript node.js ajax", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(886), "Full Stack Developer eğitimi kapsamlı bir eğitim.", "Bu eğitim sayesinde;Temel ve ileri veritabanı mantığını, Web’in ve yazılımın çalışma prensibini ve tüm süreçlerini, Yeni nesil tüm programlama araç ve dillerini, Back end programlamayı ve API yazmayı, Uçtan uca bir proje geliştirmeyi öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", false, false, 2, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(887), "Full Stack Web Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 1, "400" },
                    { 3, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 2, "Çok iyi bir kurs 10 puan", 1, "html css bootstrap react react native c# .net javascript node.js ajax", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(892), "Full Stack Developer eğitimi kapsamlı bir eğitim.", "Bu eğitim sayesinde;Temel ve ileri veritabanı mantığını, Web’in ve yazılımın çalışma prensibini ve tüm süreçlerini, Yeni nesil tüm programlama araç ve dillerini, Back end programlamayı ve API yazmayı, Uçtan uca bir proje geliştirmeyi öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", false, false, 3, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(893), "Full Stack Web Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 1, "600" },
                    { 4, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 3, "Çok iyi bir kurs 10 puan", 1, "Swift", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(897), "IOS Developer", "Bu eğitimde IOS Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak swift programını öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", false, false, 1, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(897), "IOS Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 2, "100" },
                    { 5, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 3, "Çok iyi bir kurs 10 puan", 1, "Swift", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(902), "IOS Developer", "Bu eğitimde IOS Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak swift programını öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", false, false, 2, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(903), "IOS Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 2, "200" },
                    { 6, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 3, "Çok iyi bir kurs 10 puan", 1, "Swift", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(907), "IOS Developer", "Bu eğitimde IOS Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak swift programını öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", false, false, 3, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(907), "IOS Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 2, "300" },
                    { 7, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 4, "Çok iyi bir kurs 10 puan", 1, "c# .net javascript node.js ajax ", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(912), "Backend Developer", "Bu eğitimde Backend Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", false, false, 1, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(913), "Backend Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 3, "100" },
                    { 8, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 4, "Çok iyi bir kurs 10 puan", 1, "c# .net javascript node.js ajax ", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(917), "Backend Developer", "Bu eğitimde Backend Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", false, false, 2, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(917), "Backend Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 3, "200" },
                    { 9, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 4, "Çok iyi bir kurs 10 puan", 1, "c# .net javascript node.js ajax ", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(921), "Backend Developer", "Bu eğitimde Backend Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", false, false, 3, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(922), "Backend Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 3, "300" },
                    { 10, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 5, "Çok iyi bir kurs 10 puan", 1, "html css bootstrap javascript react react native", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(926), "Frontend Developer", "Bu eğitimde Frontend Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", false, false, 1, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(927), "Frontend Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 4, "100" },
                    { 11, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 5, "Çok iyi bir kurs 10 puan", 1, "html css bootstrap javascript react react native", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(931), "Frontend Developer", "Bu eğitimde Frontend Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", false, false, 2, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(931), "Frontend Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 4, "200" },
                    { 12, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 5, "Çok iyi bir kurs 10 puan", 1, "html css bootstrap javascript react react native", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(936), "Frontend Developer", "Bu eğitimde Frontend Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", false, false, 3, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(937), "Frontend Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 4, "300" },
                    { 13, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 6, "Çok iyi bir kurs 10 puan", 1, "Java", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(941), "Frontend Developer", "Bu eğitimde Java Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", false, false, 1, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(941), "Java Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 5, "100" },
                    { 14, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 6, "Çok iyi bir kurs 10 puan", 1, "Java", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(945), "Frontend Developer", "Bu eğitimde Java Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", false, false, 2, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(946), "Java Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 5, "200" },
                    { 15, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 6, "Çok iyi bir kurs 10 puan", 1, "Java", new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(950), "Frontend Developer", "Bu eğitimde Java Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", false, false, 3, new DateTime(2023, 10, 16, 0, 9, 4, 880, DateTimeKind.Local).AddTicks(951), "Java Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 5, "300" }
                });

            migrationBuilder.InsertData(
                table: "CourseStudents",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 4, 7 },
                    { 4, 8 },
                    { 5, 9 },
                    { 5, 10 },
                    { 6, 1 },
                    { 6, 2 },
                    { 7, 3 },
                    { 7, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 9, 7 },
                    { 9, 8 },
                    { 10, 9 },
                    { 10, 10 },
                    { 11, 1 },
                    { 11, 2 },
                    { 12, 3 },
                    { 12, 4 },
                    { 13, 5 },
                    { 13, 6 },
                    { 14, 7 },
                    { 14, 8 },
                    { 15, 9 },
                    { 15, 10 }
                });

            migrationBuilder.InsertData(
                table: "TeacherCourses",
                columns: new[] { "CourseId", "TeacherId", "CreatedDate", "Id", "IsActive", "IsDeleted", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3530), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3535) },
                    { 2, 1, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3538), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3538) },
                    { 3, 1, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3540), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3540) },
                    { 4, 2, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3541), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3542) },
                    { 5, 2, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3543), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3543) },
                    { 6, 2, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3545), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3545) },
                    { 7, 3, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3546), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3547) },
                    { 8, 3, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3548), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3548) },
                    { 9, 3, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3549), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3550) },
                    { 10, 4, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3551), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3551) },
                    { 11, 4, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3552), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3553) },
                    { 12, 4, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3554), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3554) },
                    { 13, 5, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3555), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3556) },
                    { 14, 5, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3557), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3557) },
                    { 15, 5, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3558), 0, true, false, new DateTime(2023, 10, 16, 0, 9, 4, 881, DateTimeKind.Local).AddTicks(3559) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CompanyId",
                table: "Courses",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_LevelId",
                table: "Courses",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_StudentId",
                table: "CourseStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourses_TeacherId",
                table: "TeacherCourses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_TeacherId",
                table: "UserRoles",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudents");

            migrationBuilder.DropTable(
                name: "TeacherCourses");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
