using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurgerApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class all : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "HasFries", "ImageUrl", "IsOnPromotion", "IsVegan", "IsVegetarian", "Name", "Price" },
                values: new object[,]
                {
                    { 1, true, "", true, true, false, "Chicken Burger", 3.9900000000000002 },
                    { 2, false, "", false, false, true, "Beyond Burger", 4.9900000000000002 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "ClosesAt", "Name", "OpensAt" },
                values: new object[,]
                {
                    { 1, "Opstina Centar", "23:00", "Pizza Pizza", "10:00" },
                    { 2, "Opstina Kisela Voda", "22:00", "Pizza Skopje", "09:00" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "FullName", "IsDelivered", "LocationId" },
                values: new object[,]
                {
                    { 1, "Partizanska 10", "John Doe", true, 2 },
                    { 2, "Mladinska 1", "Kate Katesky", false, 1 }
                });
        }
    }
}
