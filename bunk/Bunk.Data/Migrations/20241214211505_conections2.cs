using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bunk.Data.Migrations
{
    public partial class conections2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Customers_UserId",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Accounts",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_UserId",
                table: "Accounts",
                newName: "IX_Accounts_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Customers_CustomerId",
                table: "Accounts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Customers_CustomerId",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Accounts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_CustomerId",
                table: "Accounts",
                newName: "IX_Accounts_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Customers_UserId",
                table: "Accounts",
                column: "UserId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
