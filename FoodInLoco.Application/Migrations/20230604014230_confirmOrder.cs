using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class confirmOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Confirmed",
                schema: "Order",
                table: "Order",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Password", "Photo", "Salt", "Status", "UserId", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("26ff2220-2ec3-48cf-b4bc-532148894f33"), new DateTime(2023, 6, 4, 1, 42, 30, 6, DateTimeKind.Utc).AddTicks(7945), true, null, "izWCrnd9BcydfDgDcbrSgrI9wbbuWE0T9mPBMnUNkO/LdswNRRPUdcupB2DjuidxbrNcR/k8WbzCWZsyIPI1FhQQ+diUyxf4LzDsYBtI3S0wdqI80rxIbq2akord6d7EeMyZ3+/CP8u9sgU+C72MsmVvqcp6DQLYccQ4OWRi0JfXmvQD9erjNKQ0+1GXyQ2bFhiJmzjFQR6aYQWRRnngoL7bbKruFy7ghDvH4F6yojWvSWb4VtqeFn8Pisj6IjYQTezB61EbjSa06oHr6ef/+73Nr9i8KzBVuEi5jAf+4fU270J3z5MArSYOpjXDTobtzq2Wb4ilYmbgjvp3fQG+6CiZn579JPoNztI63FtwJSIUUdyBDkAEuDsRU9KGNDX8Jn7juRfL8lDZMlABeiwHSBnatJdeWihXB914AEQTBlpZjuQa7obhAr4aXjWo/S3ivrK6vMiey6hGS888en5eZh378TvzkiWXuQQ6ngFrovVPfveDxp+3XBRd5CRG/lywxHXGS2JG3XZL64gN90iGJYcZhmJOedUz8PkgOFkVhY4CJB/m+p+235gKkVWL9F8Xp/mFB8qCuQypStq+sFSDDn6rwdJOWbym8vriuEg0VMY4aRtH1GMe+J93vXB7aMDyMZpeWGANMvXyyw+KQxxYwuf7s4gpl/2w56gg1ZirdHU=", "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", "b75e43fb-0473-4c86-9a69-f7406a0f2978", 1, null, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" },
                    { new Guid("9138c98f-829e-4791-aff8-c9b1ea9323e6"), new DateTime(2023, 6, 4, 1, 42, 29, 913, DateTimeKind.Utc).AddTicks(8024), false, null, "Bvwzy7wczFTgHY6sVANe6CBTJ85XXCjNPPqzJEnyWYdlVnaP6OElXjyh+EyYc8Q5TyJ6lvcH/JUonEyR+oBLFjrakCXoCIizS9G60yhcBkrfUxn9tUmy7uBcFPEzBdRXNPgES6czB9SvJnKO0dZIcKmkNJtyLFDrdtkFvHWgS5UdRSCVzjSQeDYqcDyWW7zlo2vCiNvcczoYY3SMZmX7zRPzApalFaHQV8MPjmgKkk0ktIcYCYmreIDb41ovxoOiajgieyFAchC+4bQRq2fWlpTvkJh2oPpczq0aHjVLAmFuxz2HT0UjWyBO/yCCSva05VCZ+ghJbo4rrEk5TvCRWcPa9oJq1JXeFg2Rjg/FLXyuVpKbn6X+pfEjk/cT6VC2R2YdOhtfVomjbgn2J3DiHN3fmDqz2CUFtpux0GAW2cvyaUhnqv3nrLcqJk6/ehi+3K/CrIte3mKXTz3YGM2UhhazMD5G8f/BCVKDCdfqn1R/XQpIVAwyxumWIJSjO0PRN1Mms90OAvxI5G0NN5vW/7LCD1n5J6gTVqg9L28ScIbONF8UU0v59TElwB6VGoQjVs/SkOPjrHaoGpGg7kTwnbbDZ8mtA44dLwwrL3VbGfPR3BOSxEtsurSM82u2RMGbXip4/ndrZa3FRzK4hNFaX9MKMgX2c1L+h389poQC3yc=", "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", "03230db1-ff37-4650-9cae-893521ef7004", 1, null, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("340c9065-f779-41b7-b252-c4c0555ea611"), new DateTime(2023, 6, 4, 1, 42, 29, 658, DateTimeKind.Utc).AddTicks(1564), null, "wPf/IKBO3f56Fz8D1lfm+8PWT/aCIdx2fr4VZES8zuMR1THQ6yBvcXEe8f+YAY/kDd4SLk5Y22PxYbFcSRFO9UfJeMZV+sBiigwntCA43kmgJIk/2DzXY1hf4Waur14tgdSAckGDw1KStqLUViNM8h98MXZ6hCYvfIcyJ7LEI1GdDhqfwhlPPwsaqDaQftoWs1Mi2uHutSRUdoaSmQ9Q5QM0Phgswe8VSqwKHbDT3/LF51QrjDNlNZsuoLfHABqyC/q/lJGWv3T8Z6mUDQuMAY51gQgIBUzDTKRphrCcDjj1IK3m5YB2m184TWjv9k/eSrcDNoUTMahafHwIeXo239b8WsZ9gxn/PSO9NpJk5eCuMpLBkrtB04d1zydk1HRB/1eaZq0S6gO8hqiJ993spyDVFEv9gjVuXzCBXxCILkxlIK3BXKbS4pzvir5vnCc7eETNg1ep/uRU7aG4W0nf69Iw+w88UOtdEWBMasydFIhnizlL39Y8jJsZVcNvs2MmXZ9W6MFt8xSkAS2jobGVUGjhRZs+EUMHo96xhEdomq0jRHFNF27F6mtXL+UfvlJYFqcJxvhsivgKbMOFcDUDNiUNI+VJpjJJX/K5wT0h4Mf+Q1YQVa/NfHWIHg3Usbr39E/bPmb9UZnar3P3flo7iUAJQuA/6s5G4/rciT2BxNU=", null, "2c4c8784-ef37-4076-8e3e-0778fee57269", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" },
                    { new Guid("38696f33-8b7c-403a-a76a-4f925de15769"), new DateTime(2023, 6, 4, 1, 42, 29, 718, DateTimeKind.Utc).AddTicks(6165), null, "W6TVD/ZtxAJN/+5rUbJ8sxO8aqJCooReAwKppzpDVtOgbDmHH64FIG7HvcgZz96Wj7wuiNwGqk/T7tgEKoRWb4zwSVL4k3LyBBfGXMu3s58J4hoclhDFs/sF1ctz0fJ7YLNHqZjq/e7DNGew4lfNQ424lNPiI8u7pSOiytXRAUGSZgJ+swm6B7qw5a4/ZcNG7tvubI3p63qO3jVIWw+Sa977/y8Cw6jCA4MLhZuMLd9N6Byk6eWejuHeT/CIHdCZi4Z8igRYWSlJXc++ErUfRLPi0owWo4uIWu+Y1u6Lco6+vcSiFusm1zWVbveOlcs6jvSXzM7HROzNgnYbEueP45uAhUB/9DKDxMB2FhNeznpXGMpC/WO45VkzJXlTov1A0F54JqdbuucOlyfTd8NC0pGSE1BpYl3lpvCNKWNjQSC958XqvjZWLWBoPDeeLqSmwXK4smIdvJRMskNtI4MFlhUC8AxT0N/gktIK58vebdUrOhx4SYk1FqZGPBns05mgj5a/b6H+xpo0z6ttD19zu8PagxMM6aoR3I0hZ58QLEbaq3PT0RmVvWCeeG/oraaYQbCD4+nVrSy+GMyYxE3IVwqP/5dBssd3MtBs9nwipwcLD8LkjJB1f4dHPPBCtYQdoX1e1njcmDl5X/XFRWvZaon4ytfgHLzJuuGA564/u2o=", null, "3a448eb0-3b0d-468d-a9b1-0ba743dc461e", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("f8a97c32-2e3f-4937-86ae-5e733f3f85e1"), new DateTime(2023, 6, 4, 1, 42, 29, 820, DateTimeKind.Utc).AddTicks(5480), null, "O+FlnmOnfTIzY9XWTCPHh5Nh1Rva/4G0Za9XMMuzKR5JglBt2YlLVH2YAQAAHWfAG91nOwTtsUfiRVrX9x94ftAUhiFtvU3vVKLcr94Qey+r1ptMN2AO82jRJRakGpt+ND46dTZYH3MPYyulzx5K1lJNuMQhff3zB5GNtW6SRJmyBq1PBkjX0KfIMDUw9uLRJXxcV3JX+xBk68fC/mkTcQ6AGt3CchroTm/hGaO63SIYYIItR2seO9cNcMangdxj+Ax47CpJEtyG1rWfPTByovnYZnzkYhJPYpaBCeHkgF5lRyHjD/5RCaBfPashk/Isy836lh7tN6TpW26aG4UQ4nlG8Atvn9jQYLhY/tUHtBmo8TPDUCXjfheeL5VD9Pt6RP47NHmYX4SNDar7EDjfbLPZMFvMWg/H3Cbc6EaK1SFegBczmii+I9tzEDQCNd5mxu06+C3KpoQkelgQ1vB4VZ6I6l5QgKcweAML9OaAli9clGV/fsI3S/O71kK8+/9fKXK4xy/cZIb385hWGKJGf3hxL5PHxLdyj0IXKlM9HMdczO3fWVDloT+BSNfZjpJdXLRsmThYtRC9MCRg4QyMdbmo6NeVGM4IVCBcCHHwySBmWyspEB3IbaSCgbIm4NHLYfopjqLYEn24l+nSi5wg5Mzf/PX8DUCqjQ3q/a8iltM=", null, "729884e0-c7f2-44ac-bde1-2ea7c0820991", 1, "85", "999174742", "gabrielevaristovcp@gmail.com", "Gabriel", "Evaristo" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("25c682e7-8772-49a6-8676-d9a5e26e4026"), 20.0, new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(678), new DateTime(2023, 6, 11, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(677), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("26ff2220-2ec3-48cf-b4bc-532148894f33"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("64d2ffdd-9c0c-439d-bda0-720fcac75c30"), 20.0, new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(513), new DateTime(2023, 6, 5, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(508), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("9138c98f-829e-4791-aff8-c9b1ea9323e6"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("bc74cffc-3b44-4c03-b7b8-772b84d6df1c"), 20.0, new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(631), new DateTime(2023, 6, 6, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(629), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("26ff2220-2ec3-48cf-b4bc-532148894f33"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("14a36c28-d565-42b5-8c07-dc084fb3e6b2"), new DateTime(2023, 6, 4, 1, 42, 30, 6, DateTimeKind.Utc).AddTicks(9782), null, new DateTime(2023, 6, 4, 1, 42, 30, 6, DateTimeKind.Utc).AddTicks(9782), null, new Guid("9138c98f-829e-4791-aff8-c9b1ea9323e6"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("50680c4f-085f-4f4f-bc50-a6183894a707"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(14), null, new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(14), null, new Guid("26ff2220-2ec3-48cf-b4bc-532148894f33"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("798d2b2a-ef46-4820-b5f2-deaa5c0e7fdc"), new DateTime(2023, 6, 4, 1, 42, 30, 6, DateTimeKind.Utc).AddTicks(9490), null, new DateTime(2023, 6, 4, 1, 42, 30, 6, DateTimeKind.Utc).AddTicks(9489), null, new Guid("9138c98f-829e-4791-aff8-c9b1ea9323e6"), 1, "Cardápio de vinhos.", "Wine", null, null, false }
                });

            migrationBuilder.InsertData(
                schema: "Table",
                table: "Table",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Number", "RestaurantId", "Status" },
                values: new object[,]
                {
                    { new Guid("0effe521-b736-4875-9ea4-a15333554643"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(739), null, 2, new Guid("9138c98f-829e-4791-aff8-c9b1ea9323e6"), 1 },
                    { new Guid("27e71bc0-5de6-4845-a49d-658eb9338dfb"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(741), null, 3, new Guid("9138c98f-829e-4791-aff8-c9b1ea9323e6"), 1 },
                    { new Guid("852304b2-69a4-4ac1-a969-9f0228928d89"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(743), null, 1, new Guid("26ff2220-2ec3-48cf-b4bc-532148894f33"), 1 },
                    { new Guid("be763bde-2f53-4c81-b2ab-12644b5d7530"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(734), null, 1, new Guid("9138c98f-829e-4791-aff8-c9b1ea9323e6"), 1 },
                    { new Guid("e3fbf06d-1ac7-4ded-a634-7f47a4c66023"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(744), null, 2, new Guid("26ff2220-2ec3-48cf-b4bc-532148894f33"), 1 }
                });

            migrationBuilder.InsertData(
                schema: "Bill",
                table: "Bill",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Status", "TableId" },
                values: new object[,]
                {
                    { new Guid("7b6231f6-2f13-408c-8af7-6c0a4fa2df39"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(771), null, 1, new Guid("852304b2-69a4-4ac1-a969-9f0228928d89") },
                    { new Guid("9e83641b-1d7e-438d-9529-9f748fe09e5e"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(767), null, 1, new Guid("be763bde-2f53-4c81-b2ab-12644b5d7530") }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("04b8833d-fab2-4f49-8071-da89a5f42f1f"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(247), null, new Guid("14a36c28-d565-42b5-8c07-dc084fb3e6b2"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("3af3bb48-78ad-44a4-b0f9-904e6168d73d"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(345), null, new Guid("50680c4f-085f-4f4f-bc50-a6183894a707"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("3d36e22b-edea-44df-af8c-dc5f7666ec66"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(402), null, new Guid("50680c4f-085f-4f4f-bc50-a6183894a707"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("4b6e5fac-f995-4426-b9bf-5ffae3f4ca25"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(450), null, new Guid("14a36c28-d565-42b5-8c07-dc084fb3e6b2"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("87fa75e6-07a6-4853-b83d-36a39ae84868"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(133), null, new Guid("798d2b2a-ef46-4820-b5f2-deaa5c0e7fdc"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("8b42dda2-edb8-4c37-b90b-1e60f52dc5bc"), new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(300), null, new Guid("50680c4f-085f-4f4f-bc50-a6183894a707"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" }
                });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId", "Status" },
                values: new object[] { new Guid("7b6231f6-2f13-408c-8af7-6c0a4fa2df39"), new Guid("38696f33-8b7c-403a-a76a-4f925de15769"), 1 });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId" },
                values: new object[] { new Guid("7b6231f6-2f13-408c-8af7-6c0a4fa2df39"), new Guid("f8a97c32-2e3f-4937-86ae-5e733f3f85e1") });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId", "Status" },
                values: new object[] { new Guid("9e83641b-1d7e-438d-9529-9f748fe09e5e"), new Guid("38696f33-8b7c-403a-a76a-4f925de15769"), 1 });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId" },
                values: new object[] { new Guid("9e83641b-1d7e-438d-9529-9f748fe09e5e"), new Guid("f8a97c32-2e3f-4937-86ae-5e733f3f85e1") });

            migrationBuilder.InsertData(
                schema: "Order",
                table: "Order",
                columns: new[] { "Id", "BillId", "Confirmed", "CreatedAt", "ItemId", "LastUpdatedAt", "Message", "Quantity", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("14c3f3f9-0c36-4567-837d-e3aed21cd6e8"), new Guid("7b6231f6-2f13-408c-8af7-6c0a4fa2df39"), true, new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(824), new Guid("8b42dda2-edb8-4c37-b90b-1e60f52dc5bc"), null, null, 2, 1, new Guid("38696f33-8b7c-403a-a76a-4f925de15769") },
                    { new Guid("228a9cb2-0da0-46c5-979b-e21991a148e2"), new Guid("9e83641b-1d7e-438d-9529-9f748fe09e5e"), true, new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(816), new Guid("87fa75e6-07a6-4853-b83d-36a39ae84868"), null, "Completo", 1, 1, new Guid("38696f33-8b7c-403a-a76a-4f925de15769") },
                    { new Guid("98b0e108-280b-4891-aff2-7f1988344b40"), new Guid("7b6231f6-2f13-408c-8af7-6c0a4fa2df39"), true, new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(825), new Guid("3d36e22b-edea-44df-af8c-dc5f7666ec66"), null, null, 1, 1, new Guid("38696f33-8b7c-403a-a76a-4f925de15769") },
                    { new Guid("fb6b95e9-9058-4898-9985-26838c590a18"), new Guid("9e83641b-1d7e-438d-9529-9f748fe09e5e"), true, new DateTime(2023, 6, 4, 1, 42, 30, 7, DateTimeKind.Utc).AddTicks(821), new Guid("04b8833d-fab2-4f49-8071-da89a5f42f1f"), null, null, 1, 1, new Guid("38696f33-8b7c-403a-a76a-4f925de15769") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("25c682e7-8772-49a6-8676-d9a5e26e4026"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("64d2ffdd-9c0c-439d-bda0-720fcac75c30"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("bc74cffc-3b44-4c03-b7b8-772b84d6df1c"));

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("7b6231f6-2f13-408c-8af7-6c0a4fa2df39"), new Guid("38696f33-8b7c-403a-a76a-4f925de15769") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("7b6231f6-2f13-408c-8af7-6c0a4fa2df39"), new Guid("f8a97c32-2e3f-4937-86ae-5e733f3f85e1") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("9e83641b-1d7e-438d-9529-9f748fe09e5e"), new Guid("38696f33-8b7c-403a-a76a-4f925de15769") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("9e83641b-1d7e-438d-9529-9f748fe09e5e"), new Guid("f8a97c32-2e3f-4937-86ae-5e733f3f85e1") });

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("3af3bb48-78ad-44a4-b0f9-904e6168d73d"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("4b6e5fac-f995-4426-b9bf-5ffae3f4ca25"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("14c3f3f9-0c36-4567-837d-e3aed21cd6e8"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("228a9cb2-0da0-46c5-979b-e21991a148e2"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("98b0e108-280b-4891-aff2-7f1988344b40"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("fb6b95e9-9058-4898-9985-26838c590a18"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("0effe521-b736-4875-9ea4-a15333554643"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("27e71bc0-5de6-4845-a49d-658eb9338dfb"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("e3fbf06d-1ac7-4ded-a634-7f47a4c66023"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("340c9065-f779-41b7-b252-c4c0555ea611"));

            migrationBuilder.DeleteData(
                schema: "Bill",
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("7b6231f6-2f13-408c-8af7-6c0a4fa2df39"));

            migrationBuilder.DeleteData(
                schema: "Bill",
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("9e83641b-1d7e-438d-9529-9f748fe09e5e"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("04b8833d-fab2-4f49-8071-da89a5f42f1f"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("3d36e22b-edea-44df-af8c-dc5f7666ec66"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("87fa75e6-07a6-4853-b83d-36a39ae84868"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("8b42dda2-edb8-4c37-b90b-1e60f52dc5bc"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("38696f33-8b7c-403a-a76a-4f925de15769"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f8a97c32-2e3f-4937-86ae-5e733f3f85e1"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("14a36c28-d565-42b5-8c07-dc084fb3e6b2"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("50680c4f-085f-4f4f-bc50-a6183894a707"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("798d2b2a-ef46-4820-b5f2-deaa5c0e7fdc"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("852304b2-69a4-4ac1-a969-9f0228928d89"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("be763bde-2f53-4c81-b2ab-12644b5d7530"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("26ff2220-2ec3-48cf-b4bc-532148894f33"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("9138c98f-829e-4791-aff8-c9b1ea9323e6"));

            migrationBuilder.DropColumn(
                name: "Confirmed",
                schema: "Order",
                table: "Order");

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Password", "Photo", "Salt", "Status", "UserId", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("34d11be2-5678-49ab-898c-48bd072df432"), new DateTime(2023, 6, 3, 23, 8, 17, 436, DateTimeKind.Utc).AddTicks(5279), false, null, "cxx5nuEQi5vOlXoicE3BIknQREeHWC6wxtDpoe+3JC55GXEqES9sUgqcebe0Fa21Ah6Qvjh2tyYs6UqfZy/X5mib8MK3BKdIrCSwG+xFO4sFATvF2eEBa7/ualJUhv+LlwuRUlUiIkck92OfxWkL8laB7WxEcJ8KR+cTvancY23SJrOy4sCoi7wgx2Wta5LxpbaDu7xEeVci5n5YlgXOYPJPnHO1oU8LeZNRDU2O4QNgvywSHLNGLWgaR3VU7JiDqiJ2J6+IOoVKNMlOMRok/+nBF2fQUlsvSVUv4lmdosCfc+87+id4WoSTSWWjka4mLqWu9/xjQUIwQFPazbtPp2HN7L7GiNP+J+nUcitb69fXOKKObeBX4IW86UiFho27ghh/EV81emuQOzQPeum55Zhuqs/5W4AgLsfzCq7oBY5DlAO3CIs+yVcNfpm4xtjcIC5nOAmry4p8ZWW3n7WA6CmElT2mrGVEP6/sBoReCDY9viDEw4kGNC6jGLuMpD7OGGjbMMGJoxHktnzXMVM270o1StPB7qahWYzfxBG36AhFSDBXO/smpkRclV3xmmtUCGXYEAeAezeMN5p0IV0XROiuHf+eke8pcVvV+j3SKKuZXwZBdLOIodIrp4UZJjeuOQ+muVR/XCFuIp8DFo/7l56vACtWpkmHoMN455JrYDg=", "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", "7fc569b6-b6dc-45b2-80e5-908e01a5d126", 1, null, "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" },
                    { new Guid("d6ba4110-a03b-4f0b-9891-e8243e49955d"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(1868), true, null, "Mu2mnV8I+Ex/cLvAxFDuxrk/ntjP9+WE/y4mt3CWhkf7Al8ZdJ/t9qVJbo0aHwCFQQOGzDGwMX6+IeT/KwAShouQu+oYns6rK/rvZSYZ5P9+cxJRzvxAsxyjY2TJRCGDkYyRWokxIwitAJhe4M4r4AiXT88nQvk9bo2MJhs4c+Y1j1+0y1tR35RLZhAsWwJtSrlYqdxkkO2U17WgKU+p61wW2d36gGBNkPYNAMY5GWloBAl7Y3njnimDG3KrVHltYsnedOcCFHYi1CyoUqjmGt44yyvU0FEtZVzrcFJOdcOW12AKci4RStTFtWQPr1ZCM9Uff3dBRopb+nEccNUMRe0a9sKpHg6cKhAjy+cmm3KueVBJMb9SrPIHFEr+RtwC+ghnqZF397DSrt992LwnrCpAcBt6bCdFYwhG8WyNaB71GgUDoI7KYtQxecyF8iSI8vUoqCPIdiry8BXuA2GhX7Czpzji+kZPAsMVyq5Lr2zx2SNmcb4k0z0rgvQ1rFbycKqHgarwWpaOZMMp82ig94gPYQsi95ah+0atAucDh+EBR7iVaAtpZ27nIBwLszgMmVVj8DNBmFW5hjIndgYWdQs9FaZkpnaN0V7/6nWkuTytilR8RzYW53TsS9a40UvQwB09GINqW3nCwP9ZqOZRNzgyd+zwHcbD6znqiTcJMBE=", "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", "72ebe5b8-502d-4133-8d88-bcca8293cfe6", 1, null, "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" }
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
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("76b0c3b2-cdf0-42ed-b142-5c47c5405374"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(3076), null, new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(3076), null, new Guid("34d11be2-5678-49ab-898c-48bd072df432"), 1, null, null, false, "Cardápio de vinhos.", "Wine" },
                    { new Guid("a10248fe-1735-4440-8ee1-9886924c1fb5"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(3912), null, new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(3912), null, new Guid("d6ba4110-a03b-4f0b-9891-e8243e49955d"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("eb33aec9-d62a-46fc-967e-474d2526fc51"), new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(3602), null, new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(3602), null, new Guid("34d11be2-5678-49ab-898c-48bd072df432"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" }
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
                columns: new[] { "Id", "BillingStatus", "CreatedAt", "LastUpdatedAt", "Status", "TableId" },
                values: new object[,]
                {
                    { new Guid("2eadeb53-64d9-4d67-82eb-7156a6d50e73"), 0, new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5106), null, 1, new Guid("11bd8eb9-8841-4f73-9d1e-a9d475ca62fc") },
                    { new Guid("4a3a0162-b07a-4c84-abe7-d62bf677f971"), 0, new DateTime(2023, 6, 3, 23, 8, 17, 523, DateTimeKind.Utc).AddTicks(5116), null, 1, new Guid("f115e682-0d54-4b5c-bf8f-686d47df9c2e") }
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
                values: new object[,]
                {
                    { new Guid("2eadeb53-64d9-4d67-82eb-7156a6d50e73"), new Guid("209c736c-9759-44ed-9cde-61e17f287443"), 1 },
                    { new Guid("2eadeb53-64d9-4d67-82eb-7156a6d50e73"), new Guid("b682d3ca-657a-4632-be6e-84f9e98a1b48"), 0 },
                    { new Guid("4a3a0162-b07a-4c84-abe7-d62bf677f971"), new Guid("209c736c-9759-44ed-9cde-61e17f287443"), 1 },
                    { new Guid("4a3a0162-b07a-4c84-abe7-d62bf677f971"), new Guid("b682d3ca-657a-4632-be6e-84f9e98a1b48"), 0 }
                });

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
    }
}
