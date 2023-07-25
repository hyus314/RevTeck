using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedEngines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "Id", "HorsePower", "Name", "Torque" },
                values: new object[,]
                {
                    { 1, 150, "1.8t", 210 },
                    { 2, 163, "1.8t", 250 },
                    { 3, 180, "1.8t", 235 },
                    { 4, 265, "2.7tt", 362 },
                    { 5, 250, "2.7tt", 342 },
                    { 6, 450, "4.2 FSI", 430 },
                    { 7, 354, "4.2 FSI", 440 },
                    { 8, 350, "4.2 FSI", 440 },
                    { 9, 200, "2.0 TFSI", 280 },
                    { 10, 211, "2.0 TFSI", 350 },
                    { 11, 420, "4.0 TFSI", 600 },
                    { 12, 560, "4.0 TFSI", 700 },
                    { 13, 605, "4.0 TFSI", 700 },
                    { 14, 333, "3.0 TFSI", 440 },
                    { 15, 290, "3.0 TFSI", 420 },
                    { 16, 310, "3.0 TFSI", 440 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
