using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class datetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("6beed666-f12d-4c74-b104-dea4acab16f4"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("6d4632a1-a97b-4f74-b247-7a2752dfc185"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("b9d9a561-c800-4f7f-87a5-5fec97da4454"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("e0ad94e8-916e-4998-8ae6-b9053f785517"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("ee397303-d6a7-44fa-9b95-919ed326eb23"));

            migrationBuilder.DeleteData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: new Guid("f8e02a72-9011-4e50-9a15-a629e6714f65"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("01ee2e8e-609e-4234-88e9-85787e9a332f"));

            migrationBuilder.DeleteData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("363c028c-631a-46ba-9ee4-fc6d207c32e2"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("4541697a-751d-4db8-b200-8a53e9255c22"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("a772cc9e-33a4-49c3-a62d-8daccd9eb11c"));

            migrationBuilder.DeleteData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("bbbb0da8-5e4d-4400-b308-45b564303021"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("9be02aa5-f544-4cd5-b0c8-361ce5288004"));

            migrationBuilder.DeleteData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: new Guid("e51a73e2-73cb-4f49-b112-ea3ea250beae"));

            migrationBuilder.DropColumn(
                name: "Time",
                schema: "Attraction",
                table: "Attraction");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "User",
                table: "User",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "User",
                table: "User",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Review",
                table: "Review",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Review",
                table: "Review",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Restaurant",
                table: "Restaurant",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Restaurant",
                table: "Restaurant",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Reservation",
                table: "Reservation",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                schema: "Reservation",
                table: "Reservation",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Reservation",
                table: "Reservation",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "MenuItem",
                table: "MenuItem",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "MenuItem",
                table: "MenuItem",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpirationDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedAt",
                schema: "Attraction",
                table: "Attraction",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                schema: "Attraction",
                table: "Attraction",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                schema: "Attraction",
                table: "Attraction",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "now()");

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "DDD", "PhoneNumber", "Email", "City", "Complement", "Number", "State", "Street", "ZipCode", "CompanyName", "TradingName" },
                values: new object[,]
                {
                    { new Guid("76b2480a-84ed-4470-b6ca-fba05f7631c0"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(3942), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "85", "998888888", "mcdonalds@foodinloco.com", "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Mc Donalds", "Méqui" },
                    { new Guid("a0f08e67-326e-430e-9890-3929c7053f8d"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(6346), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "85", "997777777", "burgerking@foodinloco.com", "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "Burger King", "BK" }
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
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "Description", "Name", "EndAt", "StartAt", "HappyHour" },
                values: new object[,]
                {
                    { new Guid("00477c15-b120-43a7-913a-c02a36316b0a"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(7303), null, new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(7303), null, new Guid("76b2480a-84ed-4470-b6ca-fba05f7631c0"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("7f5ecce9-76e2-4a90-b966-b20780156168"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(7814), null, new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(7814), null, new Guid("a0f08e67-326e-430e-9890-3929c7053f8d"), 1, "Cardápio de Happy Hour.", "Happy Hour", new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true },
                    { new Guid("f8a1df7a-4db6-4052-9014-fa8149abee58"), new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(6961), null, new DateTime(2022, 11, 21, 20, 18, 30, 894, DateTimeKind.Utc).AddTicks(6960), null, new Guid("76b2480a-84ed-4470-b6ca-fba05f7631c0"), 1, "Cardápio de vinhos.", "Wine", null, null, false }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateOnly>(
                name: "LastUpdatedAt",
                schema: "User",
                table: "User",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreatedAt",
                schema: "User",
                table: "User",
                type: "date",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "LastUpdatedAt",
                schema: "Review",
                table: "Review",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreatedAt",
                schema: "Review",
                table: "Review",
                type: "date",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "LastUpdatedAt",
                schema: "Restaurant",
                table: "Restaurant",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreatedAt",
                schema: "Restaurant",
                table: "Restaurant",
                type: "date",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "LastUpdatedAt",
                schema: "Reservation",
                table: "Reservation",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                schema: "Reservation",
                table: "Reservation",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreatedAt",
                schema: "Reservation",
                table: "Reservation",
                type: "date",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "LastUpdatedAt",
                schema: "MenuItem",
                table: "MenuItem",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreatedAt",
                schema: "MenuItem",
                table: "MenuItem",
                type: "date",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "LastUpdatedAt",
                schema: "Menu",
                table: "Menu",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "date",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "ExpirationDate",
                schema: "Menu",
                table: "Menu",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreatedAt",
                schema: "Menu",
                table: "Menu",
                type: "date",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "LastUpdatedAt",
                schema: "Attraction",
                table: "Attraction",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                schema: "Attraction",
                table: "Attraction",
                type: "date",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreatedAt",
                schema: "Attraction",
                table: "Attraction",
                type: "date",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "Time",
                schema: "Attraction",
                table: "Attraction",
                type: "time without time zone",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.InsertData(
                schema: "Restaurant",
                table: "Restaurant",
                columns: new[] { "Id", "CreatedAt", "Kids", "LastUpdatedAt", "Photo", "Status", "City", "Complement", "Number", "State", "Street", "ZipCode", "DDD", "PhoneNumber", "CompanyName", "TradingName", "Email" },
                values: new object[,]
                {
                    { new Guid("9be02aa5-f544-4cd5-b0c8-361ce5288004"), new DateOnly(2022, 11, 21), true, null, "https://d3sn2rlrwxy0ce.cloudfront.net/_800x600_crop_center-center_none/Burger-King-Novo-logo.png?mtime=20210125152539&focal=none&tmtime=20210726130340", 1, "Fortaleza", "Apto 001, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "997777777", "Burger King", "BK", "burgerking@foodinloco.com" },
                    { new Guid("e51a73e2-73cb-4f49-b112-ea3ea250beae"), new DateOnly(2022, 11, 21), false, null, "https://www.mcdonalds.com.br/images/layout/mcdonalds-logo-footer-bg-white.png", 1, "Fortaleza", "Apto 004, Bloco D", 150L, "Ceará", "Travessa Elisiário Mendes", "60841477", "85", "998888888", "Mc Donalds", "Méqui", "mcdonalds@foodinloco.com" }
                });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "Password", "Photo", "Roles", "Salt", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("01ee2e8e-609e-4234-88e9-85787e9a332f"), new DateOnly(2022, 11, 21), null, "O3o1Y/ISydCnCHzuE0Ls1tJ8nLSKiic/ySc5f8k6NEyDIB6RI2Ceo4rRv7K/bgbShXVODF8pr5WgOmqwlKW6fpKbfMbB1sOn9vlGJA3pzq++er9ZUtdxTsM7TaH0nt6VmVa+amzABVlD2XHLbTELWTX1sRLRX8Wp5RERovH1J0L/TL2zEjUpWxALmQZeeRnA7i3mTDdv8FVOxuBVJFNMTDYC7dN7KSs5m8+TznCPIirqOblvfnlwpZ+sMvyXSCZ1beC+usTxqE7c9vTRersInHboefSSEa4oUg7LdBPzmIzja4J+SM10hdPOpyjCdh5AebuZsgmNO7J5KI/pXciulTRUjdWplUqvTqahjaqeq8oW/nkWD1Mz/pzhf8sICtFNq4tw61iQg6/ylLhdJLp4wtrLmKPOz4Cbj3IkbwQg3CTHs5FnEe9f9RvImgFvH6st3mf31+u33ozuEANbASaL/m1lPzDxQfVaF1anAD3jPAFC/L/ovX18APtsOaZbxUXBBYocfWy65o+8bsnkE7qGVZZBJBMYbfzRviZQoLjk3TN2Zwg2+jYksq4G4FE0hAVMlgZzB0yPRiYVGiWDgjd2piNqrE4NNFENknhiRC4BFJ8XP/9UOSZwxNuZsKhWZWSRmA4cA683GgUBxmr3gZFd3zT1a4VLP9fKiNvyyhE2S/o=", null, 1, "5786bacb-527c-4239-9204-5c8a770146ad", 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Lopes de Oliveira" },
                    { new Guid("363c028c-631a-46ba-9ee4-fc6d207c32e2"), new DateOnly(2022, 11, 21), null, "Qm3WMdHEyOaaKsUIM24yxSW/w0mwyTYbfgTbNti68O1QZcjXJUVuXvPQ3akXroglxF2cDvSrIUN69wJnDUvWkBuKKhzElumBIlhZidFfx4oPNEuxC25wPVZnKQOpIz6CyuoEhhgM63IFk899gCIpYQ1P1afl1p+8WHA2jfdrYfFdh6CCb+/0tXcHclTTWbqtJMWYrBXLKg05IOLbIZB0KyZmd1bQNKrv+kaLgypva2o2xBUG4CX+JNjfKU358qbIWEUdiG2H0PCBowjfOVqmMhD++nJ9vV1YJUm4vZ4WA8S5TBTqiW9nC8WDrGh12Gco9Y2amaVIjqX10EiITifhXE7JInG/juoUq1DTlwf8HTpPFNf4sWhIqhiZlGOc+maXjNuv4pQkaoIAsSzs9utCJfRkJAmy7+QOn2G6W7psx5N1D/Ao8PmlCZ6j5uZTRWr9kC2lm4SBZtdUdavBq3ioyw1mJ5ZV7wCMdby5/NdCG/5TD5COo1Ck+8sUmy1hA+TEDWOL1kSk84fPxTgGM5fNuJLXOXhRnax15Z4V4fR4ImIHUFbzmcbrt/2UuCRu8BU37q5xl+KxP64VYagQ7TXiMPzaM8eCdEDadN/BuKasfqN7RHD/yYHFT6Ag2jYVFhF7BeV3Js+reawvoQwcM2adXpTgoUUtYXZarS+2ujejZSQ=", null, 3, "7b1ad173-0e7f-4382-ada8-30379af0048d", 1, "85", "999999999", "admin@foodinloco.com", "Admin", "FoodInLoco" }
                });

            migrationBuilder.InsertData(
                schema: "Menu",
                table: "Menu",
                columns: new[] { "Id", "CreatedAt", "ExpirationDate", "InitialDate", "LastUpdatedAt", "RestaurantId", "Status", "EndAt", "StartAt", "HappyHour", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("4541697a-751d-4db8-b200-8a53e9255c22"), new DateOnly(2022, 11, 21), null, new DateOnly(2022, 11, 21), null, new Guid("e51a73e2-73cb-4f49-b112-ea3ea250beae"), 1, null, null, false, "Cardápio de vinhos.", "Wine" },
                    { new Guid("a772cc9e-33a4-49c3-a62d-8daccd9eb11c"), new DateOnly(2022, 11, 21), null, new DateOnly(2022, 11, 21), null, new Guid("e51a73e2-73cb-4f49-b112-ea3ea250beae"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" },
                    { new Guid("bbbb0da8-5e4d-4400-b308-45b564303021"), new DateOnly(2022, 11, 21), null, new DateOnly(2022, 11, 21), null, new Guid("9be02aa5-f544-4cd5-b0c8-361ce5288004"), 1, new TimeOnly(20, 0, 0), new TimeOnly(16, 30, 0), true, "Cardápio de Happy Hour.", "Happy Hour" }
                });

            migrationBuilder.InsertData(
                schema: "MenuItem",
                table: "MenuItem",
                columns: new[] { "Id", "CreatedAt", "LastUpdatedAt", "MenuId", "Photo", "Quantity", "Status", "Value", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6beed666-f12d-4c74-b104-dea4acab16f4"), new DateOnly(2022, 11, 21), null, new Guid("a772cc9e-33a4-49c3-a62d-8daccd9eb11c"), null, 6, 1, 14.0, "Empanados de frango recheados com queijo.", "Chicken Nuggets" },
                    { new Guid("6d4632a1-a97b-4f74-b247-7a2752dfc185"), new DateOnly(2022, 11, 21), null, new Guid("4541697a-751d-4db8-b200-8a53e9255c22"), null, 1, 1, 90.0, "Vinho de uva.", "Vinho Quinta do Morgado" },
                    { new Guid("b9d9a561-c800-4f7f-87a5-5fec97da4454"), new DateOnly(2022, 11, 21), null, new Guid("a772cc9e-33a4-49c3-a62d-8daccd9eb11c"), null, 1, 1, 4.9000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("e0ad94e8-916e-4998-8ae6-b9053f785517"), new DateOnly(2022, 11, 21), null, new Guid("bbbb0da8-5e4d-4400-b308-45b564303021"), null, 1, 1, 11.0, "Porção de batata feita com a melhor batata que existe (Burger King).", "Porção de batata" },
                    { new Guid("ee397303-d6a7-44fa-9b95-919ed326eb23"), new DateOnly(2022, 11, 21), null, new Guid("bbbb0da8-5e4d-4400-b308-45b564303021"), null, 1, 1, 5.4000000000000004, "Chopp de Brahma.", "Chopp" },
                    { new Guid("f8e02a72-9011-4e50-9a15-a629e6714f65"), new DateOnly(2022, 11, 21), null, new Guid("bbbb0da8-5e4d-4400-b308-45b564303021"), null, 1, 1, 22.0, "Hamburguer feito com pão brioche (homemade), 90g de blend, queijo cheddar, cebola caramelizada, picles e molho da casa.", "Hamburguer" }
                });
        }
    }
}
