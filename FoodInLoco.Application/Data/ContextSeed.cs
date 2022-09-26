using FoodInLoco.Application.Data.Entities;
using FoodInLoco.Application.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace FoodInLoco.Application.Data
{
    public static class ContextSeed
    {
        internal static Guid guid1 = Guid.NewGuid();
        internal static Guid guid2 = Guid.NewGuid();
        internal static Guid guid3 = Guid.NewGuid();

        public static void Seed(this ModelBuilder builder)
        {
            builder.SeedAuths();
            builder.SeedUsers();
            builder.SeedRestaurants();
            builder.SeedMenus();
            builder.SeedItemsMenu();
        }

        private static void SeedAuths(this ModelBuilder builder)
        {
            builder.Entity<Auth>(auth =>
            {
                auth.HasData(new
                {
                    Id = 1L,
                    Login = "admin",
                    Password = Convert.ToBase64String(new Rfc2898DeriveBytes(Encoding.Default.GetBytes("123456"), Encoding.Default.GetBytes(guid1.ToString()), 10000, HashAlgorithmName.SHA512).GetBytes(512)),
                    Salt = guid1.ToString(),
                    Roles = Roles.User | Roles.Admin
                });

                auth.HasData(new
                {
                    Id = 2L,
                    Login = "macdonalds",
                    Password = Convert.ToBase64String(new Rfc2898DeriveBytes(Encoding.Default.GetBytes("123456"), Encoding.Default.GetBytes(guid2.ToString()), 10000, HashAlgorithmName.SHA512).GetBytes(512)),
                    Salt = guid2.ToString(),
                    Roles = Roles.Restaurant
                });

                auth.HasData(new
                {
                    Id = 3L,
                    Login = "pedro",
                    Password = Convert.ToBase64String(new Rfc2898DeriveBytes(Encoding.Default.GetBytes("123456"), Encoding.Default.GetBytes(guid3.ToString()), 10000, HashAlgorithmName.SHA512).GetBytes(512)),
                    Salt = guid3.ToString(),
                    Roles = Roles.User
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

            builder.Entity<User>(user =>
            {
                user.HasData(new
                {
                    Id = 2L,
                    Status = Status.Active,
                    AuthId = 3L
                });

                user.OwnsOne(userName => userName.Name).HasData(new
                {
                    UserId = 2L,
                    FirstName = "Pedro",
                    LastName = "Lopes"
                });

                user.OwnsOne(userEmail => userEmail.Email).HasData(new
                {
                    UserId = 2L,
                    Value = "letter@gmail.com"
                });

                user.OwnsOne(userPhone => userPhone.CellPhone).HasData(new
                {
                    UserId = 2L,
                    DDD = "85",
                    PhoneNumber = "999999999"
                });
            });
        }

        private static void SeedRestaurants(this ModelBuilder builder)
        {
            builder.Entity<Restaurant>(restaurant =>
            {
                restaurant.HasData(new
                {
                    Id = 1L,
                    Status = Status.Active,
                    AuthId = 2L
                });

                restaurant.OwnsOne(restaurantName => restaurantName.Company).HasData(new
                {
                    RestaurantId = 1L,
                    CompanyName = "Mac Donalds",
                    TradingName = "Méqui"
                });

                restaurant.OwnsOne(restaurantEmail => restaurantEmail.Email).HasData(new
                {
                    RestaurantId = 1L,
                    Value = "letter.pedro@gmail.com"
                });

                restaurant.OwnsOne(restaurantPhone => restaurantPhone.CellPhone).HasData(new
                {
                    RestaurantId = 1L,
                    DDD = "85",
                    PhoneNumber = "997851936"
                });

                restaurant.OwnsOne(restaurantPhone => restaurantPhone.Address).HasData(new
                {
                    RestaurantId = 1L,
                    State = "Ceará",
                    City = "Fortaleza",
                    ZipCode = "60841477",
                    Street = "Travessa Elisiário Mendes",
                    Number = 150L,
                    Complement = "Apto 004, Bloco D"
                });
            });
        }

        private static void SeedMenus(this ModelBuilder builder)
        {
            builder.Entity<Menu>(menu =>
            {
                menu.HasData(new
                {
                    Id = 1L,
                    RestaurantId = 1L,
                    InitialDate = DateTime.UtcNow
                });

                menu.OwnsOne(menuName => menuName.NameDescription).HasData(new
                {
                    MenuId = 1L,
                    Name = "Wine",
                    Description = "Cardápio de vinhos."
                });

                menu.OwnsOne(menuEmail => menuEmail.HappyHour).HasData(new
                {
                    MenuId = 1L,
                    Value = false
                });
            });
        }

        private static void SeedItemsMenu(this ModelBuilder builder)
        {
            builder.Entity<MenuItem>(item =>
            {
                item.HasData(new
                {
                    Id = 1L,
                    MenuId = 1L,
                    Status = Status.Active,
                    Photo = "foto qualquer",
                    Quantity = 1,
                    Value = 11.99
                });

                item.OwnsOne(restaurantName => restaurantName.NameDescription).HasData(new
                {
                    MenuItemId = 1L,
                    Name = "Hamburguer",
                    Description = "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa."
                });
            });
        }
    }
}
