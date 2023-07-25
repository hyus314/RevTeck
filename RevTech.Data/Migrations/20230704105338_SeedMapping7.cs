using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedMapping7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Engine_InjectorKits",
                columns: new[] { "EngineId", "InjectorKitId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 6 },
                    { 8, 6 },
                    { 9, 7 },
                    { 10, 7 },
                    { 11, 6 },
                    { 12, 6 },
                    { 13, 6 },
                    { 14, 8 },
                    { 15, 8 },
                    { 16, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 14, 8 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "Engine_InjectorKits",
                keyColumns: new[] { "EngineId", "InjectorKitId" },
                keyValues: new object[] { 16, 8 });
        }
    }
}
