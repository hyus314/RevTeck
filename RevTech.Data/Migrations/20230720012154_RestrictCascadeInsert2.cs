using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class RestrictCascadeInsert2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ECU_TCU_Connection_ECUTunings_ECUTuningId",
                table: "ECU_TCU_Connection");

            migrationBuilder.AddForeignKey(
                name: "FK_ECU_TCU_Connection_ECUTunings_ECUTuningId",
                table: "ECU_TCU_Connection",
                column: "ECUTuningId",
                principalTable: "ECUTunings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ECU_TCU_Connection_ECUTunings_ECUTuningId",
                table: "ECU_TCU_Connection");

            migrationBuilder.AddForeignKey(
                name: "FK_ECU_TCU_Connection_ECUTunings_ECUTuningId",
                table: "ECU_TCU_Connection",
                column: "ECUTuningId",
                principalTable: "ECUTunings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
