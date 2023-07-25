using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class ChangeStructre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FuelPumps_Engines_EngineId",
                table: "FuelPumps");

            migrationBuilder.DropIndex(
                name: "IX_FuelPumps_EngineId",
                table: "FuelPumps");

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "FuelPumps");

            migrationBuilder.CreateTable(
                name: "Engine_FuelPumps",
                columns: table => new
                {
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    FuelPumpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine_FuelPumps", x => new { x.EngineId, x.FuelPumpId });
                    table.ForeignKey(
                        name: "FK_Engine_FuelPumps_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engine_FuelPumps_FuelPumps_FuelPumpId",
                        column: x => x.FuelPumpId,
                        principalTable: "FuelPumps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Engine_FuelPumps_FuelPumpId",
                table: "Engine_FuelPumps",
                column: "FuelPumpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engine_FuelPumps");

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "FuelPumps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FuelPumps_EngineId",
                table: "FuelPumps",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_FuelPumps_Engines_EngineId",
                table: "FuelPumps",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
