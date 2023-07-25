using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class AddConnectionBetweenModelAndExhaustKit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarModelId",
                table: "ExhaustKits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExhaustKits_CarModelId",
                table: "ExhaustKits",
                column: "CarModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExhaustKits_CarModels_CarModelId",
                table: "ExhaustKits",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExhaustKits_CarModels_CarModelId",
                table: "ExhaustKits");

            migrationBuilder.DropIndex(
                name: "IX_ExhaustKits_CarModelId",
                table: "ExhaustKits");

            migrationBuilder.DropColumn(
                name: "CarModelId",
                table: "ExhaustKits");
        }
    }
}
