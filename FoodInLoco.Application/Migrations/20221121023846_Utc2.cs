using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class Utc2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2022, 11, 21, 2, 38, 45, 976, DateTimeKind.Utc).AddTicks(7941),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 11, 21, 2, 32, 32, 296, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "Kids", "Photo", "Status", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("39a10ac3-803b-4154-a84a-002c4ff2e4c4"), false, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" },
                    { new Guid("b7056268-0c3d-4e3a-8a0b-250f46f05a11"), true, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" }
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
                columns: new[] { "Id", "ExpirationDate", "InitialDate", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("abfe87a4-c2fe-4987-a1da-50a57afc8744"), null, new DateTime(2022, 11, 21, 2, 38, 46, 107, DateTimeKind.Utc).AddTicks(3093), new Guid("39a10ac3-803b-4154-a84a-002c4ff2e4c4"), 1, "Cardápio de Happy Hour.", "Happy Hour", "20:00", "16:30", true },
                    { new Guid("df56ba80-2cf7-4806-a76b-f4dbec5fd60c"), null, new DateTime(2022, 11, 21, 2, 38, 46, 107, DateTimeKind.Utc).AddTicks(2791), new Guid("39a10ac3-803b-4154-a84a-002c4ff2e4c4"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("f656b199-3375-4861-8bea-cc87bc8a1e28"), null, new DateTime(2022, 11, 21, 2, 38, 46, 107, DateTimeKind.Utc).AddTicks(3463), new Guid("b7056268-0c3d-4e3a-8a0b-250f46f05a11"), 1, "Cardápio de Happy Hour.", "Happy Hour", "20:00", "16:30", true }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 21, 2, 32, 32, 296, DateTimeKind.Utc).AddTicks(4624),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 11, 21, 2, 38, 45, 976, DateTimeKind.Utc).AddTicks(7941));

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "Kids", "Photo", "Status", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("21c96e58-77cb-4d78-94db-b129a3eef53b"), true, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" },
                    { new Guid("5f2ae251-b582-4a20-8ba4-e0b3017bb3df"), false, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" }
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
                columns: new[] { "Id", "ExpirationDate", "InitialDate", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("5345c164-f46f-4025-9303-5ababe27c72e"), null, new DateTime(2022, 11, 20, 23, 32, 32, 421, DateTimeKind.Local).AddTicks(3318), new Guid("21c96e58-77cb-4d78-94db-b129a3eef53b"), 1, "20:00", "16:30", true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("7186d5a3-6b50-47ff-8f07-7f548b5d8c4e"), null, new DateTime(2022, 11, 20, 23, 32, 32, 421, DateTimeKind.Local).AddTicks(3115), new Guid("5f2ae251-b582-4a20-8ba4-e0b3017bb3df"), 1, "20:00", "16:30", true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("993abfda-6e9c-41e5-837c-28de1d0edf29"), null, new DateTime(2022, 11, 20, 23, 32, 32, 421, DateTimeKind.Local).AddTicks(2876), new Guid("5f2ae251-b582-4a20-8ba4-e0b3017bb3df"), 1, null, null, false, "Cardápio de vinhos.", "Wine" }
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
    }
}
