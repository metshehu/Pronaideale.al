using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Propertys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    STrange = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Enrange = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Monthly = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Size = table.Column<decimal>(type: "decimal(30,5)", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: true),
                    Usersid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propertys", x => x.id);
                    table.ForeignKey(
                        name: "FK_Propertys_Users_Usersid",
                        column: x => x.Usersid,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Propertys_Usersid",
                table: "Propertys",
                column: "Usersid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Propertys");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
