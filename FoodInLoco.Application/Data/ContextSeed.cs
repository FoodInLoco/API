using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Enums;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace FoodInLoco.Application.Data
{
    public static class ContextSeed
    {
        internal static Guid GuidUser1 = Guid.NewGuid();
        internal static Guid GuidUser2 = Guid.NewGuid();
        internal static Guid GuidRestaurant1 = Guid.NewGuid();
        internal static Guid GuidRestaurant2 = Guid.NewGuid();
        internal static Guid GuidMenu1 = Guid.NewGuid();
        internal static Guid GuidMenu2 = Guid.NewGuid();
        internal static Guid GuidMenu3 = Guid.NewGuid();
        internal static Guid GuidItemMenu1 = Guid.NewGuid();
        internal static Guid GuidItemMenu2 = Guid.NewGuid();
        internal static Guid GuidItemMenu3 = Guid.NewGuid();
        internal static Guid GuidItemMenu4 = Guid.NewGuid();
        internal static Guid GuidItemMenu5 = Guid.NewGuid();
        internal static Guid GuidItemMenu6 = Guid.NewGuid();
        
        internal static Guid SaltGuid1 = Guid.NewGuid();
        internal static Guid SaltGuid2 = Guid.NewGuid();

        public static void Seed(this ModelBuilder builder)
        {
            builder.SeedUsers();
            builder.SeedRestaurants();
            builder.SeedMenus();
            builder.SeedItemsMenu();
            //builder.SeedAttraction();
            //builder.SeedReservation();
            //builder.SeedReview();
        }

        private static void SeedUsers(this ModelBuilder builder)
        {
            builder.Entity<User>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidUser1,
                    Status = Status.Active,
                    Password = Convert.ToBase64String(new Rfc2898DeriveBytes(Encoding.Default.GetBytes("123456"), Encoding.Default.GetBytes(SaltGuid1.ToString()), 10000, HashAlgorithmName.SHA512).GetBytes(512)),
                    Salt = SaltGuid1,
                    Roles = Roles.User | Roles.Admin
                });

                obj.OwnsOne(_ => _.Name).HasData(new
                {
                    UserId = GuidUser1,
                    FirstName = "Admin",
                    LastName = "FoodInLoco"
                });

                obj.OwnsOne(_ => _.Email).HasData(new
                {
                    UserId = GuidUser1,
                    Value = "admin@foodinloco.com"
                });

                obj.OwnsOne(_ => _.CellPhone).HasData(new
                {
                    UserId = GuidUser1,
                    DDD = "85",
                    PhoneNumber = "999999999"
                });
            });

            builder.Entity<User>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidUser2,
                    Status = Status.Active,
                    Password = Convert.ToBase64String(new Rfc2898DeriveBytes(Encoding.Default.GetBytes("123456"), Encoding.Default.GetBytes(SaltGuid2.ToString()), 10000, HashAlgorithmName.SHA512).GetBytes(512)),
                    Salt = SaltGuid2.ToString(),
                    Roles = Roles.User
                });

                obj.OwnsOne(_ => _.Name).HasData(new
                {
                    UserId = GuidUser2,
                    FirstName = "Pedro",
                    LastName = "Lopes de Oliveira"
                });

                obj.OwnsOne(_ => _.Email).HasData(new
                {
                    UserId = GuidUser2,
                    Value = "letter.pedro@gmail.com"
                });

                obj.OwnsOne(_ => _.CellPhone).HasData(new
                {
                    UserId = GuidUser2,
                    DDD = "85",
                    PhoneNumber = "997851936"
                });
            });
        }

        private static void SeedRestaurants(this ModelBuilder builder)
        {
            builder.Entity<Restaurant>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidRestaurant1,
                    Status = Status.Active,
                    Kids = false,
                    Photo = "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png"
                });

                obj.OwnsOne(_ => _.Company).HasData(new
                {
                    RestaurantId = GuidRestaurant1,
                    CompanyName = "Mc Donalds",
                    TradingName = "Méqui"
                });

                obj.OwnsOne(_ => _.Email).HasData(new
                {
                    RestaurantId = GuidRestaurant1,
                    Value = "mcdonalds@foodinloco.com"
                });

                obj.OwnsOne(_ => _.CellPhone).HasData(new
                {
                    RestaurantId = GuidRestaurant1,
                    DDD = "85",
                    PhoneNumber = "998888888"
                });

                obj.OwnsOne(_ => _.Address).HasData(new
                {
                    RestaurantId = GuidRestaurant1,
                    State = "Ceará",
                    City = "Fortaleza",
                    ZipCode = "60841477",
                    Street = "Travessa Elisiário Mendes",
                    Number = 150L,
                    Complement = "Apto 004, Bloco D"
                });
            });

            builder.Entity<Restaurant>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidRestaurant2,
                    Status = Status.Active,
                    Kids = true,
                    Photo = "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340"
                });

                obj.OwnsOne(_ => _.Company).HasData(new
                {
                    RestaurantId = GuidRestaurant2,
                    CompanyName = "Burger King",
                    TradingName = "BK"
                });

                obj.OwnsOne(_ => _.Email).HasData(new
                {
                    RestaurantId = GuidRestaurant2,
                    Value = "burgerking@foodinloco.com"
                });

                obj.OwnsOne(_ => _.CellPhone).HasData(new
                {
                    RestaurantId = GuidRestaurant2,
                    DDD = "85",
                    PhoneNumber = "997777777"
                });

                obj.OwnsOne(_ => _.Address).HasData(new
                {
                    RestaurantId = GuidRestaurant2,
                    State = "Ceará",
                    City = "Fortaleza",
                    ZipCode = "60841477",
                    Street = "Travessa Elisiário Mendes",
                    Number = 150L,
                    Complement = "Apto 001, Bloco D"
                });
            });
        }

        private static void SeedMenus(this ModelBuilder builder)
        {
            builder.Entity<Menu>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidMenu1,
                    RestaurantId = GuidRestaurant1,
                    InitialDate = DateTime.Now,
                    Status = Status.Active
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuId = GuidMenu1,
                    Name = "Wine",
                    Description = "Cardápio de vinhos."
                });

                obj.OwnsOne(_ => _.HappyHour).HasData(new
                {
                    MenuId = GuidMenu1,
                    Value = false
                });
            });

            builder.Entity<Menu>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidMenu2,
                    RestaurantId = GuidRestaurant1,
                    InitialDate = DateTime.Now,
                    Status = Status.Active
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuId = GuidMenu2,
                    Name = "Happy Hour",
                    Description = "Cardápio de Happy Hour."
                });

                obj.OwnsOne(_ => _.HappyHour).HasData(new
                {
                    MenuId = GuidMenu2,
                    Value = true,
                    StartAt = "16:30",
                    EndAt = "20:00"
                });
            });

            builder.Entity<Menu>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidMenu3,
                    RestaurantId = GuidRestaurant2,
                    InitialDate = DateTime.Now,
                    Status = Status.Active
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuId = GuidMenu3,
                    Name = "Happy Hour",
                    Description = "Cardápio de Happy Hour."
                });

                obj.OwnsOne(_ => _.HappyHour).HasData(new
                {
                    MenuId = GuidMenu3,
                    Value = true,
                    StartAt = "16:30",
                    EndAt = "20:00"
                });
            });
        }

        private static void SeedItemsMenu(this ModelBuilder builder)
        {
            builder.Entity<MenuItem>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidItemMenu1,
                    MenuId = GuidMenu1,
                    Quantity = 1,
                    Value = 90.00,
                    Status = Status.Active
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuItemId = GuidItemMenu1,
                    Name = "Vinho Quinta do Morgado",
                    Description = "Vinho de uva."
                });
            });

            builder.Entity<MenuItem>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidItemMenu2,
                    MenuId = GuidMenu2,
                    Quantity = 1,
                    Value = 4.90,
                    Status = Status.Active
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuItemId = GuidItemMenu2,
                    Name = "Chopp",
                    Description = "Chopp de Brahma."
                });
            });

            builder.Entity<MenuItem>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidItemMenu3,
                    MenuId = GuidMenu3,
                    Quantity = 1,
                    Value = 5.40,
                    Status = Status.Active
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuItemId = GuidItemMenu3,
                    Name = "Chopp",
                    Description = "Chopp de Brahma."
                });
            });

            builder.Entity<MenuItem>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidItemMenu4,
                    MenuId = GuidMenu3,
                    Quantity = 1,
                    Value = 22.00,
                    Status = Status.Active
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuItemId = GuidItemMenu1,
                    Name = "Hamburguer",
                    Description = "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa."
                });
            });

            builder.Entity<MenuItem>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidItemMenu5,
                    MenuId = GuidMenu3,
                    Quantity = 1,
                    Value = 11.00,
                    Status = Status.Active
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuItemId = GuidItemMenu1,
                    Name = "Porção de batata",
                    Description = "Porção de batata feita com a melhor batata que existe (Burger King)."
                });
            });

            builder.Entity<MenuItem>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidItemMenu6,
                    MenuId = GuidMenu2,
                    Quantity = 6,
                    Value = 14.00,
                    Status = Status.Active
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuItemId = GuidItemMenu6,
                    Name = "Chicken Nuggets",
                    Description = "Empanados de frango recheados com queijo."
                });
            });

        }
    }
}
