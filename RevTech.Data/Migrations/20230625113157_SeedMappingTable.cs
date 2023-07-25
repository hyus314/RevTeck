using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarModelsEngines",
                columns: new[] { "CarModelId", "EngineId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 4 },
                    { 5, 6 },
                    { 6, 7 },
                    { 6, 14 },
                    { 7, 7 },
                    { 7, 14 },
                    { 8, 6 },
                    { 9, 8 },
                    { 9, 15 },
                    { 10, 9 },
                    { 11, 10 },
                    { 12, 11 },
                    { 13, 12 },
                    { 14, 12 },
                    { 15, 13 },
                    { 16, 11 },
                    { 17, 12 },
                    { 18, 16 },
                    { 19, 8 },
                    { 19, 15 },
                    { 19, 16 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 9, 15 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 14, 12 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 15, 13 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 16, 11 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 17, 12 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 18, 16 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 19, 15 });

            migrationBuilder.DeleteData(
                table: "CarModelsEngines",
                keyColumns: new[] { "CarModelId", "EngineId" },
                keyValues: new object[] { 19, 16 });
        }
    }
}
