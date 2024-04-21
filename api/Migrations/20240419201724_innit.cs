using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class innit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Agends",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deals = table.Column<int>(type: "int", nullable: false),
                    YoE = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanysId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agends", x => x.id);
                    table.ForeignKey(
                        name: "FK_Agends_Companys_CompanysId",
                        column: x => x.CompanysId,
                        principalTable: "Companys",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agendsid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Agends_Agendsid",
                        column: x => x.Agendsid,
                        principalTable: "Agends",
                        principalColumn: "id");
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
                    UsersId = table.Column<int>(type: "int", nullable: true),
                    AgendId = table.Column<int>(type: "int", nullable: true),
                    Agendsid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propertys", x => x.id);
                    table.ForeignKey(
                        name: "FK_Propertys_Agends_Agendsid",
                        column: x => x.Agendsid,
                        principalTable: "Agends",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Propertys_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agends_CompanysId",
                table: "Agends",
                column: "CompanysId");

            migrationBuilder.CreateIndex(
                name: "IX_Propertys_Agendsid",
                table: "Propertys",
                column: "Agendsid");

            migrationBuilder.CreateIndex(
                name: "IX_Propertys_UsersId",
                table: "Propertys",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Agendsid",
                table: "Users",
                column: "Agendsid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Propertys");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Agends");

            migrationBuilder.DropTable(
                name: "Companys");
        }
    }
}
