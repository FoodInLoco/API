using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class atualizaauth2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auth_Restaurant_RestaurantId",
                schema: "Auth",
                table: "Auth");

            migrationBuilder.DropForeignKey(
                name: "FK_Auth_User_UserId",
                schema: "Auth",
                table: "Auth");

            migrationBuilder.DropIndex(
                name: "IX_Auth_RestaurantId",
                schema: "Auth",
                table: "Auth");

            migrationBuilder.DropIndex(
                name: "IX_Auth_UserId",
                schema: "Auth",
                table: "Auth");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                schema: "Auth",
                table: "Auth");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "Auth",
                table: "Auth");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 9, 36, 35, 327, DateTimeKind.Utc).AddTicks(1405),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 10, 24, 9, 22, 56, 87, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "Apz3ywvGJr3DWaZAzbytc/D59NaNXYJ3Ewxj/Ck0U8y+AGv7hdG13rmW7UAaziYn1Qxf/vZEHZE0a2wIrSg1gMjWaKyHB83N5dwO1MohIQSA774u1tgWGHiMz3X/uBNiuDV5q1v8/TbeuM8rThtnx49+gOP+Cmuh/DTwceyAYov4g3gLEa0RU93YAUvv+RvbjQBnd6JkRt5EfZUKFOfFnvenssvMQZJPynkjKqGJUDgI3pu7IF4s5cFP+fuaRclSGDzWZ+Itc48+PE/HvHLW72vpHtcJNUf7i6I5OkB+vs6I+irFMXdUoXTPsy1ES3XROzKPqIGnWjC++8k4oTFFL+s2Ha1+pZs/e0NAEuCvaecp8PlItC5RYi6W1lbH0AZt8wwtisvBtzcQOl9DNSQ168hGLgpq0Yo+pIcr2EmKzQrvdtjJz/CPFi0NjBDl6yqyvYtA5cyHBM2vmd2A5C4dgJU3hp9xVis87q+XJ++tbmwft4z8veLXOZ0iM/EAbLrGe9/C70TCCP3uWctObWrLQtZk/igMxHZvzUf8RNM5UGTkA0+lGHwlxxNpw9fSe4RPnTurMH92KXlpNQj28nBTBj0DaAM+pAVOu4sXW5iPzKM7f+uu+I9z4MGEqAVNfaFJ462F85+FpTobIj7t3NfhRX31SRS5kxW0hjdKEeupK8U=", "9ae56778-e666-4213-8148-97a49d2cf6cc" });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "LZdig9kMTMqgi3wMfInSQ57qDoedBvF6sxy5AYbzdiO6GVTmVcDEUzSnwK23PUvtNB4iKFNKMcbuL1fYI/IIEZLuIuB3gZYtryk39cmnihjQJgqb4vLpWGiqjnRNt7xJ6zZ7joJYZEkkk3hEFN8aUk3gdOVZcgKLAteToVxtJT1X4Ejk2Sx3zwD8hsEcwxwzysfS/anT3clbe/+Fxg1OhWfwzDsofTYyzv3hBkk4kvn0DaKQt4+2tVH3Mbh4cJvCcEkHFYcw03VlYdBhh4kILGrPkBIcC6v7VwrKYP/hbesW/MLSA4h+TgiZbyU7PqPf++nHaZNZh5jNLyXq0Sdy98lfLYrhyqnBZ7aLcO+8jB9AyzMiiAkbj479R96X+dWiVTQ1d+b+fOoiAp7bYRSnbAa6yIJraXlW61DpTQlEFGAM+ajTSgUFSF98Qf9mACQPmfElssio/czFQLkOMzbFqyA/nc+ZMBSlhZT3vkvy7m2GyckJHYQl2gJN3FjBvF3fHC1zwGN1yHRppkfHRojbQ27LZMQaAvBzV19M7ObN87/tFjjRg7ed5XnI93SKv5kAi057smmBn1iX16Xbf0WREIs2g7+b9/EiVW5eTM/LRSy7j+yklTbdyzQoYiQ35MDy4pnwiK5id+BGbS6u3YcRGHVNofUPuwGGIG7oMUluc04=", "531136f7-560d-46b8-a390-e7e282711ae9" });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "9ug2Ysb+hAwZWZ/C4B39pA54o0cO7Y8GJQvwtgR7txevrfvpwkpgUVZzdInXsrYV4sFOzDTTpSZTibOeu7e9eoORj+5W2Zjcir6ChpcauXuXphfiICewa686PIW+ZrhXOcCRZ47m0AOCZdckHKfq5AliKF/TkYQTh+Xqot/xRLdCUfChRGsmKa+23/bGE8URg+zGFLS3ssXyXt3Q0GfULEojZvOumv4aMQUUbTiqfbvbqRfTd4fSwftMaCnPd9OB/IpVg/gDce8IkboHWKtQcii39b8xLMmXP1qsg3yJt19KZb5k4rs0PUbrmWhlb/TXEbUyDxXR2enxRCel/r4ooyt6Cyl0KpS7AMVBpiW3SwE5JmoZdDWa0czRpkVtd8KM6MR6WnnM5MSquPqzJUeTg1pTh6o7FS21yhn86sOFm4ryZ2iBIiJ5r2QMGhNotc9q57QO+Ks8O+jW4N+TTgZnjmh3dK7MOBu+0lcARxt+FSWMNmN9Z3CAp9fOs5LElzJYm9Zg+ofA8UdYUEToqQmprpHXCAFSFFEuQlcW/PpQPRrh1o0OlTFhZoKaBxuintCzNBgh1bbh+laBmUhAkuvYuYU4hzcT8gXt2qO2os/JP+muldxLsrf5J4IEPmNMQdEqUWYtPTYs2T0kEhD9e/+WY7eH8pCMsnEmusW5t3kvrfw=", "74ce8592-b31d-42cc-b50a-e5c80b14a173" });

            migrationBuilder.UpdateData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InitialDate",
                value: new DateTime(2022, 10, 24, 9, 36, 35, 504, DateTimeKind.Utc).AddTicks(458));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 9, 22, 56, 87, DateTimeKind.Utc).AddTicks(1131),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 10, 24, 9, 36, 35, 327, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.AddColumn<long>(
                name: "RestaurantId",
                schema: "Auth",
                table: "Auth",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                schema: "Auth",
                table: "Auth",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "AMBUbAtpVz8KgjjypcusZY5csFQvwdTEBs49fm8oqptFK2qDnVo8oTMVj+7t3jblUzzALYXy1jwqm0xGO0k0eJqlHb9EkqTQBSHQRWHgqR10Pu7xFQBHZU+78P/4exmbtR9Z24Gca+/n/d9Wk8SLHfE0+3GduNTIxhz/JfFISVKY22MmnpTk4OF6ja4jiLJwTvq2ZBLI1UwSJKJ7luf6cN06IbHDI+m4jLMfQ2+bUB3bARv37Bx2ZFwrMCcyrLq+JXTAVO1SbSXed85iAsuvCFUNiSifKzvLyB3f161nc/p7T7N3dlpJP9/B6Q79nrPcO/VbomzML9eQJEX2zESpN2CxgEsUjNFhOGj/CuirW0mzweoO6xiyiCydYJEvfa+7Y3FjPIu+BtYSFgLUYLJgMG7CCbX5zMG0pcSfzciAwYJH1CT/ZAFrj7Epa+sArpD+eS8M2aF7Iik9tLyWf2g4mjgu42tGzu+6E2RP54PFFZ7lu+36o4SnMrLTtTZAvDhOc4lt/6CHb6dWOsa37Yc5WQ39Cus8vQj4cqHyQ2Bg/1Ault/4eovlvMEVUoF3gJhsXqu5iHAg6L2I7zUCV5/hCMOICTjBaPL28PByw3XxZ919P8l5rHzMplDjnIHdClLxWUlCSoNE1n3xJs0h0j8URTohAN97VMNIohJrN9WVpLI=", "ab4fa790-1ebd-4b65-a33b-0c8c5cbfbbd7" });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "sz6XQQpxdSbaBN6UPKSJXt9viQo4n1dwaciIDTlj2YgfgernIN6aeC13cjUijhRDCF3xejyLS/Xo4eU7TfQxllIJw57P/rkyV5iwmsisoEdnMGK1ru3DygJxX5iPAzl9jnUBdqSV+ORzQ7i8l8YMMaP2yhLcvXRO0oe/4HSM0wytdKg9V2Zr9q1fIBRSUfSOJN89j6CUxQC3MPmcDGQqPwS1LHqA7/9cZHmyLqVvY7ptNyJYf8WeJTmXXvo73dVTV4VB9vOUgBj9mj/PpSskpTuSXb3Pq/Q16un/lKCoKCMc3wVxxpZsic/s8uPC8sqgjJbMSNqt0MWEnSdxqyQcAgXUYNvKYufjUPB0reJ7cGW8gA+hntqNynz0icmzJiCeoq3GJ3tzETV8gMqbU1JRWjxv/8V02QCD8TrbYaA2ikuwwb+aRDFwIrK9qnKFDVVtFMa+PHVTh1je5uctubYWj4/fP2CIk3Loo7P8H1tu80Bohsby4735gWgYWTIktNI7oQmqF6Ep0Y25vDmbIHvn1+M4SwqD+mJ5Xxw5cKaGltwR5rIEzkgGSqM2qQK88vGQrYqjCvsC9w/eq8rjkhy/Iicwt2ueYbdapcrrfDBpF3/V5O2FjwRYLjy1TpSy+TuRwUYuot9AW+Tv78uBj8/M4v8qP/ZF1uwW4ALR65aQZtI=", "e1460931-6535-41e0-b6de-4a7d86768c61" });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "gMz9ZdqfuJYjc4SmopC/g2seudzNeHmNZapn9J+gQqH5GdoLFsu35nZpEoqPXAGBDaTIUAEr8RjvhVUF2HhgIr56QwrzXeN0id3og9qAnIuOkmRjhDJg17xHWHBNlf2TaKoibyOObKsN8NzbgzwXfR8VLwXDot1ZG42Tf7zAGAv89nPZ3e008WokdjAvyJv4J8lJOY1oPu5VyK6cAn4CS/SpUndJMCaQvb4Qpf8Gqk8aHnsnFypyyHJEN5GA9Xq4bOxI/UoL9uG141fUfBDU0BBtEDzvx+KDW+UpDhLwfpUTrYBiWvuta/MCZFW+w0+JE+PkR9tYQlXPKzUH/+gSoxXqcUmeebti3Oq6FaF+GZ5RgNrs3MfCut18ivYaiiikuAfnGUt7UBWOGFOCCFKr+UxsOzCwkno+CqGSf3hQ9Ssc8rG80YVl4DdFKUbl7pRDl9L+qCNJtHq23Y/KUjuOQVvyBDoIBV0nwLqYbYLh1NUPXJDxCCoyBDNV4N4YZCIq5njncKCYd6+ccM2ZiZsElDGiOnmCA1xzF7El5VYpFN6IqIsfS81/mJ10BehEtDWIkjRwE/cjmrNVJNYZxVsEcljtEXEi2ShdEOmOg4ZUTMfF/WvuDS6l0TiqPu3BdzSEp8i1xUKX9efusG7tupIWCLY3UeqcHLTU0/xr3vXVCXQ=", "5698c8b4-c81b-4e87-8201-b9363f24845b" });

            migrationBuilder.UpdateData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InitialDate",
                value: new DateTime(2022, 10, 24, 9, 22, 56, 264, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.CreateIndex(
                name: "IX_Auth_RestaurantId",
                schema: "Auth",
                table: "Auth",
                column: "RestaurantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Auth_UserId",
                schema: "Auth",
                table: "Auth",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Auth_Restaurant_RestaurantId",
                schema: "Auth",
                table: "Auth",
                column: "RestaurantId",
                principalSchema: "Restaurant",
                principalTable: "Restaurant",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Auth_User_UserId",
                schema: "Auth",
                table: "Auth",
                column: "UserId",
                principalSchema: "User",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
