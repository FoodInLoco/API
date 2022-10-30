using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class modificacaoprojeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_Auth_AuthId",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Auth_AuthId",
                schema: "User",
                table: "User");

            migrationBuilder.DropTable(
                name: "Auth",
                schema: "Auth");

            migrationBuilder.DropIndex(
                name: "IX_User_AuthId",
                schema: "User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Restaurant_AuthId",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "AuthId",
                schema: "User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AuthId",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                schema: "User",
                table: "User",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Roles",
                schema: "User",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Salt",
                schema: "User",
                table: "User",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 30, 9, 10, 14, 63, DateTimeKind.Utc).AddTicks(1346),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 10, 24, 9, 36, 35, 327, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InitialDate",
                value: new DateTime(2022, 10, 30, 9, 10, 14, 251, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Roles", "Salt" },
                values: new object[] { "MgpcGfZdk9zZHEpZDFSwoNl83Jpsh8dsyF1GXo5SRbLM5Ufz2VutzdiJPpKgVwWjQsiTkcRRSMwmVJKEFAGT4iSdI7VV8cgcjwe0noDbgDsSWu0PT+3rHjQD8CGCjpw8zy61iBRJjHMkZtIqj1KQGp8Afx/2aA7+b8FpqwWfAvIuBsVlk2nsfJ/bUx5wLMm+COI2Oqa5KF7tqBVqeS4o7fxpm8MpHWTsZw8Yus5Ve8in29elbzMlEJ0ib8JfIyYiusEyz4nnUVHS0XXKa18cszcubgssNU4tLtYcrC+Q6eTxB40Ue7IbgYeKBusfFEjJgXIdvn9RK4fwfRq+BrIIHLwszLfPAf0otqgPfieJi6y3OLBJj1Z26UIDmVCv3Vvb+IXEaPz9+h2i5PCP7tf/vu7yr6sws4mBiH65P9d5oiuvzkjxheoJLzdKALmsZa3SCmZsvLA+GsJf4M5uo6kWRyCBaUxXT++wn2a8UUg7H2rQD5bUqyr/XzK/MGiTDqXrDfW4AuNdXWSM03L2Oyyv45KyLwrkFaF1R9MrSpwPjObn3X1VtM3nXF0GHyfXXkGcOW4qG7MVW0ebJ/v6cpQPUvJxyUOimp7UuZYsRKCv2KVUhZWA4N/9j//4TBg7TO+2IKOj6o/KioGjBiQiTg1D8xxyAcjYoouvaHsLabAlvBk=", 3, "a21e371e-7db0-4809-aa62-4d8bb33535c1" });

            migrationBuilder.UpdateData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Roles", "Salt" },
                values: new object[] { "y2EOamUBVjnb1XIERBJz/fe17z7igtjh8Y3VmOP6wZrRXxkpp2AHNj7921qxZYUMJRWQHC/XXzl0vtiTLPiCfKAOYmh+rUxfnj1R1SyXBxpl2tu4auUC659y+jlGq/H1/T6swrDGJ/ZZblBiZM6nrfvTexNGK1NWB57hPgtskCeFSz38iPyaBfOwmnSJsvqHCgKdAU423Q5eKXk24FuZUIrfAXJbdF8hvMOVvko6VPJv/xGfOWOL1l4s8SchgA9rgRG2+S8M3UNpR/T/K/4b0/TOJbGSu0fIX8wS76XXrtZZUBW8NjpQPLMCpI/tUpabUxPtHVVxrXEsppJCFVt0EaHBymuyWpLTrErTZTdcpjedNti7+CQ19UR2tGI9QbdLjEOyW5TKI2w6tJrqztc9hQ7VGmTjwp9RXXfLTBRnkdYwZooBVeKqSdFYpXESS4XxWrFBqLZF2WneO3bc2vJm0DnxlKOI5DtwBNcjR8qSmR3bGm3vLDBAQvrUiZsu7BOiH9snrVlh4xrHlO0syCldQUJKbDyxqOujaSR3N3WhCqByghjBf9qmRQyUopNx9WOun8jsHE6WqcVC5G3+8xbFwlGO7Ku03mdCkYlkV79n6dF7bxpZExe9beT9M6lzn77tt6T/exuwUGZcCCuY79QREOBoWDcgoVI0wHUm+0YqVSg=", 1, "1f414507-de3c-4835-9844-11de08995d7f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                schema: "User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Roles",
                schema: "User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Salt",
                schema: "User",
                table: "User");

            migrationBuilder.EnsureSchema(
                name: "Auth");

            migrationBuilder.AddColumn<long>(
                name: "AuthId",
                schema: "User",
                table: "User",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AuthId",
                schema: "Restaurant",
                table: "Restaurant",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 9, 36, 35, 327, DateTimeKind.Utc).AddTicks(1405),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 10, 30, 9, 10, 14, 63, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.CreateTable(
                name: "Auth",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Password = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Roles = table.Column<int>(type: "integer", nullable: false),
                    Salt = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Auth",
                columns: new[] { "Id", "Password", "Roles", "Salt", "Email" },
                values: new object[,]
                {
                    { 1L, "Apz3ywvGJr3DWaZAzbytc/D59NaNXYJ3Ewxj/Ck0U8y+AGv7hdG13rmW7UAaziYn1Qxf/vZEHZE0a2wIrSg1gMjWaKyHB83N5dwO1MohIQSA774u1tgWGHiMz3X/uBNiuDV5q1v8/TbeuM8rThtnx49+gOP+Cmuh/DTwceyAYov4g3gLEa0RU93YAUvv+RvbjQBnd6JkRt5EfZUKFOfFnvenssvMQZJPynkjKqGJUDgI3pu7IF4s5cFP+fuaRclSGDzWZ+Itc48+PE/HvHLW72vpHtcJNUf7i6I5OkB+vs6I+irFMXdUoXTPsy1ES3XROzKPqIGnWjC++8k4oTFFL+s2Ha1+pZs/e0NAEuCvaecp8PlItC5RYi6W1lbH0AZt8wwtisvBtzcQOl9DNSQ168hGLgpq0Yo+pIcr2EmKzQrvdtjJz/CPFi0NjBDl6yqyvYtA5cyHBM2vmd2A5C4dgJU3hp9xVis87q+XJ++tbmwft4z8veLXOZ0iM/EAbLrGe9/C70TCCP3uWctObWrLQtZk/igMxHZvzUf8RNM5UGTkA0+lGHwlxxNpw9fSe4RPnTurMH92KXlpNQj28nBTBj0DaAM+pAVOu4sXW5iPzKM7f+uu+I9z4MGEqAVNfaFJ462F85+FpTobIj7t3NfhRX31SRS5kxW0hjdKEeupK8U=", 3, "9ae56778-e666-4213-8148-97a49d2cf6cc", "admin@foodinloco.com" },
                    { 2L, "LZdig9kMTMqgi3wMfInSQ57qDoedBvF6sxy5AYbzdiO6GVTmVcDEUzSnwK23PUvtNB4iKFNKMcbuL1fYI/IIEZLuIuB3gZYtryk39cmnihjQJgqb4vLpWGiqjnRNt7xJ6zZ7joJYZEkkk3hEFN8aUk3gdOVZcgKLAteToVxtJT1X4Ejk2Sx3zwD8hsEcwxwzysfS/anT3clbe/+Fxg1OhWfwzDsofTYyzv3hBkk4kvn0DaKQt4+2tVH3Mbh4cJvCcEkHFYcw03VlYdBhh4kILGrPkBIcC6v7VwrKYP/hbesW/MLSA4h+TgiZbyU7PqPf++nHaZNZh5jNLyXq0Sdy98lfLYrhyqnBZ7aLcO+8jB9AyzMiiAkbj479R96X+dWiVTQ1d+b+fOoiAp7bYRSnbAa6yIJraXlW61DpTQlEFGAM+ajTSgUFSF98Qf9mACQPmfElssio/czFQLkOMzbFqyA/nc+ZMBSlhZT3vkvy7m2GyckJHYQl2gJN3FjBvF3fHC1zwGN1yHRppkfHRojbQ27LZMQaAvBzV19M7ObN87/tFjjRg7ed5XnI93SKv5kAi057smmBn1iX16Xbf0WREIs2g7+b9/EiVW5eTM/LRSy7j+yklTbdyzQoYiQ35MDy4pnwiK5id+BGbS6u3YcRGHVNofUPuwGGIG7oMUluc04=", 4, "531136f7-560d-46b8-a390-e7e282711ae9", "mcdonalds@foodinloco.com" },
                    { 3L, "9ug2Ysb+hAwZWZ/C4B39pA54o0cO7Y8GJQvwtgR7txevrfvpwkpgUVZzdInXsrYV4sFOzDTTpSZTibOeu7e9eoORj+5W2Zjcir6ChpcauXuXphfiICewa686PIW+ZrhXOcCRZ47m0AOCZdckHKfq5AliKF/TkYQTh+Xqot/xRLdCUfChRGsmKa+23/bGE8URg+zGFLS3ssXyXt3Q0GfULEojZvOumv4aMQUUbTiqfbvbqRfTd4fSwftMaCnPd9OB/IpVg/gDce8IkboHWKtQcii39b8xLMmXP1qsg3yJt19KZb5k4rs0PUbrmWhlb/TXEbUyDxXR2enxRCel/r4ooyt6Cyl0KpS7AMVBpiW3SwE5JmoZdDWa0czRpkVtd8KM6MR6WnnM5MSquPqzJUeTg1pTh6o7FS21yhn86sOFm4ryZ2iBIiJ5r2QMGhNotc9q57QO+Ks8O+jW4N+TTgZnjmh3dK7MOBu+0lcARxt+FSWMNmN9Z3CAp9fOs5LElzJYm9Zg+ofA8UdYUEToqQmprpHXCAFSFFEuQlcW/PpQPRrh1o0OlTFhZoKaBxuintCzNBgh1bbh+laBmUhAkuvYuYU4hzcT8gXt2qO2os/JP+muldxLsrf5J4IEPmNMQdEqUWYtPTYs2T0kEhD9e/+WY7eH8pCMsnEmusW5t3kvrfw=", 1, "74ce8592-b31d-42cc-b50a-e5c80b14a173", "letter.pedro@gmail.com" }
                });

            migrationBuilder.UpdateData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InitialDate",
                value: new DateTime(2022, 10, 24, 9, 36, 35, 504, DateTimeKind.Utc).AddTicks(458));

            migrationBuilder.UpdateData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AuthId",
                value: 2L);

            migrationBuilder.UpdateData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                column: "AuthId",
                value: 1L);

            migrationBuilder.UpdateData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                column: "AuthId",
                value: 3L);

            migrationBuilder.CreateIndex(
                name: "IX_User_AuthId",
                schema: "User",
                table: "User",
                column: "AuthId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_AuthId",
                schema: "Restaurant",
                table: "Restaurant",
                column: "AuthId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Auth_Email",
                schema: "Auth",
                table: "Auth",
                column: "Email",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_Auth_AuthId",
                schema: "Restaurant",
                table: "Restaurant",
                column: "AuthId",
                principalSchema: "Auth",
                principalTable: "Auth",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Auth_AuthId",
                schema: "User",
                table: "User",
                column: "AuthId",
                principalSchema: "Auth",
                principalTable: "Auth",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
