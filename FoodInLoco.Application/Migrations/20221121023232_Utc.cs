using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class Utc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 21, 2, 32, 32, 296, DateTimeKind.Utc).AddTicks(4624),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 11, 20, 23, 28, 44, 315, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "Kids", "Photo", "Status", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("21c96e58-77cb-4d78-94db-b129a3eef53b"), true, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" },
                    { new Guid("5f2ae251-b582-4a20-8ba4-e0b3017bb3df"), false, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("13750d23-b78e-4b06-afb3-26f126103002"), "jHwjD1IVf416zX/cqKXRQ8CixO4XTsZaWzY0SbsnKBCKJ4Icc2FKAKaCB13x4/6IOnQYiY/b8lMkDrMNt4nRhRS6sp2Ok+1PR6meloduTgUAhDRwKZ11Vh72TJgKv0FNW+1Yj+iL3gqPU/B7y5CmTOlxNzdmqmbjO6mFwKUHT2WV0AOB+dui45sJVtgl4oMXmRKc+0U5V5X6vTcK6lYvxTn/lkmFxPHtgRjj+LKo+msdEtZFhQczzyucTgnoMSlbtKQUJ9CMMjCpZVLMOmF+vhXfEelgUinQNur6JNVjZph+t60UET57F9OSSw77II2F5w7x/qjs07GQ1bZWJEI4Bl0rIJrbyNQvUPGirQYVvTIIL9Zq1EePJlYn+LB1dHt24QMXPkm4VjZzU1qk3lNspiKbjnFxQ0rfToiCWahiPOm4uyX8WeVTirqSTQpvF44uXo6GNWBcmlKYS5aeAOrE6pzRs+bZUWXhYLV/v5+A7Dbou3v49P1FlaRgeqHHDj3js9aK2Z47oKQ/L2v19dWjYrrJ1jx0F/e7w4ak2aGzOxzW5/q693AfhVB6PE6OhXIohWaXXKGjuyj5hGO5K7/MKt2ByFylrQ5+OsjvhUfs8hNh4F/4yQDKi4BCwfBoxwubm3Q3cc5hiDjC9hS/3qWhYpCr/KzmFPl0i182TSS+wDY=", null, 3, "9209c278-0598-4d3b-ae7e-95130ffbc7e4", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" },
                    { new Guid("c3a36d5d-0350-4864-b5b6-e11f88164253"), "vShHPZX0SZoYy/sbCtq6neq/PBmIO4DnVZpEX2JdHaEKGVpg/dke2h+0mGu8K0/ZOQKgddgA0quM8uiPhA+548yZl2ao2kDEPUvNGwH05wrQzwPQ28VralyzazAcOTe5V7FLlrVtDwn0vC2JBoyW6dIiLh7Gv+bsI6+NMGLy92guMOKtR1BEQ+s8uZyIW29zRnNDlBg6gyvRs03Q1jN1sFgSeMrFBs2PsUe7dvom1zx1di47uYG6YXCCt3w2ed82ud7sXnwnhBwZVVrrycVlMPzaKhFC5NrsxKhKWfmw57nBEZAF4qnqmtsmguXryO91UDhU7ilacIMQwkM6ZFpXTDXLxwywS6EptGvzcYPprokI77KAzNggSNdyKvFPOga6NVzrzEqiCbjy515rYjE/sZRucFnO83dCSalTIqjPSeHjoztiky+Y5v8WAXyh7dMhTvYpdw8QX8D6t7CNYXGEyuBth0c7NeXqGbrURt6ATDzixYkfZiM2ccwo1IJIEPpP2Sgu/ULgzOH9aKxWT29/FFTCviymSwuPHTbP4vtjkNyPTJxKrCgNcGb01k9yMtjuxNHp+pG42r3FSCy7jSZc64E+97xWxharupPhQRwCLotlkKk6wRJIFmSwmPSxMAManLPyJRhQ/3TO8XfgdclmoaiferInBg3s1k4dI33l5yE=", null, 1, "e06261b2-32a6-450e-bea4-f3f1d12c9f2b", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "ExpirationDate", "InitialDate", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("5345c164-f46f-4025-9303-5ababe27c72e"), null, new DateTime(2022, 11, 20, 23, 32, 32, 421, DateTimeKind.Local).AddTicks(3318), new Guid("21c96e58-77cb-4d78-94db-b129a3eef53b"), 1, "Cardápio de Happy Hour.", "Happy Hour", "20:00", "16:30", true },
                    { new Guid("7186d5a3-6b50-47ff-8f07-7f548b5d8c4e"), null, new DateTime(2022, 11, 20, 23, 32, 32, 421, DateTimeKind.Local).AddTicks(3115), new Guid("5f2ae251-b582-4a20-8ba4-e0b3017bb3df"), 1, "Cardápio de Happy Hour.", "Happy Hour", "20:00", "16:30", true },
                    { new Guid("993abfda-6e9c-41e5-837c-28de1d0edf29"), null, new DateTime(2022, 11, 20, 23, 32, 32, 421, DateTimeKind.Local).AddTicks(2876), new Guid("5f2ae251-b582-4a20-8ba4-e0b3017bb3df"), 1, "Cardápio de vinhos.", "Wine", null, null, false }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2c7cb00d-4cc6-416c-a6ee-7a801f92752e"), new Guid("7186d5a3-6b50-47ff-8f07-7f548b5d8c4e"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("3c6abf28-9e32-4646-bfd9-2edd14e2a557"), new Guid("7186d5a3-6b50-47ff-8f07-7f548b5d8c4e"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("53414f6e-0006-4e87-b0b7-5bc0d1226146"), new Guid("5345c164-f46f-4025-9303-5ababe27c72e"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("73f3c155-0dfe-49b1-85b4-975467509e85"), new Guid("5345c164-f46f-4025-9303-5ababe27c72e"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("c8453bb7-a25e-497d-96f9-1e0fd8c3273d"), new Guid("993abfda-6e9c-41e5-837c-28de1d0edf29"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("eaa32944-51e8-47cb-813b-1d553fdb0f4c"), new Guid("5345c164-f46f-4025-9303-5ababe27c72e"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("2c7cb00d-4cc6-416c-a6ee-7a801f92752e"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("3c6abf28-9e32-4646-bfd9-2edd14e2a557"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("53414f6e-0006-4e87-b0b7-5bc0d1226146"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("73f3c155-0dfe-49b1-85b4-975467509e85"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("c8453bb7-a25e-497d-96f9-1e0fd8c3273d"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("eaa32944-51e8-47cb-813b-1d553fdb0f4c"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("13750d23-b78e-4b06-afb3-26f126103002"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c3a36d5d-0350-4864-b5b6-e11f88164253"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("5345c164-f46f-4025-9303-5ababe27c72e"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("7186d5a3-6b50-47ff-8f07-7f548b5d8c4e"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("993abfda-6e9c-41e5-837c-28de1d0edf29"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("21c96e58-77cb-4d78-94db-b129a3eef53b"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("5f2ae251-b582-4a20-8ba4-e0b3017bb3df"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 20, 23, 28, 44, 315, DateTimeKind.Local).AddTicks(1639),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 11, 21, 2, 32, 32, 296, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "Kids", "Photo", "Status", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("14d67b82-c794-40de-ac54-57756c41c1dc"), true, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" },
                    { new Guid("a169084d-c624-432a-aaeb-39668f068b48"), false, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" }
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
                columns: new[] { "Id", "ExpirationDate", "InitialDate", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("a0ff3d3a-8095-4788-a4fa-f0d667cefed3"), null, new DateTime(2022, 11, 20, 23, 28, 44, 433, DateTimeKind.Local).AddTicks(5782), new Guid("14d67b82-c794-40de-ac54-57756c41c1dc"), 1, "20:00", "16:30", true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("a7fe226c-58ef-4ab4-a4b7-6015e23e3209"), null, new DateTime(2022, 11, 20, 23, 28, 44, 433, DateTimeKind.Local).AddTicks(5538), new Guid("a169084d-c624-432a-aaeb-39668f068b48"), 1, null, null, false, "Cardápio de vinhos.", "Wine" },
                    { new Guid("f8c245e6-2681-4ab9-8e68-ee85a35fdcd9"), null, new DateTime(2022, 11, 20, 23, 28, 44, 433, DateTimeKind.Local).AddTicks(5690), new Guid("a169084d-c624-432a-aaeb-39668f068b48"), 1, "20:00", "16:30", true, "Cardápio de Happy Hour.", "Happy Hour" }
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
        }
    }
}
