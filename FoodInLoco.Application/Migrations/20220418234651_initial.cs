using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Auth");

            migrationBuilder.EnsureSchema(
                name: "Restaurant");

            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.CreateTable(
                name: "Auth",
                schema: "Auth",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Salt = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Roles = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                schema: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CompanyName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    TradingName = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Email = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    DDD = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    AuthId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurant_Auth_AuthId",
                        column: x => x.AuthId,
                        principalSchema: "Auth",
                        principalTable: "Auth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    DDD = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    AuthId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Auth_AuthId",
                        column: x => x.AuthId,
                        principalSchema: "Auth",
                        principalTable: "Auth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Auth",
                table: "Auth",
                columns: new[] { "Id", "Login", "Password", "Roles", "Salt" },
                values: new object[] { 1L, "admin", "Ywh5sxyZwNhv41ttnYPNGbYtpxYY2qZa7d4sABOvHyPjmlWSQ9394NXIYLrDcoQT4qOP/+IAU1xXtRk6FRX4T2vnTyqt7Z4cPvSaeRwV6+U0D5QYsJQhoyq/MWwrheazdEkqA9u7HpEdgQZ4iiSDFRd3Q2ePoZQ1eJzDZ8FCAiURB6EbfH7sWhga+vF+ipx1ifkLQHWZ+AO9nnUJw9qIANe6opS3U8MHT7SQUteXTNDUAmPNK+MidmqBTnmnFs+gjeqOyX4hCuFjLy8hRhu/GdFJFDUKWgO+49/x9JinhRZkNRv6kgQdDjtfcfzrY1N73oc/f0kOQ0NijDHzaIDvye2JLp6O68nZjOVYRQ5U9lIuwQoaPpD3b+bePnx8jJ/dBRqeQQzn3xRyk+1R4SHiykAVZcOMRuG5DOLaF/bUC3ECu5QPUGFQSDy8qChOdFoRQSEJpMZ06EUFqpw5CZyFm5kubbejlew1tdRIIdgL/F5HXFRKXd9+ysxyVT1ktnjHljLBBZaFqK6vM/LlY0vLtZGLBCETthoiubErDUN4CJX+sUGIfnNtKCGBvo0SQ6N09OFym9MCQOsITX64GKx+uNQJ9/nNWaKozK4J/TetBPdXpM3ZL5zFWOPUY+s3RIg/zrwkxQx/tarTUwTKxJi3RQkUrHFDDxKhf1BHT03Ilho=", 3, "79005744-e69a-4b09-996b-08fe0b70cbb9" });

            migrationBuilder.InsertData(
                schema: "User",
                table: "User",
                columns: new[] { "Id", "AuthId", "Status", "DDD", "PhoneNumber", "Email", "FirstName", "LastName" },
                values: new object[] { 1L, 1L, 1, "85", "997851936", "letter.pedro@gmail.com", "Pedro", "Oliveira" });

            migrationBuilder.CreateIndex(
                name: "IX_Auth_Login",
                schema: "Auth",
                table: "Auth",
                column: "Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_AuthId",
                schema: "Restaurant",
                table: "Restaurant",
                column: "AuthId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_Email",
                schema: "Restaurant",
                table: "Restaurant",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_AuthId",
                schema: "User",
                table: "User",
                column: "AuthId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                schema: "User",
                table: "User",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurant",
                schema: "Restaurant");

            migrationBuilder.DropTable(
                name: "User",
                schema: "User");

            migrationBuilder.DropTable(
                name: "Auth",
                schema: "Auth");
        }
    }
}
