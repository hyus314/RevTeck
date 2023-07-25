using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedMapping9999 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Engine_SparkPlugKits",
                columns: new[] { "EngineId", "SparkPlugKitId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 3 },
                    { 9, 4 },
                    { 10, 4 },
                    { 11, 5 },
                    { 12, 5 },
                    { 13, 5 },
                    { 14, 6 },
                    { 15, 6 },
                    { 16, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "Engine_SparkPlugKits",
                keyColumns: new[] { "EngineId", "SparkPlugKitId" },
                keyValues: new object[] { 16, 6 });
        }
    }
}
