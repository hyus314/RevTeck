using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SimplifyDBRemovingECU_TCU_ConnectionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ECU_TCU_Connection");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ECU_TCU_Connection",
                columns: new[] { "ECUTuningId", "TCUTuningId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 3 },
                    { 13, 1 },
                    { 13, 2 },
                    { 13, 3 },
                    { 14, 1 },
                    { 14, 2 },
                    { 14, 3 }
                });

            migrationBuilder.InsertData(
                table: "ECU_TCU_Connection",
                columns: new[] { "ECUTuningId", "TCUTuningId" },
                values: new object[,]
                {
                    { 15, 1 },
                    { 15, 2 },
                    { 15, 3 },
                    { 16, 1 },
                    { 16, 2 },
                    { 16, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ECU_TCU_Connection_TCUTuningId",
                table: "ECU_TCU_Connection",
                column: "TCUTuningId");
        }
    }
}
