using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class AddedMenuAndItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Menu");

            migrationBuilder.EnsureSchema(
                name: "MenuItem");

            migrationBuilder.AddColumn<string>(
                name: "City",
                schema: "Restaurant",
                table: "Restaurant",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complement",
                schema: "Restaurant",
                table: "Restaurant",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "Number",
                schema: "Restaurant",
                table: "Restaurant",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "State",
                schema: "Restaurant",
                table: "Restaurant",
                type: "character varying(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                schema: "Restaurant",
                table: "Restaurant",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                schema: "Restaurant",
                table: "Restaurant",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Menu",
                schema: "Menu",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RestaurantId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    InitialDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2022, 8, 22, 10, 6, 48, 739, DateTimeKind.Utc).AddTicks(5548)),
                    ExpirationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    HappyHour = table.Column<bool>(type: "boolean", nullable: false),
                    StartAt = table.Column<int>(type: "integer", nullable: false),
                    EndAt = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalSchema: "Restaurant",
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                schema: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MenuId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Photo = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItem_Menu_MenuId",
                        column: x => x.MenuId,
                        principalSchema: "Menu",
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menu_RestaurantId",
                schema: "Menu",
                table: "Menu",
                column: "RestaurantId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_MenuId",
                schema: "MenuItem",
                table: "MenuItem",
                column: "MenuId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItem",
                schema: "MenuItem");

            migrationBuilder.DropTable(
                name: "Menu",
                schema: "Menu");

            migrationBuilder.DropColumn(
                name: "City",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Complement",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Number",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "State",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "Street",
                schema: "Restaurant",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                schema: "Restaurant",
                table: "Restaurant");
        }
    }
}
