using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class nullableRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("2a2dcfc5-bfc0-408c-bc5a-c334646733ad"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("63a15fdd-e842-4830-8cf6-6d95a8889ef8"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("cdc126c2-d1ba-4329-a212-dd6befd9ed8a"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("48c63618-e4b2-42c3-bc17-1bfb599722e5"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("49cddba2-9213-4574-b70c-7004f57eba2e"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("c1a75e8d-3fb0-453e-8805-d7717f8f2624"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("c75ac7ad-96a9-43c2-8518-61350d729956"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("da9d27ef-5443-4c53-a98e-50e4709f3a20"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("f2f38c81-09ad-403c-a078-ef00248c2daf"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1602c566-349a-4fa3-956e-df3ccc531558"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("3c77f67b-806c-4042-bb6f-98efb87b5c5a"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("c0581d1d-2bf6-4909-88b7-2d1bc87e9347"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("f3929b9b-d0e9-4aad-b467-b3529a2ef7e3"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("0d252a00-6de4-4bbd-8215-c83c2f865582"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("1eb98d03-7bef-41ff-8ea4-4290d92a640b"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2216d7a7-8cfe-4e82-ae09-9a2899adde93"));

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("28f1a369-06c7-4b1c-bdcf-eec1bfbbdd2f"), new DateTime(2022, 11, 23, 7, 25, 4, 707, DateTimeKind.Utc).AddTicks(9696), null, "Fb9R0PnLJTTgi4Fdc8/VClX3zL3HUDVAlqg0FwiaHGJ1UZooUXoP2oMjwttlAcTnFyFz2bXwMNseG1qHm7bhRR0qY9XXF0XYBqvexBYdC2UyiZ7339CtjrpLdP3fm4zK2Dt3jVvAnkUre6NxrGjFnZNv1FMfVSCz8EbCIkiIQGaYXI1Hp1PpoIBJSInjdHDshX9xXgRjUTzOzhTU5Z876qLhxnw0j5vhDM276oaqgHePf42MY7gf4W5vwO+cGtuU068e54oWSPEAXbtd4KRnKsni0w9i3DVtDJ7xtBSdpqNfi355DPy19X5jfyOnUHYDedK1Ezl1Ivyft3+N2rShyjmL+fy/4ucUVfRizl9k9GU74tQNhkg2GCZngtLRfS/MLVt+ZvEPgqm8fRGZ70+90RM+xhrDAqu4bRCshTTV8aeJl0RtZZcuQHMUkQV7Ik3lUTfrm+hfLljQiDXKQdUY9ykcgJdaXX61M+VDJb0hGlAjQ4hPX7TOqdtebtmg1nrjsJT24U1wR5rzHkpMaQ41fQDbdxNBlidQ0bslY5svTrLjil2GCWrtwIOovymjm+dVfmjDi8MXiFzbuGsMvELLSmAHOt3pGA5prXFc8ZJcv79PX9p7VwX5XXu9MJz31jdoFXbOIZnt/Pkq1lnT2K+M3KabMYOrQxBf310bjkb2XxM=", null, 1, "3d24f5c0-61ee-4015-bbcb-343cfd301c6f", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("e9eb175c-2332-4023-9366-4d16b746e817"), new DateTime(2022, 11, 23, 7, 25, 4, 641, DateTimeKind.Utc).AddTicks(821), null, "YKTT9nAicmBNPBe6PITSRbh0i/x7gm2DDeBjbdv4N7LJuFU5BHbnNlrK0f+HUfJe9sBxCsM8HsrQPrGBzj6UKTXdnXpy0HLPnaFcyctFv4CbcvlZRs+wRiY4WJkXKFQ60tnetA2vKjmA/xwM2+QsLnQk0lkcqu5Wln1ZS0mbIwxE+WEj9ZJYuZ6kiTImGX6qXnls8VzZo0tc8LctuxsZdrB0nEsx5l8gf0A6yCqSKkgzPkW5cVCAOXmicuV9q+UzKrpmO3Nd4tqBCuZp0yXePiDtSb7zZLhM9S2VgSKr4d9sJ4t2bsSuSsHVTGseePyCFFVDAp84jGvvZU9gvJmkhPGEDOmiMhPkqwVHEnbJZU22mOPYRXRubASBtbjy+WGqT2pNY5u/a19fzR217BwtkzlB8sFRFbJd4VIv5au1ARCkUFWCLqUqWlWI4PvFGwsIcDNe69A8PXKtHUZWSmNo/EHeLA+fkFyjz1YHwMFJ2dgD4rtpcArenVdi/PpjyeK3Nhhifmy3bbx87DPFhmF6gLmOQ7oLfB+PX8LLqE/vSrqmUPY6PN5opdYLNwZ+jZNIQH25sHiHCRBBbXgh9ImmcTTNCUnuwwJu39OeAyTFp7RP6KAaJmOu7FpwN761dYUnONsYM0R/bYSEDreDNwVQ6xKJCxin3UkJ8plYNcqFhP0=", null, 7, "8cee4488-5bae-4eb9-9441-e2a958cd5d1a", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "UserId", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("447e92eb-a102-4ba5-89e8-fcb30bb35b6f"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(1048), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, new Guid("e9eb175c-2332-4023-9366-4d16b746e817"), "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" },
                    { new Guid("b4a97127-fba2-4ca3-b924-57e3c213c5da"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(1459), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, new Guid("e9eb175c-2332-4023-9366-4d16b746e817"), "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("24f1859a-d608-40c1-afee-dcf9c7883ea4"), 20.0, new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2752), new DateTime(2022, 11, 24, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2747), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("447e92eb-a102-4ba5-89e8-fcb30bb35b6f"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("a51e8039-2ee4-459d-940d-c5b9d8fa5749"), 20.0, new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2849), new DateTime(2022, 11, 25, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2848), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("b4a97127-fba2-4ca3-b924-57e3c213c5da"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("e369a3b3-e424-4aa9-8914-c71da8e5dd59"), 20.0, new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2910), new DateTime(2022, 11, 30, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2906), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("b4a97127-fba2-4ca3-b924-57e3c213c5da"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("02e2a719-822c-491e-a882-f0d920f0ca16"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(1912), null, new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(1912), null, new Guid("447e92eb-a102-4ba5-89e8-fcb30bb35b6f"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("4c7ab2e7-0fb3-4f7c-b1c7-a1c38b9056e2"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(1667), null, new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(1667), null, new Guid("447e92eb-a102-4ba5-89e8-fcb30bb35b6f"), 1, "Cardápio de vinhos.", "Wine", null, null, false },
                    { new Guid("ec8e631f-8299-44fc-8789-30c374e64946"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2131), null, new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2131), null, new Guid("b4a97127-fba2-4ca3-b924-57e3c213c5da"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("23a8b8e6-0ead-452b-a612-ec41baa8e842"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2596), null, new Guid("ec8e631f-8299-44fc-8789-30c374e64946"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("67f882c6-da89-4bfe-90b8-c54f0adfb788"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2653), null, new Guid("02e2a719-822c-491e-a882-f0d920f0ca16"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("696f8345-2d7b-47d9-9b5e-e55647eeee83"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2490), null, new Guid("ec8e631f-8299-44fc-8789-30c374e64946"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("8df7354a-afb8-4362-9936-08c6e0477928"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2258), null, new Guid("4c7ab2e7-0fb3-4f7c-b1c7-a1c38b9056e2"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("cce22f76-0dd3-47aa-bd1b-727ed9235706"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2542), null, new Guid("ec8e631f-8299-44fc-8789-30c374e64946"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("dc674942-db41-45be-90da-e89201392fe2"), new DateTime(2022, 11, 23, 7, 25, 4, 708, DateTimeKind.Utc).AddTicks(2433), null, new Guid("02e2a719-822c-491e-a882-f0d920f0ca16"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("24f1859a-d608-40c1-afee-dcf9c7883ea4"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("a51e8039-2ee4-459d-940d-c5b9d8fa5749"));

            migrationBuilder.DeleteData(
                schema: "Attraction",
                table: "Attraction",
                keyColumn: "Id",
                keyValue: new Guid("e369a3b3-e424-4aa9-8914-c71da8e5dd59"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("23a8b8e6-0ead-452b-a612-ec41baa8e842"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("67f882c6-da89-4bfe-90b8-c54f0adfb788"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("696f8345-2d7b-47d9-9b5e-e55647eeee83"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("8df7354a-afb8-4362-9936-08c6e0477928"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("cce22f76-0dd3-47aa-bd1b-727ed9235706"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("dc674942-db41-45be-90da-e89201392fe2"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("28f1a369-06c7-4b1c-bdcf-eec1bfbbdd2f"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("02e2a719-822c-491e-a882-f0d920f0ca16"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("4c7ab2e7-0fb3-4f7c-b1c7-a1c38b9056e2"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("ec8e631f-8299-44fc-8789-30c374e64946"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("447e92eb-a102-4ba5-89e8-fcb30bb35b6f"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("b4a97127-fba2-4ca3-b924-57e3c213c5da"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e9eb175c-2332-4023-9366-4d16b746e817"));

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("1602c566-349a-4fa3-956e-df3ccc531558"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(5106), null, "CEzUd2xeXlRsWX/dzuuF0Qx8gE/T4joEKKlb2HzS8tBs5iXfJ/H/dOnVSZxvvg3fM3xdREwECv/EHuqbc/i1ihnDXJ+YAULKTgBv7BIX2OcbpsNCyl1exGksIiq85Bw+ElN7iznTPohVShZxPIj1up3Afts0GYcwBwg6QLXQ5WmYOFcGFA8bzioS1bxm8atRNpNZBtxu0zQAWM2AoAYPTLLaeOmlHcmHSdPT2hge8PQz1QSO29fYH/zUtYGgtvuBCcpnYM8CI0oTGk+OlHyNxZjbaS0NDMCp8pse0E4e0Jg7/1IOrQwKwYa8Qm2T8i3XTYAR2o5AAjvd/h7sTTYqOwA48W44M5ltrYWmdstmwc7bfk20h/cTNLvfw0tiHxJ85GVmTHKv4MG7GkzN7fxTcFupnYva1IIMozHFWDhoGdtKymcvVIodT+yZ73eaQ2nJBYulERkc8bhZxuPDwWbAU7aRb9hTBwMiCo9uN+rQ7XdmW7UqjoQYe0hS2tjk3CbPFGsxAQ8OCrZp7aRyzxOw7zSdMPgbB0xP6ZSU/4po60i6aHFXA3sP7kJUN4KolpP0i+t2gpjAL20kmevu63NlA6PdaURFo6ddImNv/gRqizjW9+fMamEh9rLUNQ5nxqySAoiML4loQ1+5pGg9l/D42EbcxLn69esIrK4KAstzS7Y=", null, 1, "423c50ec-36aa-47f6-8d1a-f99677a8aa0d", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("2216d7a7-8cfe-4e82-ae09-9a2899adde93"), new DateTime(2022, 11, 23, 3, 38, 57, 78, DateTimeKind.Utc).AddTicks(6047), null, "UV/sqmk7lYj4abv7L/5j6TPSL95wEqIvxYivpMIV5DicPDc6MrGb76Y0iMrlRRB/xZhkVAJwOFe8jHiqtRsZpu1AQa8tdoCUNs1XXfFHt9Quxo9oUewvC1BqhfvPY+aTx9VGTc/ihIE1s3ZrxG3wReG035kBXKuV2Pa8iOuo+xoLF8aJIzMNGhJnvydyBnvz6bUa/gnZEj7UxqU5E5jGmb/PAzeJtvUmt3WoCYqBcfMnr156rqbm9YALZTXxNP/oHuUepQVPV+JRx9tf4W1sNJf1uSjT0D1XAYfvCTJqbcxZkgJLKOM39JzuSQ5UTNvZA/sD9cZELq/pIhp+EwTURjjrrWcswqYrvDZTy6xLwLKoaFVMi0+F0rFT7I3ZMq4Rh1iT+wkzOg7px96HHZkD1tHPfxNBuCsC+37W2p4wKLWNzvuOuOHz5eTXfi8vd3zdi+cnXPjOmFBex92qFL9h3mRhf3cgVOW5or9yAe3HADPCNpXftGUrUOFFq26YAtA1JzCQ8b86ZqcIjPucKm9UpjZq32pIOkDjla+C0zCsXi6QUr2/QIbwVMampJzQ6qUoi4giJnRf0shaBs5S4pjzuxhpw37BOLGCNSISaICkZ6RwigJkbJmEV21T4jxpm8moD+MAuoyIBomTXHfIBQvmV4KYOJA2Jde73hG/un6cUI4=", null, 7, "86bb51ab-f2eb-43f6-b10e-a97cd4a53ba0", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "UserId", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("0d252a00-6de4-4bbd-8215-c83c2f865582"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(6394), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, new Guid("2216d7a7-8cfe-4e82-ae09-9a2899adde93"), "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" },
                    { new Guid("1eb98d03-7bef-41ff-8ea4-4290d92a640b"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(6761), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, new Guid("2216d7a7-8cfe-4e82-ae09-9a2899adde93"), "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" }
                });

            migrationBuilder.InsertData(
                schema: "Attraction",
                table: "Attraction",
                columns: new[] { "Id", "CoverTax", "CreatedAt", "Date", "LastUpdatedAt", "Photo", "RestaurantId", "Status", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2a2dcfc5-bfc0-408c-bc5a-c334646733ad"), 20.0, new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(8193), new DateTime(2022, 11, 30, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(8193), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("1eb98d03-7bef-41ff-8ea4-4290d92a640b"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("63a15fdd-e842-4830-8cf6-6d95a8889ef8"), 20.0, new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(8016), new DateTime(2022, 11, 24, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(8013), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("0d252a00-6de4-4bbd-8215-c83c2f865582"), 1, "Excelente banda.", "Fets Domino" },
                    { new Guid("cdc126c2-d1ba-4329-a212-dd6befd9ed8a"), 20.0, new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(8138), new DateTime(2022, 11, 25, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(8137), null, "https://scontent.fjdo1-1.fna.fbcdn.net/v/t39.30808-6/292709447_483405863791805_379209062390556101_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeGjo-OBezYn3E16VwXa7mkQ6JZ7t6ANUJbolnu3oA1Qlg3ohBa-81hGAF7BKDuc7tzeYDnnYjaFTra0RtF1YD7d&_nc_ohc=cq57dZpXtzcAX_RAgvH&_nc_ht=scontent.fjdo1-1.fna&oh=00_AfCxsShn3s5eflRMUoUlKFMJbrzj_PU5tNfuDHGVeRlJ0Q&oe=63811EEA", new Guid("1eb98d03-7bef-41ff-8ea4-4290d92a640b"), 1, "Excelente banda.", "Fets Domino" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3c77f67b-806c-4042-bb6f-98efb87b5c5a"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7174), null, new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7174), null, new Guid("0d252a00-6de4-4bbd-8215-c83c2f865582"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("c0581d1d-2bf6-4909-88b7-2d1bc87e9347"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7003), null, new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7003), null, new Guid("0d252a00-6de4-4bbd-8215-c83c2f865582"), 1, null, null, false, "Cardápio de vinhos.", "Wine" },
                    { new Guid("f3929b9b-d0e9-4aad-b467-b3529a2ef7e3"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7474), null, new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7474), null, new Guid("1eb98d03-7bef-41ff-8ea4-4290d92a640b"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("48c63618-e4b2-42c3-bc17-1bfb599722e5"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7780), null, new Guid("f3929b9b-d0e9-4aad-b467-b3529a2ef7e3"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("49cddba2-9213-4574-b70c-7004f57eba2e"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7887), null, new Guid("f3929b9b-d0e9-4aad-b467-b3529a2ef7e3"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("c1a75e8d-3fb0-453e-8805-d7717f8f2624"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7833), null, new Guid("f3929b9b-d0e9-4aad-b467-b3529a2ef7e3"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" },
                    { new Guid("c75ac7ad-96a9-43c2-8518-61350d729956"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7943), null, new Guid("3c77f67b-806c-4042-bb6f-98efb87b5c5a"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("da9d27ef-5443-4c53-a98e-50e4709f3a20"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7598), null, new Guid("c0581d1d-2bf6-4909-88b7-2d1bc87e9347"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("f2f38c81-09ad-403c-a078-ef00248c2daf"), new DateTime(2022, 11, 23, 3, 38, 57, 136, DateTimeKind.Utc).AddTicks(7698), null, new Guid("3c77f67b-806c-4042-bb6f-98efb87b5c5a"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" }
                });
        }
    }
}
