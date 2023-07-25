using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedMapping5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 8, 2 },
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_FuelPumps",
                keyColumns: new[] { "EngineId", "FuelPumpId" },
                keyValues: new object[] { 16, 5 });
        }
    }
}
