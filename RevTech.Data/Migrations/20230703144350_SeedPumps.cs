using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedPumps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FuelPumps",
                columns: new[] { "Id", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 1, 50, "https://strperformance.com/42122-large_default/high-flow-fuel-pump-assembly-bosch-044-034motorsport-for-audi-a4-s4-b5-s2-rs2-a6-c5-s6-c7-18t-22-27-40-fsi.jpg", "Bosch", "High Flow Fuel Pump", 589.13m, 70 },
                    { 2, 70, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/24113/25401/stage_3__b7rs4_hpfps_1_1__82083.1542907995.jpg?c=2", "APR", "High Pressure Fuel Pump For 4.2 FSI", 3172.55m, 90 },
                    { 3, 35, "https://clptuning.co.uk/wp-content/uploads/2016/11/fsi_pump__11368.1449608918.1280.1280-300x300.jpg", "APR", "High Pressure Fuel Pump For 2.0 TFSI", 1713.18m, 45 },
                    { 4, 145, "https://cdn11.bigcommerce.com/s-a4fc6cbe36/images/stencil/1280x1280/products/209/1324/4.0L_Audi_TT_High_Pressure_Fuel_Pump_Kit__06817.1671545289.jpg?c=1", "Nostrum High Performance", "High Pressure Fuel Pump Kit For 4.0 TFSI", 2450.00m, 180 },
                    { 5, 50, "https://images.goapr.com/583x/ms100207_001.jpg", "APR", "High Pressure Fuel Pump For 3.0 TFSI", 1199.95m, 90 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FuelPumps",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
