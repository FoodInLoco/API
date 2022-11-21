using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Complement",
                schema: "Restaurant",
                table: "Restaurant",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("30267878-8fd7-42bd-9285-3f7ed8566d26"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(2504), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" },
                    { new Guid("96ecbf25-0ab3-4d2a-b0d8-426eb62639fc"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(2201), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" }
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
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("03b7a2e8-4a52-4ef3-ae85-45045c6ec012"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(2695), null, new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(2694), null, new Guid("96ecbf25-0ab3-4d2a-b0d8-426eb62639fc"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("d8ea239a-16c7-4e5c-a1c1-c2c28225a302"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3026), null, new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(3026), null, new Guid("30267878-8fd7-42bd-9285-3f7ed8566d26"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("dc7a44a0-f7bb-4bce-8eeb-7f416f5857a4"), new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(2838), null, new DateTime(2022, 11, 21, 23, 20, 15, 579, DateTimeKind.Utc).AddTicks(2838), null, new Guid("96ecbf25-0ab3-4d2a-b0d8-426eb62639fc"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Complement",
                schema: "Restaurant",
                table: "Restaurant",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("3b1a1f9e-d7c0-4912-bbcf-74680de49b81"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(6683), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" },
                    { new Guid("8cd2585b-c05a-4912-afde-fa5bee9ccdd1"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7004), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" }
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
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0d8b8920-8d7a-4bab-bcbc-9bdc08a12614"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7559), null, new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7559), null, new Guid("8cd2585b-c05a-4912-afde-fa5bee9ccdd1"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("5ed16fb7-58a8-4899-a58d-b63bcd67f750"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7198), null, new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7197), null, new Guid("3b1a1f9e-d7c0-4912-bbcf-74680de49b81"), 1, null, null, false, "Cardápio de vinhos.", "Wine" },
                    { new Guid("ec893660-cb27-44ee-9aa1-32384fbf1a9c"), new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7356), null, new DateTime(2022, 11, 21, 21, 49, 55, 218, DateTimeKind.Utc).AddTicks(7356), null, new Guid("3b1a1f9e-d7c0-4912-bbcf-74680de49b81"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" }
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
        }
    }
}
