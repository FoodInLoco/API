using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class removeRolesAndAddLoginToRestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_User_UserId",
                schema: "Restaurant",
                table: "Restaurant");

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
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("223c9e9a-24c0-4479-86b6-1c5f7dd969c3"), new Guid("964b7b6a-324d-4eac-b33d-576dc188fe24") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("223c9e9a-24c0-4479-86b6-1c5f7dd969c3"), new Guid("de190574-dd9a-4d50-b5ec-baeb92fa83b4") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("db3aa74f-9977-47d0-a62c-5b19f102394e"), new Guid("964b7b6a-324d-4eac-b33d-576dc188fe24") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("db3aa74f-9977-47d0-a62c-5b19f102394e"), new Guid("de190574-dd9a-4d50-b5ec-baeb92fa83b4") });

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
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("08a45035-2824-4b9b-93f0-c53933365887"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("18ff6a3e-b7c6-45ac-aa05-e85046fe381d"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("25e96f3f-e7b1-4d5f-a68f-bc322527daae"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("41e80155-23cd-4704-bf5f-961c87576cf7"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("050b7cc5-3f90-44be-b38b-1319379732bd"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("1bbdb507-d40a-4a65-b480-40bccc806f28"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("cf89c4d3-bb2b-4bc7-af50-4f2f11835554"));

            migrationBuilder.DeleteData(
                schema: "Bill",
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("223c9e9a-24c0-4479-86b6-1c5f7dd969c3"));

            migrationBuilder.DeleteData(
                schema: "Bill",
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("db3aa74f-9977-47d0-a62c-5b19f102394e"));

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
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("6567c8a4-0067-48a1-8557-1ba402badb8c"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("8c7cea46-a3d8-41b1-b6f2-1e27bba2a8db"));

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

            migrationBuilder.DropColumn(
                name: "Roles",
                schema: "User",
                table: "User");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                schema: "Restaurant",
                table: "Restaurant",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                schema: "Restaurant",
                table: "Restaurant",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Salt",
                schema: "Restaurant",
                table: "Restaurant",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Password", "Photo", "Salt", "Status", "UserId", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("1aba526e-8013-400b-9305-1999115da99a"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(4379), true, null, "dzPLdPO66iDtDPTHIlQ0yp6Gig5De896frT7996p0obprqKgNn5L+DnRp7xUnSUrHzIveeuceGw4Qn6yWhnB4Q+4XMw7W9hc654l9pNhhyYgZgKP7VJZnB48pbG0pxwz0QJZyJ/IjnNZsiaG6LeMwzbuExJvfgqy+xiQVEP3408ZxKohVe8tKPSAjrqsdn/ay+G7fIv9QvXVK0VcQs6G87wW3Q59iDMeinGdQCmh+15k2kZF76Nm35tCozadVN3MoOisuK7+NXTZSh+GRE+UaJWmCwX07Tz3hIzGVPaDkBhYRrXOLhi1sY8pQcSOBrh2/+V+Pzh8ySX+kPoGmGzRjm89Y+oGumOJWbzTA6mKzQ5R1TCnYETFYkJSr4gsxlhqh848D25wqBpQnzszuMQ8Fd4XM+ZZ0auN6hdd7sa9lHiSoDZVAoaXdx7adgPC8J6tLNGtVyp8rvkxMtek7oupnjcURp7uGhNKKnEteCXQ5EN5+kMUPWzMjnuEEYxc2FYp1u/SLdJndIXzC1g9tF2HCCXEWe1ARn2HKdngwkJMx0GNNpo6Q8p/u3AnIp8Hmo5XQji/WayNmy6UJ/npFFQvYWwpVxKSBUqJtjSBAKfnuUMgaH2G4u1SFwoq27OpCOan8ypOKoOW7z8N0CNgsxZm5i+sbSZdiaJ94Y9K3EeKLLk=", "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", "d99f757b-4489-495a-9110-ab43510d42d4", 1, null, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" },
                    { new Guid("8bc27b6d-e518-4702-9880-4294fafbff41"), new DateTime(2023, 5, 29, 4, 54, 10, 884, DateTimeKind.Utc).AddTicks(4991), false, null, "fTIoWynRx+nGkJUkW/UDkW+9ck3FwwxUtlaya2QHj90tcAONVuVFfWza16hQEE1Ih8sE84dst8jXIZZdP/zXXpAfptCkTO2lHiLzjvJdIKwNKMjElNT8pxIU8wzd5hrXUU1f3SsxISEjEIQkCb9J9L4ue5CCpCOc7hlOtz6FBm0T+oTplKnQuMuoyEZcPDEhZuN2vffFK7RIuaaeSwZBDTwv2GrHeomtjdWZ1emh3fgGhrqpJAQqGPwNGMwkvs0/CuwgV6xQb7n6E5HrBafpwllOxtjWfc7BX+Py+OJ1Wg+ilKsKi68hh746B0wf9Ilz4WcyBibqMcwpSyZRRwtpaarSre2j2MLF4ZLebXfPCMbUijwN6Qoq3Gs/Od9yCllciE1eQts+C6qMKGuQum5ea24BlMzWLGzFN9JNAdoSZoG1bPcvNaSROxpp4LupyFasNoplrMO1QJG3/12f331vdFX3lP3PJv5gNp/bW7DCprUZV08yIc3zW2oRyc9ufTvexSmgy79Wu2bCJU2UknhXSP+VxN0LC5UQmp+u3Ik6fNbCT5M3XjOEMPjh8juDYd1tjQ9DQ28HMRVuyCJx0YZEZVCnPP2vH75PWU8gUVWCyv5ozRb5h/wJINxoi1AiqPx8wLl9lTXbAketXoGTqU1Ayf8vSyl3PbgjTQB4dBxTer0=", "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", "ccc95a0a-5b26-428e-bad2-8205c5f8ed3c", 1, null, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("0672f946-b9eb-4293-8610-fca84d5837a2"), new DateTime(2023, 5, 29, 4, 54, 10, 628, DateTimeKind.Utc).AddTicks(2715), null, "Z3iGQmxVA4fJGv1L0BKBaEkdv70qqyBWRHVmpns/m7qSx1tK2Re80e+OIe1upUB2Cq6zRzw/nKcqoqJMgnJP21HyfuERhVuxEj/bHxKpJLWqKWQelqzMn3KEdqfxIigP/Cc/IDejGHaeyLccr07ATt5hjYSwWCX3mmBRo4jDqfuz+QCejMk4tDcpzj2jx6RRaoANZOyyR/jcng3n4LSRhbjd9Sg8DQ7MpDvMMBqO1uf16E6lGoURQEtJTgMCxkVjwFWCwxFGoEmKLm+gklF9GTaFVy4JP59cik8oVJm8n1piFCJx88ObRY8OldubwvqN2M3tmtuLGwKsGXgrSzHEG/dKZ4gLe30DEGr9fWf6nLZ8vnrPJS1dmqXQYE/x2/48915/XUVyfI0DE/WlL5vAAMeZU4tZ8hkvkizCMVLTed3qMx4D92IsNS/ZLiAj2pfJirSCkVko5L6H7pZn2SdkELX1L6BRrDgTJgw91ch8FySJDow8i+QdxK3KYWfYGneHLn2UwEk+WadBR7zlZ5U68H++6qiXrK7uEFbJrWQTZ4WVnMr2hzms8IRahOQKEb+F+JB0gJw4sXF0pW2KJRwjzqf5FHkSptHyt1dJyelIMXydRgCg7ZCMxBdawwRMXsCkAyv4GsiDg9g2qPc5jj1OuCHCWpQz33+UQvj8zmYAbNE=", null, "dd477ae8-19b9-4d9c-a14d-187d85c77343", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" },
                    { new Guid("c1a9d0bd-df87-4547-9663-2b74c457df79"), new DateTime(2023, 5, 29, 4, 54, 10, 702, DateTimeKind.Utc).AddTicks(8846), null, "4oD8dCOTmtWWTfT9FzFXwPjHKYLL545RNDTymJCEQxeLGMQITU7oBbOux9fRKOPJisf1wguX4AdUV/dv5lQ2wuBxojEH8p8eUj/MuQX6okjMaQMX4zcDik2TRAgt5SKvlZJ0OFO3XCRrxLkVfM3hGox9w6SzHjKOVJ7i5mDRIqojB9upI5PG3y6JDHSiqGgpWFF61F9KmxFkw5UUS6VJ1x/PdGx6Ib7N03qmTvgc9CV6C0Qzm7Kl3CItiT/Iu2TGQHweGaHv2loHDUn4HOZ0f/vCIcqFtcJZ7DiaMYvpStxwkGtm5d926sI/2Om7cYANqU2ahalxVCorhnKbdUZTLzX/hkr7XA3Ps82+0ScG2ckr+7+tVO3AI5FBS72/6T700+e0qrpee732eUwXS8SPAMMeBW7aVoYTywcXCK0RAaQjOOCAqhY7p9B0qJhzOfoEKDmLYL1wXel6s9z5oeCRZgoV41MAHks6p8gLEABFbx9VKnHXS5X1zJCXwPae7LsxYL3pBxuG3S7wieeueZiob1b3pnOmWHcjL9KtIYhGOA1lNVM3+jIvmOg4DhZQvZSTQeURhxmijN9qBgZupOssrO3562rvMCijZTsPAEOH8fE0d28IP10Y0jQ3gGY2K//E5yhJKNEelPQfW20tSvW2uYLySW+hQhDzRYVCuYA9HUE=", null, "bef7f6c7-e727-4562-bc9e-34980befe709", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("e0564670-f479-44f6-b3a3-23dec0d2d6f7"), new DateTime(2023, 5, 29, 4, 54, 10, 786, DateTimeKind.Utc).AddTicks(5660), null, "iIlGpR5tjxqrsmTBFBa3y1BkoNg7M6Ewm9U5cEmAKTeToZ9vb0FxCtHoBbliQ3l5DTjYiQUoo9akujgm8Go9wWAUycRJLZ5dcQJcRz9EKRiVUmQu19BpwQVnj1Ks0pH5ypRZklgFV4ZLQhEbPDd094v5eguC/qju9lRX/d77722SgPAuKHRdtXux5kdK0ZoJrGyBvAaTD2VHEOcvR/vYE38KGxaHlglWps0d9VA9Xw194hEVXmZ3g2Uq13ZecJn5ekh5+IvM0bVwrIiM/RoqrutJmKQOWWHUseDtOdWbBGDZdgwUsQJxhE03+pF6IbWzRSbUzl9T43iVqO0KFvn5/tkOUElBLG+DSEzXedRBLOAxNfu5jzRe+KPg5s2GBV8EbPqc8zJS4x4l5zLSrqOTToO1O8pyKQaio0AJB47loLhMNWlix4nhN1gkhQCcrrScvh2cLWENN0jNlhmjPJ3nOGhaegWx77G9AwWdWCWeZTDpZn1khWjdVhcHHh6TNOuZtj738FVgSTTYCRQKC4e3r30ycVxAsrXntzYovKneDw7FtfVB7GFBcf+b5H+63OAi8RhrJzkpkxNlgz6IsCoz+Bc4wCHBnMXgvMXH0kcSwVIeEoDwaDOmZK6Qzh62YPE9yHViZT8ravmLQmiu1ZHz73d+ryp5GELswj/tEYpF/2Q=", null, "43abd271-a615-45ee-a0a7-c8fd23a1bdf7", 1, "85", "999174742", "gabrielevaristovcp@gmail.com", "Gabriel", "Evaristo" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0274ea44-9895-4d76-82d9-88d21b80b4ee"), 20.0, new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6532), new DateTime(2023, 6, 5, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6531), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("1aba526e-8013-400b-9305-1999115da99a"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("14528916-e2ca-4a75-b111-9afd0074e91f"), 20.0, new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6486), new DateTime(2023, 5, 31, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6485), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("1aba526e-8013-400b-9305-1999115da99a"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("861b4d46-b305-4d2e-a9cc-cab1d203747d"), 20.0, new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6371), new DateTime(2023, 5, 30, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6363), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("8bc27b6d-e518-4702-9880-4294fafbff41"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("10b92eec-b50f-4cf6-bfd8-a3b1cd5c9c5d"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5626), null, new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5626), null, new Guid("8bc27b6d-e518-4702-9880-4294fafbff41"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("7f060c4c-57f1-4280-8d52-4b6b4c86723f"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5850), null, new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5850), null, new Guid("1aba526e-8013-400b-9305-1999115da99a"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("9ce0b2fd-de97-4793-8a3b-9a2023604184"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5298), null, new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5298), null, new Guid("8bc27b6d-e518-4702-9880-4294fafbff41"), 1, "Cardápio de vinhos.", "Wine", null, null, false }
                });

            migrationBuilder.InsertData(
                schema: "Table",
                table: "Table",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Number", "RestaurantId", "Status" },
                values: new object[,]
                {
                    { new Guid("2ae72198-e773-4767-a081-70263f5f7d1a"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6605), null, 1, new Guid("1aba526e-8013-400b-9305-1999115da99a"), 1 },
                    { new Guid("3c4573c2-d871-4910-bba9-69c381cc8838"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6601), null, 2, new Guid("8bc27b6d-e518-4702-9880-4294fafbff41"), 1 },
                    { new Guid("507faae3-bdd3-41f9-b8ce-7f5fb04bca27"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6603), null, 3, new Guid("8bc27b6d-e518-4702-9880-4294fafbff41"), 1 },
                    { new Guid("75972842-354f-46ef-a806-48b48155fbff"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6591), null, 1, new Guid("8bc27b6d-e518-4702-9880-4294fafbff41"), 1 },
                    { new Guid("805075e5-55de-4c9d-8e21-325515d3bde0"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6607), null, 2, new Guid("1aba526e-8013-400b-9305-1999115da99a"), 1 }
                });

            migrationBuilder.InsertData(
                schema: "Bill",
                table: "Bill",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Status", "TableId" },
                values: new object[,]
                {
                    { new Guid("473cf64c-bed8-4b86-ade3-ec5c365a5d95"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6633), null, 1, new Guid("2ae72198-e773-4767-a081-70263f5f7d1a") },
                    { new Guid("66c22ca4-d6d9-44da-a5a9-72b63d6338f9"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6627), null, 1, new Guid("75972842-354f-46ef-a806-48b48155fbff") }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0452a8aa-94ba-4f78-84a0-e8a2a3713c12"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6301), null, new Guid("10b92eec-b50f-4cf6-bfd8-a3b1cd5c9c5d"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("08ce0d9b-7d57-4b13-a2d6-d61052e0f1ee"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6247), null, new Guid("7f060c4c-57f1-4280-8d52-4b6b4c86723f"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("0cf8ebf5-cc9a-4669-bb97-879a7eea264c"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6097), null, new Guid("10b92eec-b50f-4cf6-bfd8-a3b1cd5c9c5d"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("b1cf6bb1-ee24-4fbd-bf5a-0e636a9671ae"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6201), null, new Guid("7f060c4c-57f1-4280-8d52-4b6b4c86723f"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("cbcb7d4c-a446-4469-be56-86f1c83f2d2f"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5973), null, new Guid("9ce0b2fd-de97-4793-8a3b-9a2023604184"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("e05ce716-41d5-418d-adbd-0554d3e44aaa"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6145), null, new Guid("7f060c4c-57f1-4280-8d52-4b6b4c86723f"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" }
                });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId", "Status" },
                values: new object[] { new Guid("473cf64c-bed8-4b86-ade3-ec5c365a5d95"), new Guid("c1a9d0bd-df87-4547-9663-2b74c457df79"), 1 });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId" },
                values: new object[] { new Guid("473cf64c-bed8-4b86-ade3-ec5c365a5d95"), new Guid("e0564670-f479-44f6-b3a3-23dec0d2d6f7") });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId", "Status" },
                values: new object[] { new Guid("66c22ca4-d6d9-44da-a5a9-72b63d6338f9"), new Guid("c1a9d0bd-df87-4547-9663-2b74c457df79"), 1 });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId" },
                values: new object[] { new Guid("66c22ca4-d6d9-44da-a5a9-72b63d6338f9"), new Guid("e0564670-f479-44f6-b3a3-23dec0d2d6f7") });

            migrationBuilder.InsertData(
                schema: "Order",
                table: "Order",
                columns: new[] { "Id", "BillId", "CreatedAt", "ItemId", "LastUpdatedAt", "Message", "Quantity", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("148917dd-744e-4cd4-bc83-d375aef9ee84"), new Guid("473cf64c-bed8-4b86-ade3-ec5c365a5d95"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6676), new Guid("e05ce716-41d5-418d-adbd-0554d3e44aaa"), null, null, 2, 1, new Guid("c1a9d0bd-df87-4547-9663-2b74c457df79") },
                    { new Guid("1507c5c8-7e4d-4172-8820-a3696121c534"), new Guid("473cf64c-bed8-4b86-ade3-ec5c365a5d95"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6677), new Guid("08ce0d9b-7d57-4b13-a2d6-d61052e0f1ee"), null, null, 1, 1, new Guid("c1a9d0bd-df87-4547-9663-2b74c457df79") },
                    { new Guid("6c9def27-c144-4967-a45e-126271310e0c"), new Guid("66c22ca4-d6d9-44da-a5a9-72b63d6338f9"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6667), new Guid("cbcb7d4c-a446-4469-be56-86f1c83f2d2f"), null, "Completo", 1, 1, new Guid("c1a9d0bd-df87-4547-9663-2b74c457df79") },
                    { new Guid("8b0ce6ea-f453-4a92-880d-6d3cb27260aa"), new Guid("66c22ca4-d6d9-44da-a5a9-72b63d6338f9"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6673), new Guid("0cf8ebf5-cc9a-4669-bb97-879a7eea264c"), null, null, 1, 1, new Guid("c1a9d0bd-df87-4547-9663-2b74c457df79") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_User_UserId",
                schema: "Restaurant",
                table: "Restaurant",
                column: "UserId",
                principalSchema: "User",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_User_UserId",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("0274ea44-9895-4d76-82d9-88d21b80b4ee"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("14528916-e2ca-4a75-b111-9afd0074e91f"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("861b4d46-b305-4d2e-a9cc-cab1d203747d"));

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("473cf64c-bed8-4b86-ade3-ec5c365a5d95"), new Guid("c1a9d0bd-df87-4547-9663-2b74c457df79") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("473cf64c-bed8-4b86-ade3-ec5c365a5d95"), new Guid("e0564670-f479-44f6-b3a3-23dec0d2d6f7") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("66c22ca4-d6d9-44da-a5a9-72b63d6338f9"), new Guid("c1a9d0bd-df87-4547-9663-2b74c457df79") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("66c22ca4-d6d9-44da-a5a9-72b63d6338f9"), new Guid("e0564670-f479-44f6-b3a3-23dec0d2d6f7") });

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("0452a8aa-94ba-4f78-84a0-e8a2a3713c12"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("b1cf6bb1-ee24-4fbd-bf5a-0e636a9671ae"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("148917dd-744e-4cd4-bc83-d375aef9ee84"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("1507c5c8-7e4d-4172-8820-a3696121c534"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("6c9def27-c144-4967-a45e-126271310e0c"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("8b0ce6ea-f453-4a92-880d-6d3cb27260aa"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("3c4573c2-d871-4910-bba9-69c381cc8838"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("507faae3-bdd3-41f9-b8ce-7f5fb04bca27"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("805075e5-55de-4c9d-8e21-325515d3bde0"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0672f946-b9eb-4293-8610-fca84d5837a2"));

            migrationBuilder.DeleteData(
                schema: "Bill",
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("473cf64c-bed8-4b86-ade3-ec5c365a5d95"));

            migrationBuilder.DeleteData(
                schema: "Bill",
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("66c22ca4-d6d9-44da-a5a9-72b63d6338f9"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("08ce0d9b-7d57-4b13-a2d6-d61052e0f1ee"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("0cf8ebf5-cc9a-4669-bb97-879a7eea264c"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("cbcb7d4c-a446-4469-be56-86f1c83f2d2f"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("e05ce716-41d5-418d-adbd-0554d3e44aaa"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c1a9d0bd-df87-4547-9663-2b74c457df79"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0564670-f479-44f6-b3a3-23dec0d2d6f7"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("10b92eec-b50f-4cf6-bfd8-a3b1cd5c9c5d"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("7f060c4c-57f1-4280-8d52-4b6b4c86723f"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("9ce0b2fd-de97-4793-8a3b-9a2023604184"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("2ae72198-e773-4767-a081-70263f5f7d1a"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("75972842-354f-46ef-a806-48b48155fbff"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("1aba526e-8013-400b-9305-1999115da99a"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("8bc27b6d-e518-4702-9880-4294fafbff41"));

            migrationBuilder.DropColumn(
                name: "Password",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Salt",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.AddColumn<int>(
                name: "Roles",
                schema: "User",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                schema: "Restaurant",
                table: "Restaurant",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

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
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "UserId", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("8d420721-f914-4a00-8c3d-c83cb83b1570"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(955), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, new Guid("3a1ff367-3013-4a81-9118-7c9df5f13f24"), "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" },
                    { new Guid("ffca0fdd-b31c-4fea-b18e-fb3021a4577e"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(192), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, new Guid("3a1ff367-3013-4a81-9118-7c9df5f13f24"), "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" }
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
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("15968327-5349-476c-bcfd-a760913a23ce"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3684), null, new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3683), null, new Guid("8d420721-f914-4a00-8c3d-c83cb83b1570"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("55321c95-66a8-490b-91f2-f269e419abec"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3051), null, new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3050), null, new Guid("ffca0fdd-b31c-4fea-b18e-fb3021a4577e"), 1, null, null, false, "Cardápio de vinhos.", "Wine" },
                    { new Guid("6aaf7dd2-3edf-476e-99eb-5ce14b671733"), new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3282), null, new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(3282), null, new Guid("ffca0fdd-b31c-4fea-b18e-fb3021a4577e"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" }
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
                columns: new[] { "Id", "BillingStatus", "CreatedAt", "LastUpdatedAt", "Status", "TableId" },
                values: new object[,]
                {
                    { new Guid("223c9e9a-24c0-4479-86b6-1c5f7dd969c3"), 0, new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4729), null, 1, new Guid("8c7cea46-a3d8-41b1-b6f2-1e27bba2a8db") },
                    { new Guid("db3aa74f-9977-47d0-a62c-5b19f102394e"), 0, new DateTime(2023, 5, 28, 0, 24, 26, 369, DateTimeKind.Utc).AddTicks(4725), null, 1, new Guid("6567c8a4-0067-48a1-8557-1ba402badb8c") }
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
                columns: new[] { "BillId", "UserId", "Status" },
                values: new object[,]
                {
                    { new Guid("223c9e9a-24c0-4479-86b6-1c5f7dd969c3"), new Guid("964b7b6a-324d-4eac-b33d-576dc188fe24"), 0 },
                    { new Guid("223c9e9a-24c0-4479-86b6-1c5f7dd969c3"), new Guid("de190574-dd9a-4d50-b5ec-baeb92fa83b4"), 1 },
                    { new Guid("db3aa74f-9977-47d0-a62c-5b19f102394e"), new Guid("964b7b6a-324d-4eac-b33d-576dc188fe24"), 0 },
                    { new Guid("db3aa74f-9977-47d0-a62c-5b19f102394e"), new Guid("de190574-dd9a-4d50-b5ec-baeb92fa83b4"), 1 }
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_User_UserId",
                schema: "Restaurant",
                table: "Restaurant",
                column: "UserId",
                principalSchema: "User",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
