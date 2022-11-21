using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class seedAttractions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("36f27341-ecac-45ae-b30b-a9aa6a164fb0"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("6aacfe0b-7c3e-459f-907d-0b0be0e1d026"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("7f2e8fcd-6ebf-4c1e-ae83-8f601e06e86a"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("ccbe6648-87d2-4751-89fe-40a8d31ae2a8"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("d6c2da10-d2cb-417a-a721-242509c5a5bc"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("e786c248-455b-4425-9f3b-bafa5bba0a3f"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1bd46c96-48e0-47a5-bf0f-502b48295339"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69e72a19-3533-4eac-9d77-b4562c70e3fc"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("00477c15-b120-43a7-913a-c02a36316b0a"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("7f5ecce9-76e2-4a90-b966-b20780156168"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("f8a1df7a-4db6-4052-9014-fa8149abee58"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("76b2480a-84ed-4470-b6ca-fba05f7631c0"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("a0f08e67-326e-430e-9890-3929c7053f8d"));

            migrationBuilder.AlterColumn<double>(
                name: "CoverTax",
                schema: "Attraction",
                table: "Attraction",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("285d3064-a449-44e5-8a86-ac16a17e28ce"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(4148), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" },
                    { new Guid("4c07b79a-778f-4cc2-82a5-9f1ddc6ebc6a"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(3613), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("2d0fcae6-4c87-40ae-ac89-8bc099e2f665"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(1825), null, "x76I+huDXTT9KNYpKI0ZNts1U9t4GVZw8ESOD9fkNKgBl+1hiTz4HsjJeSJVMtRe3uV1rpa/syKCX6gg9EgbNW5XduCfvXdZvznZupF/z4F+UKnwQytVdQCuE2jXdYgbrOEgJ1LcDDzrXFXesQA6vv29peeMYWD66UmEb0gmd29LHpEMLfrf8pvlR3EAwkRjynO0xczk4ny79ln8lmXtmuI2ZeY1qm4RkcW26wF2aqv+Ca2JKC/Z7RIBkzXnU9Fk20AxatHF2LOrXHvCrR4JnzF/xBFzH4DESLblVsfVHCfflqf903ZF5oJhLwf9oMdQsPffeuiqUb18dfOnUKb6Bdylfk5IYnABB8zTY1dhB9AEdyomBxUhVjgbNsjyHp+s0o8P0gjNtU/9dOwDwcQYyqjcrGUrnGDm23Sg1G+qpR3iY00mAtzs+jmWKEijyR4rTnmlOfGUizVoBjhcPsfih3QFY5ZYKXoCuseMVgJWmTm2YXcoKDr+zBeVjXCJse/Rrlh1XsyiZauj10i0UXkeeXo/KXM8Evt9p7UMx7QuK/968ivc/8cclXJUOtEMQPjxT9KMMNb2zdGeVWbrYRrZUbp5hv7631tPH7TXe1vvZdzIHQGu9y9y9/ru4QZ2GoSW99LD39LAPMXE9Ui6yJCXfLDMsb+NauDQmD33qYiJFlI=", null, 1, "5778ac38-1deb-4e54-9e16-a03b9ab9bb52", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("362a91df-868e-4644-8a1d-3a43306da7d8"), new DateTime(2022, 11, 21, 21, 7, 9, 501, DateTimeKind.Utc).AddTicks(5066), null, "OyoXm5LnQ2yy0tdENbd6Abs3af2t3NmQLg3XOp21KbPUfTbxP2zhFKECtoNBpy5f+H1Nw/UErdqoZlGwjGxCCemv5kJ27o4cKRRzJbNjX1p56+G0DwgzvSfKIRaZXeat/agO7QVbgd3LCySW/MY7ZiNv7YjRFuKCwlAEBkgvFuRFGYSF/93kYFPTZjUf5nuex060qFi8P1vAfX3J7VeX80pyRr7P+eZy/wyg80Qe590yV23Pk+6L1ZNeUcVXSjvhnbJd5a/swSOzpD8SH5tXP5b8dQK0LsneUEjD+r2y96dQhTpSd4qEZAb0g/dnfnC0ldFwI9JclZNDrXE/iHx0cyKKzZaCe1gr2fXciVGfYo9hZLuFsLTBG0SyZIRKkv7WZRx7OKyu3rRqYyBBN553BsT2v4QXiqK8pUj0LZH7HtkWgM5RSg7Jv7MiD59SgSVy1Hka3Tgr6Urgl19whQ3FVlX7DDitpJR4VeSzcwTorXfj66ONr3IMsiSuMHGTvEZl8qt94qyq+IyVSuZ9W1ey0eClREua3LLkNkGx3l0qx7/TbA0zyqvv5lTRFnFDc9glvH2HNliio5R8XZ7stz9gmL4+5n/Hmo678L5C3XEnPboXZ7PdiSvALpewNx9L/h6eY4dJMCKDsWqBaKqQjwjBthuevbPGMGPQllsngCnzBWU=", null, 3, "5e81e705-50a5-467d-8915-87e8bd142a34", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("33c1dd89-9ff7-4db2-9615-846c9654167d"), 20.0, new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6380), new DateTime(2022, 11, 22, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6373), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("4c07b79a-778f-4cc2-82a5-9f1ddc6ebc6a"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("8514e6cb-7313-4bff-893d-7075d80acd4e"), 20.0, new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6508), new DateTime(2022, 11, 23, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6507), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("285d3064-a449-44e5-8a86-ac16a17e28ce"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("9c48feb5-234c-4cce-a275-9fb749ce5289"), 20.0, new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6608), new DateTime(2022, 11, 28, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6606), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("285d3064-a449-44e5-8a86-ac16a17e28ce"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("27e8ac2f-de26-4971-8ee1-647a50314a56"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(5379), null, new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(5378), null, new Guid("285d3064-a449-44e5-8a86-ac16a17e28ce"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("c2c13e61-1284-472d-86f5-3509a7d77e0f"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(4654), null, new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(4654), null, new Guid("4c07b79a-778f-4cc2-82a5-9f1ddc6ebc6a"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("df2f744a-d2e1-4ac8-975d-56ae5f40ab71"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(4929), null, new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(4928), null, new Guid("4c07b79a-778f-4cc2-82a5-9f1ddc6ebc6a"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3e38dbf7-9e71-42b8-a1e6-7e8ed5054437"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6161), null, new Guid("27e8ac2f-de26-4971-8ee1-647a50314a56"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("3fb9ded3-806b-4e01-a020-7545562a0b12"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(5747), null, new Guid("df2f744a-d2e1-4ac8-975d-56ae5f40ab71"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("582fc92d-c4d4-4b27-9151-5108f14ed51c"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(5837), null, new Guid("27e8ac2f-de26-4971-8ee1-647a50314a56"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("7c358971-354c-4304-89f0-3f39cb18e4f1"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(6263), null, new Guid("df2f744a-d2e1-4ac8-975d-56ae5f40ab71"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("842ea07a-6248-46d6-a0b3-b44a3c4c334b"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(5935), null, new Guid("27e8ac2f-de26-4971-8ee1-647a50314a56"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("bae71d6a-bcc6-4dfa-be03-7d231f28bdb1"), new DateTime(2022, 11, 21, 21, 7, 9, 571, DateTimeKind.Utc).AddTicks(5587), null, new Guid("c2c13e61-1284-472d-86f5-3509a7d77e0f"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("33c1dd89-9ff7-4db2-9615-846c9654167d"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("8514e6cb-7313-4bff-893d-7075d80acd4e"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("9c48feb5-234c-4cce-a275-9fb749ce5289"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("3e38dbf7-9e71-42b8-a1e6-7e8ed5054437"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("3fb9ded3-806b-4e01-a020-7545562a0b12"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("582fc92d-c4d4-4b27-9151-5108f14ed51c"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("7c358971-354c-4304-89f0-3f39cb18e4f1"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("842ea07a-6248-46d6-a0b3-b44a3c4c334b"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("bae71d6a-bcc6-4dfa-be03-7d231f28bdb1"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2d0fcae6-4c87-40ae-ac89-8bc099e2f665"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("362a91df-868e-4644-8a1d-3a43306da7d8"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("27e8ac2f-de26-4971-8ee1-647a50314a56"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("c2c13e61-1284-472d-86f5-3509a7d77e0f"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("df2f744a-d2e1-4ac8-975d-56ae5f40ab71"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("285d3064-a449-44e5-8a86-ac16a17e28ce"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("4c07b79a-778f-4cc2-82a5-9f1ddc6ebc6a"));

            migrationBuilder.AlterColumn<decimal>(
                name: "CoverTax",
                schema: "Attraction",
                table: "Attraction",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("76b2480a-84ed-4470-b6ca-fba05f7631c0"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(3942), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" },
                    { new Guid("a0f08e67-326e-430e-9890-3929c7053f8d"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(6346), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("1bd46c96-48e0-47a5-bf0f-502b48295339"), new DateTime(2022, 11, 21, 20, 18, 30, 826, DateTimeKind.Utc).AddTicks(1812), null, "6f/U3of8yC3XVipvUdCSDrqNmjqgFsgtdZ7loyz5IKuBdWMDX67P2/Wks1DHNN5Y7YWwrVS0/gLrip0Zne++PeqGlE8dP+LLMzhQWqueA3cs/sfl5EeunWAo9OA3C+CIRnwHSYVpWQCG+FhFuBsJfvbiqyynL/ZD/ACffDCZCio76pTwXFwu8PSQb4lgfHmBtIDbsr24ZmuD1g1pRHlzq7l186IsxEBCvL1AuzstnJ5I1Qmik+bZwNOFAymkt9dvBwZtrYLfGTQ8OI3tgWzXFGtAayF+OJ4D9t8iOArpVzuHGV1ijqyseozt4RjvHtxKn8KZutOxrhAdJjLat69d323h3S8F6HKYgMyLV9Qd/lI42MO4l4aELXvEy+D4D1hBCQG+drXn/08yCGuIOACEz8N7VTVO956csHXetATKYYLEXUszCh2npvqal+RfMw6Fl+tqVebTLfRgZhPtwpcD/eFgrnhJKSqdX04hVF26dI23Vdcto5VcRkOL2PMtXY0Z8ptp6boY3ciA8mg0LwUgzzmLot8lDjsgker/oM5X/RTW69ZHnOTu0+/1nz0s2g0qsRhW5S+OTUoasEUvyqhbWfUE8oHGLhY7FEIotLpusCDDgT3IkGkCWVNAqBT2SjnCA19nB+Lp57XP3nZU5h5dapt8OLMymOXX3ii7SjeTbC0=", null, 3, "5183552b-74d6-4929-acbc-4c1991f2e5f1", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" },
                    { new Guid("69e72a19-3533-4eac-9d77-b4562c70e3fc"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(2071), null, "GRN420ixRkDng5zsNn8cf9ahp/I07CUS3Yg68B1bcaluX2j7tCTRSiWP9uFx/NlorzaiMteI/u6vr1iXX8HybaudDG8X7ILlBPl49XWY2sXRynJZTP4HKGes4e0pYPA77M7wuhKmsiuIi1k/LgpUViTZ3sPrwrEOjztnGn13KZ+vAM/IaafSadvcb9iflUq1496TKCBHxE+R7d3jeYnXZ2MsU6k0/5HvMnWIQ1coq5AHUntGkn3AXxMPmQGqdNKnFGaaYBfl2hf5311u2aQPVvUk1p4slxJ+NV48xctJzXMGWJlkZihYj4y1J1jvUnBUXTbaJ49cvTePNvLwVEh+GEYej9k+GSZys9CxCAsJil2r0QGheCzoLBb6w2dB7EgdtHXdKZIv4DS4k27Yz5qh/44EhX+IgHRc5bSMeC8tsxqdMnKf3SJKJhhCoMcRlZOcViwSOUP0dznpp9u4vBCTZvBhnElehfG6iY/X636EFXUKwjmllZUyUy0a/r/EaYNCVn9Ygnhb4BGakwFiQJ/yIsMq8ivvobufHXBDW+ys2QtHrc+XZglsb7O2IPIw4DGOs0pqEM8+mRViCZU0JhgA0K0sLUZsOARM5D4oh72UgdLA60BQsp9g3Nlz5vWf7aqfbPmir3QvCpv+VD9E150PP855JR5EkYYc0FhhCx35fwU=", null, 1, "b2f22d03-ccf2-4442-b90a-534f52ada3cf", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("00477c15-b120-43a7-913a-c02a36316b0a"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(7303), null, new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(7303), null, new Guid("76b2480a-84ed-4470-b6ca-fba05f7631c0"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("7f5ecce9-76e2-4a90-b966-b20780156168"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(7814), null, new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(7814), null, new Guid("a0f08e67-326e-430e-9890-3929c7053f8d"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("f8a1df7a-4db6-4052-9014-fa8149abee58"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(6961), null, new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(6960), null, new Guid("76b2480a-84ed-4470-b6ca-fba05f7631c0"), 1, null, null, false, "Cardápio de vinhos.", "Wine" }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("36f27341-ecac-45ae-b30b-a9aa6a164fb0"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(8252), null, new Guid("7f5ecce9-76e2-4a90-b966-b20780156168"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("6aacfe0b-7c3e-459f-907d-0b0be0e1d026"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(8011), null, new Guid("f8a1df7a-4db6-4052-9014-fa8149abee58"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("7f2e8fcd-6ebf-4c1e-ae83-8f601e06e86a"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(8501), null, new Guid("7f5ecce9-76e2-4a90-b966-b20780156168"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("ccbe6648-87d2-4751-89fe-40a8d31ae2a8"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(8592), null, new Guid("00477c15-b120-43a7-913a-c02a36316b0a"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("d6c2da10-d2cb-417a-a721-242509c5a5bc"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(8346), null, new Guid("7f5ecce9-76e2-4a90-b966-b20780156168"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("e786c248-455b-4425-9f3b-bafa5bba0a3f"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(8157), null, new Guid("00477c15-b120-43a7-913a-c02a36316b0a"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" }
                });
        }
    }
}
