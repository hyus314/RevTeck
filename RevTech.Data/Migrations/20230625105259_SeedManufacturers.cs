using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedManufacturers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "ImageURL", "Name" },
                values: new object[] { 1, "https://w7.pngwing.com/pngs/115/486/png-transparent-audi-tt-car-volkswagen-group-audi-rs-6-audi-text-trademark-logo.png", "Audi" });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "ImageURL", "Name" },
                values: new object[] { 2, "https://w7.pngwing.com/pngs/986/859/png-transparent-mercedes-benz-u-s-international-car-daimler-ag-mercedes-benz-angle-trademark-logo.png", "Mercedes-Benz" });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "ImageURL", "Name" },
                values: new object[] { 3, "https://image.similarpng.com/very-thumbnail/2020/06/Logo-bmw-vector-transparent-PNG.png", "BMW" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
