using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class menuchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 5, 21, 19, 35, 84, DateTimeKind.Utc).AddTicks(4740),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 10, 30, 9, 10, 14, 63, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                schema: "Menu",
                table: "Menu",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                schema: "Menu",
                table: "Menu",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "InitialDate", "Photo", "Status" },
                values: new object[] { new DateTime(2022, 11, 5, 21, 19, 35, 207, DateTimeKind.Utc).AddTicks(7568), "https://www.underconsideration.com/artofthemenu/project_images/the_urban_tap_PHOTO_01.jpg", 1 });

            migrationBuilder.UpdateData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Photo",
                value: "https://www.underconsideration.com/artofthemenu/project_images/the_urban_tap_PHOTO_01.jpg");

            migrationBuilder.UpdateData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "q87KdHFXZl0erFi1C71Rp9miF/QFSKU3SQwNb87Kk42+AI9Xs1yfApzhZfXNzicnPOBXlgHLdSf98NRpwJS9JxGyvBdGpAN2J3Tj4xCxSKLhArwHghQieo4fLQEAOyL98XC41PbvZn6IVMvymhWCfbJbf3UedlXZxpODqPPi/bp4XmRc9xCK4Tp+rTBivGP5Og71cOSVDeQHwTO4At6n65fyQkKRih7Zxq0MqQ+FLnkgniTMF+yJHeaC+lNPmtUs2ffuDlJ2qL6fi5d0xYc/RI9lLXkd5JOuwpFf95lBruY+k3JJursLNoIWq7R2Qm2FMELd4C/81f1LtzdbMK8aUzFpw7MEIHMOjbCNJBqJicrXRXVs550PluDIuKFgG0wGsfoyNgunQrKB/WVNpPJB96luVwtTFlEEamjO7EgFUwdMKMtQFokK6nSYVBnpTZilR87irEdx5S8CqPdcUeruFecyZLXeujOy08vaNrXvioiETqIO8kC2fZnTIljmxlEUJIV4bhq0do3gRJMm8Y4AZizUp7L+9LAeEMC5R5MUsB4/9GbOT3FxXWpF3m0vFzPvfqokn3YuGLKCNMXi2H71sV2TKIBqUCCG7SFnVBTZgswpUfmgGc/d6xP2/Mga5EtJp/c63lNAKY+pzWo5WWP3mdqpfjuaBWibchMv0Og91Qk=", "a936717c-0a12-4db8-9bea-debe9f499a95" });

            migrationBuilder.UpdateData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "S4WQ0xO1c+FtWb8kWIRS2or7aG/QH9kqZgspnCWPBMrS0t9jVWVwjpVco146JLPxMgkNn5sitUCfjdlP7EaCKRQCue7MBa5d7/RyuAAXAcXiSKIi6hZgi7zjHtInflnCj6vaTG8b8/JIFg4m21oIasan4ZZQ1r7P4K1Qri6ujRLOIyuaD0rv3MiW1X+U5osHU0dJPf893oV0fEKVTbIwRGwak0rXQr75K9sP43HdyclASwuU7Km4CFiYLYYEXqCcI5wAJbhksR/Z7puV7hyEmTPHXL+gJSfChzymVf282kXZWHk5aWfoQGKcHpWg0utRwGUHozt8I+qDf68i3ZsXJp+dv+OW2gBm/JmZr4Uwsq982e7YETOGSEyr9EG83SXXu1N/4JMiBzfUz8xcLWI5RReKTpHJUAcv70VGeKYQK5bqSiXmtg1jKNX/Ig8LzKncxp+WWd3F5M0JGUlYPf/eowN+2M9HBGNB/NkR4jSvvooMQmtFCmQD4onGGHLjxEUqUt3chGiZVrGHidyFlxqgvJqtp8MKLYwyr34fqfQcP3bAGzgcHQk3CecpHRzoySZm8lkbeYJCQ1xvHuv32Y6iI7hVwhp7ckFQQWnWAYbtCiHfzGUZ3d3dwMcS0sjfJLI+nxnsHygumf8lQ7mdCagzACP3pD3a+aaCJeCFCIuSTZk=", "0991f2f3-1dbb-4c4a-8dbc-7a6bd9a83027" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                schema: "Menu",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "Status",
                schema: "Menu",
                table: "Menu");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 30, 9, 10, 14, 63, DateTimeKind.Utc).AddTicks(1346),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 11, 5, 21, 19, 35, 84, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InitialDate",
                value: new DateTime(2022, 10, 30, 9, 10, 14, 251, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                schema: "MenuItem",
                table: "MenuItem",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Photo",
                value: "foto qualquer");

            migrationBuilder.UpdateData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "MgpcGfZdk9zZHEpZDFSwoNl83Jpsh8dsyF1GXo5SRbLM5Ufz2VutzdiJPpKgVwWjQsiTkcRRSMwmVJKEFAGT4iSdI7VV8cgcjwe0noDbgDsSWu0PT+3rHjQD8CGCjpw8zy61iBRJjHMkZtIqj1KQGp8Afx/2aA7+b8FpqwWfAvIuBsVlk2nsfJ/bUx5wLMm+COI2Oqa5KF7tqBVqeS4o7fxpm8MpHWTsZw8Yus5Ve8in29elbzMlEJ0ib8JfIyYiusEyz4nnUVHS0XXKa18cszcubgssNU4tLtYcrC+Q6eTxB40Ue7IbgYeKBusfFEjJgXIdvn9RK4fwfRq+BrIIHLwszLfPAf0otqgPfieJi6y3OLBJj1Z26UIDmVCv3Vvb+IXEaPz9+h2i5PCP7tf/vu7yr6sws4mBiH65P9d5oiuvzkjxheoJLzdKALmsZa3SCmZsvLA+GsJf4M5uo6kWRyCBaUxXT++wn2a8UUg7H2rQD5bUqyr/XzK/MGiTDqXrDfW4AuNdXWSM03L2Oyyv45KyLwrkFaF1R9MrSpwPjObn3X1VtM3nXF0GHyfXXkGcOW4qG7MVW0ebJ/v6cpQPUvJxyUOimp7UuZYsRKCv2KVUhZWA4N/9j//4TBg7TO+2IKOj6o/KioGjBiQiTg1D8xxyAcjYoouvaHsLabAlvBk=", "a21e371e-7db0-4809-aa62-4d8bb33535c1" });

            migrationBuilder.UpdateData(
                schema: "User",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "y2EOamUBVjnb1XIERBJz/fe17z7igtjh8Y3VmOP6wZrRXxkpp2AHNj7921qxZYUMJRWQHC/XXzl0vtiTLPiCfKAOYmh+rUxfnj1R1SyXBxpl2tu4auUC659y+jlGq/H1/T6swrDGJ/ZZblBiZM6nrfvTexNGK1NWB57hPgtskCeFSz38iPyaBfOwmnSJsvqHCgKdAU423Q5eKXk24FuZUIrfAXJbdF8hvMOVvko6VPJv/xGfOWOL1l4s8SchgA9rgRG2+S8M3UNpR/T/K/4b0/TOJbGSu0fIX8wS76XXrtZZUBW8NjpQPLMCpI/tUpabUxPtHVVxrXEsppJCFVt0EaHBymuyWpLTrErTZTdcpjedNti7+CQ19UR2tGI9QbdLjEOyW5TKI2w6tJrqztc9hQ7VGmTjwp9RXXfLTBRnkdYwZooBVeKqSdFYpXESS4XxWrFBqLZF2WneO3bc2vJm0DnxlKOI5DtwBNcjR8qSmR3bGm3vLDBAQvrUiZsu7BOiH9snrVlh4xrHlO0syCldQUJKbDyxqOujaSR3N3WhCqByghjBf9qmRQyUopNx9WOun8jsHE6WqcVC5G3+8xbFwlGO7Ku03mdCkYlkV79n6dF7bxpZExe9beT9M6lzn77tt6T/exuwUGZcCCuY79QREOBoWDcgoVI0wHUm+0YqVSg=", "1f414507-de3c-4835-9844-11de08995d7f" });
        }
    }
}
