using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class waiterrequested : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "WaiterRequested",
                schema: "Bill",
                table: "Bill",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Password", "Photo", "Salt", "Status", "UserId", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("34d11be2-5678-49ab-898c-48bd072df432"), new DateTime(2023, 6, 3, 23, 8, 17, 436, DateTimeKind.Utc).AddTicks(5279), false, null, "cxx5nuEQi5vOlXoicE3BIknQREeHWC6wxtDpoe+3JC55GXEqES9sUgqcebe0Fa21Ah6Qvjh2tyYs6UqfZy/X5mib8MK3BKdIrCSwG+xFO4sFATvF2eEBa7/ualJUhv+LlwuRUlUiIkck92OfxWkL8laB7WxEcJ8KR+cTvancY23SJrOy4sCoi7wgx2Wta5LxpbaDu7xEeVci5n5YlgXOYPJPnHO1oU8LeZNRDU2O4QNgvywSHLNGLWgaR3VU7JiDqiJ2J6+IOoVKNMlOMRok/+nBF2fQUlsvSVUv4lmdosCfc+87+id4WoSTSWWjka4mLqWu9/xjQUIwQFPazbtPp2HN7L7GiNP+J+nUcitb69fXOKKObeBX4IW86UiFho27ghh/EV81emuQOzQPeum55Zhuqs/5W4AgLsfzCq7oBY5DlAO3CIs+yVcNfpm4xtjcIC5nOAmry4p8ZWW3n7WA6CmElT2mrGVEP6/sBoReCDY9viDEw4kGNC6jGLuMpD7OGGjbMMGJoxHktnzXMVM270o1StPB7qahWYzfxBG36AhFSDBXO/smpkRclV3xmmtUCGXYEAeAezeMN5p0IV0XROiuHf+eke8pcVvV+j3SKKuZXwZBdLOIodIrp4UZJjeuOQ+muVR/XCFuIp8DFo/7l56vACtWpkmHoMN455JrYDg=", "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", "7fc569b6-b6dc-45b2-80e5-908e01a5d126", 1, null, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" },
                    { new Guid("d6ba4110-a03b-4f0b-9891-e8243e49955d"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(1868), true, null, "Mu2mnV8I+Ex/cLvAxFDuxrk/ntjP9+WE/y4mt3CWhkf7Al8ZdJ/t9qVJbo0aHwCFQQOGzDGwMX6+IeT/KwAShouQu+oYns6rK/rvZSYZ5P9+cxJRzvxAsxyjY2TJRCGDkYyRWokxIwitAJhe4M4r4AiXT88nQvk9bo2MJhs4c+Y1j1+0y1tR35RLZhAsWwJtSrlYqdxkkO2U17WgKU+p61wW2d36gGBNkPYNAMY5GWloBAl7Y3njnimDG3KrVHltYsnedOcCFHYi1CyoUqjmGt44yyvU0FEtZVzrcFJOdcOW12AKci4RStTFtWQPr1ZCM9Uff3dBRopb+nEccNUMRe0a9sKpHg6cKhAjy+cmm3KueVBJMb9SrPIHFEr+RtwC+ghnqZF397DSrt992LwnrCpAcBt6bCdFYwhG8WyNaB71GgUDoI7KYtQxecyF8iSI8vUoqCPIdiry8BXuA2GhX7Czpzji+kZPAsMVyq5Lr2zx2SNmcb4k0z0rgvQ1rFbycKqHgarwWpaOZMMp82ig94gPYQsi95ah+0atAucDh+EBR7iVaAtpZ27nIBwLszgMmVVj8DNBmFW5hjIndgYWdQs9FaZkpnaN0V7/6nWkuTytilR8RzYW53TsS9a40UvQwB09GINqW3nCwP9ZqOZRNzgyd+zwHcbD6znqiTcJMBE=", "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", "72ebe5b8-502d-4133-8d88-bcca8293cfe6", 1, null, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("209c736c-9759-44ed-9cde-61e17f287443"), new DateTime(2023, 6, 3, 23, 8, 17, 259, DateTimeKind.Utc).AddTicks(3048), null, "dI8De0r3gQIlNfu5pgAVNpWRPVRhGF6MIwtd3s4r9eGpkcdoor6qKJq/w3J0UK2OAWoYxXu5IDtm2wVy38vSuD/H6KwQe6XEtrL55WQQ55bPx7I/NUWQ1p4r162Y8lw6opGKM285HgFSt+eDfhYg0F4TqqalVxssVPGMSn5ztgBI+enKuxtfVSD+r938AgK31qzElzrw+te6jZWtR3P/6vA6nhNZg9wCRpEr5W/qnJ2UGVtJQ4eyr7WGjP6EkU4mLkhtpWJTBb5ZpUvqGKtEKl1dq9cqsK0nbtVdCFEKFQ04vLJD0/qmH/f4XoeDfCffgfhB5hriE8QoTAkY7l4vooZsXN4gt4Bjznd5TdiwSa5zopgvSVQLUzt1d2EKnT9KS2wMw9XDImyVqRu7sWfuOfKnrvdt7PgsV//yy+VZ6KjafHzw/JjQA2zBHmTLRNwcQB6PDY5Yswu4Tj2h9nysM1udZS3BH2WmpQTKmdNVB4VjBwoYvVRrsGR+MYgseDblztH5EzwVVu2JttMX4U12dCmpPI/aPTQBYDErm0GEHIJ6Yq9BkaoJDYL0oQ8yHP2uI39EsBh3LU0yo+4ZiTnFQVufWI8Cw1QZsPUDhja6sZeZxFX7dUL+q1Pq21Q1U9D2/+eg/29pDL9rcuXVr94+PVwZNxOMgRvqzr4kvzePrrk=", null, "e48b24e2-df1c-4479-9916-1177aaec8496", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("47729b55-fd05-4608-9c8f-29888bdf73dc"), new DateTime(2023, 6, 3, 23, 8, 17, 175, DateTimeKind.Utc).AddTicks(8855), null, "SjwuL8PGogXfDPuOu9s4Kri+BDSahdWMad/RslzCHwOBK7Y14155ZUv8r+ny8lCHgU+sFAhdf7tqf28mwn2kDxl9SyqdpzKWys/SadknEAQqXK7qYdINNpUlV7t1tuP01dq35T2bcjv/exgoV3QC0y8531z+U4Et8SGQDZ5iqhdatdgIAqZjcIsKYxy/q72jHAzgzjae3qol+1mziFKa1XNfeppsWPzeRY+tQF99WAlIoRLQQMw6hJY7E40VMI5YYIB0gvdxiPa1VuBY6eYt7dAEaqyP4lliIfU95hWoejLmCUUjGTmCqmbrDWj55iPkOXZ3zz4y2/jH89LCWTAXXu7g3evQhZQInxdDPMi5uzT4I/fevl8vF9emAQWkjs2I9b0dGX3//4j3ZMUn+Nna7rOEEK5d9HH7ucBAhIy6wk1YRuNajvO759DufnYjuTCFFR7TzGsDO11NlXionMPOAwZc5d0RzB2tub+s76Kz49F7T/kTdlwRRrvcVNCqMIzHmyQiuKE1dUCFV2emZBxiYOzBKM1yDWsvTXPVO/qU/lFzGvg8HcAJ65F/B7OIN4pse+sqapHRMBKodGGIO0lWdv/uOknS1wex/4aS8BPTQw+3WUPcbOq+cVMd4OJKOtRLe5N3rkZ3lgyW13E7kPJCNtTSQ/iUE8nsdTbbb4KA3HU=", null, "a9ac9bcd-a4a9-4cf3-a807-8749458c5003", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" },
                    { new Guid("b682d3ca-657a-4632-be6e-84f9e98a1b48"), new DateTime(2023, 6, 3, 23, 8, 17, 346, DateTimeKind.Utc).AddTicks(178), null, "fdbLpVqPq6tAf06qzvsv+Bmmex6TtLxUCeyJgCATYYi/jX2DcCMucN/6RxsFkoUwTeSH3I7o4aj1mQFu/eHkmNVTPAE606brTdZnEn+wwkMQ8ufMZ9zRMP7j3N4NqPGQ815cIeVNaq1jdRb9BwXLjjUq4RXiGT05mUEdqmJP7gipwtX4GGXGZPkKcVBGichfHzWtQdtUGeTv/1LB/TqAVmdZr8Q53C1/yetgCbo/YV5segG03uGpPNrvQZj7sndN1tEDNHmzogXc7yNikTGdgN2mza/0Ody8ENtifAhgu1Kb2yIO3v6xWJLH7JU+4tUJkKA1R6XwB88VZW+PbhEnaLCNfIXurY4veYLQl6XJHcL5e9h5Z9AYAHbbOuMD42iBFqMrCeRQvbKDE0XsmrBF9B1iI3KdYz1x9eipVoTwOm1Qab2ys5K+EKgZBc7niSwkjTWDnjDel3USpGmc3WTqKaWdRv64+rFfkfV7yZ1jidzNDT+WUMfoVU81hpofLV1IT627E/64XxlXyU3gu9KL+AxTGX6LMKJU8t87DSH0x9qX42B1Elt50x7Nv7Il3W8qqmBSR/btP/5YxQ+MzypGIp6bwTFSWdVeRXwWkFVQgKsDuVwirkA4HvdoT9RLCoYx5AC4ibt14/DEqWJ+Ra+gNDHSl6QUEBGlNgYD/5cRR0Q=", null, "44421434-5dad-4f14-bd61-a6517c578ff1", 1, "85", "999174742", "gabrielevaristovcp@gmail.com", "Gabriel", "Evaristo" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("4ad20295-e048-4364-88ee-9781d4283589"), 20.0, new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(4889), new DateTime(2023, 6, 5, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(4887), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("d6ba4110-a03b-4f0b-9891-e8243e49955d"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("4de7a682-b70e-4e36-b62d-cdd24fe2c8ab"), 20.0, new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(4966), new DateTime(2023, 6, 10, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(4965), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("d6ba4110-a03b-4f0b-9891-e8243e49955d"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("eefaa96f-e1af-4d38-aed3-a0883511a84f"), 20.0, new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(4692), new DateTime(2023, 6, 4, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(4684), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("34d11be2-5678-49ab-898c-48bd072df432"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("76b0c3b2-cdf0-42ed-b142-5c47c5405374"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(3076), null, new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(3076), null, new Guid("34d11be2-5678-49ab-898c-48bd072df432"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("a10248fe-1735-4440-8ee1-9886924c1fb5"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(3912), null, new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(3912), null, new Guid("d6ba4110-a03b-4f0b-9891-e8243e49955d"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("eb33aec9-d62a-46fc-967e-474d2526fc51"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(3602), null, new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(3602), null, new Guid("34d11be2-5678-49ab-898c-48bd072df432"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true }
                });

            migrationBuilder.InsertData(
                schema: "Table",
                table: "Table",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Number", "RestaurantId", "Status" },
                values: new object[,]
                {
                    { new Guid("08b3b603-2ec4-40ae-ade4-582a046c6a54"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5076), null, 3, new Guid("34d11be2-5678-49ab-898c-48bd072df432"), 1 },
                    { new Guid("11bd8eb9-8841-4f73-9d1e-a9d475ca62fc"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5062), null, 1, new Guid("34d11be2-5678-49ab-898c-48bd072df432"), 1 },
                    { new Guid("62ca422a-9abe-41ec-a017-8f7bebfc46e9"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5073), null, 2, new Guid("34d11be2-5678-49ab-898c-48bd072df432"), 1 },
                    { new Guid("6ba9b143-7edb-48b7-8ce5-d9bd8db68ba3"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5081), null, 2, new Guid("d6ba4110-a03b-4f0b-9891-e8243e49955d"), 1 },
                    { new Guid("f115e682-0d54-4b5c-bf8f-686d47df9c2e"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5078), null, 1, new Guid("d6ba4110-a03b-4f0b-9891-e8243e49955d"), 1 }
                });

            migrationBuilder.InsertData(
                schema: "Bill",
                table: "Bill",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Status", "TableId" },
                values: new object[,]
                {
                    { new Guid("2eadeb53-64d9-4d67-82eb-7156a6d50e73"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5106), null, 1, new Guid("11bd8eb9-8841-4f73-9d1e-a9d475ca62fc") },
                    { new Guid("4a3a0162-b07a-4c84-abe7-d62bf677f971"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5116), null, 1, new Guid("f115e682-0d54-4b5c-bf8f-686d47df9c2e") }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1ff17ad9-5aae-4d9f-930f-1810488a68dd"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(4105), null, new Guid("76b0c3b2-cdf0-42ed-b142-5c47c5405374"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("60e974e1-55cb-4cb6-ba6c-dbb8e345d6ed"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(4602), null, new Guid("eb33aec9-d62a-46fc-967e-474d2526fc51"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("6bd692b7-4ce9-4dcf-9291-3ce0a904ff0d"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(4372), null, new Guid("a10248fe-1735-4440-8ee1-9886924c1fb5"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("826e73a0-306f-40bb-89a7-47dd193ec83d"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(4303), null, new Guid("eb33aec9-d62a-46fc-967e-474d2526fc51"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("9f5635e5-0b1f-443a-b96d-cac914f6c3e8"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(4519), null, new Guid("a10248fe-1735-4440-8ee1-9886924c1fb5"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("d9d65371-5e8e-4ec9-9936-a5e0df7fe2ae"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(4438), null, new Guid("a10248fe-1735-4440-8ee1-9886924c1fb5"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" }
                });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId", "Status" },
                values: new object[] { new Guid("2eadeb53-64d9-4d67-82eb-7156a6d50e73"), new Guid("209c736c-9759-44ed-9cde-61e17f287443"), 1 });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId" },
                values: new object[] { new Guid("2eadeb53-64d9-4d67-82eb-7156a6d50e73"), new Guid("b682d3ca-657a-4632-be6e-84f9e98a1b48") });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId", "Status" },
                values: new object[] { new Guid("4a3a0162-b07a-4c84-abe7-d62bf677f971"), new Guid("209c736c-9759-44ed-9cde-61e17f287443"), 1 });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId" },
                values: new object[] { new Guid("4a3a0162-b07a-4c84-abe7-d62bf677f971"), new Guid("b682d3ca-657a-4632-be6e-84f9e98a1b48") });

            migrationBuilder.InsertData(
                schema: "Order",
                table: "Order",
                columns: new[] { "Id", "BillId", "CreatedAt", "ItemId", "LastUpdatedAt", "Message", "Quantity", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("0fc2b223-cb37-4a15-8591-5972de90ffcf"), new Guid("2eadeb53-64d9-4d67-82eb-7156a6d50e73"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5172), new Guid("1ff17ad9-5aae-4d9f-930f-1810488a68dd"), null, "Completo", 1, 1, new Guid("209c736c-9759-44ed-9cde-61e17f287443") },
                    { new Guid("1332e512-7fd2-4a69-b842-4c08b296ee21"), new Guid("4a3a0162-b07a-4c84-abe7-d62bf677f971"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5182), new Guid("6bd692b7-4ce9-4dcf-9291-3ce0a904ff0d"), null, null, 2, 1, new Guid("209c736c-9759-44ed-9cde-61e17f287443") },
                    { new Guid("bbc6fbee-3323-43c8-a515-116a9aaeedb3"), new Guid("2eadeb53-64d9-4d67-82eb-7156a6d50e73"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5179), new Guid("826e73a0-306f-40bb-89a7-47dd193ec83d"), null, null, 1, 1, new Guid("209c736c-9759-44ed-9cde-61e17f287443") },
                    { new Guid("c3232a67-5e3a-40e4-835f-59543ad221ec"), new Guid("4a3a0162-b07a-4c84-abe7-d62bf677f971"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5184), new Guid("9f5635e5-0b1f-443a-b96d-cac914f6c3e8"), null, null, 1, 1, new Guid("209c736c-9759-44ed-9cde-61e17f287443") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("4ad20295-e048-4364-88ee-9781d4283589"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("4de7a682-b70e-4e36-b62d-cdd24fe2c8ab"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("eefaa96f-e1af-4d38-aed3-a0883511a84f"));

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("2eadeb53-64d9-4d67-82eb-7156a6d50e73"), new Guid("209c736c-9759-44ed-9cde-61e17f287443") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("2eadeb53-64d9-4d67-82eb-7156a6d50e73"), new Guid("b682d3ca-657a-4632-be6e-84f9e98a1b48") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("4a3a0162-b07a-4c84-abe7-d62bf677f971"), new Guid("209c736c-9759-44ed-9cde-61e17f287443") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("4a3a0162-b07a-4c84-abe7-d62bf677f971"), new Guid("b682d3ca-657a-4632-be6e-84f9e98a1b48") });

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("60e974e1-55cb-4cb6-ba6c-dbb8e345d6ed"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("d9d65371-5e8e-4ec9-9936-a5e0df7fe2ae"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("0fc2b223-cb37-4a15-8591-5972de90ffcf"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("1332e512-7fd2-4a69-b842-4c08b296ee21"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("bbc6fbee-3323-43c8-a515-116a9aaeedb3"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("c3232a67-5e3a-40e4-835f-59543ad221ec"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("08b3b603-2ec4-40ae-ade4-582a046c6a54"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("62ca422a-9abe-41ec-a017-8f7bebfc46e9"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("6ba9b143-7edb-48b7-8ce5-d9bd8db68ba3"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("47729b55-fd05-4608-9c8f-29888bdf73dc"));

            migrationBuilder.DeleteData(
                schema: "Bill",
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("2eadeb53-64d9-4d67-82eb-7156a6d50e73"));

            migrationBuilder.DeleteData(
                schema: "Bill",
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("4a3a0162-b07a-4c84-abe7-d62bf677f971"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("1ff17ad9-5aae-4d9f-930f-1810488a68dd"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("6bd692b7-4ce9-4dcf-9291-3ce0a904ff0d"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("826e73a0-306f-40bb-89a7-47dd193ec83d"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("9f5635e5-0b1f-443a-b96d-cac914f6c3e8"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("209c736c-9759-44ed-9cde-61e17f287443"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b682d3ca-657a-4632-be6e-84f9e98a1b48"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("76b0c3b2-cdf0-42ed-b142-5c47c5405374"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("a10248fe-1735-4440-8ee1-9886924c1fb5"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("eb33aec9-d62a-46fc-967e-474d2526fc51"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("11bd8eb9-8841-4f73-9d1e-a9d475ca62fc"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("f115e682-0d54-4b5c-bf8f-686d47df9c2e"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("34d11be2-5678-49ab-898c-48bd072df432"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("d6ba4110-a03b-4f0b-9891-e8243e49955d"));

            migrationBuilder.DropColumn(
                name: "WaiterRequested",
                schema: "Bill",
                table: "Bill");

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Password", "Photo", "Salt", "Status", "UserId", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("1aba526e-8013-400b-9305-1999115da99a"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(4379), true, null, "dzPLdPO66iDtDPTHIlQ0yp6Gig5De896frT7996p0obprqKgNn5L+DnRp7xUnSUrHzIveeuceGw4Qn6yWhnB4Q+4XMw7W9hc654l9pNhhyYgZgKP7VJZnB48pbG0pxwz0QJZyJ/IjnNZsiaG6LeMwzbuExJvfgqy+xiQVEP3408ZxKohVe8tKPSAjrqsdn/ay+G7fIv9QvXVK0VcQs6G87wW3Q59iDMeinGdQCmh+15k2kZF76Nm35tCozadVN3MoOisuK7+NXTZSh+GRE+UaJWmCwX07Tz3hIzGVPaDkBhYRrXOLhi1sY8pQcSOBrh2/+V+Pzh8ySX+kPoGmGzRjm89Y+oGumOJWbzTA6mKzQ5R1TCnYETFYkJSr4gsxlhqh848D25wqBpQnzszuMQ8Fd4XM+ZZ0auN6hdd7sa9lHiSoDZVAoaXdx7adgPC8J6tLNGtVyp8rvkxMtek7oupnjcURp7uGhNKKnEteCXQ5EN5+kMUPWzMjnuEEYxc2FYp1u/SLdJndIXzC1g9tF2HCCXEWe1ARn2HKdngwkJMx0GNNpo6Q8p/u3AnIp8Hmo5XQji/WayNmy6UJ/npFFQvYWwpVxKSBUqJtjSBAKfnuUMgaH2G4u1SFwoq27OpCOan8ypOKoOW7z8N0CNgsxZm5i+sbSZdiaJ94Y9K3EeKLLk=", "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", "d99f757b-4489-495a-9110-ab43510d42d4", 1, null, "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" },
                    { new Guid("8bc27b6d-e518-4702-9880-4294fafbff41"), new DateTime(2023, 5, 29, 4, 54, 10, 884, DateTimeKind.Utc).AddTicks(4991), false, null, "fTIoWynRx+nGkJUkW/UDkW+9ck3FwwxUtlaya2QHj90tcAONVuVFfWza16hQEE1Ih8sE84dst8jXIZZdP/zXXpAfptCkTO2lHiLzjvJdIKwNKMjElNT8pxIU8wzd5hrXUU1f3SsxISEjEIQkCb9J9L4ue5CCpCOc7hlOtz6FBm0T+oTplKnQuMuoyEZcPDEhZuN2vffFK7RIuaaeSwZBDTwv2GrHeomtjdWZ1emh3fgGhrqpJAQqGPwNGMwkvs0/CuwgV6xQb7n6E5HrBafpwllOxtjWfc7BX+Py+OJ1Wg+ilKsKi68hh746B0wf9Ilz4WcyBibqMcwpSyZRRwtpaarSre2j2MLF4ZLebXfPCMbUijwN6Qoq3Gs/Od9yCllciE1eQts+C6qMKGuQum5ea24BlMzWLGzFN9JNAdoSZoG1bPcvNaSROxpp4LupyFasNoplrMO1QJG3/12f331vdFX3lP3PJv5gNp/bW7DCprUZV08yIc3zW2oRyc9ufTvexSmgy79Wu2bCJU2UknhXSP+VxN0LC5UQmp+u3Ik6fNbCT5M3XjOEMPjh8juDYd1tjQ9DQ28HMRVuyCJx0YZEZVCnPP2vH75PWU8gUVWCyv5ozRb5h/wJINxoi1AiqPx8wLl9lTXbAketXoGTqU1Ayf8vSyl3PbgjTQB4dBxTer0=", "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", "ccc95a0a-5b26-428e-bad2-8205c5f8ed3c", 1, null, "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" }
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
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("10b92eec-b50f-4cf6-bfd8-a3b1cd5c9c5d"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5626), null, new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5626), null, new Guid("8bc27b6d-e518-4702-9880-4294fafbff41"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("7f060c4c-57f1-4280-8d52-4b6b4c86723f"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5850), null, new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5850), null, new Guid("1aba526e-8013-400b-9305-1999115da99a"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("9ce0b2fd-de97-4793-8a3b-9a2023604184"), new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5298), null, new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(5298), null, new Guid("8bc27b6d-e518-4702-9880-4294fafbff41"), 1, null, null, false, "Cardápio de vinhos.", "Wine" }
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
                columns: new[] { "Id", "BillingStatus", "CreatedAt", "LastUpdatedAt", "Status", "TableId" },
                values: new object[,]
                {
                    { new Guid("473cf64c-bed8-4b86-ade3-ec5c365a5d95"), 0, new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6633), null, 1, new Guid("2ae72198-e773-4767-a081-70263f5f7d1a") },
                    { new Guid("66c22ca4-d6d9-44da-a5a9-72b63d6338f9"), 0, new DateTime(2023, 5, 29, 4, 54, 10, 965, DateTimeKind.Utc).AddTicks(6627), null, 1, new Guid("75972842-354f-46ef-a806-48b48155fbff") }
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
                values: new object[,]
                {
                    { new Guid("473cf64c-bed8-4b86-ade3-ec5c365a5d95"), new Guid("c1a9d0bd-df87-4547-9663-2b74c457df79"), 1 },
                    { new Guid("473cf64c-bed8-4b86-ade3-ec5c365a5d95"), new Guid("e0564670-f479-44f6-b3a3-23dec0d2d6f7"), 0 },
                    { new Guid("66c22ca4-d6d9-44da-a5a9-72b63d6338f9"), new Guid("c1a9d0bd-df87-4547-9663-2b74c457df79"), 1 },
                    { new Guid("66c22ca4-d6d9-44da-a5a9-72b63d6338f9"), new Guid("e0564670-f479-44f6-b3a3-23dec0d2d6f7"), 0 }
                });

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
        }
    }
}
