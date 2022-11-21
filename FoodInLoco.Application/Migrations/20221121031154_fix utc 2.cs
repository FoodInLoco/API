using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class fixutc2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "User",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Review",
                table: "Review",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Restaurant",
                table: "Restaurant",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Reservation",
                table: "Reservation",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "MenuItem",
                table: "MenuItem",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 21, 0, 11, 53, 281, DateTimeKind.Local).AddTicks(7230),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 11, 21, 0, 8, 56, 187, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Attraction",
                table: "Attraction",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "Kids", "Photo", "Status", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("5c9b0659-938a-486a-8424-046b502974e9"), false, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" },
                    { new Guid("908693dd-3714-4674-9015-34321a8e263b"), true, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("0854ab7a-8271-4ef4-9dd5-230bdf918602"), "xacYFz3OZvFqSGbGtmrtuQbGyCRF3Cg7aNLeNgJhayLOpQIU3ecylKSePmz47GvdLMFbpMQwm+zRwJhu2mhR2821yj9iwfGt4kWQbXUChFlSa4vxaN8HS8OUQySgLnS9qdB0PKGfFScGWsboOivSt/2FD3I33YqskeUyg5H0wLwjostebEVG6jLUyGKGZpPO2cid66dC0Ux3s7/BD+A3nPreBFehxS62U/ZJE1MvmCX7S882iIpKTVZAUAPMd+CjyPlgqQ0pqj2624odOX7Ovz7HvcrSWBj7Weq4f7HJ+WQJzxEZkEssg1RvbClUky++VdJqIEC9dSPfE+14gvd8YRODd6wNLbmvWx4PNnE4220ncMSfR3lE78FcjALNZAUeTocsrJZWPhtRx1OYwVtr1wCwCDh3+LW+TouYa3YpRu+EgWx9z4Px+IWHBPUQ9fuPLv8aKw2J2WehYO1T7pKyXfi5oBHI+CapYEhrMZZqtT2OC1ZF5mO0UWSp4fdyHLtrWUpBf0SX8asYBpSZx7eilT6HO5K3OznHAXI/jnNp3FxmyQoxBsYr/RM1p0pKrIGxZ64EmgRuiKYuLVQVWIieG5dUg+JbSfRZZS6/0Cqf0F4Dq8D5N524JGHp5CgknxQgYSHPG3MLierS8yPbloQMr9rXjoWPIdoMyeifYoyxcQM=", null, 3, "c60e8af1-f66c-4a3b-8c67-f4edcf219f8a", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" },
                    { new Guid("c3416ab2-b50c-4e56-8d68-639b2dd2c05d"), "jmD0puYE06y2ea/wtgEMxIfsA5fUs5rP/0exo5hvnRl6K1oVhURb4dzWICmvZq9gxxgfBVGlO87vPum33EEm0kWCmyL0JHqmYMaKx7s9RxKR91zWlYfcJEsYkTMOBFibUIrGSaH/2I7ML5EWL//ZLpaxVbh+iHmEoIJKkraPJsWAQqvv2u6FBS+GCOhE6UVqPkLr5SWOzsqp6F0JpniO55587k/IkBQmBwWklLctIlJ1j+n04fU4oM7+XQdzXvh7+fLzY5mEj4s1VOmxwjRL33b7/pb3DLc7ezK7YjcOabsylxlWPsvtNAT5rwxBPAOzmIyhEaOUqiBW/1RpJLE23E8gc5A9zKB2kNM5b8KRjwU36qGcAL39FDhN5FstwBzAYyesCUbu7Tr16aoYXH6HRo3D52Lu85xa+PtZxE0Smlyi3RnfdWjOSDpjzTxDO6T6Jh0393stX48H6qvrv2HoJx+gizc7Y+4yv+qS8jipHbGNntVLBEW4PamSv7n4tqIAsXkT0nP358JQ3s3rkXfB9vv2WW2uMIaONfZivIkqh7CA5ghM1ut/i3Lf4EPGMjNEqbBju4vPpqsrz1fzpZdt+BzorYE5LUJxcsJycTyR0YtXBtTWO0DONeoMXftecLOVeF8TJkDxKlSX04VUdQY52DrtwTM69CQ3FB5VZGuHc+s=", null, 1, "c35e0a5b-af40-48f8-8ab6-6cf33106203d", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "ExpirationDate", "InitialDate", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("66088142-38a0-490b-addb-4943dd261887"), null, new DateTime(2022, 11, 21, 0, 11, 53, 514, DateTimeKind.Local).AddTicks(4809), new Guid("908693dd-3714-4674-9015-34321a8e263b"), 1, "Cardápio de Happy Hour.", "Happy Hour", "20:00", "16:30", true },
                    { new Guid("ad7b79f6-d6d9-470a-9da3-8ba077fc2e11"), null, new DateTime(2022, 11, 21, 0, 11, 53, 514, DateTimeKind.Local).AddTicks(2077), new Guid("5c9b0659-938a-486a-8424-046b502974e9"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("c132e8b6-6fb2-405f-a942-a737eb11d981"), null, new DateTime(2022, 11, 21, 0, 11, 53, 514, DateTimeKind.Local).AddTicks(2781), new Guid("5c9b0659-938a-486a-8424-046b502974e9"), 1, "Cardápio de Happy Hour.", "Happy Hour", "20:00", "16:30", true }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1c413564-4f6d-4e12-a463-e44d6afadf36"), new Guid("66088142-38a0-490b-addb-4943dd261887"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("63c2da29-e5ab-4c28-bfaa-51d353668387"), new Guid("c132e8b6-6fb2-405f-a942-a737eb11d981"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("7cd6a7d2-7cf1-4b08-94d7-940b79dc9436"), new Guid("c132e8b6-6fb2-405f-a942-a737eb11d981"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("9600ff62-3b8f-4e1f-8ed5-13eaabb22cca"), new Guid("66088142-38a0-490b-addb-4943dd261887"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("a44fe5cd-8c60-4064-adf4-c4c1e3ae51bf"), new Guid("ad7b79f6-d6d9-470a-9da3-8ba077fc2e11"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("ec889c58-6182-4808-a2a5-cdfa8d226650"), new Guid("66088142-38a0-490b-addb-4943dd261887"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("1c413564-4f6d-4e12-a463-e44d6afadf36"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("63c2da29-e5ab-4c28-bfaa-51d353668387"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("7cd6a7d2-7cf1-4b08-94d7-940b79dc9436"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("9600ff62-3b8f-4e1f-8ed5-13eaabb22cca"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("a44fe5cd-8c60-4064-adf4-c4c1e3ae51bf"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("ec889c58-6182-4808-a2a5-cdfa8d226650"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0854ab7a-8271-4ef4-9dd5-230bdf918602"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c3416ab2-b50c-4e56-8d68-639b2dd2c05d"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("66088142-38a0-490b-addb-4943dd261887"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("ad7b79f6-d6d9-470a-9da3-8ba077fc2e11"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("c132e8b6-6fb2-405f-a942-a737eb11d981"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("5c9b0659-938a-486a-8424-046b502974e9"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("908693dd-3714-4674-9015-34321a8e263b"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "User",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Review",
                table: "Review",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Restaurant",
                table: "Restaurant",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Reservation",
                table: "Reservation",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "MenuItem",
                table: "MenuItem",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 21, 0, 8, 56, 187, DateTimeKind.Local).AddTicks(8246),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 11, 21, 0, 11, 53, 281, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Attraction",
                table: "Attraction",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "Kids", "Photo", "Status", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("71ba77a6-9ea0-45c6-814c-75daeb3e84a8"), true, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" },
                    { new Guid("faadc5f2-e5d4-4b2a-973b-b74f6f32f4e2"), false, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" }
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
                columns: new[] { "Id", "ExpirationDate", "InitialDate", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2cb7bc6e-0967-43cd-b9b6-f0079ac8c2f0"), null, new DateTime(2022, 11, 21, 0, 8, 56, 346, DateTimeKind.Local).AddTicks(9289), new Guid("faadc5f2-e5d4-4b2a-973b-b74f6f32f4e2"), 1, null, null, false, "Cardápio de vinhos.", "Wine" },
                    { new Guid("56fae501-79df-44f8-b354-1d8e25fb4c11"), null, new DateTime(2022, 11, 21, 0, 8, 56, 346, DateTimeKind.Local).AddTicks(9615), new Guid("faadc5f2-e5d4-4b2a-973b-b74f6f32f4e2"), 1, "20:00", "16:30", true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("b782fa8c-484a-4971-9b09-79e5563e5d8f"), null, new DateTime(2022, 11, 21, 0, 8, 56, 347, DateTimeKind.Local).AddTicks(82), new Guid("71ba77a6-9ea0-45c6-814c-75daeb3e84a8"), 1, "20:00", "16:30", true, "Cardápio de Happy Hour.", "Happy Hour" }
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
    }
}
