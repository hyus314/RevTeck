using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class RestrictCascadeInsert4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModelsEngines_CarModels_CarModelId",
                table: "CarModelsEngines");

            migrationBuilder.DropForeignKey(
                name: "FK_ExhaustKits_CarModels_CarModelId",
                table: "ExhaustKits");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModelsEngines_CarModels_CarModelId",
                table: "CarModelsEngines",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExhaustKits_CarModels_CarModelId",
                table: "ExhaustKits",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModelsEngines_CarModels_CarModelId",
                table: "CarModelsEngines");

            migrationBuilder.DropForeignKey(
                name: "FK_ExhaustKits_CarModels_CarModelId",
                table: "ExhaustKits");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModelsEngines_CarModels_CarModelId",
                table: "CarModelsEngines",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExhaustKits_CarModels_CarModelId",
                table: "ExhaustKits",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
