using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class FKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("33c1dd89-9ff7-4db2-9615-846c9654167d"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("8514e6cb-7313-4bff-893d-7075d80acd4e"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("9c48feb5-234c-4cce-a275-9fb749ce5289"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("3e38dbf7-9e71-42b8-a1e6-7e8ed5054437"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("3fb9ded3-806b-4e01-a020-7545562a0b12"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("582fc92d-c4d4-4b27-9151-5108f14ed51c"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("7c358971-354c-4304-89f0-3f39cb18e4f1"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("842ea07a-6248-46d6-a0b3-b44a3c4c334b"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("bae71d6a-bcc6-4dfa-be03-7d231f28bdb1"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2d0fcae6-4c87-40ae-ac89-8bc099e2f665"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("362a91df-868e-4644-8a1d-3a43306da7d8"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("27e8ac2f-de26-4971-8ee1-647a50314a56"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("c2c13e61-1284-472d-86f5-3509a7d77e0f"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("df2f744a-d2e1-4ac8-975d-56ae5f40ab71"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("285d3064-a449-44e5-8a86-ac16a17e28ce"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("4c07b79a-778f-4cc2-82a5-9f1ddc6ebc6a"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                schema: "Review",
                table: "Review",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("3b1a1f9e-d7c0-4912-bbcf-74680de49b81"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(6683), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" },
                    { new Guid("8cd2585b-c05a-4912-afde-fa5bee9ccdd1"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7004), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("5131ddce-f657-44e0-b9be-7ce2a450fb15"), new DateTime(2022, 11, 21, 21, 49, 55, 162, DateTimeKind.Utc).AddTicks(8218), null, "Kj85tHQgca2kVwoz6ar9HkkbFca+tFdxpfntUdty9WsCNd4jTCVphpfGFr+w9nnOeYKSPvBGKxgBfDS2VPXSGZsm62M+pSYaSsRP1NrziinbrIa4+k+ZPwWT3Svg7B/U5x+4c/L5ApVT42uCLT0CE2Rp/wFstC4gZhLUKhehKwKkVDJuftnxx/8Beoso/YhyDsLwkG8wViBEc/vBVHd+nqcAJLtsQStycK2KAwuxV2YBIaoTE4WecqAD66V6El/wiNAZr4oNIj9c8dRCXtKMZzpJQYgV9S9z2r4KTq+Zk09e+bBxvEzd3+oLr+sAVkZm7qXgJCeyStt5gTDJZuDHFIYX9H3PlmnXw4lZd/uQjoN3fH22K7wt/2afyGIRf4pfoIubHKOnMICeynESQFXhGTgll4xopmW4QN57gPMa+EiBTtI3I7zuauSz8cZeuQxvNC/bqfJjN98S5EXvjWBjB8+7ep/OXNgljw330T1Z19T/ZZnqPBCOQ2pJeup6ZzfFhZX3EBJSUf9GwIBwvCGi+kFGALwi4gLzLwMpob3ceKsf3/6tvZ20BN5A+BNjbe1UgZ1oUjbYOMl22V4WgEQgYHGrpi8KSGypBoM3teBUSU2g+Hd5k0eV6PtMATRXrpRCDJfhNs6csY8J60Kudp3EI2oky2kvHrMNKWp1B5iSZHw=", null, 3, "f1e94755-e73b-4362-8de0-ccd5b122f364", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" },
                    { new Guid("d86506b7-73ac-42db-a0d7-ba47367d4fcb"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(5945), null, "Zx62rSR6ZfWTkcYyEhAoL7cgclIlu65QKpSU9lD5cMzOhk48Dqc9+6+J4E0hayVlI6joGGkZaUSrWKY3l8lwfpByD+eOTzFMg79gaKiKY+dvHi3NEP2FOikkHVeHESmFrKaMhrn6/acA94DwUvBc/BmNZSdhqIh1mn+bbwd6rd8rFFAC2BmKv/iBwm9HHBtonr+zr0vkMz6vf96DuSsRJb2f5ls0ckuf6cujZ2N31Z3dVapsIhV02aGIfMEG6vDL0HioNnyqepafR6ALhHnff7Dj0oD/JrJSEm4NDyZb3oYj33Th3hmuwT/48BkAw62tPh0nkcaMHB1nc5SE8jxum/iLxMygy3l5ZJtKEOgZRJBpvdRujk+KM6MszzvCLaKcSbufQnJktl1i9f0FPsNYT+KcMG9qG1jwHt3clh+yF6bGYhMk3bOqA7TrD0d9ncWCPDMC1rLIywQMgAbIWS8pmGI/NIqAoliTn4V9Nsaw+8VBmqPv7pdYb8SAmuCCAxWCTF6hUgLMJ/7uHnLhpWXWVr95Rq0JYbHcw8whRDdJ6LyHhM4Q7nru2a9vlhtWTXzVe0Aayp8esq1egEmY3GBhGw6FWrXOcUVHwq6ammDXdfTBTG1wQkWVt1D9yUYc7Pra1af9seJ3w/4zF4GKG9otDE9KqJAhCltt7fePq17eVBs=", null, 1, "afd8cd7b-41ce-4fed-9bb9-cbbbfb1d6042", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("98414c2c-e83f-4491-9a0f-734eb201eb75"), 20.0, new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(8128), new DateTime(2022, 11, 23, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(8127), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("8cd2585b-c05a-4912-afde-fa5bee9ccdd1"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("9c7a980d-9549-43b6-826a-33cdb1407edf"), 20.0, new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(8182), new DateTime(2022, 11, 28, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(8181), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("8cd2585b-c05a-4912-afde-fa5bee9ccdd1"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("dc6668ba-b67a-4b66-a913-29220f1ddf1f"), 20.0, new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(8037), new DateTime(2022, 11, 22, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(8033), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("3b1a1f9e-d7c0-4912-bbcf-74680de49b81"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("0d8b8920-8d7a-4bab-bcbc-9bdc08a12614"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7559), null, new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7559), null, new Guid("8cd2585b-c05a-4912-afde-fa5bee9ccdd1"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("5ed16fb7-58a8-4899-a58d-b63bcd67f750"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7198), null, new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7197), null, new Guid("3b1a1f9e-d7c0-4912-bbcf-74680de49b81"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("ec893660-cb27-44ee-9aa1-32384fbf1a9c"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7356), null, new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7356), null, new Guid("3b1a1f9e-d7c0-4912-bbcf-74680de49b81"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2ee3f86a-e2d9-4572-bea4-b65c30e62240"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7971), null, new Guid("ec893660-cb27-44ee-9aa1-32384fbf1a9c"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("42eeea7e-960c-4a65-8684-e2ff1d3b288b"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7677), null, new Guid("5ed16fb7-58a8-4899-a58d-b63bcd67f750"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("65bcb1cb-724c-41dc-a066-04bbed27b3a0"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7871), null, new Guid("0d8b8920-8d7a-4bab-bcbc-9bdc08a12614"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("77d21e45-ebf8-4450-ba15-6cd75f6c04db"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7770), null, new Guid("ec893660-cb27-44ee-9aa1-32384fbf1a9c"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("99249fcd-d950-407b-aff4-11cfac4a15a4"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7819), null, new Guid("0d8b8920-8d7a-4bab-bcbc-9bdc08a12614"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("dc3f9b2b-ad7f-4503-a472-0dbb66363ef2"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7919), null, new Guid("0d8b8920-8d7a-4bab-bcbc-9bdc08a12614"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                schema: "Review",
                table: "Review",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_User_UserId",
                schema: "Review",
                table: "Review",
                column: "UserId",
                principalSchema: "User",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_User_UserId",
                schema: "Review",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_UserId",
                schema: "Review",
                table: "Review");

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("98414c2c-e83f-4491-9a0f-734eb201eb75"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("9c7a980d-9549-43b6-826a-33cdb1407edf"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("dc6668ba-b67a-4b66-a913-29220f1ddf1f"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("2ee3f86a-e2d9-4572-bea4-b65c30e62240"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("42eeea7e-960c-4a65-8684-e2ff1d3b288b"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("65bcb1cb-724c-41dc-a066-04bbed27b3a0"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("77d21e45-ebf8-4450-ba15-6cd75f6c04db"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("99249fcd-d950-407b-aff4-11cfac4a15a4"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("dc3f9b2b-ad7f-4503-a472-0dbb66363ef2"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5131ddce-f657-44e0-b9be-7ce2a450fb15"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d86506b7-73ac-42db-a0d7-ba47367d4fcb"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("0d8b8920-8d7a-4bab-bcbc-9bdc08a12614"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("5ed16fb7-58a8-4899-a58d-b63bcd67f750"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("ec893660-cb27-44ee-9aa1-32384fbf1a9c"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("3b1a1f9e-d7c0-4912-bbcf-74680de49b81"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("8cd2585b-c05a-4912-afde-fa5bee9ccdd1"));

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "Review",
                table: "Review");

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("285d3064-a449-44e5-8a86-ac16a17e28ce"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(4148), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" },
                    { new Guid("4c07b79a-778f-4cc2-82a5-9f1ddc6ebc6a"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(3613), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("2d0fcae6-4c87-40ae-ac89-8bc099e2f665"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(1825), null, "x76I+huDXTT9KNYpKI0ZNts1U9t4GVZw8ESOD9fkNKgBl+1hiTz4HsjJeSJVMtRe3uV1rpa/syKCX6gg9EgbNW5XduCfvXdZvznZupF/z4F+UKnwQytVdQCuE2jXdYgbrOEgJ1LcDDzrXFXesQA6vv29peeMYWD66UmEb0gmd29LHpEMLfrf8pvlR3EAwkRjynO0xczk4ny79ln8lmXtmuI2ZeY1qm4RkcW26wF2aqv+Ca2JKC/Z7RIBkzXnU9Fk20AxatHF2LOrXHvCrR4JnzF/xBFzH4DESLblVsfVHCfflqf903ZF5oJhLwf9oMdQsPffeuiqUb18dfOnUKb6Bdylfk5IYnABB8zTY1dhB9AEdyomBxUhVjgbNsjyHp+s0o8P0gjNtU/9dOwDwcQYyqjcrGUrnGDm23Sg1G+qpR3iY00mAtzs+jmWKEijyR4rTnmlOfGUizVoBjhcPsfih3QFY5ZYKXoCuseMVgJWmTm2YXcoKDr+zBeVjXCJse/Rrlh1XsyiZauj10i0UXkeeXo/KXM8Evt9p7UMx7QuK/968ivc/8cclXJUOtEMQPjxT9KMMNb2zdGeVWbrYRrZUbp5hv7631tPH7TXe1vvZdzIHQGu9y9y9/ru4QZ2GoSW99LD39LAPMXE9Ui6yJCXfLDMsb+NauDQmD33qYiJFlI=", null, 1, "5778ac38-1deb-4e54-9e16-a03b9ab9bb52", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("362a91df-868e-4644-8a1d-3a43306da7d8"), new DateTime(2022, 11, 21, 21, 7, 9, 501, DateTimeKind.Utc).AddTicks(5066), null, "OyoXm5LnQ2yy0tdENbd6Abs3af2t3NmQLg3XOp21KbPUfTbxP2zhFKECtoNBpy5f+H1Nw/UErdqoZlGwjGxCCemv5kJ27o4cKRRzJbNjX1p56+G0DwgzvSfKIRaZXeat/agO7QVbgd3LCySW/MY7ZiNv7YjRFuKCwlAEBkgvFuRFGYSF/93kYFPTZjUf5nuex060qFi8P1vAfX3J7VeX80pyRr7P+eZy/wyg80Qe590yV23Pk+6L1ZNeUcVXSjvhnbJd5a/swSOzpD8SH5tXP5b8dQK0LsneUEjD+r2y96dQhTpSd4qEZAb0g/dnfnC0ldFwI9JclZNDrXE/iHx0cyKKzZaCe1gr2fXciVGfYo9hZLuFsLTBG0SyZIRKkv7WZRx7OKyu3rRqYyBBN553BsT2v4QXiqK8pUj0LZH7HtkWgM5RSg7Jv7MiD59SgSVy1Hka3Tgr6Urgl19whQ3FVlX7DDitpJR4VeSzcwTorXfj66ONr3IMsiSuMHGTvEZl8qt94qyq+IyVSuZ9W1ey0eClREua3LLkNkGx3l0qx7/TbA0zyqvv5lTRFnFDc9glvH2HNliio5R8XZ7stz9gmL4+5n/Hmo678L5C3XEnPboXZ7PdiSvALpewNx9L/h6eY4dJMCKDsWqBaKqQjwjBthuevbPGMGPQllsngCnzBWU=", null, 3, "5e81e705-50a5-467d-8915-87e8bd142a34", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("33c1dd89-9ff7-4db2-9615-846c9654167d"), 20.0, new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6380), new DateTime(2022, 11, 22, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6373), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("4c07b79a-778f-4cc2-82a5-9f1ddc6ebc6a"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("8514e6cb-7313-4bff-893d-7075d80acd4e"), 20.0, new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6508), new DateTime(2022, 11, 23, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6507), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("285d3064-a449-44e5-8a86-ac16a17e28ce"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("9c48feb5-234c-4cce-a275-9fb749ce5289"), 20.0, new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6608), new DateTime(2022, 11, 28, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6606), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("285d3064-a449-44e5-8a86-ac16a17e28ce"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("27e8ac2f-de26-4971-8ee1-647a50314a56"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(5379), null, new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(5378), null, new Guid("285d3064-a449-44e5-8a86-ac16a17e28ce"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("c2c13e61-1284-472d-86f5-3509a7d77e0f"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(4654), null, new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(4654), null, new Guid("4c07b79a-778f-4cc2-82a5-9f1ddc6ebc6a"), 1, null, null, false, "Cardápio de vinhos.", "Wine" },
                    { new Guid("df2f744a-d2e1-4ac8-975d-56ae5f40ab71"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(4929), null, new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(4928), null, new Guid("4c07b79a-778f-4cc2-82a5-9f1ddc6ebc6a"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3e38dbf7-9e71-42b8-a1e6-7e8ed5054437"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6161), null, new Guid("27e8ac2f-de26-4971-8ee1-647a50314a56"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("3fb9ded3-806b-4e01-a020-7545562a0b12"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(5747), null, new Guid("df2f744a-d2e1-4ac8-975d-56ae5f40ab71"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("582fc92d-c4d4-4b27-9151-5108f14ed51c"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(5837), null, new Guid("27e8ac2f-de26-4971-8ee1-647a50314a56"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("7c358971-354c-4304-89f0-3f39cb18e4f1"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6263), null, new Guid("df2f744a-d2e1-4ac8-975d-56ae5f40ab71"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("842ea07a-6248-46d6-a0b3-b44a3c4c334b"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(5935), null, new Guid("27e8ac2f-de26-4971-8ee1-647a50314a56"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("bae71d6a-bcc6-4dfa-be03-7d231f28bdb1"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(5587), null, new Guid("c2c13e61-1284-472d-86f5-3509a7d77e0f"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" }
                });
        }
    }
}
