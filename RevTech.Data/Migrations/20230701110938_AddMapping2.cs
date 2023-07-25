using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class AddMapping2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TCUTunings_ECUTunings_ECUTuningId",
                table: "TCUTunings");

            migrationBuilder.DropIndex(
                name: "IX_TCUTunings_ECUTuningId",
                table: "TCUTunings");

            migrationBuilder.DropColumn(
                name: "ECUTuningId",
                table: "TCUTunings");

            migrationBuilder.CreateTable(
                name: "ECU_TCU_Connection",
                columns: table => new
                {
                    ECUTuningId = table.Column<int>(type: "int", nullable: false),
                    TCUTuningId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECU_TCU_Connection", x => new { x.ECUTuningId, x.TCUTuningId });
                    table.ForeignKey(
                        name: "FK_ECU_TCU_Connection_ECUTunings_ECUTuningId",
                        column: x => x.ECUTuningId,
                        principalTable: "ECUTunings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ECU_TCU_Connection_TCUTunings_TCUTuningId",
                        column: x => x.TCUTuningId,
                        principalTable: "TCUTunings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ECU_TCU_Connection_TCUTuningId",
                table: "ECU_TCU_Connection",
                column: "TCUTuningId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ECU_TCU_Connection");

            migrationBuilder.AddColumn<int>(
                name: "ECUTuningId",
                table: "TCUTunings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TCUTunings_ECUTuningId",
                table: "TCUTunings",
                column: "ECUTuningId");

            migrationBuilder.AddForeignKey(
                name: "FK_TCUTunings_ECUTunings_ECUTuningId",
                table: "TCUTunings",
                column: "ECUTuningId",
                principalTable: "ECUTunings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
