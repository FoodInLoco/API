using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class addBillOrderTable : Migration
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

            migrationBuilder.EnsureSchema(
                name: "Bill");

            migrationBuilder.EnsureSchema(
                name: "BillUser");

            migrationBuilder.EnsureSchema(
                name: "Order");

            migrationBuilder.EnsureSchema(
                name: "Table");

            migrationBuilder.CreateTable(
                name: "Table",
                schema: "Table",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Table_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalSchema: "Restaurant",
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                schema: "Bill",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    TableId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    BillingStatus = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bill_Table_TableId",
                        column: x => x.TableId,
                        principalSchema: "Table",
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillUser",
                schema: "BillUser",
                columns: table => new
                {
                    BillId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillUser", x => new { x.BillId, x.UserId });
                    table.ForeignKey(
                        name: "FK_BillUser_Bill_BillId",
                        column: x => x.BillId,
                        principalSchema: "Bill",
                        principalTable: "Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillUser_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    BillId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Message = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Bill_BillId",
                        column: x => x.BillId,
                        principalSchema: "Bill",
                        principalTable: "Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_MenuItem_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "MenuItem",
                        principalTable: "MenuItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("3a1ff367-3013-4a81-9118-7c9df5f13f24"), new DateTime(2023, 5, 28, 0, 24, 26, 246, DateTimeKind.Utc).AddTicks(7914), null, "mpmsJ2kVXD+7zbGnn/LAjUNHJ5Pbto8WWSb6s4g30324iTEltrEwz4s/UuKfOm9AKXdnqh8/e5MitRZotOU84l7ue4+Cm5vEE0lhd85dTS+OBqq7qwR7uhGz70ieOeER94kyxIrW11EMV4NxZ62Ip0JzAhvCntV5Ar3GcSob3tAT3xa/5wf+yFclzsCaFMdApgBCdcKKW1fDY8hbjhBB4MijievjxdKHYG6m0re7rD1c4pdnoO7FzrabBo+L5c/As0ixxatFy5gdcX8VtpdpMv7DuP1eYMe9mbPbrceBY0LMYMlECQhi8AjSz0cK+FHWeZJsXseQyH1Fwz7L7mJPUBdp7K30bwAgLdLlPYxtq153rg/Pb3eKYkykDU4eTPNpxhEr4+/G3nVEF0m6X1E1rCK7I/xSsuw+1AQ34JGizYaPTQ9WiElIMBNse9ZHYtqTgHtvGk/lCBBDwJfibHnxbvLPeT17sZiDedKrEXmvZe+wmHqzyaJMnrCaIunWM+7H4GkHpndP87Gq9tise+XJx5na36l1zTvXxOO5ZmL6d6IGgonjvSBRzAQ+0YULx87xSnXWUG9HoHRRriCWi2JYPyUijJ+/Yqs2dgXQbGaeDRouHKzjFf4ECjnIwXL+ar+1We4+Ti8VLL/XJ1bHqQ8nP9gcfcev9ck32gKlQhSYZIA=", null, 7, "7c337e37-5863-4207-9241-275c04bd0079", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" },
                    { new Guid("964b7b6a-324d-4eac-b33d-576dc188fe24"), new DateTime(2023, 5, 28, 0, 24, 26, 368, DateTimeKind.Utc).AddTicks(8638), null, "jYP1Pgx2mluRaVxIw5oMtq2Wd4ZqRBczrmmyX40WPxKpbXPaQwu6T9AzKO7yRpqIRkGG8RtbkXGE6l2oHrp5Lbml89f/gweauR4I3NCWlvncP0XGESMNt23ew/CR2lFjP7jlapLBuugkcJLo7hCFzRgxEg4bn8yddNU+ArOjRLl9kTe96v3QhFqtyO+D5KbRq3umF3MUfFY4Ekq2I4DFpvJteopr+pzJVNOk8mTokHPf2rqoOvL/f3moq6eob5h4dIzmJhE8IVo3RmVWEGcpaNlYjqiw5Oo8yHhK6kPeegwgp2RioQ+4NPVX49yWXAfLEvHPuvpJ5wadAJ3JEIRc1vkiEVaSrUO1/C1rbehkhDLrM7cF5dKMpNqHJKLTMba465FIyeUgT+GxdRX3MrsaNTYSSEyPW8UN7R7CHewSB9olSKXpWRgnAjp4ROHpNygBEFu0TgbAgYn7puU2bWUbNV5IB1rOi1l6Rn8GvXeAi1zlo/tG8+WmKmu7w5flcAHE1AgfYcdgVqQOW4rUYfeH+S3342rBaeQNMnfR9vPn1pWdpnni35Oov9QDmXJIDnFIfgCK2dqskb8SnEIX8mGGwgoEtz9NuOFVYge1hNtaGKM+kcZvFW3inQtQhWZtaHPWABvkIE32RvBX0iOlbXGpNUdvKljVprMZA0zEJNX2gnI=", null, 1, "1faa05d4-1d12-48bd-a3dc-fb7f29de4b90", 1, "85", "999174742", "gabrielevaristovcp@gmail.com", "Gabriel", "Evaristo" },
                    { new Guid("de190574-dd9a-4d50-b5ec-baeb92fa83b4"), new DateTime(2023, 5, 28, 0, 24, 26, 307, DateTimeKind.Utc).AddTicks(1285), null, "j4TgY9Nj1gt3BIwKoo6sqlSMyXAFJoJdZ/LPnWS9O4VaaLOnljge7f2JhzVdx72A3ebz2deima8X8Vj999XRa+2M9YS30sdXeP5v/8QPLrIK3wysyIeAcstAFlT9siS6G+qkfBhBDaaPLzZ1ccifsuwFvJtDWjYF6VjkGLmFICC/Y+n9rcolDKaxQl4ax/lqqIeszvQvkznqbvXqqYzQyJALxCwoLLeQ3WRIcEfPmeQhY18bsIq4ze0bQgK7UQvyy27YcX6ahsjy35Iwqf9kMOsTw1ThVPk6RSyvE/z5q0k3CZHM4rqS0B4oPOYYoZ4daInXLrsh1yUe70navy9emzT6/brN0ttZtlg+rlmZE13rDoUci/AyCNa8smkrOF8Jn/4egzwTIWRBQgl7LIbaUNR6WmT3J29Jx77uv4gLEdjMHpE57ymJqZPZ5vtybQk+UJwDId4fgqFqQPXZiAQ+lXWJs1yUjTvqGq4lTjFCYHirhjgD1PVQRwU4bTIpyydfMqkrfULkjQsdZ50+xypkf6XF0RtvKLV7L4h3kC9gqeUZQOaO8xcny3ImQbR++IdXgbP+TTr8569ChAGDCuE/OU5iUyWenlYGNOZF2NVWsQTMKzNH2rGYb4FyDCm3BuF7JF5IZRO0A08nXe94Ip4oKmZGdPZCsuVVCWM893eKz0U=", null, 1, "72aa4e23-b040-4119-b1c9-1763e2712620", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" }
                });

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "UserId", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("8d420721-f914-4a00-8c3d-c83cb83b1570"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(955), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, new Guid("3a1ff367-3013-4a81-9118-7c9df5f13f24"), "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" },
                    { new Guid("ffca0fdd-b31c-4fea-b18e-fb3021a4577e"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(192), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, new Guid("3a1ff367-3013-4a81-9118-7c9df5f13f24"), "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("59f75798-646a-42bf-8d61-bc1506d3ce4e"), 20.0, new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4431), new DateTime(2023, 5, 29, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4426), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("ffca0fdd-b31c-4fea-b18e-fb3021a4577e"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("f5a0a4a0-5062-48dd-b920-c25d80452605"), 20.0, new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4552), new DateTime(2023, 5, 30, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4551), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("8d420721-f914-4a00-8c3d-c83cb83b1570"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("f6992de0-e6cf-4d0d-b099-9e204ee5acd6"), 20.0, new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4620), new DateTime(2023, 6, 4, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4619), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("8d420721-f914-4a00-8c3d-c83cb83b1570"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("15968327-5349-476c-bcfd-a760913a23ce"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3684), null, new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3683), null, new Guid("8d420721-f914-4a00-8c3d-c83cb83b1570"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("55321c95-66a8-490b-91f2-f269e419abec"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3051), null, new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3050), null, new Guid("ffca0fdd-b31c-4fea-b18e-fb3021a4577e"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("6aaf7dd2-3edf-476e-99eb-5ce14b671733"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3282), null, new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3282), null, new Guid("ffca0fdd-b31c-4fea-b18e-fb3021a4577e"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true }
                });

            migrationBuilder.InsertData(
                schema: "Table",
                table: "Table",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Number", "RestaurantId", "Status" },
                values: new object[,]
                {
                    { new Guid("050b7cc5-3f90-44be-b38b-1319379732bd"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4707), null, 2, new Guid("8d420721-f914-4a00-8c3d-c83cb83b1570"), 1 },
                    { new Guid("1bbdb507-d40a-4a65-b480-40bccc806f28"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4698), null, 2, new Guid("ffca0fdd-b31c-4fea-b18e-fb3021a4577e"), 1 },
                    { new Guid("6567c8a4-0067-48a1-8557-1ba402badb8c"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4693), null, 1, new Guid("ffca0fdd-b31c-4fea-b18e-fb3021a4577e"), 1 },
                    { new Guid("8c7cea46-a3d8-41b1-b6f2-1e27bba2a8db"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4702), null, 1, new Guid("8d420721-f914-4a00-8c3d-c83cb83b1570"), 1 },
                    { new Guid("cf89c4d3-bb2b-4bc7-af50-4f2f11835554"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4700), null, 3, new Guid("ffca0fdd-b31c-4fea-b18e-fb3021a4577e"), 1 }
                });

            migrationBuilder.InsertData(
                schema: "Bill",
                table: "Bill",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Status", "TableId" },
                values: new object[,]
                {
                    { new Guid("223c9e9a-24c0-4479-86b6-1c5f7dd969c3"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4729), null, 1, new Guid("8c7cea46-a3d8-41b1-b6f2-1e27bba2a8db") },
                    { new Guid("db3aa74f-9977-47d0-a62c-5b19f102394e"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4725), null, 1, new Guid("6567c8a4-0067-48a1-8557-1ba402badb8c") }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3bc25564-64f6-4284-80a8-387ce51922c8"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4343), null, new Guid("6aaf7dd2-3edf-476e-99eb-5ce14b671733"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("5e1037ff-0526-4c07-a605-85f74302bf60"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3975), null, new Guid("6aaf7dd2-3edf-476e-99eb-5ce14b671733"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("6e01e40d-4b22-42b5-a597-f5345304e5b5"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4047), null, new Guid("15968327-5349-476c-bcfd-a760913a23ce"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("c242215a-5f3f-4c24-a19a-03e9b106c2b2"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4122), null, new Guid("15968327-5349-476c-bcfd-a760913a23ce"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("e8816335-7443-4c6b-b391-4034f7ee63b8"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4273), null, new Guid("15968327-5349-476c-bcfd-a760913a23ce"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("fd71d070-db49-40a9-abc2-7e37accd3b4e"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3843), null, new Guid("55321c95-66a8-490b-91f2-f269e419abec"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" }
                });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId" },
                values: new object[] { new Guid("223c9e9a-24c0-4479-86b6-1c5f7dd969c3"), new Guid("964b7b6a-324d-4eac-b33d-576dc188fe24") });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId", "Status" },
                values: new object[] { new Guid("223c9e9a-24c0-4479-86b6-1c5f7dd969c3"), new Guid("de190574-dd9a-4d50-b5ec-baeb92fa83b4"), 1 });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId" },
                values: new object[] { new Guid("db3aa74f-9977-47d0-a62c-5b19f102394e"), new Guid("964b7b6a-324d-4eac-b33d-576dc188fe24") });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId", "Status" },
                values: new object[] { new Guid("db3aa74f-9977-47d0-a62c-5b19f102394e"), new Guid("de190574-dd9a-4d50-b5ec-baeb92fa83b4"), 1 });

            migrationBuilder.InsertData(
                schema: "Order",
                table: "Order",
                columns: new[] { "Id", "BillId", "CreatedAt", "ItemId", "LastUpdatedAt", "Message", "Quantity", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("08a45035-2824-4b9b-93f0-c53933365887"), new Guid("db3aa74f-9977-47d0-a62c-5b19f102394e"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4776), new Guid("fd71d070-db49-40a9-abc2-7e37accd3b4e"), null, "Completo", 1, 1, new Guid("de190574-dd9a-4d50-b5ec-baeb92fa83b4") },
                    { new Guid("18ff6a3e-b7c6-45ac-aa05-e85046fe381d"), new Guid("db3aa74f-9977-47d0-a62c-5b19f102394e"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4781), new Guid("5e1037ff-0526-4c07-a605-85f74302bf60"), null, null, 1, 1, new Guid("de190574-dd9a-4d50-b5ec-baeb92fa83b4") },
                    { new Guid("25e96f3f-e7b1-4d5f-a68f-bc322527daae"), new Guid("223c9e9a-24c0-4479-86b6-1c5f7dd969c3"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4786), new Guid("6e01e40d-4b22-42b5-a597-f5345304e5b5"), null, null, 2, 1, new Guid("de190574-dd9a-4d50-b5ec-baeb92fa83b4") },
                    { new Guid("41e80155-23cd-4704-bf5f-961c87576cf7"), new Guid("223c9e9a-24c0-4479-86b6-1c5f7dd969c3"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4788), new Guid("e8816335-7443-4c6b-b391-4034f7ee63b8"), null, null, 1, 1, new Guid("de190574-dd9a-4d50-b5ec-baeb92fa83b4") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_TableId",
                schema: "Bill",
                table: "Bill",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_BillUser_BillId",
                schema: "BillUser",
                table: "BillUser",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillUser_UserId",
                schema: "BillUser",
                table: "BillUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_BillId",
                schema: "Order",
                table: "Order",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ItemId",
                schema: "Order",
                table: "Order",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                schema: "Order",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Table_RestaurantId",
                schema: "Table",
                table: "Table",
                column: "RestaurantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillUser",
                schema: "BillUser");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "Order");

            migrationBuilder.DropTable(
                name: "Bill",
                schema: "Bill");

            migrationBuilder.DropTable(
                name: "Table",
                schema: "Table");

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("59f75798-646a-42bf-8d61-bc1506d3ce4e"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("f5a0a4a0-5062-48dd-b920-c25d80452605"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("f6992de0-e6cf-4d0d-b099-9e204ee5acd6"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("3bc25564-64f6-4284-80a8-387ce51922c8"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("c242215a-5f3f-4c24-a19a-03e9b106c2b2"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("5e1037ff-0526-4c07-a605-85f74302bf60"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("6e01e40d-4b22-42b5-a597-f5345304e5b5"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("e8816335-7443-4c6b-b391-4034f7ee63b8"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("fd71d070-db49-40a9-abc2-7e37accd3b4e"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("964b7b6a-324d-4eac-b33d-576dc188fe24"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("de190574-dd9a-4d50-b5ec-baeb92fa83b4"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("15968327-5349-476c-bcfd-a760913a23ce"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("55321c95-66a8-490b-91f2-f269e419abec"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("6aaf7dd2-3edf-476e-99eb-5ce14b671733"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("8d420721-f914-4a00-8c3d-c83cb83b1570"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("ffca0fdd-b31c-4fea-b18e-fb3021a4577e"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3a1ff367-3013-4a81-9118-7c9df5f13f24"));

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
