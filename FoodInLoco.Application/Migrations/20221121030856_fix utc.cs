using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class fixutc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("42a92b4f-d4a3-4ff9-9c5a-c324a2feac9f"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("49773b36-040d-4290-af9b-72bd2e940168"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("5c21fa8a-5617-435e-92b6-1ae4ec11d0e7"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("63fd82a8-0b4f-486a-b0a5-61d2d5685788"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("8bcf5a95-57d2-42ae-ba37-4909af752d3c"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("9b9d68ff-6971-4ea9-b72d-ee8c5a74d93e"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("51dd88b4-f130-422f-a0ca-255821721741"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a2f46912-0583-4662-9c75-221a841e6bef"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("abfe87a4-c2fe-4987-a1da-50a57afc8744"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("df56ba80-2cf7-4806-a76b-f4dbec5fd60c"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("f656b199-3375-4861-8bea-cc87bc8a1e28"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("39a10ac3-803b-4154-a84a-002c4ff2e4c4"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("b7056268-0c3d-4e3a-8a0b-250f46f05a11"));

            migrationBuilder.DropColumn(
                name: "InsertDate",
                schema: "User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                schema: "Review",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                schema: "Reservation",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                schema: "MenuItem",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                schema: "Menu",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                schema: "Attraction",
                table: "Attraction");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "User",
                table: "User",
                newName: "LastUpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "Review",
                table: "Review",
                newName: "LastUpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "Restaurant",
                table: "Restaurant",
                newName: "LastUpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "Reservation",
                table: "Reservation",
                newName: "LastUpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "MenuItem",
                table: "MenuItem",
                newName: "LastUpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "Menu",
                table: "Menu",
                newName: "LastUpdatedAt");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                schema: "Attraction",
                table: "Attraction",
                newName: "LastUpdatedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "User",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "Review",
                table: "Review",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "Restaurant",
                table: "Restaurant",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "Reservation",
                table: "Reservation",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "MenuItem",
                table: "MenuItem",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 21, 0, 8, 56, 187, DateTimeKind.Local).AddTicks(8246),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 11, 21, 2, 38, 45, 976, DateTimeKind.Utc).AddTicks(7941));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "Attraction",
                table: "Attraction",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "Kids", "Photo", "Status", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("71ba77a6-9ea0-45c6-814c-75daeb3e84a8"), true, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" },
                    { new Guid("faadc5f2-e5d4-4b2a-973b-b74f6f32f4e2"), false, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("79ec73dd-a182-4924-ba9d-16005d681cf7"), "n2x5cZGxCakIq5NKhUuwxCaaxRO3hso0kh0DX7iiZN/s0HU9EK8RQ3bwAR5nFYAj814Zwybm+msaEy2XwsRZCFDgDI4COCj5O09TP82a6vUL+09NtFFd2mQCNqwy6qswumQjGbstirlY8JBDWhs0X0e7Mn2HIR10aXhcr2pMddfq578+a2TbcnH7raz35oJPw/UMmKveuZnolY5vZr/uOsEigZ94N0xcfFs2eQDwyl8F3d9cjNnIe+FrJI2dzc8BB6KqS4PAPhg9DsiFUpooxzqxyiQeb4BVUemE8oc7iyWZXln4QFKIOzWxRwacpoo1TJ5au+kfnMYKnasC7OD3kChUzUi/0DDKCLBPNYHiaaHO3xeJEyN//MpeK+J9Q3AY4kCC5iPKLQfyQRVVG039fwjJ/oBfJtPlSriFfhSl+WKCgAZ80ympoCli//CAaUFd9Q3sVzHB+9X6qskIZdmFKeHxz/NvW9m0aqpQ5CzrybqUiRMlcTmcmi0FeRFwOi1UerQ5xwdV/fvxHojGCmh5gJxJvrEBxvljq4jYxbv4nxjRgizlN48/mq2NbkVQIYT2GQohwlL78yemrfrxop8SWpP8ZEyJtNlN5TsXwnYtl3rwnQxbfthqG2AG22inhM4SAcBVw8JeUITwF5fgWNCsFdVrQo52j/3WxKEbej0VGBc=", null, 1, "1202335f-76de-45dc-a833-334d06914830", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("bec395fa-1dde-42a8-9820-204b9c68c4d2"), "kneeOJSM8tTQwEUlndMPoPt/N4wtMim734wrpA6AGRrS+wztaFdlAUmjD0R1uxcpVRcqhBCELPzhGFlNS9WtUPGpX1x4kZFBg1LXZWApw5upR0kBZrNtBIvZEnbSIUFhPIg1BYybLsJHjmpwRGClUrc+cVUXqN+S0pArjp+D/rijDhhAXvGFm7jlMQNlmFrkdo556Q1SdzYBrsGSZD5Ufx0jSiH1/S1KstYR0O9lCJG+6I3+3uQBuw+8bWZozyOyluv/ni2nOtTSSCZw7T63kH8qfPR86mowauLgp1NNFhzXyHRI4u61YoTrQQL1DmxEajWTJF2Z9h5wjnJAfm/Xmzu6VJTgeYcYdWTmA2Q6S7W4ouSjqVBiEjT31VFqW8DVOdBQSuIftOg/q2ac8wV2LA/4V84Krha+OshB5AX9b4HxJBbGV4dHtg5d2uYUzy7OKKBU6OCrMDhg8CdPLxLXMy7S1jUCJacjF6C8bDjYuDdJ0c+Fpuon9XTZIkaNc75JOo7hDXQaYW5XgtQdTUaw4zDWubAYkvkK+YWHop5C7QW4w7DKSB0D4CBYwYFyKqEvGmpCY4epE/1ZJeSOle8da+cp+naf4mUh6Br1t1AXloWmGxaarAiPxnuzRcceNunjzTlJZuAgcs7YDfqn7ranGPqJtSvQ9oK447e5nixLtdg=", null, 3, "a40a6f23-0f12-464d-9d0d-9b79f922208e", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "ExpirationDate", "InitialDate", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("2cb7bc6e-0967-43cd-b9b6-f0079ac8c2f0"), null, new DateTime(2022, 11, 21, 0, 8, 56, 346, DateTimeKind.Local).AddTicks(9289), new Guid("faadc5f2-e5d4-4b2a-973b-b74f6f32f4e2"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("56fae501-79df-44f8-b354-1d8e25fb4c11"), null, new DateTime(2022, 11, 21, 0, 8, 56, 346, DateTimeKind.Local).AddTicks(9615), new Guid("faadc5f2-e5d4-4b2a-973b-b74f6f32f4e2"), 1, "Cardápio de Happy Hour.", "Happy Hour", "20:00", "16:30", true },
                    { new Guid("b782fa8c-484a-4971-9b09-79e5563e5d8f"), null, new DateTime(2022, 11, 21, 0, 8, 56, 347, DateTimeKind.Local).AddTicks(82), new Guid("71ba77a6-9ea0-45c6-814c-75daeb3e84a8"), 1, "Cardápio de Happy Hour.", "Happy Hour", "20:00", "16:30", true }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1f9d9151-a955-4e42-b120-59a528e5be99"), new Guid("56fae501-79df-44f8-b354-1d8e25fb4c11"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("6aee3b72-2532-4b4d-a62f-d129f4c2ca05"), new Guid("b782fa8c-484a-4971-9b09-79e5563e5d8f"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("b842079d-f0ab-4f32-ba21-59ab9cc371f0"), new Guid("2cb7bc6e-0967-43cd-b9b6-f0079ac8c2f0"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("cf8559da-40cc-4c22-ba61-97123725e441"), new Guid("b782fa8c-484a-4971-9b09-79e5563e5d8f"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("eba6037c-2a99-4410-915c-ab5145a02a8c"), new Guid("56fae501-79df-44f8-b354-1d8e25fb4c11"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("ff92d56a-c9be-4489-9c7e-48f7485cb2ec"), new Guid("b782fa8c-484a-4971-9b09-79e5563e5d8f"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("1f9d9151-a955-4e42-b120-59a528e5be99"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("6aee3b72-2532-4b4d-a62f-d129f4c2ca05"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("b842079d-f0ab-4f32-ba21-59ab9cc371f0"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("cf8559da-40cc-4c22-ba61-97123725e441"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("eba6037c-2a99-4410-915c-ab5145a02a8c"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("ff92d56a-c9be-4489-9c7e-48f7485cb2ec"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("79ec73dd-a182-4924-ba9d-16005d681cf7"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bec395fa-1dde-42a8-9820-204b9c68c4d2"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("2cb7bc6e-0967-43cd-b9b6-f0079ac8c2f0"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("56fae501-79df-44f8-b354-1d8e25fb4c11"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("b782fa8c-484a-4971-9b09-79e5563e5d8f"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("71ba77a6-9ea0-45c6-814c-75daeb3e84a8"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("faadc5f2-e5d4-4b2a-973b-b74f6f32f4e2"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "Review",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "Reservation",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "MenuItem",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "Menu",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "Attraction",
                table: "Attraction");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedAt",
                schema: "User",
                table: "User",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedAt",
                schema: "Review",
                table: "Review",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedAt",
                schema: "Restaurant",
                table: "Restaurant",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedAt",
                schema: "Reservation",
                table: "Reservation",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedAt",
                schema: "MenuItem",
                table: "MenuItem",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedAt",
                schema: "Menu",
                table: "Menu",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "LastUpdatedAt",
                schema: "Attraction",
                table: "Attraction",
                newName: "UpdateDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                schema: "User",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                schema: "Review",
                table: "Review",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                schema: "Restaurant",
                table: "Restaurant",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                schema: "Reservation",
                table: "Reservation",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                schema: "MenuItem",
                table: "MenuItem",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 21, 2, 38, 45, 976, DateTimeKind.Utc).AddTicks(7941),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 11, 21, 0, 8, 56, 187, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                schema: "Attraction",
                table: "Attraction",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "Kids", "Photo", "Status", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("39a10ac3-803b-4154-a84a-002c4ff2e4c4"), false, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" },
                    { new Guid("b7056268-0c3d-4e3a-8a0b-250f46f05a11"), true, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("51dd88b4-f130-422f-a0ca-255821721741"), "LkQ7zspIqQVofrFmaVy8qXSy71OId8BPeGYsSiBXNPkFNNLCIJJDKppYIufR7D3b164dVEmLGgNzFvjO9ZQ6kGVayiwOV4vYFlVrmKU43WNDbrYBVA5goGdG94/TBzxjz9DzYaW7IWj4/N5el1knNmfn+HrVR9xZcp6hz+g7VKNA7uLRBubpVlA4YHRdPIF3wDpxIGD5F4KnM9g5oJ/fk9FTxSuMGw6IqEYw1P5UyRTzAXBOiJazu0DzVroabXXSm5j44YiNx0NEBvE7nzaCjMQfOnFu9kjaBDiPvVMIUL30aOvIHv4/QwIRIxFKJ2ah/1JmycPZ+3Otp2H+/4h5gZO1y2Hqu6gJXQFv4J/10WDQm1mWu/Xh6z+6knUQwd+NOynP8OoOZQFAYKUDK+VQByb07WtYwl6ykLtUioTZsa6AhmxProjORfUCMcjA2XdNouEFf0Z2iAS+NnGOqMFzTubmQVRnoA1yRpxzzSlHigJwQ18IhApiu/uk7iZSdPvV/f7nBdNXBP2u98Jl3BedCJ7RgXUEI6wfW6+NLAX6mRrxGYdJ0YPzw76iP5eeKoKqacU9qLcref8tJFj0gAi/XCxkPSocf5JZMHIlqpUThpQnLUbm+rNXvxNG+wtD9lrOzqJ5PYp/9qipWFzZUnkja8sPbJzamq5V67A0/UPpJtI=", null, 1, "a988d31c-0c26-4adb-865a-287231f9e7f4", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("a2f46912-0583-4662-9c75-221a841e6bef"), "D4Qscyv8ph+YO/8/wQM9uXiY5eRaY/0i6Um5HWGREmjbuAFdaXMM0/RqoyLuBrlAxABmYpFIJknBkJS8qU3X9sbJtCIgeCgrfoNnngoreMo3YrXFlzQRI4AiSPuyL0O/EVV+2dwYtiPyMJlUw+NJBCnbK162d2DSStv2xHWFPDCTnUNVNdUbpecipj0O1f+jj9Fc6COGEt142jklhja+sRieoNNkQLFu0NkCsAXAnmHSI2D7qk6Prh8G6xfgC9w3gn3ZMlkxggg5Pj6tVSQFISR3Mlm2/xTVs3pj1D8+3iaCQPsWSAkOo1B/YbGRKxbai2xEObqQwxQXnyd/uwfFVQyVjP3s3jnT2vwZouHgDaai9b391AR5In7joKGwzUq3kNXpnOHYoSZ+CeUAH0t2bestUcV4Nul8TX7ln8WWSqAmEQ7m8Uh0YMIhIAVAKhH0nfGN0z/Jc4n1IlVdKnQNHrWJ3p/7h0v265iOK9ygbpdKYWInQ4jK/0tUpsPhZSBkdWCCPpTIv+fCiNeHtdUMj+HXlIwD3tuEVBMDe6gENp2nf1YdbpeX6a4qFRto44nKQLpKnXH56Qe3+OFW8g71jOjthIyB3chLMYBdkg/f/q1FujzspuvJS6lXGRQ6NgcK7FTE7PvHvKpcgQSOWQKqjdqAgbWw8blXoAqgbGlgZ50=", null, 3, "4247365c-7bb1-44fb-8062-685c22b560a3", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "ExpirationDate", "InitialDate", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("abfe87a4-c2fe-4987-a1da-50a57afc8744"), null, new DateTime(2022, 11, 21, 2, 38, 46, 107, DateTimeKind.Utc).AddTicks(3093), new Guid("39a10ac3-803b-4154-a84a-002c4ff2e4c4"), 1, "20:00", "16:30", true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("df56ba80-2cf7-4806-a76b-f4dbec5fd60c"), null, new DateTime(2022, 11, 21, 2, 38, 46, 107, DateTimeKind.Utc).AddTicks(2791), new Guid("39a10ac3-803b-4154-a84a-002c4ff2e4c4"), 1, null, null, false, "Cardápio de vinhos.", "Wine" },
                    { new Guid("f656b199-3375-4861-8bea-cc87bc8a1e28"), null, new DateTime(2022, 11, 21, 2, 38, 46, 107, DateTimeKind.Utc).AddTicks(3463), new Guid("b7056268-0c3d-4e3a-8a0b-250f46f05a11"), 1, "20:00", "16:30", true, "Cardápio de Happy Hour.", "Happy Hour" }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("42a92b4f-d4a3-4ff9-9c5a-c324a2feac9f"), new Guid("abfe87a4-c2fe-4987-a1da-50a57afc8744"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("49773b36-040d-4290-af9b-72bd2e940168"), new Guid("f656b199-3375-4861-8bea-cc87bc8a1e28"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("5c21fa8a-5617-435e-92b6-1ae4ec11d0e7"), new Guid("df56ba80-2cf7-4806-a76b-f4dbec5fd60c"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("63fd82a8-0b4f-486a-b0a5-61d2d5685788"), new Guid("f656b199-3375-4861-8bea-cc87bc8a1e28"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("8bcf5a95-57d2-42ae-ba37-4909af752d3c"), new Guid("abfe87a4-c2fe-4987-a1da-50a57afc8744"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("9b9d68ff-6971-4ea9-b72d-ee8c5a74d93e"), new Guid("f656b199-3375-4861-8bea-cc87bc8a1e28"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" }
                });
        }
    }
}
