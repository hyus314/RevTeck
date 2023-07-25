using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class ChangeStructureFor100thTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OilCoolers_Engines_EngineId",
                table: "OilCoolers");

            migrationBuilder.DropIndex(
                name: "IX_OilCoolers_EngineId",
                table: "OilCoolers");

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "OilCoolers");

            migrationBuilder.CreateTable(
                name: "Engine_OilCoolers",
                columns: table => new
                {
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    OilCoolerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine_OilCoolers", x => new { x.EngineId, x.OilCoolerId });
                    table.ForeignKey(
                        name: "FK_Engine_OilCoolers_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engine_OilCoolers_OilCoolers_OilCoolerId",
                        column: x => x.OilCoolerId,
                        principalTable: "OilCoolers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Engine_OilCoolers_OilCoolerId",
                table: "Engine_OilCoolers",
                column: "OilCoolerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engine_OilCoolers");

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "OilCoolers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OilCoolers_EngineId",
                table: "OilCoolers",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_OilCoolers_Engines_EngineId",
                table: "OilCoolers",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
