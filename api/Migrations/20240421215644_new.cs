using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0cb3091b-14ce-4c37-8153-b27fc069a56c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34d827bd-dda5-42e6-97e1-78103b6425f5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e62a0a4-b312-4d95-8c98-d4e04b6795e5", null, "Admin", "ADMIN" },
                    { "aa801581-40e4-4085-a69c-51ead5864444", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e62a0a4-b312-4d95-8c98-d4e04b6795e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa801581-40e4-4085-a69c-51ead5864444");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cb3091b-14ce-4c37-8153-b27fc069a56c", null, "Admin", "ADMIN" },
                    { "34d827bd-dda5-42e6-97e1-78103b6425f5", null, "User", "USER" }
                });
        }
    }
}
