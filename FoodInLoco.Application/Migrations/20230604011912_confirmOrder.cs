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
                    { new Guid("5789cc3f-b35f-4e07-8bfe-005c491cd076"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(4524), true, null, "5eaRiB5J+uGmXIN9YCaOtOpoF9xLdtOnE+pPaGLyrVo4E2TSP21J3bxLcHkpjVkkzAuvcF6NzYGWgF6mhpE9hQQKqBqWD1ucAT9dDV2IaoKHumxBJF2pJOmkZ4pVjK1RWx1KNO2l+Twc5cpLqZ7SMrfEHyUSz/S6N1cSlEbFe8lq4EvKMZY4+FRLimjyHEp9fVI1ZklJ6nhl6Qy+HmjvgfS5TkXg+ayIVibr7M5+/en0ue7abOj1+l8o/BJR18EDIY24wcCM+F4c8rLTXTxGYL/WNT6MFKmGQOlNRuRidwMYfF/Vohv2puEPuE0LXMaUGPqL/u0bViVcescpRxHz/3eKsIgRceEqTMuSOwfZ799mhGUydd4O4SgQonfXyAQlaTHg5lVu0jLaMo5YiCY1kGmWtWoZWEq2tQdjaPyoNqOEDzC9Q8Nhx4vNnsF0fCHOojiRotox32KMlrhKzXpQp6SzXF3LFkWINcbAkG8U4q+Oz6hzBs2/KtMhusVAdWvMDAkZqp2YtXYBOSjbcdMz2tPMXq1lbxmCR6UMRMa6eccdWK5urqv+TTDMpbycTUPKrcd1R09c/xpGKktdBlJVCyCn+1iVL1aV/CjQAhdZNwq8tcayXBuO/k350p3Gcc/tuQEDR81sptMmUBpUz5TWVkTyzVMI647/6U1yQjcQALg=", "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", "ce42c45f-0e13-4623-8f0e-2ddb9f6aac0b", 1, null, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" },
                    { new Guid("e1b9408f-9462-43fe-ae85-187cb8ecffa2"), new DateTime(2023, 6, 4, 1, 19, 11, 686, DateTimeKind.Utc).AddTicks(4587), false, null, "BJ/ghVSM5nX+6mchonL1z15fmBQuq+BKJMeXncC+5JW9z5kjWYQ36qzTIDMtMWzqFBqq20qs2TRsxAWlOEmE/AmN9Y3MGApHnYzjVYJwr62n7Hyx0dejuaYNVM8v8fwqKPCZ9nVzzKEWvQdAhJ+ugycBsIbG30KEIubodwPp+Wm3tBJZKQ6WKxSyFJehuvyT2WzmL+pWfYdZzx7gknKWp/2GjoS/48WjwY3PbuJwtyZXllQcDriMXVgsngHWInRGjB9K/n/Qv3f4wIviFuPTfY+0IfGRp5vMBk5MpvqiTDp2A1m3XK+Gx+qvmgsejf2qOqqx6SWxInu2riixPdzuOnzAOQmKEE54hG0tycGOfkRz5INeWWv41ux/Pqf0y4HI142U+tOLFSnA0oEtpJYkQM82hy7ChMI7gQdV/6OWcL81Rl0my7zVT3qYvqCrYXFghXdOTgIRacbksbnpi4rxnCgvIg3v74jPlFJq2e5PcFVjaHnDeYs3AUCfTUsLe6Uta+MIB/3pcIrjW4d6b2J8VuUTsIukYbu6PmXxvIqX1ybCLxLE5OXrHI+KOeunKsAZ7IdbYcIlUgMw9WKdsq3QxxbOvP1JYjBorfp8OfyZzRWAvZS3PDUfPzN0QbVW2aCdE/GrTlaI1KKj7bDaBKMhMArBmkEak7pqsBMAiTzdQzs=", "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", "8f0dbd54-1779-4f65-89b7-dc443abec552", 1, null, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("83e64526-b605-4443-a066-3f7a5815a58d"), new DateTime(2023, 6, 4, 1, 19, 11, 605, DateTimeKind.Utc).AddTicks(3301), null, "Lmwd2h0ny9GDe/9L2ICxrpJdUZ8e8JkywFqvooFjW8ENVFmrhH9tOPxf93EibhE5FUJfk350SXVEAMCs4m0kz7H86e/W7yQHOCqHDqkZXQC0YfCHRik5inxRAAfWnSmkVeS99gFimGHl86d6lEwMCucWupmtjhbiMnsZcJr+0F2YGaK3aGO2HEyCUf/osmrKME/FvLER4zQ/7llt3WZefUoJIRo8B++pwaE3kUBwKri8u9EzQX6ENUcdZ5kVWG6zpuTQXA7hgsFBU9CK+UsMpK5do/qn/J5Yz9LJw0/Yb3JKwih6XbJNUuVfZwCtsik86BrqxvRmJ4fH64w7Na4ptgxk25yBD93GtSn8zPhD389GFToMUO6OriyD7nVmpXwFEzsNGY5/OZhIhbAZMzj0moj8U8bqfvXDvS7bJ+fQv3/RVQIF02EwbdxSpNABVuOvsCAr6MCIY8uYu9E2whqqyybcW0g1aT8LHdMR20Xu9ee35V1QD817c4Fx1oEZFVTrS+gnwymYiP2sVo34sQrj3a9Ys3h3sosgGYGE4xqlasVvN1NMk6puBToZjhlZ5TiuKOMdfTzOLCXeHShF6MT+Cqe0ejrZob0dfcNbbbWeoL6xnExJ/3VDtkMWuztG2d61sFpYkwNpYU4yHc0SC5q73SuvrbG9CfbDKKOT0o7mMLU=", null, "b273d987-846d-4862-978d-deeb97a14ab0", 1, "85", "999174742", "gabrielevaristovcp@gmail.com", "Gabriel", "Evaristo" },
                    { new Guid("840c5834-8997-46f4-b172-1567f2283954"), new DateTime(2023, 6, 4, 1, 19, 11, 500, DateTimeKind.Utc).AddTicks(4989), null, "2xT2RmTOIqZ9hVlb/9QcUB2w/FMmOg5gRVHQFdopGROb7RiLndvjW/d+nBqGcL03ISAgBQsm2TvqYDTpi+pskpG4RNR6XLxZFauqxnm5o7m4TNxFAMS/scCWNHTjLUwm19tRIRAplwYPW+Wtd8yaPLgoXxwdOPxC/NiYG4Ku1EuHPTxozNAlsb9CO1obeDxuUApJsd+f3SQtdF0WWAHd4F0wiLvOTRnXa8bBqOjnHSBqa5psNl3zM1SARnMV1MsxFekx666NMJAWNtE2Q0qTamvQNdkBSPZf4i0kk+k9KrDzaOSazvt6ByT5LZjRXoM1zZVwQPxRzemcpYDW23JXMNAuB5ryvNPsuTehirSnGoPcKseCZ34fu1BY9WKxpW7tKcw69Xh8PfERq0y5Z4QGkdrZ3eoXLeQVn02DBmWGE/XA6hazHZVfiZCz1Ng1+IINr6sIt909ovk8100JWKAlK2RSZExtoz4hxUw4pEQoYLdQ238tgtRx6qmdquzieIt5Sv6e3TuZcTIAXge6p+ikHNFEjrPOFu50IjNc3jkebj4+F1wd1BQ22qCADot70mE3biB2agsnSKo/X1KWKkrJ4+LSGnLqrhzqO3eKcsfrbXLpWxtJycWlH73nX47Vp0lvxF8ur1xh8daxQvgcAKBr+IY6lApNQ/oEB3s0DJPD1CY=", null, "2cb957d5-4378-477e-a784-ef2125255c9e", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("9c7edea8-0237-4154-9f07-233ee2f1743f"), new DateTime(2023, 6, 4, 1, 19, 11, 408, DateTimeKind.Utc).AddTicks(1858), null, "e4bjYvtnYozwkpD0+8JU7cJYly0OFAD2GCWghHZOse44Dve9m70DqO5n28McJkCxgchsuaD6IYfgodj94W6HWbmDv1RM8hA927yETTOWDVb49YxYH9VSzcyjFn2HkYadyXSUHYYvPOdZdFpJ59qhT/sRv1u7voOGbaxfIO3V4iMDK6qY2xbops4LQTCtphdaekeT/s5hYXbLxNl/Z8+io6LI8+56C/y708uZfXjmwII2JHf+klC5ETn16fV60nxsp57zl24LiYNBr5XtuepHeQs4Lbaq+yeH+WxJXewBWESRYID5HKPmPtWEjxAMtvBKxVRNqyTHejHMk3hMHlacKM32gkYAAW+Er/vwxHEsbkOcaODH/l/axnO6hyBBSPgMd852e+eUcPk8/LkQ/99UlfI578Z1NQFvePh9ITJk+hmLX+8tlC+yPmld7e487GDDu3DusQRBZjhN0R+zk/dE1PHkI07UzHe+2StfvQllQyhmarmzpEMnLDBkZmoy7Dr7Mxb+pTWZrxnptwi6dDNqMS8qBZwTmysBA+FztKaGRxUvvip+jkq9n+IqOdiFBSA4NNQ0d5Ld0t9wt0DAyeCDz8emz+aCJK8PzdFZtinBRLB/fuEnZNdvxubuRV9xcU7PN/hT43OGgtrhreu2wAVxzEudwLO39AvfBVbGeI+Mhiw=", null, "c454a02a-d431-4ec8-bd7b-04f768f36aec", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3b3e9dfe-2ead-4375-8ced-b882675f10aa"), 20.0, new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6595), new DateTime(2023, 6, 11, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6595), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("5789cc3f-b35f-4e07-8bfe-005c491cd076"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("864ca04f-3c5b-41f4-974b-d69a9301e289"), 20.0, new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6553), new DateTime(2023, 6, 6, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6552), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("5789cc3f-b35f-4e07-8bfe-005c491cd076"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("b482a11d-f86a-4dab-97cd-0837b7ed423b"), 20.0, new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6438), new DateTime(2023, 6, 5, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6429), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("e1b9408f-9462-43fe-ae85-187cb8ecffa2"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("006ececc-294d-45d9-84af-fb677d04ee3c"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(5986), null, new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(5986), null, new Guid("5789cc3f-b35f-4e07-8bfe-005c491cd076"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("3484d42a-ffb8-43d6-9d24-4976dc8753a7"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(5764), null, new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(5764), null, new Guid("e1b9408f-9462-43fe-ae85-187cb8ecffa2"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("3b91a518-af8a-4640-9450-e4463df6e385"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(5400), null, new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(5400), null, new Guid("e1b9408f-9462-43fe-ae85-187cb8ecffa2"), 1, "Cardápio de vinhos.", "Wine", null, null, false }
                });

            migrationBuilder.InsertData(
                schema: "Table",
                table: "Table",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Number", "RestaurantId", "Status" },
                values: new object[,]
                {
                    { new Guid("2e41fd8b-233b-4967-8d7a-d4697ff05ca8"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6653), null, 3, new Guid("e1b9408f-9462-43fe-ae85-187cb8ecffa2"), 1 },
                    { new Guid("5c6a24bc-63d6-4276-885a-b14ca1cf1108"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6655), null, 2, new Guid("5789cc3f-b35f-4e07-8bfe-005c491cd076"), 1 },
                    { new Guid("91bcce23-12ad-444c-9462-abf3de03e289"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6651), null, 2, new Guid("e1b9408f-9462-43fe-ae85-187cb8ecffa2"), 1 },
                    { new Guid("a4b7e366-c796-4e0b-a46f-b79011f02b5b"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6647), null, 1, new Guid("e1b9408f-9462-43fe-ae85-187cb8ecffa2"), 1 },
                    { new Guid("a8b4437b-a2c6-4ae8-ade9-1cf4109e96e4"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6654), null, 1, new Guid("5789cc3f-b35f-4e07-8bfe-005c491cd076"), 1 }
                });

            migrationBuilder.InsertData(
                schema: "Bill",
                table: "Bill",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Status", "TableId" },
                values: new object[,]
                {
                    { new Guid("acf38482-9914-4a72-9263-e869fdf07f5c"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6681), null, 1, new Guid("a8b4437b-a2c6-4ae8-ade9-1cf4109e96e4") },
                    { new Guid("cd9fa246-4b49-4578-9fca-0fdb6e08f782"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6677), null, 1, new Guid("a4b7e366-c796-4e0b-a46f-b79011f02b5b") }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("805d2fef-1fed-4791-95d8-d3f0981191cf"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6375), null, new Guid("3484d42a-ffb8-43d6-9d24-4976dc8753a7"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("9ef39960-5e42-48af-8b96-4aa988d36441"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6334), null, new Guid("006ececc-294d-45d9-84af-fb677d04ee3c"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("a42591d6-61c4-4d3a-99aa-4f970028a6cf"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6244), null, new Guid("006ececc-294d-45d9-84af-fb677d04ee3c"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("cb976610-dafc-47f4-88b9-38ce140f1b1a"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6295), null, new Guid("006ececc-294d-45d9-84af-fb677d04ee3c"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("f53d394c-7f19-44e9-b66a-766542f84269"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6086), null, new Guid("3b91a518-af8a-4640-9450-e4463df6e385"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("f85a8433-c7ab-4bd6-9dd8-265778c7e4ca"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6197), null, new Guid("3484d42a-ffb8-43d6-9d24-4976dc8753a7"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" }
                });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId" },
                values: new object[] { new Guid("acf38482-9914-4a72-9263-e869fdf07f5c"), new Guid("83e64526-b605-4443-a066-3f7a5815a58d") });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId", "Status" },
                values: new object[] { new Guid("acf38482-9914-4a72-9263-e869fdf07f5c"), new Guid("840c5834-8997-46f4-b172-1567f2283954"), 1 });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId" },
                values: new object[] { new Guid("cd9fa246-4b49-4578-9fca-0fdb6e08f782"), new Guid("83e64526-b605-4443-a066-3f7a5815a58d") });

            migrationBuilder.InsertData(
                schema: "BillUser",
                table: "BillUser",
                columns: new[] { "BillId", "UserId", "Status" },
                values: new object[] { new Guid("cd9fa246-4b49-4578-9fca-0fdb6e08f782"), new Guid("840c5834-8997-46f4-b172-1567f2283954"), 1 });

            migrationBuilder.InsertData(
                schema: "Order",
                table: "Order",
                columns: new[] { "Id", "BillId", "CreatedAt", "ItemId", "LastUpdatedAt", "Message", "Quantity", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e425600-d295-4dc8-8a1d-47f2b4b35f91"), new Guid("acf38482-9914-4a72-9263-e869fdf07f5c"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6727), new Guid("a42591d6-61c4-4d3a-99aa-4f970028a6cf"), null, null, 2, 1, new Guid("840c5834-8997-46f4-b172-1567f2283954") },
                    { new Guid("13053e27-c6e4-4022-ad11-3db88c2aea86"), new Guid("cd9fa246-4b49-4578-9fca-0fdb6e08f782"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6724), new Guid("f85a8433-c7ab-4bd6-9dd8-265778c7e4ca"), null, null, 1, 1, new Guid("840c5834-8997-46f4-b172-1567f2283954") },
                    { new Guid("3db4871b-f95d-45ea-94da-c251ff41b542"), new Guid("acf38482-9914-4a72-9263-e869fdf07f5c"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6728), new Guid("9ef39960-5e42-48af-8b96-4aa988d36441"), null, null, 1, 1, new Guid("840c5834-8997-46f4-b172-1567f2283954") },
                    { new Guid("8256af38-8eb0-4e63-aa94-86971cad8bad"), new Guid("cd9fa246-4b49-4578-9fca-0fdb6e08f782"), new DateTime(2023, 6, 4, 1, 19, 11, 775, DateTimeKind.Utc).AddTicks(6718), new Guid("f53d394c-7f19-44e9-b66a-766542f84269"), null, "Completo", 1, 1, new Guid("840c5834-8997-46f4-b172-1567f2283954") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("3b3e9dfe-2ead-4375-8ced-b882675f10aa"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("864ca04f-3c5b-41f4-974b-d69a9301e289"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("b482a11d-f86a-4dab-97cd-0837b7ed423b"));

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("acf38482-9914-4a72-9263-e869fdf07f5c"), new Guid("83e64526-b605-4443-a066-3f7a5815a58d") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("acf38482-9914-4a72-9263-e869fdf07f5c"), new Guid("840c5834-8997-46f4-b172-1567f2283954") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("cd9fa246-4b49-4578-9fca-0fdb6e08f782"), new Guid("83e64526-b605-4443-a066-3f7a5815a58d") });

            migrationBuilder.DeleteData(
                schema: "BillUser",
                table: "BillUser",
                keyColumns: new[] { "BillId", "UserId" },
                keyValues: new object[] { new Guid("cd9fa246-4b49-4578-9fca-0fdb6e08f782"), new Guid("840c5834-8997-46f4-b172-1567f2283954") });

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("805d2fef-1fed-4791-95d8-d3f0981191cf"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("cb976610-dafc-47f4-88b9-38ce140f1b1a"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("0e425600-d295-4dc8-8a1d-47f2b4b35f91"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("13053e27-c6e4-4022-ad11-3db88c2aea86"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("3db4871b-f95d-45ea-94da-c251ff41b542"));

            migrationBuilder.DeleteData(
                schema: "Order",
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("8256af38-8eb0-4e63-aa94-86971cad8bad"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("2e41fd8b-233b-4967-8d7a-d4697ff05ca8"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("5c6a24bc-63d6-4276-885a-b14ca1cf1108"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("91bcce23-12ad-444c-9462-abf3de03e289"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9c7edea8-0237-4154-9f07-233ee2f1743f"));

            migrationBuilder.DeleteData(
                schema: "Bill",
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("acf38482-9914-4a72-9263-e869fdf07f5c"));

            migrationBuilder.DeleteData(
                schema: "Bill",
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("cd9fa246-4b49-4578-9fca-0fdb6e08f782"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("9ef39960-5e42-48af-8b96-4aa988d36441"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("a42591d6-61c4-4d3a-99aa-4f970028a6cf"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("f53d394c-7f19-44e9-b66a-766542f84269"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("f85a8433-c7ab-4bd6-9dd8-265778c7e4ca"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("83e64526-b605-4443-a066-3f7a5815a58d"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("840c5834-8997-46f4-b172-1567f2283954"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("006ececc-294d-45d9-84af-fb677d04ee3c"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("3484d42a-ffb8-43d6-9d24-4976dc8753a7"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("3b91a518-af8a-4640-9450-e4463df6e385"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("a4b7e366-c796-4e0b-a46f-b79011f02b5b"));

            migrationBuilder.DeleteData(
                schema: "Table",
                table: "Table",
                keyColumn: "Id",
                keyValue: new Guid("a8b4437b-a2c6-4ae8-ade9-1cf4109e96e4"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("5789cc3f-b35f-4e07-8bfe-005c491cd076"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("e1b9408f-9462-43fe-ae85-187cb8ecffa2"));

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
