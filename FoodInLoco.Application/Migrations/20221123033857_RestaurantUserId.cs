using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class RestaurantUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("1f8c5a1a-0a9f-4173-b150-1bb307106fd4"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("2d803294-eaa2-42f9-924c-0e13da8fcfd9"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("ddc0f969-fb67-4e79-9d2b-ccbf945c918d"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("6e431981-570d-4703-a43a-3c489dd8e15c"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("ad3a867d-843a-4362-9e5d-fa6b66ca4d90"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("af426a4d-7cda-4b29-9de0-69c98738abef"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("cefbe61d-678e-4d85-909b-44e4235c3e21"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("d2f5f4ca-946f-48b9-855b-1a35245e6342"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("d52490d6-5e97-41b2-a70c-c9ee2f6d6b6f"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("77bfc02f-0b7f-4a56-8b47-21cfc4113665"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("80c7a6d4-0739-4fb6-8d91-0baf648d035c"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("03b7a2e8-4a52-4ef3-ae85-45045c6ec012"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("d8ea239a-16c7-4e5c-a1c1-c2c28225a302"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("dc7a44a0-f7bb-4bce-8eeb-7f416f5857a4"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("30267878-8fd7-42bd-9285-3f7ed8566d26"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("96ecbf25-0ab3-4d2a-b0d8-426eb62639fc"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                schema: "Restaurant",
                table: "Restaurant",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("1602c566-349a-4fa3-956e-df3ccc531558"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(5106), null, "CEzUd2xeXlRsWX/dzuuF0Qx8gE/T4joEKKlb2HzS8tBs5iXfJ/H/dOnVSZxvvg3fM3xdREwECv/EHuqbc/i1ihnDXJ+YAULKTgBv7BIX2OcbpsNCyl1exGksIiq85Bw+ElN7iznTPohVShZxPIj1up3Afts0GYcwBwg6QLXQ5WmYOFcGFA8bzioS1bxm8atRNpNZBtxu0zQAWM2AoAYPTLLaeOmlHcmHSdPT2hge8PQz1QSO29fYH/zUtYGgtvuBCcpnYM8CI0oTGk+OlHyNxZjbaS0NDMCp8pse0E4e0Jg7/1IOrQwKwYa8Qm2T8i3XTYAR2o5AAjvd/h7sTTYqOwA48W44M5ltrYWmdstmwc7bfk20h/cTNLvfw0tiHxJ85GVmTHKv4MG7GkzN7fxTcFupnYva1IIMozHFWDhoGdtKymcvVIodT+yZ73eaQ2nJBYulERkc8bhZxuPDwWbAU7aRb9hTBwMiCo9uN+rQ7XdmW7UqjoQYe0hS2tjk3CbPFGsxAQ8OCrZp7aRyzxOw7zSdMPgbB0xP6ZSU/4po60i6aHFXA3sP7kJUN4KolpP0i+t2gpjAL20kmevu63NlA6PdaURFo6ddImNv/gRqizjW9+fMamEh9rLUNQ5nxqySAoiML4loQ1+5pGg9l/D42EbcxLn69esIrK4KAstzS7Y=", null, 1, "423c50ec-36aa-47f6-8d1a-f99677a8aa0d", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("2216d7a7-8cfe-4e82-ae09-9a2899adde93"), new DateTime(2022, 11, 23, 3, 38, 57, 78, DateTimeKind.Utc).AddTicks(6047), null, "UV/sqmk7lYj4abv7L/5j6TPSL95wEqIvxYivpMIV5DicPDc6MrGb76Y0iMrlRRB/xZhkVAJwOFe8jHiqtRsZpu1AQa8tdoCUNs1XXfFHt9Quxo9oUewvC1BqhfvPY+aTx9VGTc/ihIE1s3ZrxG3wReG035kBXKuV2Pa8iOuo+xoLF8aJIzMNGhJnvydyBnvz6bUa/gnZEj7UxqU5E5jGmb/PAzeJtvUmt3WoCYqBcfMnr156rqbm9YALZTXxNP/oHuUepQVPV+JRx9tf4W1sNJf1uSjT0D1XAYfvCTJqbcxZkgJLKOM39JzuSQ5UTNvZA/sD9cZELq/pIhp+EwTURjjrrWcswqYrvDZTy6xLwLKoaFVMi0+F0rFT7I3ZMq4Rh1iT+wkzOg7px96HHZkD1tHPfxNBuCsC+37W2p4wKLWNzvuOuOHz5eTXfi8vd3zdi+cnXPjOmFBex92qFL9h3mRhf3cgVOW5or9yAe3HADPCNpXftGUrUOFFq26YAtA1JzCQ8b86ZqcIjPucKm9UpjZq32pIOkDjla+C0zCsXi6QUr2/QIbwVMampJzQ6qUoi4giJnRf0shaBs5S4pjzuxhpw37BOLGCNSISaICkZ6RwigJkbJmEV21T4jxpm8moD+MAuoyIBomTXHfIBQvmV4KYOJA2Jde73hG/un6cUI4=", null, 7, "86bb51ab-f2eb-43f6-b10e-a97cd4a53ba0", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "UserId", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("0d252a00-6de4-4bbd-8215-c83c2f865582"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(6394), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, new Guid("2216d7a7-8cfe-4e82-ae09-9a2899adde93"), "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" },
                    { new Guid("1eb98d03-7bef-41ff-8ea4-4290d92a640b"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(6761), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, new Guid("2216d7a7-8cfe-4e82-ae09-9a2899adde93"), "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2a2dcfc5-bfc0-408c-bc5a-c334646733ad"), 20.0, new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(8193), new DateTime(2022, 11, 30, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(8193), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("1eb98d03-7bef-41ff-8ea4-4290d92a640b"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("63a15fdd-e842-4830-8cf6-6d95a8889ef8"), 20.0, new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(8016), new DateTime(2022, 11, 24, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(8013), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("0d252a00-6de4-4bbd-8215-c83c2f865582"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("cdc126c2-d1ba-4329-a212-dd6befd9ed8a"), 20.0, new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(8138), new DateTime(2022, 11, 25, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(8137), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("1eb98d03-7bef-41ff-8ea4-4290d92a640b"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("3c77f67b-806c-4042-bb6f-98efb87b5c5a"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7174), null, new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7174), null, new Guid("0d252a00-6de4-4bbd-8215-c83c2f865582"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("c0581d1d-2bf6-4909-88b7-2d1bc87e9347"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7003), null, new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7003), null, new Guid("0d252a00-6de4-4bbd-8215-c83c2f865582"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("f3929b9b-d0e9-4aad-b467-b3529a2ef7e3"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7474), null, new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7474), null, new Guid("1eb98d03-7bef-41ff-8ea4-4290d92a640b"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("48c63618-e4b2-42c3-bc17-1bfb599722e5"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7780), null, new Guid("f3929b9b-d0e9-4aad-b467-b3529a2ef7e3"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("49cddba2-9213-4574-b70c-7004f57eba2e"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7887), null, new Guid("f3929b9b-d0e9-4aad-b467-b3529a2ef7e3"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("c1a75e8d-3fb0-453e-8805-d7717f8f2624"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7833), null, new Guid("f3929b9b-d0e9-4aad-b467-b3529a2ef7e3"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("c75ac7ad-96a9-43c2-8518-61350d729956"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7943), null, new Guid("3c77f67b-806c-4042-bb6f-98efb87b5c5a"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("da9d27ef-5443-4c53-a98e-50e4709f3a20"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7598), null, new Guid("c0581d1d-2bf6-4909-88b7-2d1bc87e9347"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("f2f38c81-09ad-403c-a078-ef00248c2daf"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7698), null, new Guid("3c77f67b-806c-4042-bb6f-98efb87b5c5a"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_UserId",
                schema: "Restaurant",
                table: "Restaurant",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_User_UserId",
                schema: "Restaurant",
                table: "Restaurant",
                column: "UserId",
                principalSchema: "User",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_User_UserId",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropIndex(
                name: "IX_Restaurant_UserId",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("2a2dcfc5-bfc0-408c-bc5a-c334646733ad"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("63a15fdd-e842-4830-8cf6-6d95a8889ef8"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("cdc126c2-d1ba-4329-a212-dd6befd9ed8a"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("48c63618-e4b2-42c3-bc17-1bfb599722e5"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("49cddba2-9213-4574-b70c-7004f57eba2e"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("c1a75e8d-3fb0-453e-8805-d7717f8f2624"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("c75ac7ad-96a9-43c2-8518-61350d729956"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("da9d27ef-5443-4c53-a98e-50e4709f3a20"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("f2f38c81-09ad-403c-a078-ef00248c2daf"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1602c566-349a-4fa3-956e-df3ccc531558"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("3c77f67b-806c-4042-bb6f-98efb87b5c5a"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("c0581d1d-2bf6-4909-88b7-2d1bc87e9347"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("f3929b9b-d0e9-4aad-b467-b3529a2ef7e3"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("0d252a00-6de4-4bbd-8215-c83c2f865582"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("1eb98d03-7bef-41ff-8ea4-4290d92a640b"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2216d7a7-8cfe-4e82-ae09-9a2899adde93"));

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("30267878-8fd7-42bd-9285-3f7ed8566d26"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(2504), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" },
                    { new Guid("96ecbf25-0ab3-4d2a-b0d8-426eb62639fc"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(2201), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("77bfc02f-0b7f-4a56-8b47-21cfc4113665"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(1705), null, "03243HSESEiIaEDXhSVUb0KZrC2sfXsxy1KRy/+TOm0tJynhWzKMn9RQSaMbnsssCYyciQbLmj/VWdqCUryXwUcnEEN7yTdCid2MtoD0n14MGGEuxoqBwtkDkNKtH1LCvm8rcK3eK9/QF+oLx3Wopqrccewv3HlqKyE3Gr5eNDC4kfxltFBGcDeIihZjnrJAAO9tgVOuAcSL1yOOzgcJD7fqNRp/LieaNi0X3qNzlblVB3Naq5ts+ROni5fOEirzUJA8u/wwMREAe0ggHH2TxoYARV4yzPPeLE1cgz54J/TzMw9f92H4oIZHlL/ZMzDRqU6EFog3ZHPprDX2UEUvEUDpRPBHBvG+Y9pzbvXyW7skqEeo6Ki4s1X05mwB/mk4tfXrIs3egPRqzzPFbG2IxYafttoH0EUxUSaOt8m+Mlbz9H5Te+GfkoDz3XSC/3uCH9iR1Ud5v2baVZprKnCWgLAUIkUmWc5nSqBU7Dq+LS8UCsEGHs75CFFexMGszOvXTIv7YAs/JPmQ2IbRs4HOke8odoIPtmlUVxPQD/6+YddlbRZLvEh5ZUJEddrFFByLDCuFapEoRyrn0aHBJSjX9pXy/epDUp5jcvd3dSIaGAI1N/4fj5FBeYvsMJnHgz9AUzmtCYMe7dhvgIVQasu96u9KDjVmHjdqEprXm93r1PM=", null, 1, "0e45eaf0-22e3-4944-96d4-0d1ef6ac68d2", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("80c7a6d4-0739-4fb6-8d91-0baf648d035c"), new DateTime(2022, 11, 21, 23, 20, 15, 526, DateTimeKind.Utc).AddTicks(632), null, "kjejgNX9rMZ1lP7jGvkRnnl81kX80svyeMv0rDdoz6QPnDvJstXD2/ru1L1mJ7/Vv3i1VeFqP+A1LUPAZRa9GDT06N4w1YkSZgQEspueRbXgQFLnlbxi4d7y/HCy4B8VFVl7NRPhMtmbKfJ0TldBxDPAAdVz6G5WhUDWcciR/nJwBhlY9UPM0PfW1BFVkeG3CmnNaQoMEEmrq6EmuisA3yb0zHNG1o/CLeF8G0L9YXdQplglwCqSB6yjiXa5NBO8r6SqvQcbAuNhB+RQB3g42X27MhmdYKiikV4ZuT4WoURE5/agTaMwvrajC9Ar5tVocVqo3qI8Ac1TDl/g9yrcmcQh3Qwz6cALT1V2I2OfrJIkcY+Z4c2QfXz0HK4x/RKl8mTQx9k50AqLOQzkhzEo3y8j71qKIHx46WEQnQNEANluqfMh0tb0HY5TyTPlniP7w3eYiIdfc6GQUpcvqgc7msR/o+UGMWlAmX9k/3y/wy7xYL8etTpGMMEmujQ7j2/4vxhuUbKLFJDKZ/FVDOXNV4KHAsA0RSLH5DGJiFKPAzjm99hYlpQr5BvKcEJ9YaZ8q0qthYqXdwdLZ2zSLXpE6IAS8iu0rIq7nsKTKKWkOEx/286YDRM2lzQMwj6hqstfQhl5iHVxnJAv/K+MGACTpe7wSnXXANkKNnowf+oIgaM=", null, 3, "9de82ab9-7228-4d96-9bd4-27a9edde65df", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1f8c5a1a-0a9f-4173-b150-1bb307106fd4"), 20.0, new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3505), new DateTime(2022, 11, 22, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3501), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("96ecbf25-0ab3-4d2a-b0d8-426eb62639fc"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("2d803294-eaa2-42f9-924c-0e13da8fcfd9"), 20.0, new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3649), new DateTime(2022, 11, 28, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3649), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("30267878-8fd7-42bd-9285-3f7ed8566d26"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("ddc0f969-fb67-4e79-9d2b-ccbf945c918d"), 20.0, new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3594), new DateTime(2022, 11, 23, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3593), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("30267878-8fd7-42bd-9285-3f7ed8566d26"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("03b7a2e8-4a52-4ef3-ae85-45045c6ec012"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(2695), null, new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(2694), null, new Guid("96ecbf25-0ab3-4d2a-b0d8-426eb62639fc"), 1, null, null, false, "Cardápio de vinhos.", "Wine" },
                    { new Guid("d8ea239a-16c7-4e5c-a1c1-c2c28225a302"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3026), null, new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3026), null, new Guid("30267878-8fd7-42bd-9285-3f7ed8566d26"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("dc7a44a0-f7bb-4bce-8eeb-7f416f5857a4"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(2838), null, new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(2838), null, new Guid("96ecbf25-0ab3-4d2a-b0d8-426eb62639fc"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6e431981-570d-4703-a43a-3c489dd8e15c"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3283), null, new Guid("d8ea239a-16c7-4e5c-a1c1-c2c28225a302"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("ad3a867d-843a-4362-9e5d-fa6b66ca4d90"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3232), null, new Guid("dc7a44a0-f7bb-4bce-8eeb-7f416f5857a4"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("af426a4d-7cda-4b29-9de0-69c98738abef"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3337), null, new Guid("d8ea239a-16c7-4e5c-a1c1-c2c28225a302"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("cefbe61d-678e-4d85-909b-44e4235c3e21"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3142), null, new Guid("03b7a2e8-4a52-4ef3-ae85-45045c6ec012"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("d2f5f4ca-946f-48b9-855b-1a35245e6342"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3385), null, new Guid("d8ea239a-16c7-4e5c-a1c1-c2c28225a302"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("d52490d6-5e97-41b2-a70c-c9ee2f6d6b6f"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3436), null, new Guid("dc7a44a0-f7bb-4bce-8eeb-7f416f5857a4"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" }
                });
        }
    }
}
