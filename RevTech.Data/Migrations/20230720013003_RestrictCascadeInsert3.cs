using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class RestrictCascadeInsert3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ECU_TCU_Connection_TCUTunings_TCUTuningId",
                table: "ECU_TCU_Connection");

            migrationBuilder.AddForeignKey(
                name: "FK_ECU_TCU_Connection_TCUTunings_TCUTuningId",
                table: "ECU_TCU_Connection",
                column: "TCUTuningId",
                principalTable: "TCUTunings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ECU_TCU_Connection_TCUTunings_TCUTuningId",
                table: "ECU_TCU_Connection");

            migrationBuilder.AddForeignKey(
                name: "FK_ECU_TCU_Connection_TCUTunings_TCUTuningId",
                table: "ECU_TCU_Connection",
                column: "TCUTuningId",
                principalTable: "TCUTunings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
