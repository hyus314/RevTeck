using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class AddReferenceToEngineInFuelPumpEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engine_FuelPumps");

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "FuelPumps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 1,
                column: "EngineId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 2, 50, "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg", "Bosch", "High Flow Fuel Pump", 589.13m, 70 });

            migrationBuilder.UpdateData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 3, 50, "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg", "Bosch", "High Flow Fuel Pump", 589.13m, 70 });

            migrationBuilder.UpdateData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 4, 50, "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg", "Bosch", "High Flow Fuel Pump", 589.13m, 70 });

            migrationBuilder.UpdateData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EngineId", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 5, "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg", "Bosch", "High Flow Fuel Pump", 589.13m, 70 });

            migrationBuilder.InsertData(
                table: "FuelPumps",
                columns: new[] { "Id", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 6, 11, 50, "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg", "Bosch", "High Flow Fuel Pump", 589.13m, 70 },
                    { 7, 6, 70, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/24113/25401/stage_3__b7rs4_hpfps_1_1__82083.1542907995.jpg?c=2", "APR", "High Pressure Fuel Pump For 4.2 FSI", 3172.55m, 90 },
                    { 8, 7, 70, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/24113/25401/stage_3__b7rs4_hpfps_1_1__82083.1542907995.jpg?c=2", "APR", "High Pressure Fuel Pump For 4.2 FSI", 3172.55m, 90 },
                    { 9, 9, 35, "https://clptuning.co.uk/wp-content/uploads/2016/11/fsi_pump__11368.1449608918.1280.1280-300x300.jpg", "APR", "High Pressure Fuel Pump For 2.0 TFSI", 1713.18m, 45 },
                    { 10, 10, 35, "https://clptuning.co.uk/wp-content/uploads/2016/11/fsi_pump__11368.1449608918.1280.1280-300x300.jpg", "APR", "High Pressure Fuel Pump For 2.0 TFSI", 1713.18m, 45 },
                    { 11, 11, 145, "https://cdn11.bigcommerce.com/s-a4fc6cbe36/images/stencil/1280x1280/products/209/1324/4.0L_Audi_TT_High_Pressure_Fuel_Pump_Kit__06817.1671545289.jpg?c=1", "Nostrum High Performance", "High Pressure Fuel Pump Kit For 4.0 TFSI", 2450.00m, 180 },
                    { 12, 12, 145, "https://cdn11.bigcommerce.com/s-a4fc6cbe36/images/stencil/1280x1280/products/209/1324/4.0L_Audi_TT_High_Pressure_Fuel_Pump_Kit__06817.1671545289.jpg?c=1", "Nostrum High Performance", "High Pressure Fuel Pump Kit For 4.0 TFSI", 2450.00m, 180 },
                    { 13, 13, 145, "https://cdn11.bigcommerce.com/s-a4fc6cbe36/images/stencil/1280x1280/products/209/1324/4.0L_Audi_TT_High_Pressure_Fuel_Pump_Kit__06817.1671545289.jpg?c=1", "Nostrum High Performance", "High Pressure Fuel Pump Kit For 4.0 TFSI", 2450.00m, 180 },
                    { 14, 14, 50, "https://images.goapr.com/583x/ms100207_001.jpg", "APR", "High Pressure Fuel Pump For 3.0 TFSI", 1199.95m, 90 },
                    { 15, 15, 50, "https://images.goapr.com/583x/ms100207_001.jpg", "APR", "High Pressure Fuel Pump For 3.0 TFSI", 1199.95m, 90 },
                    { 16, 16, 50, "https://images.goapr.com/583x/ms100207_001.jpg", "APR", "High Pressure Fuel Pump For 3.0 TFSI", 1199.95m, 90 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FuelPumps_EngineId",
                table: "FuelPumps",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_FuelPumps_Engines_EngineId",
                table: "FuelPumps",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FuelPumps_Engines_EngineId",
                table: "FuelPumps");

            migrationBuilder.DropIndex(
                name: "IX_FuelPumps_EngineId",
                table: "FuelPumps");

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "FuelPumps");

            migrationBuilder.CreateTable(
                name: "Engine_FuelPumps",
                columns: table => new
                {
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    FuelPumpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine_FuelPumps", x => new { x.EngineId, x.FuelPumpId });
                    table.ForeignKey(
                        name: "FK_Engine_FuelPumps_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engine_FuelPumps_FuelPumps_FuelPumpId",
                        column: x => x.FuelPumpId,
                        principalTable: "FuelPumps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Engine_FuelPumps",
                columns: new[] { "EngineId", "FuelPumpId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 2 },
                    { 7, 2 },
                    { 9, 3 },
                    { 10, 3 },
                    { 11, 1 },
                    { 11, 4 },
                    { 12, 4 },
                    { 13, 4 },
                    { 14, 5 },
                    { 15, 5 },
                    { 16, 5 }
                });

            migrationBuilder.UpdateData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 70, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/24113/25401/stage_3__b7rs4_hpfps_1_1__82083.1542907995.jpg?c=2", "APR", "High Pressure Fuel Pump For 4.2 FSI", 3172.55m, 90 });

            migrationBuilder.UpdateData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 35, "https://clptuning.co.uk/wp-content/uploads/2016/11/fsi_pump__11368.1449608918.1280.1280-300x300.jpg", "APR", "High Pressure Fuel Pump For 2.0 TFSI", 1713.18m, 45 });

            migrationBuilder.UpdateData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 145, "https://cdn11.bigcommerce.com/s-a4fc6cbe36/images/stencil/1280x1280/products/209/1324/4.0L_Audi_TT_High_Pressure_Fuel_Pump_Kit__06817.1671545289.jpg?c=1", "Nostrum High Performance", "High Pressure Fuel Pump Kit For 4.0 TFSI", 2450.00m, 180 });

            migrationBuilder.UpdateData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { "https://images.goapr.com/583x/ms100207_001.jpg", "APR", "High Pressure Fuel Pump For 3.0 TFSI", 1199.95m, 90 });

            migrationBuilder.CreateIndex(
                name: "IX_Engine_FuelPumps_FuelPumpId",
                table: "Engine_FuelPumps",
                column: "FuelPumpId");
        }
    }
}
