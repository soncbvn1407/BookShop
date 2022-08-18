using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookShop.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Detailed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detailed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    DetailedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Detailed_DetailedId",
                        column: x => x.DetailedId,
                        principalTable: "Detailed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    UserEmail = table.Column<string>(nullable: true),
                    OrderQuantity = table.Column<int>(nullable: false),
                    OrderPrice = table.Column<double>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "1a4433c2-acb7-45cd-b774-9ea073aa1685", "Admin", "Admin" },
                    { "2", "389841dd-385c-4d59-be6d-6a4b959661e7", "Customer", "Customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "5f6a3cef-cd95-48b2-9198-fe2c7b9f7016", "admin@gmail.com", false, false, null, null, "admin@gmail.com", "AQAAAAEAACcQAAAAEM25Y0AQR723EDU+lL8+n2jO6E4kXwQVdR5H++0j3TnfTPgKX7T+CoEo5b0o0cB5dg==", null, false, "29aa3c8b-2848-4174-b6b5-34e0c4ca443e", false, "admin@gmail.com" },
                    { "2", 0, "947dc7f1-99db-4f88-9010-c8350046fb2c", "customer@gmail.com", false, false, null, null, "customer@gmail.com", "AQAAAAEAACcQAAAAECD/Enn+q5u/Evmk0X8N2ceQWPLUaWgQDjwsY3Y9LLpMqV4v3fORQlEb+TCJxemaNw==", null, false, "728fa366-f5fc-4212-9734-a9955027af23", false, "customer@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Detailed",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "DC Comics" },
                    { 2, "Supernatural" },
                    { 3, "Fantasy" },
                    { 4, "Extreme Sports" },
                    { 5, "Crime" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "DetailedId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Comics" },
                    { 2, 2, "Horror" },
                    { 3, 3, "Romance" },
                    { 4, 4, "Sports" },
                    { 5, 5, "Mystery" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "CategoryId", "Date", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1997, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/en/e/e9/Batman_The_Dark_Knight_Returns_%28film%29.jpg", "Batman: The Dark Knight Returns", 6399.0, 10 },
                    { 7, 1, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/en/e/e9/Batman_The_Dark_Knight_Returns_%28film%29.jpg", "All Star Superman", 8199.0, 35 },
                    { 2, 2, new DateTime(2013, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://img.thriftbooks.com/api/images/i/s/3775E4992634D153CA456BC6C572BA5138A1267D.jpg", "Doctor Sleep", 4499.0, 30 },
                    { 9, 2, new DateTime(2017, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/P/1501156705.01._SCLZZZZZZZ_SX500_.jpg", "Pet Sematary", 1021.0, 5 },
                    { 3, 3, new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/51nh3JnQNsL.jpg", "From Blood and Ash", 7999.0, 20 },
                    { 4, 3, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://m.media-amazon.com/images/I/51XzxAUT5QS.jpg", "The Awakening", 1999.0, 50 },
                    { 5, 4, new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images-na.ssl-images-amazon.com/images/I/81NygdDiGRL._AC_UL604_SR604,400_.jpg", "Breath: The New Science of a Lost Art", 1622.0, 25 },
                    { 6, 4, new DateTime(2011, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images-na.ssl-images-amazon.com/images/I/81BAIsimy6L._AC_UL604_SR604,400_.jpg", "Born to Run", 999.0, 15 },
                    { 8, 5, new DateTime(2022, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images-na.ssl-images-amazon.com/images/I/814dSvh3Q6L._AC_UL604_SR604,400_.jpg", "Overkill", 2610.0, 45 },
                    { 10, 5, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://images-na.ssl-images-amazon.com/images/I/912F2fID5XL._AC_UL604_SR604,400_.jpg", "The 6:20 Man: A Thriller", 1539.0, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_DetailedId",
                table: "Category",
                column: "DetailedId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_BookId",
                table: "Order",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Detailed");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
