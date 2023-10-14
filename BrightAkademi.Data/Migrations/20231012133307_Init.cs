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
                    FAQ = table.Column<string>(type: "TEXT", nullable: true),
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
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
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
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
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
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
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
                        name: "FK_UserRoles_Users_UserId",
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6016), "Kategorisi silinenleri buraya atacağız", true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6019), "Genel", "genel" },
                    { 2, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6023), "Full Stack Web Developer", true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6023), "Full Stack Web Developer", "full-stack-web-developer" },
                    { 3, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6025), "IOS Developer", true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6025), "IOS Developer", "ios-developer" },
                    { 4, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6026), "BackEnd Developer", true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6027), "BackEnd Developer", "backend-developer" },
                    { 5, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6028), "FrontEnd Developer", true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6029), "FrontEnd Developer", "frontend-developer" },
                    { 6, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6030), "Java Developer", true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6030), "Java Developer", "java-developer" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "About", "Address", "CreatedDate", "Email", "FAQ", "IsActive", "IsDeleted", "ModifiedDate", "Name", "PhoneNumber" },
                values: new object[] { 1, "Yazılım eğitimi veren ana kucağı", "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6796), "info.wissenakademie.com", "Bilgim olmalı mı ? Eğitim durumum ne olmalı ?.", true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(6797), "Wissen Akademie", "1234567890" });

            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8069), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8071), "Easy" },
                    { 2, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8074), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8074), "Medium" },
                    { 3, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8076), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8076), "Senior" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5697), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5699), "Super Admin" },
                    { 2, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5702), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5702), "Admin" },
                    { 3, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5703), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5704), "Trainees" },
                    { 4, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5705), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5706), "Trainee" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Password", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4977), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4979), "superadmin", "superadmin" },
                    { 2, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4982), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4983), "admin", "admin" },
                    { 3, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4984), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4985), "ramizkaraeski", "ramizkaraeski" },
                    { 4, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4986), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4986), "kenanbirkan", "kenanbirkan" },
                    { 5, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4988), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4988), "ezelbayraktar", "ezelbayraktar" },
                    { 6, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4989), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4990), "serdartezcan", "serdartezcan" },
                    { 7, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4991), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4991), "selmahunel", "selmahunel" },
                    { 8, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4992), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4993), "eysanatay", "eysanatay" },
                    { 9, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4994), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4994), "alikizgin", "alikizgin" },
                    { 10, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4996), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4996), "teyfikzaim", "teyfikzaim" },
                    { 11, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4997), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4998), "hayratlieskikabadayi", "hayratlieskikabadayi" },
                    { 12, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4999), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4999), "cengizatay", "cengizatay" },
                    { 13, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5000), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5001), "badegarson", "badegarson" },
                    { 14, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5002), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5002), "sebnemsertuna", "sebnemsertuna" },
                    { 15, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5003), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5004), "temmuzkocaoglu", "temmuzkocaoglu" },
                    { 16, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5005), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5005), "bahartezcan", "bahartezcan" },
                    { 17, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5007), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(5007), "azadkaraeski", "azadkaraeski" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedDate", "EducationalStatus", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4188), "Kayıtlı öğrenci başlayacak.", "Eyşan", true, false, "Atay", new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4196), 8 },
                    { 2, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4200), "Kayıtlı öğrenci başlayacak.", "Ali", true, false, "Kırgız", new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4200), 9 },
                    { 3, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4202), "Kayıtlı öğrenci başlayacak.", "Teyfik", true, false, "Zaim", new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4202), 10 },
                    { 4, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4206), "Kayıtlı öğrenci başlayacak.", "Hayratlı", true, false, "Eskikabadayı", new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4207), 11 },
                    { 5, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4208), "Kayıtlı öğrenci başlayacak.", "Cengiz", true, false, "Atay", new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4208), 12 },
                    { 6, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4210), "Kayıtlı öğrenci başlayacak.", "Bade", true, false, "Garson", new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4210), 13 },
                    { 7, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4212), "Kayıtlı öğrenci başlayacak.", "Şebnem", true, false, "Sertuna", new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4212), 14 },
                    { 8, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4214), "Kayıtlı öğrenci başlayacak.", "Temmuz", true, false, "Kocaoğlu", new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4214), 15 },
                    { 9, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4215), "Kayıtlı öğrenci başlayacak.", "Bahar", true, false, "Tezcan", new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4216), 16 },
                    { 10, new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4217), "Kayıtlı öğrenci başlayacak.", "Azad", true, false, "Karaeski", new DateTime(2023, 10, 12, 16, 33, 7, 425, DateTimeKind.Local).AddTicks(4218), 17 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Comment", "CreatedDate", "EducationInfo", "Experience", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "Profession", "UserId" },
                values: new object[,]
                {
                    { 1, "10 puan", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7429), "Zonguldak Bilgisayar Öğretmenliği", "30", "Ramiz", true, false, "Karaeski", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7430), "Full Stack Web Developer", 3 },
                    { 2, "10 puan", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7436), "Eskişehir Bilgisayar Mühendisliği", "10", "Kenan", true, false, "Birkan", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7437), "IOS Developer", 4 },
                    { 3, "10 puan", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7440), "Bahçeşehir Üniversitesi Yazılım Mühendisliği", "2", "Ezel", true, false, "Bayraktar", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7440), "Backend Developer", 5 },
                    { 4, "10 puan", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7443), "Arel Üniversitesi Elektronik Haberleşme Mühendisliği", "2", "Serdar", true, false, "Tezcan", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7443), "Frontend Developer", 6 },
                    { 5, "10 puan", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7445), "Doğuş Üniversitesi", "2", "Selma", true, false, "Hünel", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(7446), "Java Developer", 7 }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4311), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4325), 1, 1 },
                    { 2, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4328), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4329), 2, 2 },
                    { 3, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4330), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4330), 3, 3 },
                    { 4, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4332), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4332), 3, 4 },
                    { 5, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4333), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4334), 3, 5 },
                    { 6, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4335), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4335), 3, 6 },
                    { 7, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4336), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4337), 3, 7 },
                    { 8, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4338), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4338), 4, 8 },
                    { 9, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4339), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4340), 4, 9 },
                    { 10, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4341), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4341), 4, 10 },
                    { 11, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4343), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4343), 4, 11 },
                    { 12, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4345), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4345), 4, 12 },
                    { 13, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4346), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4347), 4, 13 },
                    { 14, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4348), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4348), 4, 14 },
                    { 15, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4349), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4350), 4, 15 },
                    { 16, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4351), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4351), 4, 16 },
                    { 17, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4352), true, false, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(4353), 4, 17 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Address", "CategoryId", "Comment", "CompanyId", "Content", "CreatedDate", "Description", "Experience", "FinishCourseTime", "HowManyMonths", "IsActive", "IsDeleted", "LevelId", "ModifiedDate", "Name", "Price", "StartCourseTime", "Status", "TeacherId", "TotalCourseHours" },
                values: new object[,]
                {
                    { 1, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 2, "Çok iyi bir kurs 10 puan", 1, "html css bootstrap react react native c# .net javascript node.js ajax", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8900), "Full Stack Developer eğitimi kapsamlı bir eğitim.", "Bu eğitim sayesinde;Temel ve ileri veritabanı mantığını, Web’in ve yazılımın çalışma prensibini ve tüm süreçlerini, Yeni nesil tüm programlama araç ve dillerini, Back end programlamayı ve API yazmayı, Uçtan uca bir proje geliştirmeyi öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", false, false, 1, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8903), "Full Stack Web Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 1, "200" },
                    { 2, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 2, "Çok iyi bir kurs 10 puan", 1, "html css bootstrap react react native c# .net javascript node.js ajax", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8924), "Full Stack Developer eğitimi kapsamlı bir eğitim.", "Bu eğitim sayesinde;Temel ve ileri veritabanı mantığını, Web’in ve yazılımın çalışma prensibini ve tüm süreçlerini, Yeni nesil tüm programlama araç ve dillerini, Back end programlamayı ve API yazmayı, Uçtan uca bir proje geliştirmeyi öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", false, false, 2, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8924), "Full Stack Web Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 1, "400" },
                    { 3, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 2, "Çok iyi bir kurs 10 puan", 1, "html css bootstrap react react native c# .net javascript node.js ajax", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8930), "Full Stack Developer eğitimi kapsamlı bir eğitim.", "Bu eğitim sayesinde;Temel ve ileri veritabanı mantığını, Web’in ve yazılımın çalışma prensibini ve tüm süreçlerini, Yeni nesil tüm programlama araç ve dillerini, Back end programlamayı ve API yazmayı, Uçtan uca bir proje geliştirmeyi öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6", false, false, 3, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8930), "Full Stack Web Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 1, "600" },
                    { 4, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 3, "Çok iyi bir kurs 10 puan", 1, "Swift", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8934), "IOS Developer", "Bu eğitimde IOS Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak swift programını öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", false, false, 1, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8935), "IOS Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 2, "100" },
                    { 5, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 3, "Çok iyi bir kurs 10 puan", 1, "Swift", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8940), "IOS Developer", "Bu eğitimde IOS Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak swift programını öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", false, false, 2, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8941), "IOS Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 2, "200" },
                    { 6, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 3, "Çok iyi bir kurs 10 puan", 1, "Swift", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8946), "IOS Developer", "Bu eğitimde IOS Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak swift programını öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", false, false, 3, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8946), "IOS Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 2, "300" },
                    { 7, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 4, "Çok iyi bir kurs 10 puan", 1, "c# .net javascript node.js ajax ", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8950), "Backend Developer", "Bu eğitimde Backend Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", false, false, 1, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8951), "Backend Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 3, "100" },
                    { 8, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 4, "Çok iyi bir kurs 10 puan", 1, "c# .net javascript node.js ajax ", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8957), "Backend Developer", "Bu eğitimde Backend Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", false, false, 2, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8958), "Backend Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 3, "200" },
                    { 9, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 4, "Çok iyi bir kurs 10 puan", 1, "c# .net javascript node.js ajax ", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8963), "Backend Developer", "Bu eğitimde Backend Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", false, false, 3, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8964), "Backend Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 3, "300" },
                    { 10, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 5, "Çok iyi bir kurs 10 puan", 1, "html css bootstrap javascript react react native", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8969), "Frontend Developer", "Bu eğitimde Frontend Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", false, false, 1, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8970), "Frontend Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 4, "100" },
                    { 11, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 5, "Çok iyi bir kurs 10 puan", 1, "html css bootstrap javascript react react native", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8976), "Frontend Developer", "Bu eğitimde Frontend Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", false, false, 2, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8976), "Frontend Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 4, "200" },
                    { 12, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 5, "Çok iyi bir kurs 10 puan", 1, "html css bootstrap javascript react react native", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8984), "Frontend Developer", "Bu eğitimde Frontend Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", false, false, 3, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8985), "Frontend Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 4, "300" },
                    { 13, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 6, "Çok iyi bir kurs 10 puan", 1, "Java", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8989), "Frontend Developer", "Bu eğitimde Java Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", false, false, 1, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8990), "Java Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 5, "100" },
                    { 14, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 6, "Çok iyi bir kurs 10 puan", 1, "Java", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8997), "Frontend Developer", "Bu eğitimde Java Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", false, false, 2, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(8997), "Java Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 5, "200" },
                    { 15, "Kuloğlu Mh., Barbaros Blv. Yıldız İş Hanı No:9, 34353 Beşiktaş/İstanbul", 6, "Çok iyi bir kurs 10 puan", 1, "Java", new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(9002), "Frontend Developer", "Bu eğitimde Java Developer olmak adına seçeceğiniz eğitim seviyesine göre eğitim alacak gerekli programları öğreneceksiniz.", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", false, false, 3, new DateTime(2023, 10, 12, 16, 33, 7, 423, DateTimeKind.Local).AddTicks(9003), "Java Developer", 10000, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Açılacak", 5, "300" }
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
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

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
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

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
