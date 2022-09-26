using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Value",
                schema: "MenuItem",
                table: "MenuItem",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "StartAt",
                schema: "Menu",
                table: "Menu",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 10, 53, 23, 997, DateTimeKind.Utc).AddTicks(8274),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 8, 22, 10, 6, 48, 739, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.AlterColumn<int>(
                name: "EndAt",
                schema: "Menu",
                table: "Menu",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "Qzg9SDt1iyADw9D2lB4VsxKwGiNhwxT7ucgHphahgAhZyLNcMSrpmHTAeLNFSavKjB5yHT8muc7bs3NIxNL1YpwM3a4lOptdbP4N+U/ooaFeMZnoxMm5xXVWRGDD5h9YTZdp5kwN3X9BfKCPtGLQ2NQtE8Tl1WmiatP59Uzr0DJnBwJS2a8ibZONxwMOndlzkqn5J7Y5Q8jxRozlj2324b5ARH7X5XP9Oka50kD31U+nMNiWI+nXZTMG6MauvQACu/rXyTpn2PcOpLm2JfyZzRWcQrCZkYFlJA9/YLa3s7bbKB51BP7whage37GgNJExgBbkscyKmG0QkLBgjHeq2+xSAXGfI0nFgKbOO0QQTYnTfrcrrRcuvfHYMd2Alo7VxbzK8zBTVzZJV28SguPo3n859QoZuqqqCCfvHX14RS/aUSpoVCs4ZOCNkMpIXgjZUgF9E09di48cTLGIDxkBxz3mdJfn67i1XNj9tApL71UCKo9inbHz1T5eQoyVTyIpxc2mgn+kOIQGOAFne7452u8LrYbCy8SzhYe4v2hwAcFVzWETKS45BmkCpE4LpkIuV3OACKLapXYZcmmQjiuV7mD6z+ds46kqteHpsN7geDOkDT+3KTJ0x48KYfuGaL6l1kyTGmyjLfyzHb5YQXJyH+tpAG4Fk/hKQp7z+Ty0s2w=", "1ff7a590-d4ae-4adb-8502-c0262069b1ef" });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Auth",
                columns: new[] { "Id", "Login", "Password", "Roles", "Salt" },
                values: new object[,]
                {
                    { 2L, "macdonalds", "UqnOf9jVqV6vena9kHrSrHNFtJQZTlDpA+skXFKtX0vH4DBQ1IcrqiZjF/zQ2bC3BiYj0eMoDG2dMfSBASRkAbG1FfVI4faF0u1GAZDEdEsMWHOTEHdfquCDKCxc0XOpSExGTNM+FgjJLH9dZ78bSn/3c1Ck1fC5L4STnpLo7NYbeSQaj8OZanzWX6uTHEJ9Iq4XMnbMalkQzdo4h2cMxWPetfsmJr82PeC0kB3Uchudis507io+z3vaAVGtg8GzObFQgQUoYATraQSFhxm+4u02jbE4U+rP/setf8fAXeluPqC6/MleBFe+p/UbsWJfySQqDczUn4qUocuPoep1vRSLemSpOhnNHCy5nyg1xQRRX56HYIpjYy9ZodgecicDBqSM2mCpF5OH4a8NoNqa/4l17KxBD8Ws58Ly4J9hxdy5Qjk2AaYzRwyMN/bD7obLeAMNOpfDoVksYB3kAfo84hncl4r41BsYEMAAS0w2zSptC5/9AZhva198p49FA55f1rkBVptsE3bUL8J1e4kKHzWmYEpCD6vpZazt2UEPrxn9Z+R3R0xO9l8aQg63EHHIep2RlnNnAeGxBy/d4A8gRgek0ol4qve6y+0HlXNPird0MjEuarmZ318RH/ruQ9nbnaRLPrSRQVHMkbEpLDF3acShN6LQuDP4H5cY6wKZ/eA=", 4, "801d0221-fd42-4cb5-9067-d3823e04ac81" },
                    { 3L, "pedro", "G50bVmlvvmel+W6/Rfq2Jk94E6Pluy493CLK/Gi7ITllKbO3NmaRNFy2sIOUM8HtDGlN7OMEaLt03XWBD2ai3n3Vqpo6q02f48wG25Dkts+0DJm9HdVHZMoRQWb+G2XTd7Htgs8BfABGZhqVc+dN79Xu0CPDMbG4B6vJzLA9H/TzUhWhIVY0el4fQXwdf69+DrSYUpmkJ6V0LHjKhSIHnPIYz4V5u1pdzRoXMCcKRmpcMis4Jmcn1nW42VGBWCTOo+pjd0g/HCMYcqvlm4/ALTu476zt1jJqDStcrn44G62CAPZMov8QqOXEEWoppRpZrmO0Va3pfXcObJ2BX4jNDmjPRuBEfHFsAF7VHxKSYdDKQHgmkM1E51TTEJEa5h+32kCJ4GXYrBN8oUWUZsezbAzOzxCdJwkRoYidj7KeUotkVP/fRMIMtRFtMBukowOkKIjRaX9roF29uhQWfWmI+5DcMKKeShUmCG9ob9T6pROnq0hNVsQO8vR8059tFKJMNhv0VXwpf5JO7sn9IsG/uBFf3FqsnrMToLRRzP1HTP67eGbxYFsVQXZEzquUNAZIkZWSkGiIbrSfyStQnFm4ASUqrzKNPl9loa89gtR26ORRQKAe3vadMM1XzpvSIaqMy/OiL5a8cEXTeZQ/DUSPOGu0zIFVGD/bRDYB/S5bIrI=", 1, "331f1187-3c1d-4a6e-987d-1252cab58556" }
                });

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "AuthId", "Status", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[] { 1L, 2L, 1, "85", "997851936", "letter.pedro@gmail.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mac Donalds", "Méqui" });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "AuthId", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[] { 2L, 3L, 1, "85", "999999999", "letter@gmail.com", "Pedro", "Lopes" });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "ExpirationDate", "InitialDate", "RestaurantId", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[] { 1L, null, new DateTime(2022, 8, 22, 10, 53, 24, 190, DateTimeKind.Utc).AddTicks(9541), 1L, "Cardápio de vinhos.", "Wine", null, null, false });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[] { 1L, 1L, "foto qualquer", 1, 1, 11.99, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 3L);

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

            migrationBuilder.DeleteData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                schema: "MenuItem",
                table: "MenuItem",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<int>(
                name: "StartAt",
                schema: "Menu",
                table: "Menu",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 10, 6, 48, 739, DateTimeKind.Utc).AddTicks(5548),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 8, 22, 10, 53, 23, 997, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.AlterColumn<int>(
                name: "EndAt",
                schema: "Menu",
                table: "Menu",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "Ywh5sxyZwNhv41ttnYPNGbYtpxYY2qZa7d4sABOvHyPjmlWSQ9394NXIYLrDcoQT4qOP/+IAU1xXtRk6FRX4T2vnTyqt7Z4cPvSaeRwV6+U0D5QYsJQhoyq/MWwrheazdEkqA9u7HpEdgQZ4iiSDFRd3Q2ePoZQ1eJzDZ8FCAiURB6EbfH7sWhga+vF+ipx1ifkLQHWZ+AO9nnUJw9qIANe6opS3U8MHT7SQUteXTNDUAmPNK+MidmqBTnmnFs+gjeqOyX4hCuFjLy8hRhu/GdFJFDUKWgO+49/x9JinhRZkNRv6kgQdDjtfcfzrY1N73oc/f0kOQ0NijDHzaIDvye2JLp6O68nZjOVYRQ5U9lIuwQoaPpD3b+bePnx8jJ/dBRqeQQzn3xRyk+1R4SHiykAVZcOMRuG5DOLaF/bUC3ECu5QPUGFQSDy8qChOdFoRQSEJpMZ06EUFqpw5CZyFm5kubbejlew1tdRIIdgL/F5HXFRKXd9+ysxyVT1ktnjHljLBBZaFqK6vM/LlY0vLtZGLBCETthoiubErDUN4CJX+sUGIfnNtKCGBvo0SQ6N09OFym9MCQOsITX64GKx+uNQJ9/nNWaKozK4J/TetBPdXpM3ZL5zFWOPUY+s3RIg/zrwkxQx/tarTUwTKxJi3RQkUrHFDDxKhf1BHT03Ilho=", "79005744-e69a-4b09-996b-08fe0b70cbb9" });
        }
    }
}
