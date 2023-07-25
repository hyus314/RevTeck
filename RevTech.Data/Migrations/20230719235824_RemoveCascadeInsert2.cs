using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class RemoveCascadeInsert2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_ECUTunings_ECUTuningId",
                table: "Configurations");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_ECUTunings_ECUTuningId",
                table: "Configurations",
                column: "ECUTuningId",
                principalTable: "ECUTunings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_ECUTunings_ECUTuningId",
                table: "Configurations");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_ECUTunings_ECUTuningId",
                table: "Configurations",
                column: "ECUTuningId",
                principalTable: "ECUTunings",
                principalColumn: "Id");
        }
    }
}
