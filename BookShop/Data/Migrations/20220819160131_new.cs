using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0936d271-f436-4a8f-b8e4-a6d1d8562f78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "eecbcb74-f3ee-4da6-92fd-1659dab6a4a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53262334-8b9e-4100-a20e-90333e42ebc3", "AQAAAAEAACcQAAAAEAe7IxzR8XFO3hNx2fFh2lK4Mqekn2ey2DHYNvO88136zRtcR4a9jSDCgtsNsmDRfg==", "d979ad81-6e30-432f-b1b6-50cda070c610" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1d363b2-6178-49c0-a72b-38dae0a571d1", "AQAAAAEAACcQAAAAEHO4nzTLtA/wMK6t/beBrxXQlBJy0wJtuSxGf8ywswnc6nf3r6JbdsoJdmTz1wbD0g==", "1ae793f7-4e0b-4a08-9276-c48646de7463" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a18c4794-244b-4fed-8234-adb50320ba84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2a724173-d370-4978-99b8-3b98126ffc06");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9c71925-2ce8-4d05-bffb-5a42754eb2eb", "AQAAAAEAACcQAAAAEMEdZy7uIPksrWTQZj0pv+wF3xz3mdsFP1ki3FO1q5ogj6lTi7a+O/1LhcBzEy4JaQ==", "48d75259-c3e1-47a0-b6c1-0899758b2c74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e9957d8-b227-45b0-a8fc-c066ed74816e", "AQAAAAEAACcQAAAAEPudtRO0Y6DQAs2gDYUQrxa9381s8MQzD2Ek5hQdBkLJftga007LV66tsEfKu5zbcA==", "3ceab8c0-6eab-4a48-994a-1ee33ad23cbf" });
        }
    }
}
