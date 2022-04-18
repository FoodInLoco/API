using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace FoodInLoco.Application.Data
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.SeedAuths();
            builder.SeedUsers();
        }

        private static void SeedAuths(this ModelBuilder builder)
        {
            builder.Entity<Auth>(auth =>
            {
                auth.HasData(new
                {
                    Id = 1L,
                    Login = "admin",
                    Password = Convert.ToBase64String(new Rfc2898DeriveBytes(Encoding.Default.GetBytes("123456789"), Encoding.Default.GetBytes("79005744-e69a-4b09-996b-08fe0b70cbb9"), 10000, HashAlgorithmName.SHA512).GetBytes(512)),
                    Salt = "79005744-e69a-4b09-996b-08fe0b70cbb9",
                    Roles = Roles.User | Roles.Admin
                });
            });
        }

        private static void SeedUsers(this ModelBuilder builder)
        {
            builder.Entity<User>(user =>
            {
                user.HasData(new
                {
                    Id = 1L,
                    Status = Status.Active,
                    AuthId = 1L
                });

                user.OwnsOne(userName => userName.Name).HasData(new
                {
                    UserId = 1L,
                    FirstName = "Pedro",
                    LastName = "Oliveira"
                });

                user.OwnsOne(userEmail => userEmail.Email).HasData(new
                {
                    UserId = 1L,
                    Value = "letter.pedro@gmail.com"
                });

                user.OwnsOne(userPhone => userPhone.CellPhone).HasData(new
                {
                    UserId = 1L,
                    DDD = "85",
                    PhoneNumber = "997851936"
                });
            });
        }
    }
}
