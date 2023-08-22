using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class Simplify_Database_By_Removing_Engine_SparkPlugs_Mapping_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engine_SparkPlugKits");

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "SparkPlugsKits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 1,
                column: "EngineId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EngineId", "ImageURL", "Price" },
                values: new object[] { 2, "https://i.ebayimg.com/images/g/ceQAAOSwiDFYQVzW/s-l1600.jpg", 44.42m });

            migrationBuilder.UpdateData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EngineId", "ImageURL", "Price" },
                values: new object[] { 3, "https://i.ebayimg.com/images/g/ceQAAOSwiDFYQVzW/s-l1600.jpg", 44.42m });

            migrationBuilder.UpdateData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EngineId", "ImageURL", "Price" },
                values: new object[] { 4, "https://strperformance.com/25328-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-audi-s4-b5-and-rs4-v6-27-biturbo.jpg", 130.55m });

            migrationBuilder.UpdateData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EngineId", "ImageURL", "Price" },
                values: new object[] { 5, "https://strperformance.com/25328-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-audi-s4-b5-and-rs4-v6-27-biturbo.jpg", 130.55m });

            migrationBuilder.UpdateData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EngineId", "ImageURL", "Price" },
                values: new object[] { 6, "https://strperformance.com/24726-large_default/ngk-platinum-pfr7w-tg-high-performance-spark-plugs-for-audi-r8-v8-42-fsi-quattro-420hp.jpg", 195.82m });

            migrationBuilder.InsertData(
                table: "SparkPlugsKits",
                columns: new[] { "Id", "EngineId", "ImageURL", "Manufacturer", "Price" },
                values: new object[,]
                {
                    { 7, 7, "https://strperformance.com/24726-large_default/ngk-platinum-pfr7w-tg-high-performance-spark-plugs-for-audi-r8-v8-42-fsi-quattro-420hp.jpg", "NGK", 195.82m },
                    { 8, 8, "https://strperformance.com/24726-large_default/ngk-platinum-pfr7w-tg-high-performance-spark-plugs-for-audi-r8-v8-42-fsi-quattro-420hp.jpg", "NGK", 195.82m },
                    { 9, 9, "https://strperformance.com/24718-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-20-tfsi-ea113-20-tsi-ea8881-engine.jpg", "NGK", 87.03m },
                    { 10, 10, "https://strperformance.com/24718-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-20-tfsi-ea113-20-tsi-ea8881-engine.jpg", "NGK", 87.03m },
                    { 11, 11, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/90/17/7e/1652886624/kerzenspa1okj0ueef9c6svpg2c0pr6pb6970_1280x1280.webp", "NGK", 489.55m },
                    { 12, 12, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/90/17/7e/1652886624/kerzenspa1okj0ueef9c6svpg2c0pr6pb6970_1280x1280.webp", "NGK", 489.55m },
                    { 13, 13, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/90/17/7e/1652886624/kerzenspa1okj0ueef9c6svpg2c0pr6pb6970_1280x1280.webp", "NGK", 489.55m },
                    { 14, 14, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/b8/30/1f/1652867091/3-0l-tfsi-audi-s4-s5-ngk-z-ndkerzen-race476dd_1280x1280.webp", "NGK", 108.79m },
                    { 15, 15, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/b8/30/1f/1652867091/3-0l-tfsi-audi-s4-s5-ngk-z-ndkerzen-race476dd_1280x1280.webp", "NGK", 108.79m },
                    { 16, 16, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/b8/30/1f/1652867091/3-0l-tfsi-audi-s4-s5-ngk-z-ndkerzen-race476dd_1280x1280.webp", "NGK", 108.79m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SparkPlugsKits_EngineId",
                table: "SparkPlugsKits",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_SparkPlugsKits_Engines_EngineId",
                table: "SparkPlugsKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SparkPlugsKits_Engines_EngineId",
                table: "SparkPlugsKits");

            migrationBuilder.DropIndex(
                name: "IX_SparkPlugsKits_EngineId",
                table: "SparkPlugsKits");

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "SparkPlugsKits");

            migrationBuilder.CreateTable(
                name: "Engine_SparkPlugKits",
                columns: table => new
                {
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    SparkPlugKitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine_SparkPlugKits", x => new { x.EngineId, x.SparkPlugKitId });
                    table.ForeignKey(
                        name: "FK_Engine_SparkPlugKits_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engine_SparkPlugKits_SparkPlugsKits_SparkPlugKitId",
                        column: x => x.SparkPlugKitId,
                        principalTable: "SparkPlugsKits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.UpdateData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageURL", "Price" },
                values: new object[] { "https://strperformance.com/25328-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-audi-s4-b5-and-rs4-v6-27-biturbo.jpg", 130.55m });

            migrationBuilder.UpdateData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageURL", "Price" },
                values: new object[] { "https://strperformance.com/24726-large_default/ngk-platinum-pfr7w-tg-high-performance-spark-plugs-for-audi-r8-v8-42-fsi-quattro-420hp.jpg", 195.82m });

            migrationBuilder.UpdateData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageURL", "Price" },
                values: new object[] { "https://strperformance.com/24718-large_default/ngk-iridium-ix-bkr8eix-high-performance-spark-plugs-for-20-tfsi-ea113-20-tsi-ea8881-engine.jpg", 87.03m });

            migrationBuilder.UpdateData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageURL", "Price" },
                values: new object[] { "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/90/17/7e/1652886624/kerzenspa1okj0ueef9c6svpg2c0pr6pb6970_1280x1280.webp", 489.55m });

            migrationBuilder.UpdateData(
                table: "SparkPlugsKits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageURL", "Price" },
                values: new object[] { "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/b8/30/1f/1652867091/3-0l-tfsi-audi-s4-s5-ngk-z-ndkerzen-race476dd_1280x1280.webp", 108.79m });

            migrationBuilder.CreateIndex(
                name: "IX_Engine_SparkPlugKits_SparkPlugKitId",
                table: "Engine_SparkPlugKits",
                column: "SparkPlugKitId");
        }
    }
}
