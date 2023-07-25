using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedInjectorKits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InjectorKits",
                columns: new[] { "Id", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 1, 8, "https://c1552172.ssl.cf0.rackcdn.com/87249_x450.webp", "Bosch", "550 cc Fuel Injectors - Set Of Four", 291.25m, 16 },
                    { 2, 9, "https://c1552172.ssl.cf0.rackcdn.com/75141_x450.webp", "Siemens", "630 cc Fuel Injectors - Set Of Four", 312.80m, 18 },
                    { 3, 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Four", 411.72m, 20 },
                    { 4, 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Six", 617.58m, 20 },
                    { 5, 12, "https://cdn.shopify.com/s/files/1/0109/5814/3547/products/32_710e4d04-15b1-40cf-8c72-48dc955e88d5_695x695.jpg?v=1670590394", "Bosch", "1000 cc Fuel Injectors - Set Of Six", 650.12m, 22 },
                    { 6, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 7, 7, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Four", 762.61m, 15 },
                    { 8, 9, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Six", 1143.92m, 22 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
