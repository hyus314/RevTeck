using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class AddMapping10000000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SparkPlugsKits_Engines_EngineId",
                table: "SparkPlugsKits");

            migrationBuilder.DropIndex(
                name: "IX_SparkPlugsKits_EngineId",
                table: "SparkPlugsKits");

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "SparkPlugsKits");

            migrationBuilder.CreateTable(
                name: "Engine_SparkPlugKits",
                columns: table => new
                {
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    SparkPlugKitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine_SparkPlugKits", x => new { x.EngineId, x.SparkPlugKitId });
                    table.ForeignKey(
                        name: "FK_Engine_SparkPlugKits_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engine_SparkPlugKits_SparkPlugsKits_SparkPlugKitId",
                        column: x => x.SparkPlugKitId,
                        principalTable: "SparkPlugsKits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Engine_SparkPlugKits_SparkPlugKitId",
                table: "Engine_SparkPlugKits",
                column: "SparkPlugKitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engine_SparkPlugKits");

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "SparkPlugsKits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SparkPlugsKits_EngineId",
                table: "SparkPlugsKits",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_SparkPlugsKits_Engines_EngineId",
                table: "SparkPlugsKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
