using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class atualizaauth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Auth_Login",
                schema: "Auth",
                table: "Auth");

            migrationBuilder.DropColumn(
                name: "Login",
                schema: "Auth",
                table: "Auth");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 9, 22, 56, 87, DateTimeKind.Utc).AddTicks(1131),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 9, 26, 10, 29, 18, 649, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "Auth",
                table: "Auth",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "Password", "Salt", "Email" },
                values: new object[] { "AMBUbAtpVz8KgjjypcusZY5csFQvwdTEBs49fm8oqptFK2qDnVo8oTMVj+7t3jblUzzALYXy1jwqm0xGO0k0eJqlHb9EkqTQBSHQRWHgqR10Pu7xFQBHZU+78P/4exmbtR9Z24Gca+/n/d9Wk8SLHfE0+3GduNTIxhz/JfFISVKY22MmnpTk4OF6ja4jiLJwTvq2ZBLI1UwSJKJ7luf6cN06IbHDI+m4jLMfQ2+bUB3bARv37Bx2ZFwrMCcyrLq+JXTAVO1SbSXed85iAsuvCFUNiSifKzvLyB3f161nc/p7T7N3dlpJP9/B6Q79nrPcO/VbomzML9eQJEX2zESpN2CxgEsUjNFhOGj/CuirW0mzweoO6xiyiCydYJEvfa+7Y3FjPIu+BtYSFgLUYLJgMG7CCbX5zMG0pcSfzciAwYJH1CT/ZAFrj7Epa+sArpD+eS8M2aF7Iik9tLyWf2g4mjgu42tGzu+6E2RP54PFFZ7lu+36o4SnMrLTtTZAvDhOc4lt/6CHb6dWOsa37Yc5WQ39Cus8vQj4cqHyQ2Bg/1Ault/4eovlvMEVUoF3gJhsXqu5iHAg6L2I7zUCV5/hCMOICTjBaPL28PByw3XxZ919P8l5rHzMplDjnIHdClLxWUlCSoNE1n3xJs0h0j8URTohAN97VMNIohJrN9WVpLI=", "ab4fa790-1ebd-4b65-a33b-0c8c5cbfbbd7", "admin@foodinloco.com" });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt", "Email" },
                values: new object[] { "sz6XQQpxdSbaBN6UPKSJXt9viQo4n1dwaciIDTlj2YgfgernIN6aeC13cjUijhRDCF3xejyLS/Xo4eU7TfQxllIJw57P/rkyV5iwmsisoEdnMGK1ru3DygJxX5iPAzl9jnUBdqSV+ORzQ7i8l8YMMaP2yhLcvXRO0oe/4HSM0wytdKg9V2Zr9q1fIBRSUfSOJN89j6CUxQC3MPmcDGQqPwS1LHqA7/9cZHmyLqVvY7ptNyJYf8WeJTmXXvo73dVTV4VB9vOUgBj9mj/PpSskpTuSXb3Pq/Q16un/lKCoKCMc3wVxxpZsic/s8uPC8sqgjJbMSNqt0MWEnSdxqyQcAgXUYNvKYufjUPB0reJ7cGW8gA+hntqNynz0icmzJiCeoq3GJ3tzETV8gMqbU1JRWjxv/8V02QCD8TrbYaA2ikuwwb+aRDFwIrK9qnKFDVVtFMa+PHVTh1je5uctubYWj4/fP2CIk3Loo7P8H1tu80Bohsby4735gWgYWTIktNI7oQmqF6Ep0Y25vDmbIHvn1+M4SwqD+mJ5Xxw5cKaGltwR5rIEzkgGSqM2qQK88vGQrYqjCvsC9w/eq8rjkhy/Iicwt2ueYbdapcrrfDBpF3/V5O2FjwRYLjy1TpSy+TuRwUYuot9AW+Tv78uBj8/M4v8qP/ZF1uwW4ALR65aQZtI=", "e1460931-6535-41e0-b6de-4a7d86768c61", "mcdonalds@foodinloco.com" });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Password", "Salt", "Email" },
                values: new object[] { "gMz9ZdqfuJYjc4SmopC/g2seudzNeHmNZapn9J+gQqH5GdoLFsu35nZpEoqPXAGBDaTIUAEr8RjvhVUF2HhgIr56QwrzXeN0id3og9qAnIuOkmRjhDJg17xHWHBNlf2TaKoibyOObKsN8NzbgzwXfR8VLwXDot1ZG42Tf7zAGAv89nPZ3e008WokdjAvyJv4J8lJOY1oPu5VyK6cAn4CS/SpUndJMCaQvb4Qpf8Gqk8aHnsnFypyyHJEN5GA9Xq4bOxI/UoL9uG141fUfBDU0BBtEDzvx+KDW+UpDhLwfpUTrYBiWvuta/MCZFW+w0+JE+PkR9tYQlXPKzUH/+gSoxXqcUmeebti3Oq6FaF+GZ5RgNrs3MfCut18ivYaiiikuAfnGUt7UBWOGFOCCFKr+UxsOzCwkno+CqGSf3hQ9Ssc8rG80YVl4DdFKUbl7pRDl9L+qCNJtHq23Y/KUjuOQVvyBDoIBV0nwLqYbYLh1NUPXJDxCCoyBDNV4N4YZCIq5njncKCYd6+ccM2ZiZsElDGiOnmCA1xzF7El5VYpFN6IqIsfS81/mJ10BehEtDWIkjRwE/cjmrNVJNYZxVsEcljtEXEi2ShdEOmOg4ZUTMfF/WvuDS6l0TiqPu3BdzSEp8i1xUKX9efusG7tupIWCLY3UeqcHLTU0/xr3vXVCXQ=", "5698c8b4-c81b-4e87-8201-b9363f24845b", "letter.pedro@gmail.com" });

            migrationBuilder.UpdateData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InitialDate",
                value: new DateTime(2022, 10, 24, 9, 22, 56, 264, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.UpdateData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "PhoneNumber", "Email", "CompanyName" },
                values: new object[] { "998888888", "mcdonalds@foodinloco.com", "Mc Donalds" });

            migrationBuilder.UpdateData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Email",
                value: "admin@foodinloco.com");

            migrationBuilder.UpdateData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Email",
                value: "letter.pedro@gmail.com");

            migrationBuilder.CreateIndex(
                name: "IX_Auth_Email",
                schema: "Auth",
                table: "Auth",
                column: "Email",
                unique: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IX_Auth_Email",
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
                name: "Email",
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
                defaultValue: new DateTime(2022, 9, 26, 10, 29, 18, 649, DateTimeKind.Utc).AddTicks(2319),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 10, 24, 9, 22, 56, 87, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.AddColumn<string>(
                name: "Login",
                schema: "Auth",
                table: "Auth",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Login", "Password", "Salt" },
                values: new object[] { "admin", "kc32FulUhcTpC4F+31zW86SlCFFEKZIq1CO8UNkg4b6qIG6PvQCJ5+vFLD+O7DbPrZ2pl0kaQxuY2cZCOjQAg3sFEiNrNhljuoR6/I0Wke/XM02bnVX7NwlxF+ELM8/2UdTd2gkPhgOzsMagRTzHMrC1h0SNheT3DW+K4XZ1fidKhgvoQ4blpSZk1HUA2d34bIlN2RS6oEgL3CNV5qVlhjJ6kdupCw4NgxYefMPu7ih/5R3re+CCN+2KGlIp4mbyKxLsnYVmFBjVAgSXlZjh32eTXCfDznLP/0/OgkHl3mQbFgzCZkTKPqDSFAabk/HK+Vtoaa4/M3qiGvbU+TVVQ8pe60jg8OtbH5Ua5qjm8oAnR1FAmhnv/hn8jo6SkYazYf3nwVW5dPomoRlpKq854ZjoLULylwW1UHLWyTZg0aI0IDX5kJgwIcXcXLt0Yl4q4Utyrg8QNTgM+X+0H24GnJ8OcAHOsCOeRVLLaMAvvcRLXhU/mvRxWXDdbXt16UevrBeSXyG8hVC6WhyXFCWNREFJIXGPEI2PvWLRBvsxdcPJh6Pqd4E34a4SIYC6rhFfA1xL2crL3nFYicrwrupp9dYIU+NdeLvGPo6ZnwhU7aCw7OVrAC6rSAj+D10oaybHDzjrCEmoNO5J5cnTXBsx5F83f1mcHTDrrMFMi3Z/HYw=", "6a5902f9-e463-4f2d-966d-754fd446908e" });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Login", "Password", "Salt" },
                values: new object[] { "macdonalds", "VNGkNYDzagz+ZJ0hG1QGEutunJnyO9Ki9CAHztSNm1B+hZLbKspJnZm6HzZfXdhb141AF2xAmsorcHHEZsZ55pf5rA+ktaLUsJjUmVhxj4lCpsBrD8lgqqseAzwnj6TQnf0t9dV5aAk8ukchWBuJmtcZtQR4DJmkt4+RxxCt8Iw+7eoW6ToR7iCtmytRbKuwm3yV3xvxIlVu2ZyvfkX7V/WifeHwztq/MTnsOc9hXSzI5AIYJtdAdMFjOtgyIwc5iAD7+M/73k5pIG06BPItzjidz6dFZ1ptJJiYoKcWyx3KeF2dMJH2PjHB8Yg+v57Ajvv/Y44mhyMm/OimK4KBervhncYRsRW2hbrylqDQjRibOeNjcmqFQ+0cXCk6S5U4I7AVNTqp7YtLYa0tXkof1s7MpGRwxVS2Y4YwZm+JUxR/GOLm4She82h4hwLyGKPujp3ctlisFbu8CUPBdlrDa1loqkftGottEs3WYcfUEE7d+iVwCNoNB5g5oB6h3sBd2tEtaVDYs2X/egcm7rB2o2/YQxOhTG9+d5YbdC54xV2nD5fA9HnoGP1DwQkmt+QAtTd0wb8Y1ocuEbfaloY0lpZiNFRD4Ih2a2WUyf9MFpenCxFV6w7oGCT9bgGOpsyLUFbtgNkPZSL/fU+bQujuAAn8+Fc3zuI50zc07ZEzkoU=", "dd9dd0c8-6375-4627-bf63-815bc6ec9eeb" });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Login", "Password", "Salt" },
                values: new object[] { "pedro", "E78sPG8E3Rw4NmQ/BlbDhplyKJ2tF0Xi3xZFsFNECAazdS7x0jl43sjUZV1DeqXh8gMHh8SXGsex8miNMW4wZ+8r1r91CLi5sM+qj7EpdOCuWDRsrRnOl6HzBTG/WnhuvxNfhGJjNS/UvYJ3PXOa8KXGZ7OJcwMsUWubfrwErPoVP0oAFIHu8/JqTUmE8XcV7AgRb9iA/ZlLa8GYB8bg3DWUGt2EPEt8eMIOaZvUlMwMisHY9i29b1M2Hvrc3i9xJ8HgPpjIGzrnGVMzpNlKBJfCWFN8QKjzk1hjtxgJ/E+HmqqEVS1qsMoLbHYqiu4wMZOWNN6wtUM9tQ4tUXq4aGXN6Rmr5HierrRZ8A7v4gsN7jEgKLeXppAepaDWRzph+kaH/D2tCSLFfvqU7846gl5nfr3Sbzi7so9G+/k80HTna1g5jWFGfj8sBivASXiS2RYBUS/FYqafIlRqYepCPV/QkUu/dEUNAwStRNcMOdF0h/MDXyCYzzSAmZ1oFj8wPATXJ6W6Xkh9J8aNURmBMmLNsGXrKhAURykGd/Mkzp15kUVDQn9j8b/iBBUQ4hgblxbLEchrw/SLk4amldjgO+01Xb6FmflWCsgqCMSxsaWk3qkWpIntccgDrES6DaC9QbbuC0rg+qEHayztssjSTg11HPjMNY3HIwIYF1huJZY=", "fbf4f452-2320-4f48-b904-603f033f690e" });

            migrationBuilder.UpdateData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InitialDate",
                value: new DateTime(2022, 9, 26, 10, 29, 18, 885, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                schema: "Restaurant",
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "PhoneNumber", "CompanyName", "Email" },
                values: new object[] { "997851936", "Mac Donalds", "letter.pedro@gmail.com" });

            migrationBuilder.UpdateData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Email",
                value: "letter.pedro@gmail.com");

            migrationBuilder.UpdateData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Email",
                value: "letter@gmail.com");

            migrationBuilder.CreateIndex(
                name: "IX_Auth_Login",
                schema: "Auth",
                table: "Auth",
                column: "Login",
                unique: true);
        }
    }
}
