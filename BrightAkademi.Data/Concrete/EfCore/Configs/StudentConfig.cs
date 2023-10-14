using BrightAkademi.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BrightAkademi.Data.Concrete.EfCore.Configs
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasData(
                new Student
                {
                    Id = 1,
                    UserId = 8,
                    FirstName = "Eyşan",
                    LastName = "Atay",
                    EducationalStatus = "Kayıtlı öğrenci başlayacak."
                },
                new Student
                {
                    Id = 2,
                    UserId = 9,
                    FirstName = "Ali",
                    LastName = "Kırgız",
                    EducationalStatus = "Kayıtlı öğrenci başlayacak."
                },
                new Student
                {
                    Id = 3,
                    UserId = 10,
                    FirstName = "Teyfik",
                    LastName = "Zaim",
                    EducationalStatus = "Kayıtlı öğrenci başlayacak."
                },
                new Student
                {
                    Id = 4,
                    UserId = 11,
                    FirstName = "Hayratlı",
                    LastName = "Eskikabadayı",
                    EducationalStatus = "Kayıtlı öğrenci başlayacak."
                },
                new Student
                {
                    Id = 5,
                    UserId = 12,
                    FirstName = "Cengiz",
                    LastName = "Atay",
                    EducationalStatus = "Kayıtlı öğrenci başlayacak."
                },
                new Student
                {
                    Id = 6,
                    UserId = 13,
                    FirstName = "Bade",
                    LastName = "Garson",
                    EducationalStatus = "Kayıtlı öğrenci başlayacak."
                },
                new Student
                {
                    Id = 7,
                    UserId = 14,
                    FirstName = "Şebnem",
                    LastName = "Sertuna",
                    EducationalStatus = "Kayıtlı öğrenci başlayacak."
                },
                new Student
                {
                    Id = 8,
                    UserId = 15,
                    FirstName = "Temmuz",
                    LastName = "Kocaoğlu",
                    EducationalStatus = "Kayıtlı öğrenci başlayacak."
                },
                new Student
                {
                    Id = 9,
                    UserId = 16,
                    FirstName = "Bahar",
                    LastName = "Tezcan",
                    EducationalStatus = "Kayıtlı öğrenci başlayacak."
                },
                new Student
                {
                    Id = 10,
                    UserId = 17,
                    FirstName = "Azad",
                    LastName = "Karaeski",
                    EducationalStatus = "Kayıtlı öğrenci başlayacak."
                }
            );
        }
    }
}