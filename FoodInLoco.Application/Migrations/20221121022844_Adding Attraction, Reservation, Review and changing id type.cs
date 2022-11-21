using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class AddingAttractionReservationReviewandchangingidtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MenuItem_MenuId",
                schema: "MenuItem",
                table: "MenuItem");

            migrationBuilder.DropIndex(
                name: "IX_Menu_RestaurantId",
                schema: "Menu",
                table: "Menu");

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.EnsureSchema(
                name: "Attraction");

            migrationBuilder.EnsureSchema(
                name: "Reservation");

            migrationBuilder.EnsureSchema(
                name: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "User",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "User",
                table: "User",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                schema: "User",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                schema: "User",
                table: "User",
                type: "character varying(10000)",
                maxLength: 10000,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                schema: "User",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "Restaurant",
                table: "Restaurant",
                type: "integer",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "Restaurant",
                table: "Restaurant",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                schema: "Restaurant",
                table: "Restaurant",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Kids",
                schema: "Restaurant",
                table: "Restaurant",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                schema: "Restaurant",
                table: "Restaurant",
                type: "character varying(10000)",
                maxLength: 10000,
                nullable: true,
                defaultValue: "https://img.freepik.com/free-vector/restaurant-logo_23-2147506959.jpg?w=826&t=st=1668952356~exp=1668952956~hmac=49402768c6b8d28e62ceaf62db752e285911d5b9ec57bb827b2118d98f046d74");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                schema: "Restaurant",
                table: "Restaurant",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "MenuItem",
                table: "MenuItem",
                type: "integer",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                schema: "MenuItem",
                table: "MenuItem",
                type: "character varying(10000)",
                maxLength: 10000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<Guid>(
                name: "MenuId",
                schema: "MenuItem",
                table: "MenuItem",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "MenuItem",
                table: "MenuItem",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                schema: "MenuItem",
                table: "MenuItem",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                schema: "MenuItem",
                table: "MenuItem",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "Menu",
                table: "Menu",
                type: "integer",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "StartAt",
                schema: "Menu",
                table: "Menu",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RestaurantId",
                schema: "Menu",
                table: "Menu",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                schema: "Menu",
                table: "Menu",
                type: "character varying(10000)",
                maxLength: 10000,
                nullable: true,
                defaultValue: "https://menubrands.com.br/wp-content/uploads/2020/04/Menu-300x300.png",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 20, 23, 28, 44, 315, DateTimeKind.Local).AddTicks(1639),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 11, 5, 21, 19, 35, 84, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.AlterColumn<string>(
                name: "EndAt",
                schema: "Menu",
                table: "Menu",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                schema: "Menu",
                table: "Menu",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Attraction",
                schema: "Attraction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Photo = table.Column<string>(type: "character varying(10000)", maxLength: 10000, nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CoverTax = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    InsertDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                name: "Reservation",
                schema: "Reservation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    SeatQuantity = table.Column<short>(type: "smallint", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    Confirmation = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    InsertDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                name: "Review",
                schema: "Review",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RestaurantId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReservationId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Rate = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    InsertDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                columns: new[] { "Id", "Kids", "Photo", "Status", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("14d67b82-c794-40de-ac54-57756c41c1dc"), true, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" },
                    { new Guid("a169084d-c624-432a-aaeb-39668f068b48"), false, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("262955c6-7472-48e0-8f12-4df678aab27e"), "vuRbB1nAr5kfXc0nkwWJRMhlZjGeOGXUboT7nd6EBzIG4QbHkJt1kAF3YPMe6dAJIvlrKNgDGwNE43QpHoD3MPTb/qSLq5kk4cGt5rhSyhxZC5B95uL2xp0KWc11Stm+cagUjY3l1kGk5IMEXvGc+iXh5Owz2ouTn3nSwBy+1dKAY45ylEWCTUwqz2wUEmbFYh4B9nat6w3QrG4/HKk9Ylk/Eo7sRQY+YY/Y2rVvTcaYp0qptmgppcKinY1ZuWp58u6fErEzHhyu3ZwkpfxQrdra8l/O0csWXd7TCa7EUcLLuWjuOzsAoL5uOfF2kg7XtHTP1acdFSQMy6DPXkyQ2etoO4Q47LHl6QTFREhW4+iSQqpuVURoGxv6aREzXEi5HMxa0L4MWjIVQ3quQvHZ6/MFBj0+HxWUJM///vgnxr8X9A+QVutLpO/F+WEPSdF6QOhKA6giySnPD7JXrUtLGydFZ+5wF0NL+hFKVMsmaqx0IKJXkdq6dO4b0IS9WVT2WymBQOJwnAlidrk34GvEcvH9JCHRJuH/pz8jyLWMygS4nECoRPH2r7pD1c2amq5olJdxQXRTsCkQgCxrQ5tBYdMlaIRTdL+iVqEJWkZPxVYoCjt3hfXESRvczLqhBbmykn2vdkLyEyhGWalEDjqGx4Qdw4ACjod8ZcpTal5fCPk=", null, 1, "48680f49-b80e-46cc-a7e6-1cbebb1095f7", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("aa03dfdd-2dfa-4350-978c-6ab3bd1011f5"), "RFzZQ2BK//RW0NqXCjVhc7c54T1HZsNNeEV4ZrPdFPEakKi0+OqDfGuf0mRMdXpcnr44RtL/QMGnJM6gcac2tjLmAs3i/bLZunC+84FgvCHRZJFrWUmvLW5jpab7dgCiVWEY9udqyaAFyJ9ADAigYQszprQTgJslsWWQxNLoXgC7mzxuqRLn93ooj55en/YZIywr8NvSGV8WyLgngZfF7fQqVZ2Wy8ksFvJ4RVnzoSJWE+d8LMGYXQOZY+b8/SM6FSwLyo8hrIBOIn0mqwY6LGQQWSNm2lLGbntf9lhX0I9El3Ky0sZwn2fvPRqF65yg7KkHlaRAkyy77LhVcESezSYYq77ulCNPD5e2p/BKUU0oVHOSY3pf+MqwNOUslutYJZqVmlhoUbV+vqbjGIF8ctOEwX29ZHqRnC+TFYMkKmsY711rjxQEtW4Utr1SgWphAnaej+prg86CS1jpT5xXOzXuRWpEXoIcCeC/ZmEdOb8lTlK5+fvt5wPkyKDkI+Khu6e+Di0bzF3H9dlPotS8q2GLiavj0FdOfnjld8FfeZMgKBgnU5iFptorFyp8Gwysx83gczFb7xawbICQZjS6ew6eGSUJaKR1FNotVy/uXuSJaSoUidU9v2HlnWgwpSw8K4pzQi/1zqcrlkSKeeurSLsMUeiwT8WIC1ZEvvH6/Xo=", null, 3, "5c21a513-fa7a-465f-8e78-3533c705bafd", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "ExpirationDate", "InitialDate", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("a0ff3d3a-8095-4788-a4fa-f0d667cefed3"), null, new DateTime(2022, 11, 20, 23, 28, 44, 433, DateTimeKind.Local).AddTicks(5782), new Guid("14d67b82-c794-40de-ac54-57756c41c1dc"), 1, "Cardápio de Happy Hour.", "Happy Hour", "20:00", "16:30", true },
                    { new Guid("a7fe226c-58ef-4ab4-a4b7-6015e23e3209"), null, new DateTime(2022, 11, 20, 23, 28, 44, 433, DateTimeKind.Local).AddTicks(5538), new Guid("a169084d-c624-432a-aaeb-39668f068b48"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("f8c245e6-2681-4ab9-8e68-ee85a35fdcd9"), null, new DateTime(2022, 11, 20, 23, 28, 44, 433, DateTimeKind.Local).AddTicks(5690), new Guid("a169084d-c624-432a-aaeb-39668f068b48"), 1, "Cardápio de Happy Hour.", "Happy Hour", "20:00", "16:30", true }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("08e4a1f6-2432-45a9-9e9d-95c8166b7c6e"), new Guid("f8c245e6-2681-4ab9-8e68-ee85a35fdcd9"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("0de5d7a7-915b-4331-9c52-8211e677920c"), new Guid("a7fe226c-58ef-4ab4-a4b7-6015e23e3209"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("2c34c8fc-b4d7-434b-a8be-32640fd9a3b6"), new Guid("a0ff3d3a-8095-4788-a4fa-f0d667cefed3"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("8dc829dc-0ba1-4add-8451-b1ee54cbd7dd"), new Guid("a0ff3d3a-8095-4788-a4fa-f0d667cefed3"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("cac307fc-27da-4b76-8d6f-cffd25812266"), new Guid("a0ff3d3a-8095-4788-a4fa-f0d667cefed3"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("ea5005fe-2dc2-43a9-b599-669970220de9"), new Guid("f8c245e6-2681-4ab9-8e68-ee85a35fdcd9"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_MenuId",
                schema: "MenuItem",
                table: "MenuItem",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_RestaurantId",
                schema: "Menu",
                table: "Menu",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Attraction_RestaurantId",
                schema: "Attraction",
                table: "Attraction",
                column: "RestaurantId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attraction",
                schema: "Attraction");

            migrationBuilder.DropTable(
                name: "Review",
                schema: "Review");

            migrationBuilder.DropTable(
                name: "Reservation",
                schema: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_MenuItem_MenuId",
                schema: "MenuItem",
                table: "MenuItem");

            migrationBuilder.DropIndex(
                name: "IX_Menu_RestaurantId",
                schema: "Menu",
                table: "Menu");

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("08e4a1f6-2432-45a9-9e9d-95c8166b7c6e"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("0de5d7a7-915b-4331-9c52-8211e677920c"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("2c34c8fc-b4d7-434b-a8be-32640fd9a3b6"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("8dc829dc-0ba1-4add-8451-b1ee54cbd7dd"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("cac307fc-27da-4b76-8d6f-cffd25812266"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("ea5005fe-2dc2-43a9-b599-669970220de9"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("262955c6-7472-48e0-8f12-4df678aab27e"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("aa03dfdd-2dfa-4350-978c-6ab3bd1011f5"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("a0ff3d3a-8095-4788-a4fa-f0d667cefed3"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("a7fe226c-58ef-4ab4-a4b7-6015e23e3209"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("f8c245e6-2681-4ab9-8e68-ee85a35fdcd9"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("14d67b82-c794-40de-ac54-57756c41c1dc"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("a169084d-c624-432a-aaeb-39668f068b48"));

            migrationBuilder.DropColumn(
                name: "InsertDate",
                schema: "User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Photo",
                schema: "User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                schema: "User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Kids",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Photo",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                schema: "MenuItem",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                schema: "MenuItem",
                table: "MenuItem");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                schema: "Menu",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                schema: "Menu",
                table: "Menu");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "User",
                table: "User",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "User",
                table: "User",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "Restaurant",
                table: "Restaurant",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Restaurant",
                table: "Restaurant",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "MenuItem",
                table: "MenuItem",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                schema: "MenuItem",
                table: "MenuItem",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(10000)",
                oldMaxLength: 10000,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "MenuId",
                schema: "MenuItem",
                table: "MenuItem",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "MenuItem",
                table: "MenuItem",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "Menu",
                table: "Menu",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "StartAt",
                schema: "Menu",
                table: "Menu",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "RestaurantId",
                schema: "Menu",
                table: "Menu",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                schema: "Menu",
                table: "Menu",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(10000)",
                oldMaxLength: 10000,
                oldNullable: true,
                oldDefaultValue: "https://menubrands.com.br/wp-content/uploads/2020/04/Menu-300x300.png");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 21, 19, 35, 84, DateTimeKind.Utc).AddTicks(4740),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 11, 20, 23, 28, 44, 315, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.AlterColumn<int>(
                name: "EndAt",
                schema: "Menu",
                table: "Menu",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "Menu",
                table: "Menu",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "Status", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[] { 1L, 1, "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "Password", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1L, "q87KdHFXZl0erFi1C71Rp9miF/QFSKU3SQwNb87Kk42+AI9Xs1yfApzhZfXNzicnPOBXlgHLdSf98NRpwJS9JxGyvBdGpAN2J3Tj4xCxSKLhArwHghQieo4fLQEAOyL98XC41PbvZn6IVMvymhWCfbJbf3UedlXZxpODqPPi/bp4XmRc9xCK4Tp+rTBivGP5Og71cOSVDeQHwTO4At6n65fyQkKRih7Zxq0MqQ+FLnkgniTMF+yJHeaC+lNPmtUs2ffuDlJ2qL6fi5d0xYc/RI9lLXkd5JOuwpFf95lBruY+k3JJursLNoIWq7R2Qm2FMELd4C/81f1LtzdbMK8aUzFpw7MEIHMOjbCNJBqJicrXRXVs550PluDIuKFgG0wGsfoyNgunQrKB/WVNpPJB96luVwtTFlEEamjO7EgFUwdMKMtQFokK6nSYVBnpTZilR87irEdx5S8CqPdcUeruFecyZLXeujOy08vaNrXvioiETqIO8kC2fZnTIljmxlEUJIV4bhq0do3gRJMm8Y4AZizUp7L+9LAeEMC5R5MUsB4/9GbOT3FxXWpF3m0vFzPvfqokn3YuGLKCNMXi2H71sV2TKIBqUCCG7SFnVBTZgswpUfmgGc/d6xP2/Mga5EtJp/c63lNAKY+pzWo5WWP3mdqpfjuaBWibchMv0Og91Qk=", 3, "a936717c-0a12-4db8-9bea-debe9f499a95", 1, "85", "997851936", "admin@foodinloco.com", "Pedro", "Oliveira" },
                    { 2L, "S4WQ0xO1c+FtWb8kWIRS2or7aG/QH9kqZgspnCWPBMrS0t9jVWVwjpVco146JLPxMgkNn5sitUCfjdlP7EaCKRQCue7MBa5d7/RyuAAXAcXiSKIi6hZgi7zjHtInflnCj6vaTG8b8/JIFg4m21oIasan4ZZQ1r7P4K1Qri6ujRLOIyuaD0rv3MiW1X+U5osHU0dJPf893oV0fEKVTbIwRGwak0rXQr75K9sP43HdyclASwuU7Km4CFiYLYYEXqCcI5wAJbhksR/Z7puV7hyEmTPHXL+gJSfChzymVf282kXZWHk5aWfoQGKcHpWg0utRwGUHozt8I+qDf68i3ZsXJp+dv+OW2gBm/JmZr4Uwsq982e7YETOGSEyr9EG83SXXu1N/4JMiBzfUz8xcLWI5RReKTpHJUAcv70VGeKYQK5bqSiXmtg1jKNX/Ig8LzKncxp+WWd3F5M0JGUlYPf/eowN+2M9HBGNB/NkR4jSvvooMQmtFCmQD4onGGHLjxEUqUt3chGiZVrGHidyFlxqgvJqtp8MKLYwyr34fqfQcP3bAGzgcHQk3CecpHRzoySZm8lkbeYJCQ1xvHuv32Y6iI7hVwhp7ckFQQWnWAYbtCiHfzGUZ3d3dwMcS0sjfJLI+nxnsHygumf8lQ7mdCagzACP3pD3a+aaCJeCFCIuSTZk=", 1, "0991f2f3-1dbb-4c4a-8dbc-7a6bd9a83027", 1, "85", "999999999", "letter.pedro@gmail.com", "Pedro", "Lopes" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "ExpirationDate", "InitialDate", "Photo", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[] { 1L, null, new DateTime(2022, 11, 5, 21, 19, 35, 207, DateTimeKind.Utc).AddTicks(7568), "https://www.underconsideration.com/artofthemenu/project_images/the_urban_tap_PHOTO_01.jpg", 1L, 1, null, null, false, "Cardápio de vinhos.", "Wine" });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[] { 1L, 1L, "https://www.underconsideration.com/artofthemenu/project_images/the_urban_tap_PHOTO_01.jpg", 1, 1, 11.99, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_MenuId",
                schema: "MenuItem",
                table: "MenuItem",
                column: "MenuId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menu_RestaurantId",
                schema: "Menu",
                table: "Menu",
                column: "RestaurantId",
                unique: true);
        }
    }
}
