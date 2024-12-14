using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bunk.Data.Migrations
{
    public partial class conections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BunkerCustomer",
                columns: table => new
                {
                    BunkersListId = table.Column<int>(type: "int", nullable: false),
                    CustomersListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BunkerCustomer", x => new { x.BunkersListId, x.CustomersListId });
                    table.ForeignKey(
                        name: "FK_BunkerCustomer_Bunkers_BunkersListId",
                        column: x => x.BunkersListId,
                        principalTable: "Bunkers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BunkerCustomer_Customers_CustomersListId",
                        column: x => x.CustomersListId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BunkerCustomer_CustomersListId",
                table: "BunkerCustomer",
                column: "CustomersListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BunkerCustomer");
        }
    }
}
