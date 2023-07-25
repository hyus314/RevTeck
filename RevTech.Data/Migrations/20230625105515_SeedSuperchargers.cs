using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedSuperchargers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SuperchargerKits",
                columns: new[] { "Id", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "ModelName", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 1, 6, 200, "http://goapr.jp/includes/img/products/stage_3+_b7rs4_kit_mid.jpg", "APR", "TVS1740 Stage 3+", 18000.99m, 210 },
                    { 2, 7, 180, "http://www.goapr.co.uk/includes/img/products/b8_s5_42l_stage_3_kit_mid.jpg", "APR", "95 RON", 17000.99m, 140 },
                    { 3, 8, 180, "https://fr-rtuning-shop.co.uk/images/cache/pes_supercharger.270.jpg", "PES", "Whipple 140AX", 15000.99m, 140 },
                    { 4, 13, 120, "https://fr-rtuning-shop.co.uk/images/cache/pes_supercharger.270.jpg", "CNC", "Ported", 2099.70m, 100 },
                    { 5, 14, 120, "https://fr-rtuning-shop.co.uk/images/cache/pes_supercharger.270.jpg", "CNC", "Ported", 2099.70m, 100 },
                    { 6, 15, 120, "https://fr-rtuning-shop.co.uk/images/cache/pes_supercharger.270.jpg", "CNC", "Ported", 2099.70m, 100 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SuperchargerKits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SuperchargerKits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SuperchargerKits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SuperchargerKits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SuperchargerKits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SuperchargerKits",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
