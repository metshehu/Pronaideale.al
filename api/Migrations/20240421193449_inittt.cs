using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class inittt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32df7038-05af-41c7-9cd3-8d7259ec38e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6a2ca21-7d9a-4a27-a4f5-1576e7c23969");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cb3091b-14ce-4c37-8153-b27fc069a56c", null, "Admin", "ADMIN" },
                    { "34d827bd-dda5-42e6-97e1-78103b6425f5", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "32df7038-05af-41c7-9cd3-8d7259ec38e1", null, "User", "USER" },
                    { "e6a2ca21-7d9a-4a27-a4f5-1576e7c23969", null, "Admin", "ADMIN" }
                });
        }
    }
}
