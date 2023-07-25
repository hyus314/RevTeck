using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class UpdateAllRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModelsEngines_CarModels_CarModelId",
                table: "CarModelsEngines");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModelsEngines_CarModels_CarModelId",
                table: "CarModelsEngines",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModelsEngines_CarModels_CarModelId",
                table: "CarModelsEngines");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModelsEngines_CarModels_CarModelId",
                table: "CarModelsEngines",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id");
        }
    }
}
