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
        internal static Guid GuidUser3 = Guid.NewGuid();
        internal static Guid GuidRestaurant1 = Guid.NewGuid();
        internal static Guid GuidRestaurant2 = Guid.NewGuid();
        internal static Guid GuidTable1 = Guid.NewGuid();
        internal static Guid GuidTable2 = Guid.NewGuid();
        internal static Guid GuidTable3 = Guid.NewGuid();
        internal static Guid GuidTable4 = Guid.NewGuid();
        internal static Guid GuidTable5 = Guid.NewGuid();
        internal static Guid GuidMenu1 = Guid.NewGuid();
        internal static Guid GuidMenu2 = Guid.NewGuid();
        internal static Guid GuidMenu3 = Guid.NewGuid();
        internal static Guid GuidMenuItem1 = Guid.NewGuid();
        internal static Guid GuidMenuItem2 = Guid.NewGuid();
        internal static Guid GuidMenuItem3 = Guid.NewGuid();
        internal static Guid GuidMenuItem4 = Guid.NewGuid();
        internal static Guid GuidMenuItem5 = Guid.NewGuid();
        internal static Guid GuidMenuItem6 = Guid.NewGuid();
        internal static Guid GuidBill1 = Guid.NewGuid();
        internal static Guid GuidBill2 = Guid.NewGuid();
        internal static Guid GuidOrder1 = Guid.NewGuid();
        internal static Guid GuidOrder2 = Guid.NewGuid();
        internal static Guid GuidOrder3 = Guid.NewGuid();
        internal static Guid GuidOrder4 = Guid.NewGuid();
        internal static Guid GuidAttraction1 = Guid.NewGuid();
        internal static Guid GuidAttraction2 = Guid.NewGuid();
        internal static Guid GuidAttraction3 = Guid.NewGuid();
        
        internal static Guid SaltGuid1 = Guid.NewGuid();
        internal static Guid SaltGuid2 = Guid.NewGuid();
        internal static Guid SaltGuid3 = Guid.NewGuid();

        public static void Seed(this ModelBuilder builder)
        {
            builder.SeedUsers();
            builder.SeedRestaurants();
            builder.SeedMenus();
            builder.SeedMenuItems();
            builder.SeedAttractions();
            builder.SeedTables();
            builder.SeedBills();
            builder.SeedBillUsers();
            builder.SeedOrders();
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
                    Salt = SaltGuid1.ToString(),
                    Roles = Roles.User | Roles.Admin | Roles.Restaurant,
                    CreatedAt = DateTime.UtcNow
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
                    Roles = Roles.User,
                    CreatedAt = DateTime.UtcNow
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

            builder.Entity<User>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidUser3,
                    Status = Status.Active,
                    Password = Convert.ToBase64String(new Rfc2898DeriveBytes(Encoding.Default.GetBytes("123456"), Encoding.Default.GetBytes(SaltGuid3.ToString()), 10000, HashAlgorithmName.SHA512).GetBytes(512)),
                    Salt = SaltGuid3.ToString(),
                    Roles = Roles.User,
                    CreatedAt = DateTime.UtcNow
                });

                obj.OwnsOne(_ => _.Name).HasData(new
                {
                    UserId = GuidUser3,
                    FirstName = "Gabriel",
                    LastName = "Evaristo"
                });

                obj.OwnsOne(_ => _.Email).HasData(new
                {
                    UserId = GuidUser3,
                    Value = "gabrielevaristovcp@gmail.com"
                });

                obj.OwnsOne(_ => _.CellPhone).HasData(new
                {
                    UserId = GuidUser3,
                    DDD = "85",
                    PhoneNumber = "999174742"
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
                    UserId = GuidUser1,
                    Status = Status.Active,
                    Kids = false,
                    Photo = "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png",
                    CreatedAt = DateTime.UtcNow
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
                    UserId = GuidUser1,
                    Status = Status.Active,
                    Kids = true,
                    Photo = "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340",
                    CreatedAt = DateTime.UtcNow
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
                    InitialDate = DateTime.UtcNow,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
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
                    InitialDate = DateTime.UtcNow,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
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
                    StartAt = TimeOnly.Parse("16:30"),
                    EndAt = TimeOnly.Parse("20:00")
                });
            });

            builder.Entity<Menu>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidMenu3,
                    RestaurantId = GuidRestaurant2,
                    InitialDate = DateTime.UtcNow,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
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
                    StartAt = TimeOnly.Parse("16:30"),
                    EndAt = TimeOnly.Parse("20:00")
                });
            });
        }

        private static void SeedMenuItems(this ModelBuilder builder)
        {
            builder.Entity<MenuItem>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidMenuItem1,
                    MenuId = GuidMenu1,
                    Quantity = 1,
                    Value = 90.00,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuItemId = GuidMenuItem1,
                    Name = "Vinho Quinta do Morgado",
                    Description = "Vinho de uva."
                });
            });

            builder.Entity<MenuItem>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidMenuItem2,
                    MenuId = GuidMenu2,
                    Quantity = 1,
                    Value = 4.90,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuItemId = GuidMenuItem2,
                    Name = "Chopp",
                    Description = "Chopp de Brahma."
                });
            });

            builder.Entity<MenuItem>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidMenuItem3,
                    MenuId = GuidMenu3,
                    Quantity = 1,
                    Value = 5.40,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuItemId = GuidMenuItem3,
                    Name = "Chopp",
                    Description = "Chopp de Brahma."
                });
            });

            builder.Entity<MenuItem>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidMenuItem4,
                    MenuId = GuidMenu3,
                    Quantity = 1,
                    Value = 22.00,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuItemId = GuidMenuItem4,
                    Name = "Hamburguer",
                    Description = "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa."
                });
            });

            builder.Entity<MenuItem>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidMenuItem5,
                    MenuId = GuidMenu3,
                    Quantity = 1,
                    Value = 11.00,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuItemId = GuidMenuItem5,
                    Name = "Porção de batata",
                    Description = "Porção de batata feita com a melhor batata que existe (Burger King)."
                });
            });

            builder.Entity<MenuItem>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidMenuItem6,
                    MenuId = GuidMenu2,
                    Quantity = 6,
                    Value = 14.00,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    MenuItemId = GuidMenuItem6,
                    Name = "Chicken Nuggets",
                    Description = "Empanados de frango recheados com queijo."
                });
            });
        }

        private static void SeedAttractions(this ModelBuilder builder)
        {
            builder.Entity<Attraction>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidAttraction1,
                    RestaurantId = GuidRestaurant1,
                    Photo = "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA",
                    Date = DateTime.UtcNow.AddDays(1),
                    CoverTax = 20.00,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    AttractionId = GuidAttraction1,
                    Name = "Fets Domino",
                    Description = "Excelente banda."
                });
            });

            builder.Entity<Attraction>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidAttraction2,
                    RestaurantId = GuidRestaurant2,
                    Photo = "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA",
                    Date = DateTime.UtcNow.AddDays(2),
                    CoverTax = 20.00,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    AttractionId = GuidAttraction2,
                    Name = "Fets Domino",
                    Description = "Excelente banda."
                });
            });

            builder.Entity<Attraction>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidAttraction3,
                    RestaurantId = GuidRestaurant2,
                    Photo = "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA",
                    Date = DateTime.UtcNow.AddDays(7),
                    CoverTax = 20.00,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.OwnsOne(_ => _.NameDescription).HasData(new
                {
                    AttractionId = GuidAttraction3,
                    Name = "Fets Domino",
                    Description = "Excelente banda."
                });
            });
        }

        private static void SeedTables(this ModelBuilder builder)
        {
            builder.Entity<Table>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidTable1,
                    RestaurantId = GuidRestaurant1,
                    Number = 1,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.HasData(new
                {
                    Id = GuidTable2,
                    RestaurantId = GuidRestaurant1,
                    Number = 2,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.HasData(new
                {
                    Id = GuidTable3,
                    RestaurantId = GuidRestaurant1,
                    Number = 3,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.HasData(new
                {
                    Id = GuidTable4,
                    RestaurantId = GuidRestaurant2,
                    Number = 1,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.HasData(new
                {
                    Id = GuidTable5,
                    RestaurantId = GuidRestaurant2,
                    Number = 2,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });
            });
        }

        private static void SeedBills(this ModelBuilder builder)
        {
            builder.Entity<Bill>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidBill1,
                    TableId = GuidTable1,
                    BillingStatus = BillingStatus.Pending,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.HasData(new
                {
                    Id = GuidBill2,
                    TableId = GuidTable4,
                    BillingStatus = BillingStatus.Pending,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });
            });
        }

        private static void SeedBillUsers(this ModelBuilder builder)
        {
            builder.Entity<BillUser>(obj =>
            {
                obj.HasData(new
                {
                    BillId = GuidBill1,
                    UserId = GuidUser2,
                    Status = Status.Active,
                });

                obj.HasData(new
                {
                    BillId = GuidBill1,
                    UserId = GuidUser3,
                    Status = Status.None,
                });

                obj.HasData(new
                {
                    BillId = GuidBill2,
                    UserId = GuidUser2,
                    Status = Status.Active
                });

                obj.HasData(new
                {
                    BillId = GuidBill2,
                    UserId = GuidUser3,
                    Status = Status.None,
                });
            });
        }

        private static void SeedOrders(this ModelBuilder builder)
        {
            builder.Entity<Order>(obj =>
            {
                obj.HasData(new
                {
                    Id = GuidOrder1,
                    BillId = GuidBill1,
                    UserId = GuidUser2,
                    ItemId = GuidMenuItem1,
                    Quantity = 1,
                    Message = "Completo",
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.HasData(new
                {
                    Id = GuidOrder2,
                    BillId = GuidBill1,
                    UserId = GuidUser2,
                    ItemId = GuidMenuItem2,
                    Quantity = 1,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.HasData(new
                {
                    Id = GuidOrder3,
                    BillId = GuidBill2,
                    UserId = GuidUser2,
                    ItemId = GuidMenuItem3,
                    Quantity = 2,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });

                obj.HasData(new
                {
                    Id = GuidOrder4,
                    BillId = GuidBill2,
                    UserId = GuidUser2,
                    ItemId = GuidMenuItem5,
                    Quantity = 1,
                    Status = Status.Active,
                    CreatedAt = DateTime.UtcNow
                });
            });
        }
    }
}
