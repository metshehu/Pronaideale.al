using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class initt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87c3194f-2b1c-4269-94c4-4874ad38ac27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9004d66-d216-4404-a876-695863a46945");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Companys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Companys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Companys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32df7038-05af-41c7-9cd3-8d7259ec38e1", null, "User", "USER" },
                    { "e6a2ca21-7d9a-4a27-a4f5-1576e7c23969", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32df7038-05af-41c7-9cd3-8d7259ec38e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6a2ca21-7d9a-4a27-a4f5-1576e7c23969");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Companys");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Companys");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Companys");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "87c3194f-2b1c-4269-94c4-4874ad38ac27", null, "Admin", "ADMIN" },
                    { "a9004d66-d216-4404-a876-695863a46945", null, "User", "USER" }
                });
        }
    }
}
