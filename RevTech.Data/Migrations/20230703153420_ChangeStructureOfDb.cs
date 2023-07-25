using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class ChangeStructureOfDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InjectorKits_Engines_EngineId",
                table: "InjectorKits");

            migrationBuilder.DropIndex(
                name: "IX_InjectorKits_EngineId",
                table: "InjectorKits");

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "InjectorKits");

            migrationBuilder.CreateTable(
                name: "Engine_InjectorKits",
                columns: table => new
                {
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    InjectorKitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine_InjectorKits", x => new { x.EngineId, x.InjectorKitId });
                    table.ForeignKey(
                        name: "FK_Engine_InjectorKits_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engine_InjectorKits_InjectorKits_InjectorKitId",
                        column: x => x.InjectorKitId,
                        principalTable: "InjectorKits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Engine_InjectorKits_InjectorKitId",
                table: "Engine_InjectorKits",
                column: "InjectorKitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engine_InjectorKits");

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "InjectorKits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InjectorKits_EngineId",
                table: "InjectorKits",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_InjectorKits_Engines_EngineId",
                table: "InjectorKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
