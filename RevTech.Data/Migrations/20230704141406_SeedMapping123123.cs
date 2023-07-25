using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedMapping123123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Engine_OilCoolers",
                columns: new[] { "EngineId", "OilCoolerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 5 },
                    { 3, 1 },
                    { 3, 5 },
                    { 4, 2 },
                    { 4, 5 },
                    { 5, 2 },
                    { 5, 5 },
                    { 6, 3 },
                    { 6, 5 },
                    { 7, 3 },
                    { 7, 5 },
                    { 8, 3 },
                    { 8, 5 },
                    { 9, 4 },
                    { 9, 5 },
                    { 10, 4 },
                    { 10, 5 },
                    { 11, 5 },
                    { 12, 5 },
                    { 13, 5 },
                    { 14, 5 },
                    { 15, 5 },
                    { 16, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_OilCoolers",
                keyColumns: new[] { "EngineId", "OilCoolerId" },
                keyValues: new object[] { 16, 5 });
        }
    }
}
