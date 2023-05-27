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
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    BillId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillUser", x => x.UserId);
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
                    { new Guid("b0f6eb83-46e3-41d8-a82b-a8a41298e035"), new DateTime(2023, 5, 27, 19, 22, 6, 89, DateTimeKind.Utc).AddTicks(7030), null, "Ztb1gqtAubIBR192bSo335ZW3BV82hQKbgZRZT16bwY9dlol3d/upyXRyrhVnBeakGuzlPsdzdbW130g5hjGS/LyBsvfrZ7c2db9idJ3W2CpXbOtx3BhlY/A88zhTXPFQ5yk3w522JTbIiWZNJB8x+k0Cu5Z9Od4emcOH51QXZsydSEePI5FO08Xr8TIUB0hL4hYXXvAs5dKDtjGisZJFpzONC0uv1fYSESuckmkn6oNpJ86wBFzmY7IZj2vfD3/06BjeI+oJOFhIcPQ//weY2vKQauCDW+Gi7AHe+zxk73mktMbCSbXQVu8wgV1wat01ZLA1HuAvJUuSyNm4QTCnZwDczoPR/PMitYT51erXFTBfeXUp+Bz2r9+9Go/7LVi9k8xIJzDe1BqzojMN5kmtSwIPftUhZNDzPi68hLAqtSVr318owzGZxUGAHEtNa5FO31Yst1yZNvQ770p79G+5KokBeUjn8NUz5kgnWyDPI+6AHk8Gl1lMRohZEJu4+oG54ssSTAEN/25SYPqC18rLc02kE6op6n+fboSGGfWWB7g6BcTLouN+Vtyo4mPj17by2tRnmBEvD2n13o+J0AB6n8xsjmjpRqp/WFNqMBOiVtM6LOHk2SmNVIfLGWPad9lOwrSjfRmPD3okvLr0UYVZwjFboP/dIpp0AfRdlN6mWU=", null, 1, "bf40edfd-ce10-44c6-b2e2-d620653ad6a5", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("cc8f093a-9bc9-4272-8cdf-d03edc641124"), new DateTime(2023, 5, 27, 19, 22, 6, 17, DateTimeKind.Utc).AddTicks(6414), null, "u9uJZwKsGC9udmXefeXtLxJS1NdZSNWLjBj0HWuzocx4CFCcnQ2PKJuYJNM7m9HDJvuBDX8yLxvqqJb3UYHzo/eyRDx+rLJr9cUWBBV7Ps/11hctSPEXetddzNCzGQ6z/LFn7Rm31/nV9tI7buCXjA1Q/Xk0b1KGRgAcJPfl5GXt3x86gPEawo9Jtnb0fmeX2C5fqOE653M7TiE/IWq67CBdewz3HOQc5N24MEh1aRng6iA2TDn2JgNMTex7AUZBN/ZCPWF87fcBEk0b2t1K/W2CuMj5QDqKaqHSMlvnKAP6+xJNsukj922ma3ayViTUPGX3/fbpk1TFk6Hw+Obn8OaYC/7fYkibouLwqpYeo/O01WhA7xgQEIa8gQlCD83Q6scUKCPNZo/XhADzUbbWpzhF9q7X4riPNPS6KAZCOJcJjairvpNRbesDaEAxwj0seEM1IsQ7e56jtyDbWJt0INtGZY3XOBYPKdn/EnKGtyZO0hfc1JhVYQbcIMm1PSxs/QHGLb7eTYPR/LsV8Poiu4Q4H22mFTmMT38IV3ueM2RTJ1LSlBfOylArTSlhO7WnQSV6N0/WESpmBXMWWUqgcgCRNqlX5IM0I4OYmHga6uTSH+mh2kwPxc/6jdCYcMVUcy/wlAaVoGFKdknSw3nHsxU/+xL14UrMh33gHnrRXMI=", null, 7, "b3b21bed-5289-41fa-96a9-0bfc1b47ea7a", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "UserId", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("35ff541d-8213-4afe-ade1-8fbee8aa995f"), new DateTime(2023, 5, 27, 19, 22, 6, 89, DateTimeKind.Utc).AddTicks(8900), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, new Guid("cc8f093a-9bc9-4272-8cdf-d03edc641124"), "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" },
                    { new Guid("f8b15bcb-51aa-4f02-af83-a2cba043de6f"), new DateTime(2023, 5, 27, 19, 22, 6, 89, DateTimeKind.Utc).AddTicks(8341), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, new Guid("cc8f093a-9bc9-4272-8cdf-d03edc641124"), "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("18e899c2-9adb-495e-b148-769198414d88"), 20.0, new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3279), new DateTime(2023, 5, 28, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3274), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("f8b15bcb-51aa-4f02-af83-a2cba043de6f"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("301a6d9d-5359-441a-8478-0d55c4b64975"), 20.0, new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3405), new DateTime(2023, 5, 29, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3404), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("35ff541d-8213-4afe-ade1-8fbee8aa995f"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("b2a1a328-09a0-40ef-abf7-ea62dc1a4793"), 20.0, new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3475), new DateTime(2023, 6, 3, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3474), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("35ff541d-8213-4afe-ade1-8fbee8aa995f"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("51e1fddf-4bd1-46ef-8c6c-8caa48254e14"), new DateTime(2023, 5, 27, 19, 22, 6, 89, DateTimeKind.Utc).AddTicks(9797), null, new DateTime(2023, 5, 27, 19, 22, 6, 89, DateTimeKind.Utc).AddTicks(9797), null, new Guid("f8b15bcb-51aa-4f02-af83-a2cba043de6f"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("60c4fd70-2126-40be-a957-304154ae9a45"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(2158), null, new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(2156), null, new Guid("35ff541d-8213-4afe-ade1-8fbee8aa995f"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("62d34834-8e42-44cd-b531-33230a5f7692"), new DateTime(2023, 5, 27, 19, 22, 6, 89, DateTimeKind.Utc).AddTicks(9504), null, new DateTime(2023, 5, 27, 19, 22, 6, 89, DateTimeKind.Utc).AddTicks(9504), null, new Guid("f8b15bcb-51aa-4f02-af83-a2cba043de6f"), 1, "Cardápio de vinhos.", "Wine", null, null, false }
                });

            migrationBuilder.InsertData(
                schema: "Table",
                table: "Table",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Number", "RestaurantId", "Status" },
                values: new object[,]
                {
                    { new Guid("386098c7-7f8f-461c-b18c-c4f004c9295a"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3571), null, 1, new Guid("35ff541d-8213-4afe-ade1-8fbee8aa995f"), 1 },
                    { new Guid("5465368d-8190-4bc6-a7b6-1ca62dca4a7f"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3576), null, 2, new Guid("35ff541d-8213-4afe-ade1-8fbee8aa995f"), 1 },
                    { new Guid("7d7b9291-d973-4d84-9e6e-6610e6680692"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3569), null, 3, new Guid("f8b15bcb-51aa-4f02-af83-a2cba043de6f"), 1 },
                    { new Guid("c4cf867d-1610-4c8d-a150-503b5a7ccdb2"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3559), null, 1, new Guid("f8b15bcb-51aa-4f02-af83-a2cba043de6f"), 1 },
                    { new Guid("c7a6dadb-8907-47d6-af23-5e04a5dfb086"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3567), null, 2, new Guid("f8b15bcb-51aa-4f02-af83-a2cba043de6f"), 1 }
                });

            migrationBuilder.InsertData(
                schema: "Bill",
                table: "Bill",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Status", "TableId" },
                values: new object[,]
                {
                    { new Guid("594764a7-b065-4cb5-b40c-bb1734b6cacf"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3599), null, 1, new Guid("386098c7-7f8f-461c-b18c-c4f004c9295a") },
                    { new Guid("93eed682-c432-447b-affd-e8f056ddad54"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3595), null, 1, new Guid("c4cf867d-1610-4c8d-a150-503b5a7ccdb2") }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("4d9f3e42-7338-4c6f-9c06-ed65d25bcbeb"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(2986), null, new Guid("60c4fd70-2126-40be-a957-304154ae9a45"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("7b8273d9-ea58-477b-a5e9-ba9b18fb6ab2"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(2906), null, new Guid("60c4fd70-2126-40be-a957-304154ae9a45"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("84f783cb-ede7-499c-94f7-dc53426a5693"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(2671), null, new Guid("62d34834-8e42-44cd-b531-33230a5f7692"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("994b74af-1368-4eae-b5dd-78715a729f0d"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3113), null, new Guid("60c4fd70-2126-40be-a957-304154ae9a45"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("a9ebef60-80c9-45a3-b05d-e3f303ed7ce3"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(2824), null, new Guid("51e1fddf-4bd1-46ef-8c6c-8caa48254e14"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("b7620156-6d24-43ae-927c-1a9a8dd50fd9"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3193), null, new Guid("51e1fddf-4bd1-46ef-8c6c-8caa48254e14"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" }
                });

            migrationBuilder.InsertData(
                schema: "Order",
                table: "Order",
                columns: new[] { "Id", "BillId", "CreatedAt", "ItemId", "LastUpdatedAt", "Message", "Quantity", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("46bf1865-5f23-47cb-b11d-f32b0512ac1b"), new Guid("594764a7-b065-4cb5-b40c-bb1734b6cacf"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3624), new Guid("994b74af-1368-4eae-b5dd-78715a729f0d"), null, null, 1, 1, new Guid("b0f6eb83-46e3-41d8-a82b-a8a41298e035") },
                    { new Guid("4bb3637b-ad5d-4e3a-9849-9c6db5e4b69b"), new Guid("93eed682-c432-447b-affd-e8f056ddad54"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3614), new Guid("84f783cb-ede7-499c-94f7-dc53426a5693"), null, "Completo", 1, 1, new Guid("b0f6eb83-46e3-41d8-a82b-a8a41298e035") },
                    { new Guid("7b74726b-c3db-4685-9e46-4f6358241b50"), new Guid("93eed682-c432-447b-affd-e8f056ddad54"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3619), new Guid("a9ebef60-80c9-45a3-b05d-e3f303ed7ce3"), null, null, 1, 1, new Guid("b0f6eb83-46e3-41d8-a82b-a8a41298e035") },
                    { new Guid("8e6fb407-c85f-425b-b01e-7d174ec838e1"), new Guid("594764a7-b065-4cb5-b40c-bb1734b6cacf"), new DateTime(2023, 5, 27, 19, 22, 6, 90, DateTimeKind.Utc).AddTicks(3622), new Guid("7b8273d9-ea58-477b-a5e9-ba9b18fb6ab2"), null, null, 2, 1, new Guid("b0f6eb83-46e3-41d8-a82b-a8a41298e035") }
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
                keyValue: new Guid("18e899c2-9adb-495e-b148-769198414d88"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("301a6d9d-5359-441a-8478-0d55c4b64975"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("b2a1a328-09a0-40ef-abf7-ea62dc1a4793"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("4d9f3e42-7338-4c6f-9c06-ed65d25bcbeb"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("b7620156-6d24-43ae-927c-1a9a8dd50fd9"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("7b8273d9-ea58-477b-a5e9-ba9b18fb6ab2"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("84f783cb-ede7-499c-94f7-dc53426a5693"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("994b74af-1368-4eae-b5dd-78715a729f0d"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("a9ebef60-80c9-45a3-b05d-e3f303ed7ce3"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b0f6eb83-46e3-41d8-a82b-a8a41298e035"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("51e1fddf-4bd1-46ef-8c6c-8caa48254e14"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("60c4fd70-2126-40be-a957-304154ae9a45"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("62d34834-8e42-44cd-b531-33230a5f7692"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("35ff541d-8213-4afe-ade1-8fbee8aa995f"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("f8b15bcb-51aa-4f02-af83-a2cba043de6f"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cc8f093a-9bc9-4272-8cdf-d03edc641124"));

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
