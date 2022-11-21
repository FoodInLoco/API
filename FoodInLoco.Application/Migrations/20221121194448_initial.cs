using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreatePostgresExtension("uuid-ossp");

            migrationBuilder.EnsureSchema(
                name: "Attraction");

            migrationBuilder.EnsureSchema(
                name: "Menu");

            migrationBuilder.EnsureSchema(
                name: "MenuItem");

            migrationBuilder.EnsureSchema(
                name: "Reservation");

            migrationBuilder.EnsureSchema(
                name: "Restaurant");

            migrationBuilder.EnsureSchema(
                name: "Review");

            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.CreateTable(
                name: "Restaurant",
                schema: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    CompanyName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    TradingName = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    DDD = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: false),
                    City = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    State = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    ZipCode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Street = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Number = table.Column<long>(type: "bigint", nullable: false),
                    Complement = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Kids = table.Column<bool>(type: "boolean", nullable: false),
                    Photo = table.Column<string>(type: "character varying(10000)", maxLength: 10000, nullable: true, defaultValue: "https://img.freepik.com/free-vector/restaurant-logo_23-2147506959.jpg?w=826&t=st=1668952356~exp=1668952956~hmac=49402768c6b8d28e62ceaf62db752e285911d5b9ec57bb827b2118d98f046d74"),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    CreatedAt = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "now()"),
                    LastUpdatedAt = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    DDD = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    Roles = table.Column<int>(type: "integer", nullable: false),
                    Password = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Salt = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Photo = table.Column<string>(type: "character varying(10000)", maxLength: 10000, nullable: true),
                    CreatedAt = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "now()"),
                    LastUpdatedAt = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attraction",
                schema: "Attraction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Photo = table.Column<string>(type: "character varying(10000)", maxLength: 10000, nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "now()"),
                    Time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    CoverTax = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    CreatedAt = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "now()"),
                    LastUpdatedAt = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attraction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attraction_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalSchema: "Restaurant",
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                schema: "Menu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Photo = table.Column<string>(type: "character varying(10000)", maxLength: 10000, nullable: true, defaultValue: "https://menubrands.com.br/wp-content/uploads/2020/04/Menu-300x300.png"),
                    InitialDate = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "now()"),
                    ExpirationDate = table.Column<DateOnly>(type: "date", nullable: true),
                    HappyHour = table.Column<bool>(type: "boolean", nullable: false),
                    StartAt = table.Column<TimeOnly>(type: "time without time zone", nullable: true),
                    EndAt = table.Column<TimeOnly>(type: "time without time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    CreatedAt = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "now()"),
                    LastUpdatedAt = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalSchema: "Restaurant",
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                schema: "Reservation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    SeatQuantity = table.Column<short>(type: "smallint", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    Confirmation = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    CreatedAt = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "now()"),
                    LastUpdatedAt = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalSchema: "Restaurant",
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                schema: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    MenuId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Photo = table.Column<string>(type: "character varying(10000)", maxLength: 10000, nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<double>(type: "double precision", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    CreatedAt = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "now()"),
                    LastUpdatedAt = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItem_Menu_MenuId",
                        column: x => x.MenuId,
                        principalSchema: "Menu",
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                schema: "Review",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Rate = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    CreatedAt = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "now()"),
                    LastUpdatedAt = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Reservation_ReservationId",
                        column: x => x.ReservationId,
                        principalSchema: "Reservation",
                        principalTable: "Reservation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalSchema: "Restaurant",
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("9be02aa5-f544-4cd5-b0c8-361ce5288004"), new DateOnly(2022, 11, 21), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" },
                    { new Guid("e51a73e2-73cb-4f49-b112-ea3ea250beae"), new DateOnly(2022, 11, 21), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("01ee2e8e-609e-4234-88e9-85787e9a332f"), new DateOnly(2022, 11, 21), null, "O3o1Y/ISydCnCHzuE0Ls1tJ8nLSKiic/ySc5f8k6NEyDIB6RI2Ceo4rRv7K/bgbShXVODF8pr5WgOmqwlKW6fpKbfMbB1sOn9vlGJA3pzq++er9ZUtdxTsM7TaH0nt6VmVa+amzABVlD2XHLbTELWTX1sRLRX8Wp5RERovH1J0L/TL2zEjUpWxALmQZeeRnA7i3mTDdv8FVOxuBVJFNMTDYC7dN7KSs5m8+TznCPIirqOblvfnlwpZ+sMvyXSCZ1beC+usTxqE7c9vTRersInHboefSSEa4oUg7LdBPzmIzja4J+SM10hdPOpyjCdh5AebuZsgmNO7J5KI/pXciulTRUjdWplUqvTqahjaqeq8oW/nkWD1Mz/pzhf8sICtFNq4tw61iQg6/ylLhdJLp4wtrLmKPOz4Cbj3IkbwQg3CTHs5FnEe9f9RvImgFvH6st3mf31+u33ozuEANbASaL/m1lPzDxQfVaF1anAD3jPAFC/L/ovX18APtsOaZbxUXBBYocfWy65o+8bsnkE7qGVZZBJBMYbfzRviZQoLjk3TN2Zwg2+jYksq4G4FE0hAVMlgZzB0yPRiYVGiWDgjd2piNqrE4NNFENknhiRC4BFJ8XP/9UOSZwxNuZsKhWZWSRmA4cA683GgUBxmr3gZFd3zT1a4VLP9fKiNvyyhE2S/o=", null, 1, "5786bacb-527c-4239-9204-5c8a770146ad", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("363c028c-631a-46ba-9ee4-fc6d207c32e2"), new DateOnly(2022, 11, 21), null, "Qm3WMdHEyOaaKsUIM24yxSW/w0mwyTYbfgTbNti68O1QZcjXJUVuXvPQ3akXroglxF2cDvSrIUN69wJnDUvWkBuKKhzElumBIlhZidFfx4oPNEuxC25wPVZnKQOpIz6CyuoEhhgM63IFk899gCIpYQ1P1afl1p+8WHA2jfdrYfFdh6CCb+/0tXcHclTTWbqtJMWYrBXLKg05IOLbIZB0KyZmd1bQNKrv+kaLgypva2o2xBUG4CX+JNjfKU358qbIWEUdiG2H0PCBowjfOVqmMhD++nJ9vV1YJUm4vZ4WA8S5TBTqiW9nC8WDrGh12Gco9Y2amaVIjqX10EiITifhXE7JInG/juoUq1DTlwf8HTpPFNf4sWhIqhiZlGOc+maXjNuv4pQkaoIAsSzs9utCJfRkJAmy7+QOn2G6W7psx5N1D/Ao8PmlCZ6j5uZTRWr9kC2lm4SBZtdUdavBq3ioyw1mJ5ZV7wCMdby5/NdCG/5TD5COo1Ck+8sUmy1hA+TEDWOL1kSk84fPxTgGM5fNuJLXOXhRnax15Z4V4fR4ImIHUFbzmcbrt/2UuCRu8BU37q5xl+KxP64VYagQ7TXiMPzaM8eCdEDadN/BuKasfqN7RHD/yYHFT6Ag2jYVFhF7BeV3Js+reawvoQwcM2adXpTgoUUtYXZarS+2ujejZSQ=", null, 3, "7b1ad173-0e7f-4382-ada8-30379af0048d", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("4541697a-751d-4db8-b200-8a53e9255c22"), new DateOnly(2022, 11, 21), null, new DateOnly(2022, 11, 21), null, new Guid("e51a73e2-73cb-4f49-b112-ea3ea250beae"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("a772cc9e-33a4-49c3-a62d-8daccd9eb11c"), new DateOnly(2022, 11, 21), null, new DateOnly(2022, 11, 21), null, new Guid("e51a73e2-73cb-4f49-b112-ea3ea250beae"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("bbbb0da8-5e4d-4400-b308-45b564303021"), new DateOnly(2022, 11, 21), null, new DateOnly(2022, 11, 21), null, new Guid("9be02aa5-f544-4cd5-b0c8-361ce5288004"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6beed666-f12d-4c74-b104-dea4acab16f4"), new DateOnly(2022, 11, 21), null, new Guid("a772cc9e-33a4-49c3-a62d-8daccd9eb11c"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("6d4632a1-a97b-4f74-b247-7a2752dfc185"), new DateOnly(2022, 11, 21), null, new Guid("4541697a-751d-4db8-b200-8a53e9255c22"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("b9d9a561-c800-4f7f-87a5-5fec97da4454"), new DateOnly(2022, 11, 21), null, new Guid("a772cc9e-33a4-49c3-a62d-8daccd9eb11c"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("e0ad94e8-916e-4998-8ae6-b9053f785517"), new DateOnly(2022, 11, 21), null, new Guid("bbbb0da8-5e4d-4400-b308-45b564303021"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("ee397303-d6a7-44fa-9b95-919ed326eb23"), new DateOnly(2022, 11, 21), null, new Guid("bbbb0da8-5e4d-4400-b308-45b564303021"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("f8e02a72-9011-4e50-9a15-a629e6714f65"), new DateOnly(2022, 11, 21), null, new Guid("bbbb0da8-5e4d-4400-b308-45b564303021"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attraction_RestaurantId",
                schema: "Attraction",
                table: "Attraction",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_RestaurantId",
                schema: "Menu",
                table: "Menu",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_MenuId",
                schema: "MenuItem",
                table: "MenuItem",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_RestaurantId",
                schema: "Reservation",
                table: "Reservation",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_UserId",
                schema: "Reservation",
                table: "Reservation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_Email",
                schema: "Restaurant",
                table: "Restaurant",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_ReservationId",
                schema: "Review",
                table: "Review",
                column: "ReservationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_RestaurantId",
                schema: "Review",
                table: "Review",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                schema: "User",
                table: "User",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attraction",
                schema: "Attraction");

            migrationBuilder.DropTable(
                name: "MenuItem",
                schema: "MenuItem");

            migrationBuilder.DropTable(
                name: "Review",
                schema: "Review");

            migrationBuilder.DropTable(
                name: "Menu",
                schema: "Menu");

            migrationBuilder.DropTable(
                name: "Reservation",
                schema: "Reservation");

            migrationBuilder.DropTable(
                name: "Restaurant",
                schema: "Restaurant");

            migrationBuilder.DropTable(
                name: "User",
                schema: "User");

            migrationBuilder.DropPostgresExtension("uuid-ossp");
        }
    }
}
