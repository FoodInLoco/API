using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class coverTaxNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("24f1859a-d608-40c1-afee-dcf9c7883ea4"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("a51e8039-2ee4-459d-940d-c5b9d8fa5749"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("e369a3b3-e424-4aa9-8914-c71da8e5dd59"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("23a8b8e6-0ead-452b-a612-ec41baa8e842"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("67f882c6-da89-4bfe-90b8-c54f0adfb788"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("696f8345-2d7b-47d9-9b5e-e55647eeee83"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("8df7354a-afb8-4362-9936-08c6e0477928"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("cce22f76-0dd3-47aa-bd1b-727ed9235706"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("dc674942-db41-45be-90da-e89201392fe2"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("28f1a369-06c7-4b1c-bdcf-eec1bfbbdd2f"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("02e2a719-822c-491e-a882-f0d920f0ca16"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("4c7ab2e7-0fb3-4f7c-b1c7-a1c38b9056e2"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("ec8e631f-8299-44fc-8789-30c374e64946"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("447e92eb-a102-4ba5-89e8-fcb30bb35b6f"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("b4a97127-fba2-4ca3-b924-57e3c213c5da"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e9eb175c-2332-4023-9366-4d16b746e817"));

            migrationBuilder.AlterColumn<double>(
                name: "CoverTax",
                schema: "Attraction",
                table: "Attraction",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("226da1e9-18cc-4d61-a6ec-58cab29f0b24"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(2280), null, "+u2/HGRhZFrO+HlHsyICgz2SeRmXr90HenAReQV/uwpO5xLnnq7IwITHIEYRmGiyCIjkYIW4+2a/+e4x1IXc2zFg2NQHnhJRSf0VLbiIqyFgIkR5Hm9+pxuOVsEWt6Aq720P3XGkShCP1OmTNjffzwksUajWqn5DW0h3OUXTif7gJ0aFG7HI0DfjuHEPnD9EiqQut+et/2t4YXahY7+dnE/Rjy+RPClCxG1KDr+RmihSNhiFXtQwXg4ZKwu9ZwPd2aWK3Gkl8yH0s816vubk4SLSZDBxu7AT0w0OTBhFno3m+7FB/qLZPsDVFTE57Me0otsORc5MPm3rtYBGenn2didOjvxCjU2bMM/4BMQoi9dW8LSAcuOEzzf6G8gVcBkFjBEDgHYZg7Jb8SnM/8fVLDD0v2daP5GM0DzDliI+rKAn5DTMcLGonJVu/rdbdTLJHN27dKRK4R50vB+jeIXhKdf2/UrEQYI7dnFVoeEFSLeXz7deiFwtpDVhSG8m7RRPrAdKtuKGRoHzZ52a9Pdd+7eNyecWimz5J0Noc4PBMiy4WSWJRxH/zchNJxs3/CsAoCydZJOw0vMd4Km3GRxhR51Ok561qg3QK1UBhu706k9JJkQ31hEr9U4KJcOnTl6xVUkRIfbIbyfPBUhMhDWpK2sLlSzYWFMmkjtCr6lPmTs=", null, 1, "34f5bc21-c574-41b6-be12-4cb9525c90f5", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("b552d45b-9d0b-404a-a257-c84ab7a0340a"), new DateTime(2022, 11, 24, 12, 50, 59, 984, DateTimeKind.Utc).AddTicks(7280), null, "omNMgvyegPINs9PIzPfxW/nHNilMiaIRV2751bli5gHmX7xRBnSE2ZR8QMUL9MMtNX+fKafg69tRcW2LbuGzqI/IVSu5+j6adc3OWWrvVl8CuS5J6FBu0j5iDAOrDaSMQn9UbLeBt373FA2QhkuyuwqSS4iYIqsDXoUCGG3C4V0Pm3s7Fx6XfGiI6MZfWXU3tES5Snl28Kqjj7yKYqq27Imk+uWnIjFvNJNh8fKGbKrROfaH4yFxpeSXOtIkJHenLVNU7/GfMCwbXcozKh2dJAxFRGxl6a2Tyoi6ILKZKGhbcx+Tu4izDu9DePlucCSYaIro72IjAgz1EKNkmHqyu/azFMS26ug/qYkVXZMO8Df2rkBOHBMMcUP0GOeGwdt9u94epcHZg5zhPPI1BvDJCTMkwKzXOiUsjYQOkFDvpqIDCGFWpE4UqvuPpOZIZXKls05tuo/KQcyTltFhq83Vq17IiecOwcADKn9y5Xzwgm7pL7wG/JRNPyoVcqa90IUTM6AVXvJAGGO3CRN01E1D2A3HeOSxO+SRQxpF50a5iRK+uD+v+Jg4StqtyjFUP5ZF/v4Oi6jaX4u5gbIE8NnjLiQsvcCTa0dSDkDap25EGRo8Rr6CgzCe4i8ppidU/tR7uzsO+0FADar57upb8vsl0RKmFrhNXithhB9YGEqwAuI=", null, 7, "8daa4578-bce8-4332-a620-f632fc7be8a6", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "UserId", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("60a229f3-38d1-4c21-9116-a601741ab06b"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(3857), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, new Guid("b552d45b-9d0b-404a-a257-c84ab7a0340a"), "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" },
                    { new Guid("d1c40d15-6538-4e21-a8de-0ee04a2a0976"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(3404), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, new Guid("b552d45b-9d0b-404a-a257-c84ab7a0340a"), "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0d64b152-402d-4d98-b146-4fe53dba927d"), 20.0, new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(5803), new DateTime(2022, 12, 1, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(5802), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("60a229f3-38d1-4c21-9116-a601741ab06b"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("69ef2624-8c05-4c0d-8891-0287878018f6"), 20.0, new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(5732), new DateTime(2022, 11, 26, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(5731), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("60a229f3-38d1-4c21-9116-a601741ab06b"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("d6a80bd7-ecb2-476e-a9ab-a620889945b1"), 20.0, new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(5619), new DateTime(2022, 11, 25, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(5615), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("d1c40d15-6538-4e21-a8de-0ee04a2a0976"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("a2c0434b-2205-496f-840a-c018b13ab042"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4263), null, new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4262), null, new Guid("d1c40d15-6538-4e21-a8de-0ee04a2a0976"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("af3db864-e6f2-472e-8685-6c19ea7a5562"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4496), null, new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4496), null, new Guid("d1c40d15-6538-4e21-a8de-0ee04a2a0976"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("df67a751-acf6-4c20-8df1-7d9fdb08919e"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4788), null, new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4788), null, new Guid("60a229f3-38d1-4c21-9116-a601741ab06b"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("4d1d8651-9936-46f2-b634-7a2fe0222e54"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(5331), null, new Guid("df67a751-acf6-4c20-8df1-7d9fdb08919e"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("56851692-3fca-49f8-b84b-c4c3d61f5a8e"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(5433), null, new Guid("df67a751-acf6-4c20-8df1-7d9fdb08919e"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("7180cc63-cc41-4d8d-a4e9-f7938fb70cdd"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(5104), null, new Guid("af3db864-e6f2-472e-8685-6c19ea7a5562"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("ccef7774-e66a-42dc-9523-60f68d2f1648"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(5178), null, new Guid("df67a751-acf6-4c20-8df1-7d9fdb08919e"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("d22d0777-643c-4322-bfa9-e03e1618e736"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(5508), null, new Guid("af3db864-e6f2-472e-8685-6c19ea7a5562"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("ff3e494d-ed71-47b6-a91f-6f4d5311a076"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4956), null, new Guid("a2c0434b-2205-496f-840a-c018b13ab042"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("0d64b152-402d-4d98-b146-4fe53dba927d"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("69ef2624-8c05-4c0d-8891-0287878018f6"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("d6a80bd7-ecb2-476e-a9ab-a620889945b1"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("4d1d8651-9936-46f2-b634-7a2fe0222e54"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("56851692-3fca-49f8-b84b-c4c3d61f5a8e"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("7180cc63-cc41-4d8d-a4e9-f7938fb70cdd"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("ccef7774-e66a-42dc-9523-60f68d2f1648"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("d22d0777-643c-4322-bfa9-e03e1618e736"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("ff3e494d-ed71-47b6-a91f-6f4d5311a076"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("226da1e9-18cc-4d61-a6ec-58cab29f0b24"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("a2c0434b-2205-496f-840a-c018b13ab042"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("af3db864-e6f2-472e-8685-6c19ea7a5562"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("df67a751-acf6-4c20-8df1-7d9fdb08919e"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("60a229f3-38d1-4c21-9116-a601741ab06b"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("d1c40d15-6538-4e21-a8de-0ee04a2a0976"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b552d45b-9d0b-404a-a257-c84ab7a0340a"));

            migrationBuilder.AlterColumn<double>(
                name: "CoverTax",
                schema: "Attraction",
                table: "Attraction",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("28f1a369-06c7-4b1c-bdcf-eec1bfbbdd2f"), new DateTime(2022, 11, 23, 7, 25, 4, 707, DateTimeKind.Utc).AddTicks(9696), null, "Fb9R0PnLJTTgi4Fdc8/VClX3zL3HUDVAlqg0FwiaHGJ1UZooUXoP2oMjwttlAcTnFyFz2bXwMNseG1qHm7bhRR0qY9XXF0XYBqvexBYdC2UyiZ7339CtjrpLdP3fm4zK2Dt3jVvAnkUre6NxrGjFnZNv1FMfVSCz8EbCIkiIQGaYXI1Hp1PpoIBJSInjdHDshX9xXgRjUTzOzhTU5Z876qLhxnw0j5vhDM276oaqgHePf42MY7gf4W5vwO+cGtuU068e54oWSPEAXbtd4KRnKsni0w9i3DVtDJ7xtBSdpqNfi355DPy19X5jfyOnUHYDedK1Ezl1Ivyft3+N2rShyjmL+fy/4ucUVfRizl9k9GU74tQNhkg2GCZngtLRfS/MLVt+ZvEPgqm8fRGZ70+90RM+xhrDAqu4bRCshTTV8aeJl0RtZZcuQHMUkQV7Ik3lUTfrm+hfLljQiDXKQdUY9ykcgJdaXX61M+VDJb0hGlAjQ4hPX7TOqdtebtmg1nrjsJT24U1wR5rzHkpMaQ41fQDbdxNBlidQ0bslY5svTrLjil2GCWrtwIOovymjm+dVfmjDi8MXiFzbuGsMvELLSmAHOt3pGA5prXFc8ZJcv79PX9p7VwX5XXu9MJz31jdoFXbOIZnt/Pkq1lnT2K+M3KabMYOrQxBf310bjkb2XxM=", null, 1, "3d24f5c0-61ee-4015-bbcb-343cfd301c6f", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("e9eb175c-2332-4023-9366-4d16b746e817"), new DateTime(2022, 11, 23, 7, 25, 4, 641, DateTimeKind.Utc).AddTicks(821), null, "YKTT9nAicmBNPBe6PITSRbh0i/x7gm2DDeBjbdv4N7LJuFU5BHbnNlrK0f+HUfJe9sBxCsM8HsrQPrGBzj6UKTXdnXpy0HLPnaFcyctFv4CbcvlZRs+wRiY4WJkXKFQ60tnetA2vKjmA/xwM2+QsLnQk0lkcqu5Wln1ZS0mbIwxE+WEj9ZJYuZ6kiTImGX6qXnls8VzZo0tc8LctuxsZdrB0nEsx5l8gf0A6yCqSKkgzPkW5cVCAOXmicuV9q+UzKrpmO3Nd4tqBCuZp0yXePiDtSb7zZLhM9S2VgSKr4d9sJ4t2bsSuSsHVTGseePyCFFVDAp84jGvvZU9gvJmkhPGEDOmiMhPkqwVHEnbJZU22mOPYRXRubASBtbjy+WGqT2pNY5u/a19fzR217BwtkzlB8sFRFbJd4VIv5au1ARCkUFWCLqUqWlWI4PvFGwsIcDNe69A8PXKtHUZWSmNo/EHeLA+fkFyjz1YHwMFJ2dgD4rtpcArenVdi/PpjyeK3Nhhifmy3bbx87DPFhmF6gLmOQ7oLfB+PX8LLqE/vSrqmUPY6PN5opdYLNwZ+jZNIQH25sHiHCRBBbXgh9ImmcTTNCUnuwwJu39OeAyTFp7RP6KAaJmOu7FpwN761dYUnONsYM0R/bYSEDreDNwVQ6xKJCxin3UkJ8plYNcqFhP0=", null, 7, "8cee4488-5bae-4eb9-9441-e2a958cd5d1a", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "UserId", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("447e92eb-a102-4ba5-89e8-fcb30bb35b6f"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(1048), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, new Guid("e9eb175c-2332-4023-9366-4d16b746e817"), "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" },
                    { new Guid("b4a97127-fba2-4ca3-b924-57e3c213c5da"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(1459), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, new Guid("e9eb175c-2332-4023-9366-4d16b746e817"), "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("24f1859a-d608-40c1-afee-dcf9c7883ea4"), 20.0, new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2752), new DateTime(2022, 11, 24, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2747), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("447e92eb-a102-4ba5-89e8-fcb30bb35b6f"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("a51e8039-2ee4-459d-940d-c5b9d8fa5749"), 20.0, new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2849), new DateTime(2022, 11, 25, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2848), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("b4a97127-fba2-4ca3-b924-57e3c213c5da"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("e369a3b3-e424-4aa9-8914-c71da8e5dd59"), 20.0, new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2910), new DateTime(2022, 11, 30, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2906), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("b4a97127-fba2-4ca3-b924-57e3c213c5da"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("02e2a719-822c-491e-a882-f0d920f0ca16"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(1912), null, new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(1912), null, new Guid("447e92eb-a102-4ba5-89e8-fcb30bb35b6f"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("4c7ab2e7-0fb3-4f7c-b1c7-a1c38b9056e2"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(1667), null, new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(1667), null, new Guid("447e92eb-a102-4ba5-89e8-fcb30bb35b6f"), 1, null, null, false, "Cardápio de vinhos.", "Wine" },
                    { new Guid("ec8e631f-8299-44fc-8789-30c374e64946"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2131), null, new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2131), null, new Guid("b4a97127-fba2-4ca3-b924-57e3c213c5da"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("23a8b8e6-0ead-452b-a612-ec41baa8e842"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2596), null, new Guid("ec8e631f-8299-44fc-8789-30c374e64946"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("67f882c6-da89-4bfe-90b8-c54f0adfb788"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2653), null, new Guid("02e2a719-822c-491e-a882-f0d920f0ca16"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("696f8345-2d7b-47d9-9b5e-e55647eeee83"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2490), null, new Guid("ec8e631f-8299-44fc-8789-30c374e64946"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("8df7354a-afb8-4362-9936-08c6e0477928"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2258), null, new Guid("4c7ab2e7-0fb3-4f7c-b1c7-a1c38b9056e2"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("cce22f76-0dd3-47aa-bd1b-727ed9235706"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2542), null, new Guid("ec8e631f-8299-44fc-8789-30c374e64946"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("dc674942-db41-45be-90da-e89201392fe2"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2433), null, new Guid("02e2a719-822c-491e-a882-f0d920f0ca16"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" }
                });
        }
    }
}
