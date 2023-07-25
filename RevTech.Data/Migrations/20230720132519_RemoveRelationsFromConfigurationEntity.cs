using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class RemoveRelationsFromConfigurationEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModelsEngines_Engines_EngineId",
                table: "CarModelsEngines");

            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_CarModels_CarModelId",
                table: "Configurations");

            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_ECUTunings_ECUTuningId",
                table: "Configurations");

            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_Engines_EngineId",
                table: "Configurations");

            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_ExhaustKits_ExhaustKitId",
                table: "Configurations");

            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_FuelPumps_FuelPumpId",
                table: "Configurations");

            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_InjectorKits_InjectorKitId",
                table: "Configurations");

            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_OilCoolers_OilCoolerId",
                table: "Configurations");

            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_SparkPlugsKits_SparkPlugsId",
                table: "Configurations");

            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_SuperchargerKits_SuperchargerKitId",
                table: "Configurations");

            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_TCUTunings_TCUTuningId",
                table: "Configurations");

            migrationBuilder.DropForeignKey(
                name: "FK_Configurations_TurboKits_TurboKitId",
                table: "Configurations");

            migrationBuilder.DropForeignKey(
                name: "FK_ECU_TCU_Connection_ECUTunings_ECUTuningId",
                table: "ECU_TCU_Connection");

            migrationBuilder.DropForeignKey(
                name: "FK_ECU_TCU_Connection_TCUTunings_TCUTuningId",
                table: "ECU_TCU_Connection");

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
                name: "FK_ExhaustKits_CarModels_CarModelId",
                table: "ExhaustKits");

            migrationBuilder.DropForeignKey(
                name: "FK_ExhaustKits_Engines_EngineId",
                table: "ExhaustKits");

            migrationBuilder.DropForeignKey(
                name: "FK_SuperchargerKits_Engines_EngineId",
                table: "SuperchargerKits");

            migrationBuilder.DropForeignKey(
                name: "FK_TurboKits_Engines_EngineId",
                table: "TurboKits");

            migrationBuilder.DropIndex(
                name: "IX_Configurations_CarModelId",
                table: "Configurations");

            migrationBuilder.DropIndex(
                name: "IX_Configurations_ECUTuningId",
                table: "Configurations");

            migrationBuilder.DropIndex(
                name: "IX_Configurations_EngineId",
                table: "Configurations");

            migrationBuilder.DropIndex(
                name: "IX_Configurations_ExhaustKitId",
                table: "Configurations");

            migrationBuilder.DropIndex(
                name: "IX_Configurations_FuelPumpId",
                table: "Configurations");

            migrationBuilder.DropIndex(
                name: "IX_Configurations_InjectorKitId",
                table: "Configurations");

            migrationBuilder.DropIndex(
                name: "IX_Configurations_OilCoolerId",
                table: "Configurations");

            migrationBuilder.DropIndex(
                name: "IX_Configurations_SparkPlugsId",
                table: "Configurations");

            migrationBuilder.DropIndex(
                name: "IX_Configurations_SuperchargerKitId",
                table: "Configurations");

            migrationBuilder.DropIndex(
                name: "IX_Configurations_TCUTuningId",
                table: "Configurations");

            migrationBuilder.DropIndex(
                name: "IX_Configurations_TurboKitId",
                table: "Configurations");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModelsEngines_Engines_EngineId",
                table: "CarModelsEngines",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ECU_TCU_Connection_ECUTunings_ECUTuningId",
                table: "ECU_TCU_Connection",
                column: "ECUTuningId",
                principalTable: "ECUTunings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ECU_TCU_Connection_TCUTunings_TCUTuningId",
                table: "ECU_TCU_Connection",
                column: "TCUTuningId",
                principalTable: "TCUTunings",
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
                name: "FK_ExhaustKits_CarModels_CarModelId",
                table: "ExhaustKits",
                column: "CarModelId",
                principalTable: "CarModels",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModelsEngines_Engines_EngineId",
                table: "CarModelsEngines");

            migrationBuilder.DropForeignKey(
                name: "FK_ECU_TCU_Connection_ECUTunings_ECUTuningId",
                table: "ECU_TCU_Connection");

            migrationBuilder.DropForeignKey(
                name: "FK_ECU_TCU_Connection_TCUTunings_TCUTuningId",
                table: "ECU_TCU_Connection");

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
                name: "FK_ExhaustKits_CarModels_CarModelId",
                table: "ExhaustKits");

            migrationBuilder.DropForeignKey(
                name: "FK_ExhaustKits_Engines_EngineId",
                table: "ExhaustKits");

            migrationBuilder.DropForeignKey(
                name: "FK_SuperchargerKits_Engines_EngineId",
                table: "SuperchargerKits");

            migrationBuilder.DropForeignKey(
                name: "FK_TurboKits_Engines_EngineId",
                table: "TurboKits");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_CarModelId",
                table: "Configurations",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_ECUTuningId",
                table: "Configurations",
                column: "ECUTuningId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_EngineId",
                table: "Configurations",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_ExhaustKitId",
                table: "Configurations",
                column: "ExhaustKitId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_FuelPumpId",
                table: "Configurations",
                column: "FuelPumpId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_InjectorKitId",
                table: "Configurations",
                column: "InjectorKitId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_OilCoolerId",
                table: "Configurations",
                column: "OilCoolerId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_SparkPlugsId",
                table: "Configurations",
                column: "SparkPlugsId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_SuperchargerKitId",
                table: "Configurations",
                column: "SuperchargerKitId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_TCUTuningId",
                table: "Configurations",
                column: "TCUTuningId");

            migrationBuilder.CreateIndex(
                name: "IX_Configurations_TurboKitId",
                table: "Configurations",
                column: "TurboKitId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarModelsEngines_Engines_EngineId",
                table: "CarModelsEngines",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_CarModels_CarModelId",
                table: "Configurations",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_ECUTunings_ECUTuningId",
                table: "Configurations",
                column: "ECUTuningId",
                principalTable: "ECUTunings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_Engines_EngineId",
                table: "Configurations",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_ExhaustKits_ExhaustKitId",
                table: "Configurations",
                column: "ExhaustKitId",
                principalTable: "ExhaustKits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_FuelPumps_FuelPumpId",
                table: "Configurations",
                column: "FuelPumpId",
                principalTable: "FuelPumps",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_InjectorKits_InjectorKitId",
                table: "Configurations",
                column: "InjectorKitId",
                principalTable: "InjectorKits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_OilCoolers_OilCoolerId",
                table: "Configurations",
                column: "OilCoolerId",
                principalTable: "OilCoolers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_SparkPlugsKits_SparkPlugsId",
                table: "Configurations",
                column: "SparkPlugsId",
                principalTable: "SparkPlugsKits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_SuperchargerKits_SuperchargerKitId",
                table: "Configurations",
                column: "SuperchargerKitId",
                principalTable: "SuperchargerKits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_TCUTunings_TCUTuningId",
                table: "Configurations",
                column: "TCUTuningId",
                principalTable: "TCUTunings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Configurations_TurboKits_TurboKitId",
                table: "Configurations",
                column: "TurboKitId",
                principalTable: "TurboKits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ECU_TCU_Connection_ECUTunings_ECUTuningId",
                table: "ECU_TCU_Connection",
                column: "ECUTuningId",
                principalTable: "ECUTunings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ECU_TCU_Connection_TCUTunings_TCUTuningId",
                table: "ECU_TCU_Connection",
                column: "TCUTuningId",
                principalTable: "TCUTunings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ECUTunings_Engines_EngineId",
                table: "ECUTunings",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Engine_FuelPumps_Engines_EngineId",
                table: "Engine_FuelPumps",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Engine_InjectorKits_Engines_EngineId",
                table: "Engine_InjectorKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Engine_OilCoolers_Engines_EngineId",
                table: "Engine_OilCoolers",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Engine_SparkPlugKits_Engines_EngineId",
                table: "Engine_SparkPlugKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExhaustKits_CarModels_CarModelId",
                table: "ExhaustKits",
                column: "CarModelId",
                principalTable: "CarModels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExhaustKits_Engines_EngineId",
                table: "ExhaustKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperchargerKits_Engines_EngineId",
                table: "SuperchargerKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TurboKits_Engines_EngineId",
                table: "TurboKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id");
        }
    }
}
