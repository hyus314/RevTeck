using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class UpdateStructureOfConfigurationEntityAndChangeNamesOfTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserVehicleConfiguration");

            migrationBuilder.DropTable(
                name: "UsersConfigurations");

            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarModelId = table.Column<int>(type: "int", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    TurboKitId = table.Column<int>(type: "int", nullable: true),
                    ECUTuningId = table.Column<int>(type: "int", nullable: true),
                    ExhaustKitId = table.Column<int>(type: "int", nullable: true),
                    FuelPumpId = table.Column<int>(type: "int", nullable: true),
                    InjectorKitId = table.Column<int>(type: "int", nullable: true),
                    OilCoolerId = table.Column<int>(type: "int", nullable: true),
                    SparkPlugsId = table.Column<int>(type: "int", nullable: true),
                    SuperchargerKitId = table.Column<int>(type: "int", nullable: true),
                    TCUTuningId = table.Column<int>(type: "int", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    HorsePowerBoostTotal = table.Column<int>(type: "int", nullable: false),
                    TorqueBoostTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Configurations_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Configurations_ECUTunings_ECUTuningId",
                        column: x => x.ECUTuningId,
                        principalTable: "ECUTunings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Configurations_ExhaustKits_ExhaustKitId",
                        column: x => x.ExhaustKitId,
                        principalTable: "ExhaustKits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_FuelPumps_FuelPumpId",
                        column: x => x.FuelPumpId,
                        principalTable: "FuelPumps",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_InjectorKits_InjectorKitId",
                        column: x => x.InjectorKitId,
                        principalTable: "InjectorKits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_OilCoolers_OilCoolerId",
                        column: x => x.OilCoolerId,
                        principalTable: "OilCoolers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_SparkPlugsKits_SparkPlugsId",
                        column: x => x.SparkPlugsId,
                        principalTable: "SparkPlugsKits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_SuperchargerKits_SuperchargerKitId",
                        column: x => x.SuperchargerKitId,
                        principalTable: "SuperchargerKits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_TCUTunings_TCUTuningId",
                        column: x => x.TCUTuningId,
                        principalTable: "TCUTunings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Configurations_TurboKits_TurboKitId",
                        column: x => x.TurboKitId,
                        principalTable: "TurboKits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UsersConfiguration",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConfigurationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersConfiguration", x => new { x.UserId, x.ConfigurationId });
                    table.ForeignKey(
                        name: "FK_UsersConfiguration_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersConfiguration_Configurations_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "Configurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UsersConfiguration_ConfigurationId",
                table: "UsersConfiguration",
                column: "ConfigurationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersConfiguration");

            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.CreateTable(
                name: "UsersConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarModelId = table.Column<int>(type: "int", nullable: true),
                    ECUTuningId = table.Column<int>(type: "int", nullable: true),
                    ExhaustKitId = table.Column<int>(type: "int", nullable: true),
                    FuelPumpId = table.Column<int>(type: "int", nullable: true),
                    InjectorKitId = table.Column<int>(type: "int", nullable: true),
                    OilCoolerId = table.Column<int>(type: "int", nullable: true),
                    SparkPlugsId = table.Column<int>(type: "int", nullable: true),
                    SuperchargerKitId = table.Column<int>(type: "int", nullable: true),
                    TCUTuningId = table.Column<int>(type: "int", nullable: true),
                    TurboKitId = table.Column<int>(type: "int", nullable: true),
                    HasCar = table.Column<bool>(type: "bit", nullable: false),
                    HorsePowerBoostTotal = table.Column<int>(type: "int", nullable: false),
                    TorqueBoostTotal = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersConfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersConfigurations_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersConfigurations_ECUTunings_ECUTuningId",
                        column: x => x.ECUTuningId,
                        principalTable: "ECUTunings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersConfigurations_ExhaustKits_ExhaustKitId",
                        column: x => x.ExhaustKitId,
                        principalTable: "ExhaustKits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersConfigurations_FuelPumps_FuelPumpId",
                        column: x => x.FuelPumpId,
                        principalTable: "FuelPumps",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersConfigurations_InjectorKits_InjectorKitId",
                        column: x => x.InjectorKitId,
                        principalTable: "InjectorKits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersConfigurations_OilCoolers_OilCoolerId",
                        column: x => x.OilCoolerId,
                        principalTable: "OilCoolers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersConfigurations_SparkPlugsKits_SparkPlugsId",
                        column: x => x.SparkPlugsId,
                        principalTable: "SparkPlugsKits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersConfigurations_SuperchargerKits_SuperchargerKitId",
                        column: x => x.SuperchargerKitId,
                        principalTable: "SuperchargerKits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersConfigurations_TCUTunings_TCUTuningId",
                        column: x => x.TCUTuningId,
                        principalTable: "TCUTunings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersConfigurations_TurboKits_TurboKitId",
                        column: x => x.TurboKitId,
                        principalTable: "TurboKits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserVehicleConfiguration",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConfigurationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVehicleConfiguration", x => new { x.UserId, x.ConfigurationId });
                    table.ForeignKey(
                        name: "FK_UserVehicleConfiguration_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserVehicleConfiguration_UsersConfigurations_ConfigurationId",
                        column: x => x.ConfigurationId,
                        principalTable: "UsersConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersConfigurations_CarModelId",
                table: "UsersConfigurations",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersConfigurations_ECUTuningId",
                table: "UsersConfigurations",
                column: "ECUTuningId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersConfigurations_ExhaustKitId",
                table: "UsersConfigurations",
                column: "ExhaustKitId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersConfigurations_FuelPumpId",
                table: "UsersConfigurations",
                column: "FuelPumpId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersConfigurations_InjectorKitId",
                table: "UsersConfigurations",
                column: "InjectorKitId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersConfigurations_OilCoolerId",
                table: "UsersConfigurations",
                column: "OilCoolerId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersConfigurations_SparkPlugsId",
                table: "UsersConfigurations",
                column: "SparkPlugsId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersConfigurations_SuperchargerKitId",
                table: "UsersConfigurations",
                column: "SuperchargerKitId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersConfigurations_TCUTuningId",
                table: "UsersConfigurations",
                column: "TCUTuningId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersConfigurations_TurboKitId",
                table: "UsersConfigurations",
                column: "TurboKitId");

            migrationBuilder.CreateIndex(
                name: "IX_UserVehicleConfiguration_ConfigurationId",
                table: "UserVehicleConfiguration",
                column: "ConfigurationId");
        }
    }
}
