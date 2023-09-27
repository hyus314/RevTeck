using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class UpdateTable_AllowOneClientToHaveManyOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Payments_ClientId",
                table: "Payments");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ClientId",
                table: "Payments",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Payments_ClientId",
                table: "Payments");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ClientId",
                table: "Payments",
                column: "ClientId",
                unique: true);
        }
    }
}
