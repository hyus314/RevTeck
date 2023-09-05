using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RevTech.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         
            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageURL",
                value: "https://www.tuningblog.eu/wp-content/uploads/2022/08/Verrueckter-Stage-4-Audi-RS6-C7-Avant-1200-PS-1-e1661412369854.jpg");

            migrationBuilder.UpdateData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageURL",
                value: "/img/apr-ecu-for-3.0-tfsi.png");

            migrationBuilder.UpdateData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageURL",
                value: "/img/apr-ecu-for-3.0-tfsi.png");

            migrationBuilder.UpdateData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageURL",
                value: "/img/apr-ecu-for-3.0-tfsi.png");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://www.freepnglogos.com/uploads/audi-logo-29.png");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "https://www.freepnglogos.com/uploads/mercedes-logo-png/mercedes-logo-world-car-mercedes-benz-class-cdi-1.png");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "https://cdn.freebiesupply.com/logos/large/2x/bmw-logo-png-transparent.png");


            migrationBuilder.UpdateData(
                table: "SuperchargerKits",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/img/superchargerKitId1.jpg");

            migrationBuilder.UpdateData(
                table: "SuperchargerKits",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "/img/superchargerKitId2.jpg");

            

        }

        /// <inheritdoc />
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

            migrationBuilder.UpdateData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageURL",
                value: "https://img.md-exclusive-cardesign.com/wp-content/uploads/2019/10/audi-a6-c7-limousine-breitbau-tuning-pd600r-widebody-kit-artform-af-401-felgen-in-105x21-md-exclusive-cardesign-16-455x179.jpg");

            migrationBuilder.UpdateData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageURL",
                value: "http://www.goapr.co.uk/includes/img/icons/apr-ecu.png");

            migrationBuilder.UpdateData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageURL",
                value: "http://www.goapr.co.uk/includes/img/icons/apr-ecu.png");

            migrationBuilder.UpdateData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageURL",
                value: "http://www.goapr.co.uk/includes/img/icons/apr-ecu.png");

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
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://w7.pngwing.com/pngs/115/486/png-transparent-audi-tt-car-volkswagen-group-audi-rs-6-audi-text-trademark-logo.png");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "https://w7.pngwing.com/pngs/986/859/png-transparent-mercedes-benz-u-s-international-car-daimler-ag-mercedes-benz-angle-trademark-logo.png");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "https://image.similarpng.com/very-thumbnail/2020/06/Logo-bmw-vector-transparent-PNG.png");

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

            migrationBuilder.UpdateData(
                table: "SuperchargerKits",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "../~/img/superchargerKitId1.jpg");

            migrationBuilder.UpdateData(
                table: "SuperchargerKits",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "../~/img/superchargerKitId2.jpg");

            migrationBuilder.CreateIndex(
                name: "IX_Engine_SparkPlugKits_SparkPlugKitId",
                table: "Engine_SparkPlugKits",
                column: "SparkPlugKitId");
        }
    }
}
