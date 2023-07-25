using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedSparkPlugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SparkPlugsKits",
                columns: new[] { "Id", "ImageURL", "Manufacturer", "Price" },
                values: new object[,]
                {
                    { 1, "https://i.ebayimg.com/images/g/ceQAAOSwiDFYQVzW/s-l1600.jpg", "NGK", 44.42m },
                    { 2, "https://strperformance.com/25328-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-audi-s4-b5-and-rs4-v6-27-biturbo.jpg", "NGK", 130.55m },
                    { 3, "https://strperformance.com/24726-large_default/ngk-platinum-pfr7w-tg-high-performance-spark-plugs-for-audi-r8-v8-42-fsi-quattro-420hp.jpg", "NGK", 195.82m },
                    { 4, "https://strperformance.com/24718-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-20-tfsi-ea113-20-tsi-ea8881-engine.jpg", "NGK", 87.03m },
                    { 5, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/90/17/7e/1652886624/kerzenspa1okj0ueef9c6svpg2c0pr6pb6970_1280x1280.webp", "NGK", 489.55m },
                    { 6, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/b8/30/1f/1652867091/3-0l-tfsi-audi-s4-s5-ngk-z-ndkerzen-race476dd_1280x1280.webp", "NGK", 108.79m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
