using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class UpdateStructur110011 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersConfigurations_CarModels_CarModelId",
                table: "UsersConfigurations");

            migrationBuilder.AlterColumn<int>(
                name: "CarModelId",
                table: "UsersConfigurations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersConfigurations_CarModels_CarModelId",
                table: "UsersConfigurations",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersConfigurations_CarModels_CarModelId",
                table: "UsersConfigurations");

            migrationBuilder.AlterColumn<int>(
                name: "CarModelId",
                table: "UsersConfigurations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersConfigurations_CarModels_CarModelId",
                table: "UsersConfigurations",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
