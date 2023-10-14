using BrightAkademi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrightAkademi.Data.Concrete.EfCore.Configs
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasData(
                new User
                {
                    Id = 1,
                    Username ="superadmin",
                    Password = "superadmin",

                    IsActive = true,
                },               
                new User
                {
                    Id = 2,
                    Username ="admin",
                    Password = "admin",
                    IsActive = true,
                },              
                new User
                {
                    Id = 3,
                    Username ="ramizkaraeski",
                    Password = "ramizkaraeski",
                    IsActive = true,
                },
                new User
                {
                    Id = 4,
                    Username = "kenanbirkan",
                    Password = "kenanbirkan",
                    IsActive = true,
                },
                new User
                {
                    Id = 5,
                    Username="ezelbayraktar",
                    Password = "ezelbayraktar",
                    IsActive = true,
                },
                new User
                {
                    Id = 6,
                    Username="serdartezcan",
                    Password = "serdartezcan",
                    IsActive = true,
                },
                new User
                {
                    Id = 7,
                    Username="selmahunel",
                    Password ="selmahunel",
                    IsActive = true,
                },
                 new User
                 {
                     Id = 8,
                     Username="eysanatay",
                     Password = "eysanatay",
                     IsActive = true,

                 },
                 new User
                    {
                        Id = 9,
                        Username = "alikizgin",
                        Password = "alikizgin",
                        IsActive = true,

                   },
                 new User
                 {
                     Id = 10,
                     Username = "teyfikzaim",
                     Password = "teyfikzaim",
                     IsActive = true,

                 },
                 new User
                 {
                     Id = 11,
                     Username = "hayratlieskikabadayi",
                     Password = "hayratlieskikabadayi",
                     IsActive = true,

                 },
                 new User
                 {
                     Id = 12,
                     Username = "cengizatay",
                     Password = "cengizatay",
                     IsActive = true,

                 },
                 new User
                 {
                     Id = 13,
                     Username = "badegarson",
                     Password = "badegarson",
                     IsActive = true,

                 },
                 new User
                 {
                     Id = 14,
                     Username = "sebnemsertuna",
                     Password = "sebnemsertuna",
                     IsActive = true,

                 },
                 new User
                 {
                     Id = 15,
                     Username = "temmuzkocaoglu",
                     Password = "temmuzkocaoglu",
                     IsActive = true,

                 },
                 new User
                 {
                     Id = 16,
                     Username = "bahartezcan",
                     Password = "bahartezcan",
                     IsActive = true,

                 },
                 new User
                 {
                     Id = 17,
                     Username = "azadkaraeski",
                     Password = "azadkaraeski",
                     IsActive = true,

                 }
            );
        }
    } }