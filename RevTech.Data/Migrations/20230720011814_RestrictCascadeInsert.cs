using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class RestrictCascadeInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModelsEngines_Engines_EngineId",
                table: "CarModelsEngines");

            migrationBuilder.DropForeignKey(
                name: "FK_ECUTunings_Engines_EngineId",
                table: "ECUTunings");

            migrationBuilder.DropForeignKey(
                name: "FK_Engine_FuelPumps_Engines_EngineId",
                table: "Engine_FuelPumps");

            migrationBuilder.DropForeignKey(
                name: "FK_Engine_InjectorKits_Engines_EngineId",
                table: "Engine_InjectorKits");

            migrationBuilder.DropForeignKey(
                name: "FK_Engine_OilCoolers_Engines_EngineId",
                table: "Engine_OilCoolers");

            migrationBuilder.DropForeignKey(
                name: "FK_Engine_SparkPlugKits_Engines_EngineId",
                table: "Engine_SparkPlugKits");

            migrationBuilder.DropForeignKey(
                name: "FK_ExhaustKits_Engines_EngineId",
                table: "ExhaustKits");

            migrationBuilder.DropForeignKey(
                name: "FK_SuperchargerKits_Engines_EngineId",
                table: "SuperchargerKits");

            migrationBuilder.DropForeignKey(
                name: "FK_TurboKits_Engines_EngineId",
                table: "TurboKits");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModelsEngines_Engines_EngineId",
                table: "CarModelsEngines",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ECUTunings_Engines_EngineId",
                table: "ECUTunings",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Engine_FuelPumps_Engines_EngineId",
                table: "Engine_FuelPumps",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Engine_InjectorKits_Engines_EngineId",
                table: "Engine_InjectorKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Engine_OilCoolers_Engines_EngineId",
                table: "Engine_OilCoolers",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Engine_SparkPlugKits_Engines_EngineId",
                table: "Engine_SparkPlugKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExhaustKits_Engines_EngineId",
                table: "ExhaustKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuperchargerKits_Engines_EngineId",
                table: "SuperchargerKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TurboKits_Engines_EngineId",
                table: "TurboKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModelsEngines_Engines_EngineId",
                table: "CarModelsEngines");

            migrationBuilder.DropForeignKey(
                name: "FK_ECUTunings_Engines_EngineId",
                table: "ECUTunings");

            migrationBuilder.DropForeignKey(
                name: "FK_Engine_FuelPumps_Engines_EngineId",
                table: "Engine_FuelPumps");

            migrationBuilder.DropForeignKey(
                name: "FK_Engine_InjectorKits_Engines_EngineId",
                table: "Engine_InjectorKits");

            migrationBuilder.DropForeignKey(
                name: "FK_Engine_OilCoolers_Engines_EngineId",
                table: "Engine_OilCoolers");

            migrationBuilder.DropForeignKey(
                name: "FK_Engine_SparkPlugKits_Engines_EngineId",
                table: "Engine_SparkPlugKits");

            migrationBuilder.DropForeignKey(
                name: "FK_ExhaustKits_Engines_EngineId",
                table: "ExhaustKits");

            migrationBuilder.DropForeignKey(
                name: "FK_SuperchargerKits_Engines_EngineId",
                table: "SuperchargerKits");

            migrationBuilder.DropForeignKey(
                name: "FK_TurboKits_Engines_EngineId",
                table: "TurboKits");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModelsEngines_Engines_EngineId",
                table: "CarModelsEngines",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ECUTunings_Engines_EngineId",
                table: "ECUTunings",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engine_FuelPumps_Engines_EngineId",
                table: "Engine_FuelPumps",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engine_InjectorKits_Engines_EngineId",
                table: "Engine_InjectorKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engine_OilCoolers_Engines_EngineId",
                table: "Engine_OilCoolers",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Engine_SparkPlugKits_Engines_EngineId",
                table: "Engine_SparkPlugKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExhaustKits_Engines_EngineId",
                table: "ExhaustKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SuperchargerKits_Engines_EngineId",
                table: "SuperchargerKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TurboKits_Engines_EngineId",
                table: "TurboKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
