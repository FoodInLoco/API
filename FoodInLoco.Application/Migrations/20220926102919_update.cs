using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodInLoco.Application.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 26, 10, 29, 18, 649, DateTimeKind.Utc).AddTicks(2319),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 8, 22, 10, 53, 23, 997, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "kc32FulUhcTpC4F+31zW86SlCFFEKZIq1CO8UNkg4b6qIG6PvQCJ5+vFLD+O7DbPrZ2pl0kaQxuY2cZCOjQAg3sFEiNrNhljuoR6/I0Wke/XM02bnVX7NwlxF+ELM8/2UdTd2gkPhgOzsMagRTzHMrC1h0SNheT3DW+K4XZ1fidKhgvoQ4blpSZk1HUA2d34bIlN2RS6oEgL3CNV5qVlhjJ6kdupCw4NgxYefMPu7ih/5R3re+CCN+2KGlIp4mbyKxLsnYVmFBjVAgSXlZjh32eTXCfDznLP/0/OgkHl3mQbFgzCZkTKPqDSFAabk/HK+Vtoaa4/M3qiGvbU+TVVQ8pe60jg8OtbH5Ua5qjm8oAnR1FAmhnv/hn8jo6SkYazYf3nwVW5dPomoRlpKq854ZjoLULylwW1UHLWyTZg0aI0IDX5kJgwIcXcXLt0Yl4q4Utyrg8QNTgM+X+0H24GnJ8OcAHOsCOeRVLLaMAvvcRLXhU/mvRxWXDdbXt16UevrBeSXyG8hVC6WhyXFCWNREFJIXGPEI2PvWLRBvsxdcPJh6Pqd4E34a4SIYC6rhFfA1xL2crL3nFYicrwrupp9dYIU+NdeLvGPo6ZnwhU7aCw7OVrAC6rSAj+D10oaybHDzjrCEmoNO5J5cnTXBsx5F83f1mcHTDrrMFMi3Z/HYw=", "6a5902f9-e463-4f2d-966d-754fd446908e" });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "VNGkNYDzagz+ZJ0hG1QGEutunJnyO9Ki9CAHztSNm1B+hZLbKspJnZm6HzZfXdhb141AF2xAmsorcHHEZsZ55pf5rA+ktaLUsJjUmVhxj4lCpsBrD8lgqqseAzwnj6TQnf0t9dV5aAk8ukchWBuJmtcZtQR4DJmkt4+RxxCt8Iw+7eoW6ToR7iCtmytRbKuwm3yV3xvxIlVu2ZyvfkX7V/WifeHwztq/MTnsOc9hXSzI5AIYJtdAdMFjOtgyIwc5iAD7+M/73k5pIG06BPItzjidz6dFZ1ptJJiYoKcWyx3KeF2dMJH2PjHB8Yg+v57Ajvv/Y44mhyMm/OimK4KBervhncYRsRW2hbrylqDQjRibOeNjcmqFQ+0cXCk6S5U4I7AVNTqp7YtLYa0tXkof1s7MpGRwxVS2Y4YwZm+JUxR/GOLm4She82h4hwLyGKPujp3ctlisFbu8CUPBdlrDa1loqkftGottEs3WYcfUEE7d+iVwCNoNB5g5oB6h3sBd2tEtaVDYs2X/egcm7rB2o2/YQxOhTG9+d5YbdC54xV2nD5fA9HnoGP1DwQkmt+QAtTd0wb8Y1ocuEbfaloY0lpZiNFRD4Ih2a2WUyf9MFpenCxFV6w7oGCT9bgGOpsyLUFbtgNkPZSL/fU+bQujuAAn8+Fc3zuI50zc07ZEzkoU=", "dd9dd0c8-6375-4627-bf63-815bc6ec9eeb" });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "E78sPG8E3Rw4NmQ/BlbDhplyKJ2tF0Xi3xZFsFNECAazdS7x0jl43sjUZV1DeqXh8gMHh8SXGsex8miNMW4wZ+8r1r91CLi5sM+qj7EpdOCuWDRsrRnOl6HzBTG/WnhuvxNfhGJjNS/UvYJ3PXOa8KXGZ7OJcwMsUWubfrwErPoVP0oAFIHu8/JqTUmE8XcV7AgRb9iA/ZlLa8GYB8bg3DWUGt2EPEt8eMIOaZvUlMwMisHY9i29b1M2Hvrc3i9xJ8HgPpjIGzrnGVMzpNlKBJfCWFN8QKjzk1hjtxgJ/E+HmqqEVS1qsMoLbHYqiu4wMZOWNN6wtUM9tQ4tUXq4aGXN6Rmr5HierrRZ8A7v4gsN7jEgKLeXppAepaDWRzph+kaH/D2tCSLFfvqU7846gl5nfr3Sbzi7so9G+/k80HTna1g5jWFGfj8sBivASXiS2RYBUS/FYqafIlRqYepCPV/QkUu/dEUNAwStRNcMOdF0h/MDXyCYzzSAmZ1oFj8wPATXJ6W6Xkh9J8aNURmBMmLNsGXrKhAURykGd/Mkzp15kUVDQn9j8b/iBBUQ4hgblxbLEchrw/SLk4amldjgO+01Xb6FmflWCsgqCMSxsaWk3qkWpIntccgDrES6DaC9QbbuC0rg+qEHayztssjSTg11HPjMNY3HIwIYF1huJZY=", "fbf4f452-2320-4f48-b904-603f033f690e" });

            migrationBuilder.UpdateData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InitialDate",
                value: new DateTime(2022, 9, 26, 10, 29, 18, 885, DateTimeKind.Utc).AddTicks(1629));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InitialDate",
                schema: "Menu",
                table: "Menu",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 8, 22, 10, 53, 23, 997, DateTimeKind.Utc).AddTicks(8274),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 9, 26, 10, 29, 18, 649, DateTimeKind.Utc).AddTicks(2319));

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "Qzg9SDt1iyADw9D2lB4VsxKwGiNhwxT7ucgHphahgAhZyLNcMSrpmHTAeLNFSavKjB5yHT8muc7bs3NIxNL1YpwM3a4lOptdbP4N+U/ooaFeMZnoxMm5xXVWRGDD5h9YTZdp5kwN3X9BfKCPtGLQ2NQtE8Tl1WmiatP59Uzr0DJnBwJS2a8ibZONxwMOndlzkqn5J7Y5Q8jxRozlj2324b5ARH7X5XP9Oka50kD31U+nMNiWI+nXZTMG6MauvQACu/rXyTpn2PcOpLm2JfyZzRWcQrCZkYFlJA9/YLa3s7bbKB51BP7whage37GgNJExgBbkscyKmG0QkLBgjHeq2+xSAXGfI0nFgKbOO0QQTYnTfrcrrRcuvfHYMd2Alo7VxbzK8zBTVzZJV28SguPo3n859QoZuqqqCCfvHX14RS/aUSpoVCs4ZOCNkMpIXgjZUgF9E09di48cTLGIDxkBxz3mdJfn67i1XNj9tApL71UCKo9inbHz1T5eQoyVTyIpxc2mgn+kOIQGOAFne7452u8LrYbCy8SzhYe4v2hwAcFVzWETKS45BmkCpE4LpkIuV3OACKLapXYZcmmQjiuV7mD6z+ds46kqteHpsN7geDOkDT+3KTJ0x48KYfuGaL6l1kyTGmyjLfyzHb5YQXJyH+tpAG4Fk/hKQp7z+Ty0s2w=", "1ff7a590-d4ae-4adb-8502-c0262069b1ef" });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "UqnOf9jVqV6vena9kHrSrHNFtJQZTlDpA+skXFKtX0vH4DBQ1IcrqiZjF/zQ2bC3BiYj0eMoDG2dMfSBASRkAbG1FfVI4faF0u1GAZDEdEsMWHOTEHdfquCDKCxc0XOpSExGTNM+FgjJLH9dZ78bSn/3c1Ck1fC5L4STnpLo7NYbeSQaj8OZanzWX6uTHEJ9Iq4XMnbMalkQzdo4h2cMxWPetfsmJr82PeC0kB3Uchudis507io+z3vaAVGtg8GzObFQgQUoYATraQSFhxm+4u02jbE4U+rP/setf8fAXeluPqC6/MleBFe+p/UbsWJfySQqDczUn4qUocuPoep1vRSLemSpOhnNHCy5nyg1xQRRX56HYIpjYy9ZodgecicDBqSM2mCpF5OH4a8NoNqa/4l17KxBD8Ws58Ly4J9hxdy5Qjk2AaYzRwyMN/bD7obLeAMNOpfDoVksYB3kAfo84hncl4r41BsYEMAAS0w2zSptC5/9AZhva198p49FA55f1rkBVptsE3bUL8J1e4kKHzWmYEpCD6vpZazt2UEPrxn9Z+R3R0xO9l8aQg63EHHIep2RlnNnAeGxBy/d4A8gRgek0ol4qve6y+0HlXNPird0MjEuarmZ318RH/ruQ9nbnaRLPrSRQVHMkbEpLDF3acShN6LQuDP4H5cY6wKZ/eA=", "801d0221-fd42-4cb5-9067-d3823e04ac81" });

            migrationBuilder.UpdateData(
                schema: "Auth",
                table: "Auth",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Password", "Salt" },
                values: new object[] { "G50bVmlvvmel+W6/Rfq2Jk94E6Pluy493CLK/Gi7ITllKbO3NmaRNFy2sIOUM8HtDGlN7OMEaLt03XWBD2ai3n3Vqpo6q02f48wG25Dkts+0DJm9HdVHZMoRQWb+G2XTd7Htgs8BfABGZhqVc+dN79Xu0CPDMbG4B6vJzLA9H/TzUhWhIVY0el4fQXwdf69+DrSYUpmkJ6V0LHjKhSIHnPIYz4V5u1pdzRoXMCcKRmpcMis4Jmcn1nW42VGBWCTOo+pjd0g/HCMYcqvlm4/ALTu476zt1jJqDStcrn44G62CAPZMov8QqOXEEWoppRpZrmO0Va3pfXcObJ2BX4jNDmjPRuBEfHFsAF7VHxKSYdDKQHgmkM1E51TTEJEa5h+32kCJ4GXYrBN8oUWUZsezbAzOzxCdJwkRoYidj7KeUotkVP/fRMIMtRFtMBukowOkKIjRaX9roF29uhQWfWmI+5DcMKKeShUmCG9ob9T6pROnq0hNVsQO8vR8059tFKJMNhv0VXwpf5JO7sn9IsG/uBFf3FqsnrMToLRRzP1HTP67eGbxYFsVQXZEzquUNAZIkZWSkGiIbrSfyStQnFm4ASUqrzKNPl9loa89gtR26ORRQKAe3vadMM1XzpvSIaqMy/OiL5a8cEXTeZQ/DUSPOGu0zIFVGD/bRDYB/S5bIrI=", "331f1187-3c1d-4a6e-987d-1252cab58556" });

            migrationBuilder.UpdateData(
                schema: "Menu",
                table: "Menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InitialDate",
                value: new DateTime(2022, 8, 22, 10, 53, 24, 190, DateTimeKind.Utc).AddTicks(9541));
        }
    }
}
