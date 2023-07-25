using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class RemoveCascadeInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_TurboKits_TurboKitId",
                table: "Configurations");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_TurboKits_TurboKitId",
                table: "Configurations",
                column: "TurboKitId",
                principalTable: "TurboKits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_TurboKits_TurboKitId",
                table: "Configurations");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_TurboKits_TurboKitId",
                table: "Configurations",
                column: "TurboKitId",
                principalTable: "TurboKits",
                principalColumn: "Id");
        }
    }
}
