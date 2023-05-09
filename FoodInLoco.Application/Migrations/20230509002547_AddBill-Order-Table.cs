using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class AddBillOrderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("62fcb6f2-7ac0-4bf2-8ca6-f999861fe263"), new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(3002), null, "wTRKiya8vjeT5Sc1WtEjot+oubXcQvUO+1zJtd0vcMuN+hP6uzGGEKT1xw6+6kQGfe9aFeodzSvp79PrmdT0VOVrvTtbz0zPW/vESwr9iO9uOC2YT/I2EghNrABUOWBmFgBsA022D+aT3Y+dHGga6aJE+G8HouftCqm0tsGWZxTZjjsVdEWQutTNwfVbvxg7k7v1qtjecgGBDv866ogRruf+bhvoH/vPGeW8sA9wuV9OQ9OdL86gYx+syosdaitATj5toOSweQachUF/2NMLhyOFrqImP2t5gAzhN5i4odOIXRAPLHsCGhs1BUYXZ3dWlYbAbJ5siHBMfQnyzadNkquK7WQ2YZ2YDOAaWXoXcEFkpmI+Hp6PivOaJv8u8QyKcvRZbSiT284eH1hQU3vHd5Apbw58zi0EQNmxWpwKFg3M1iOxHK6SK9HAzzxXamqr0bQPZtZ+xDKedApBDztfyXk2Dv0kM6FtJgjWMcqQZSrkJIAWFZHjxhTxlN+89HV/1rUkfOh9giAmELuZL9vAYMoCR4QQWQAea2jDfarY51062as3dIxk5eUUyWtz1QnqAquJ7ULEcA+3qPtf51+eT3pd6SHKCuwjyTPdNweF+1boCrtuHOSvmixVdYvyD7S75dI8MX1duS9dEJQV8yGXpb9lgxceBpva5zjWdx78IpY=", null, 1, "584ee01e-37c5-4b51-8262-ae3ea550e1a5", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("631f4a7e-e4c4-4d4f-9eb1-8e32c9e4b5f2"), new DateTime(2023, 5, 9, 0, 25, 46, 837, DateTimeKind.Utc).AddTicks(5595), null, "4tmeXhJC7d6p6xh4CkzTvOPCq87eoNWlQX8Ndvqr0/10kxd1bCWEbTO50vdt2/TaY1JVYgpV9eaXZ2WL7xVTKwIw/5Z37cTSZdum3Z7sdnA5J++st4AbY6BkA11iggKVNt24H+XH6UUuAKnNENnLNqMaPLVPjLhbRj+/81rPXNlT2Ekdjmo4eRsgMwuJnfFCR8QjYd0LzGTHMdjSxvKYupkBmF803mYtoHjhEVy/7x8tk5XZx1/ezJcXO3gGY6QP+pIsmbeq7ywaJg+aImdVxWpg97/Mn90Cl+y7yYALG9KG7vtG/8iF3CO5OJHcrsQ9+eUdZHRzoaAGy520i06MRK6udshNX9QB2SwyOunuPTln2DWxGYWCh7iZqJREFTmEWc+NR9gL/cuy5zq8zelrooyacL1aBd+LmBxHOjIAwASvCdyOc1XREtwo30bdNzMk2UVVFLhXfvleX5idK8akNGyz6BsLX+Iq+oAvhq3fSGkain+P+M8xxQZGOHrc22aQhDXQBB8JGQYlv09yir22sTLOjH9sAgov6GT3m9o4o5Gn8aY+av+RBqtZs9Lq8B75UPz2wtDLlVwE3pL2Q1tnmkh9NvnQASxk4keM2k/m8U8lUN+SXfZIdPYnGgHIbboGoItrHxpBejtWmUJT4GmMC9jhRjK6QQBloECuYX/d7dw=", null, 7, "86c44c70-f217-40b5-ada5-531ee492ad26", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "UserId", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("4ccc9ba0-4e0f-4378-be09-77f739fb982b"), new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(4139), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, new Guid("631f4a7e-e4c4-4d4f-9eb1-8e32c9e4b5f2"), "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" },
                    { new Guid("ec1743b8-eced-4095-a040-1ccab368814e"), new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(4525), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, new Guid("631f4a7e-e4c4-4d4f-9eb1-8e32c9e4b5f2"), "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("273f1a42-0b90-4b52-b637-ef04840bf46f"), 20.0, new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5793), new DateTime(2023, 5, 11, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5792), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("ec1743b8-eced-4095-a040-1ccab368814e"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("6ee13407-f63c-4f78-919c-5324469f0695"), 20.0, new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5703), new DateTime(2023, 5, 10, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5700), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("4ccc9ba0-4e0f-4378-be09-77f739fb982b"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("d6648068-bda5-4430-a166-91e8d0cd0fb9"), 20.0, new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5848), new DateTime(2023, 5, 16, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5848), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("ec1743b8-eced-4095-a040-1ccab368814e"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("1f031df8-bc44-4977-a013-1f755c7c0e23"), new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(4975), null, new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(4974), null, new Guid("4ccc9ba0-4e0f-4378-be09-77f739fb982b"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("5295fdc5-ca0b-4530-96bd-809ab3489d82"), new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5167), null, new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5166), null, new Guid("ec1743b8-eced-4095-a040-1ccab368814e"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("8fe41af8-db79-4fd7-a780-38601f433a9e"), new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(4793), null, new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(4792), null, new Guid("4ccc9ba0-4e0f-4378-be09-77f739fb982b"), 1, "Cardápio de vinhos.", "Wine", null, null, false }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("00a923d0-1bc7-4a1d-a890-4317a727890c"), new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5403), null, new Guid("1f031df8-bc44-4977-a013-1f755c7c0e23"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("1d7c5fce-2508-4092-b4b5-089fbb13f040"), new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5456), null, new Guid("5295fdc5-ca0b-4530-96bd-809ab3489d82"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("46fee5d2-543c-450a-82e4-42019e3360dd"), new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5582), null, new Guid("5295fdc5-ca0b-4530-96bd-809ab3489d82"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("538b40bc-2ee0-4000-a165-530fa76202a4"), new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5637), null, new Guid("1f031df8-bc44-4977-a013-1f755c7c0e23"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("59a763ca-a8ff-422d-b1e3-d7523b1b6002"), new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5509), null, new Guid("5295fdc5-ca0b-4530-96bd-809ab3489d82"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("cf1e5f05-a5ee-4a5c-bcc0-bac8e986576b"), new DateTime(2023, 5, 9, 0, 25, 46, 900, DateTimeKind.Utc).AddTicks(5315), null, new Guid("8fe41af8-db79-4fd7-a780-38601f433a9e"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("273f1a42-0b90-4b52-b637-ef04840bf46f"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("6ee13407-f63c-4f78-919c-5324469f0695"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("d6648068-bda5-4430-a166-91e8d0cd0fb9"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("00a923d0-1bc7-4a1d-a890-4317a727890c"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("1d7c5fce-2508-4092-b4b5-089fbb13f040"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("46fee5d2-543c-450a-82e4-42019e3360dd"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("538b40bc-2ee0-4000-a165-530fa76202a4"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("59a763ca-a8ff-422d-b1e3-d7523b1b6002"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("cf1e5f05-a5ee-4a5c-bcc0-bac8e986576b"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("62fcb6f2-7ac0-4bf2-8ca6-f999861fe263"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("1f031df8-bc44-4977-a013-1f755c7c0e23"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("5295fdc5-ca0b-4530-96bd-809ab3489d82"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("8fe41af8-db79-4fd7-a780-38601f433a9e"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("4ccc9ba0-4e0f-4378-be09-77f739fb982b"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("ec1743b8-eced-4095-a040-1ccab368814e"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("631f4a7e-e4c4-4d4f-9eb1-8e32c9e4b5f2"));

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
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "UserId", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("60a229f3-38d1-4c21-9116-a601741ab06b"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(3857), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, new Guid("b552d45b-9d0b-404a-a257-c84ab7a0340a"), "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" },
                    { new Guid("d1c40d15-6538-4e21-a8de-0ee04a2a0976"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(3404), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, new Guid("b552d45b-9d0b-404a-a257-c84ab7a0340a"), "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" }
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
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("a2c0434b-2205-496f-840a-c018b13ab042"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4263), null, new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4262), null, new Guid("d1c40d15-6538-4e21-a8de-0ee04a2a0976"), 1, null, null, false, "Cardápio de vinhos.", "Wine" },
                    { new Guid("af3db864-e6f2-472e-8685-6c19ea7a5562"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4496), null, new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4496), null, new Guid("d1c40d15-6538-4e21-a8de-0ee04a2a0976"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("df67a751-acf6-4c20-8df1-7d9fdb08919e"), new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4788), null, new DateTime(2022, 11, 24, 12, 51, 0, 50, DateTimeKind.Utc).AddTicks(4788), null, new Guid("60a229f3-38d1-4c21-9116-a601741ab06b"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" }
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
    }
}
