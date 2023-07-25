using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedOilCoolers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OilCoolers",
                columns: new[] { "Id", "ImageURL", "Manufacturer", "Model", "Price" },
                values: new object[,]
                {
                    { 1, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/42/68/50/1652867207/oelkuehler_13reihen_dash_kl99c4c_1280x1280.webp", "BAR-TEK", "Oil Cooler Kit for 1.8t", 299.71m },
                    { 2, "https://r-parts-store.com/media/image/product/120679/lg/wt-250001001_wagnertuning-upgrade-oil-cooler-kit-audi-rs4-b5-27biturbo.jpg", "WAGNERTUNING", "Oil Cooler Kit for 2.7tt", 1035.35m },
                    { 3, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/23136/24066/fmocrs4__35308.1449614047.jpg?c=2", "Forge", "Oil Cooler Kit for 4.2 FSI", 1144.33m },
                    { 4, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/5a/a4/f2/1652886657/13_reiher_ea113b5d62_1280x1280.webp", "Bar-Tek", "Oil Cooler Kit for 2.0 TFSI", 544.92m },
                    { 5, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
