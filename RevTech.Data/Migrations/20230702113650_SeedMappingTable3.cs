using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedMappingTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ECU_TCU_Connection",
                columns: new[] { "ECUTuningId", "TCUTuningId" },
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
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 12, 1 },
                    { 12, 2 },
                    { 12, 3 },
                    { 13, 1 },
                    { 13, 2 },
                    { 13, 3 },
                    { 14, 1 },
                    { 14, 2 },
                    { 14, 3 }
                });

            migrationBuilder.InsertData(
                table: "ECU_TCU_Connection",
                columns: new[] { "ECUTuningId", "TCUTuningId" },
                values: new object[,]
                {
                    { 15, 1 },
                    { 15, 2 },
                    { 15, 3 },
                    { 16, 1 },
                    { 16, 2 },
                    { 16, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "ECU_TCU_Connection",
                keyColumns: new[] { "ECUTuningId", "TCUTuningId" },
                keyValues: new object[] { 16, 3 });
        }
    }
}
