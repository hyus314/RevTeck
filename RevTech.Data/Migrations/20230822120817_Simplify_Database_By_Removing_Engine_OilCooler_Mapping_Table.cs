using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class Simplify_Database_By_Removing_Engine_OilCooler_Mapping_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engine_OilCoolers");

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "OilCoolers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 1,
                column: "EngineId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EngineId", "ImageURL", "Manufacturer", "Model", "Price" },
                values: new object[] { 2, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/42/68/50/1652867207/oelkuehler_13reihen_dash_kl99c4c_1280x1280.webp", "BAR-TEK", "Oil Cooler Kit for 1.8t", 299.71m });

            migrationBuilder.UpdateData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EngineId", "ImageURL", "Manufacturer", "Model", "Price" },
                values: new object[] { 3, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/42/68/50/1652867207/oelkuehler_13reihen_dash_kl99c4c_1280x1280.webp", "BAR-TEK", "Oil Cooler Kit for 1.8t", 299.71m });

            migrationBuilder.UpdateData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EngineId", "ImageURL", "Manufacturer", "Model", "Price" },
                values: new object[] { 4, "https://r-parts-store.com/media/image/product/120679/lg/wt-250001001_wagnertuning-upgrade-oil-cooler-kit-audi-rs4-b5-27biturbo.jpg", "WAGNERTUNING", "Oil Cooler Kit for 2.7tt", 1035.35m });

            migrationBuilder.UpdateData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EngineId", "ImageURL", "Manufacturer", "Model", "Price" },
                values: new object[] { 5, "https://r-parts-store.com/media/image/product/120679/lg/wt-250001001_wagnertuning-upgrade-oil-cooler-kit-audi-rs4-b5-27biturbo.jpg", "WAGNERTUNING", "Oil Cooler Kit for 2.7tt", 1035.35m });

            migrationBuilder.InsertData(
                table: "OilCoolers",
                columns: new[] { "Id", "EngineId", "ImageURL", "Manufacturer", "Model", "Price" },
                values: new object[,]
                {
                    { 6, 6, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/23136/24066/fmocrs4__35308.1449614047.jpg?c=2", "Forge", "Oil Cooler Kit for 4.2 FSI", 1144.33m },
                    { 7, 7, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/23136/24066/fmocrs4__35308.1449614047.jpg?c=2", "Forge", "Oil Cooler Kit for 4.2 FSI", 1144.33m },
                    { 8, 8, "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/23136/24066/fmocrs4__35308.1449614047.jpg?c=2", "Forge", "Oil Cooler Kit for 4.2 FSI", 1144.33m },
                    { 9, 9, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/5a/a4/f2/1652886657/13_reiher_ea113b5d62_1280x1280.webp", "Bar-Tek", "Oil Cooler Kit for 2.0 TFSI", 544.92m },
                    { 10, 10, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/5a/a4/f2/1652886657/13_reiher_ea113b5d62_1280x1280.webp", "Bar-Tek", "Oil Cooler Kit for 2.0 TFSI", 544.92m },
                    { 11, 1, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 12, 2, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 13, 3, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 14, 4, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 15, 5, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 16, 6, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 17, 7, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 18, 8, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 19, 9, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 20, 10, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 21, 11, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 22, 12, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 23, 13, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 24, 14, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 25, 15, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m },
                    { 26, 16, "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OilCoolers_EngineId",
                table: "OilCoolers",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_OilCoolers_Engines_EngineId",
                table: "OilCoolers",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OilCoolers_Engines_EngineId",
                table: "OilCoolers");

            migrationBuilder.DropIndex(
                name: "IX_OilCoolers_EngineId",
                table: "OilCoolers");

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "OilCoolers");

            migrationBuilder.CreateTable(
                name: "Engine_OilCoolers",
                columns: table => new
                {
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    OilCoolerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine_OilCoolers", x => new { x.EngineId, x.OilCoolerId });
                    table.ForeignKey(
                        name: "FK_Engine_OilCoolers_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engine_OilCoolers_OilCoolers_OilCoolerId",
                        column: x => x.OilCoolerId,
                        principalTable: "OilCoolers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Engine_OilCoolers",
                columns: new[] { "EngineId", "OilCoolerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 5 },
                    { 3, 1 },
                    { 3, 5 },
                    { 4, 2 },
                    { 4, 5 },
                    { 5, 2 },
                    { 5, 5 },
                    { 6, 3 },
                    { 6, 5 },
                    { 7, 3 },
                    { 7, 5 },
                    { 8, 3 },
                    { 8, 5 },
                    { 9, 4 },
                    { 9, 5 },
                    { 10, 4 },
                    { 10, 5 },
                    { 11, 5 },
                    { 12, 5 },
                    { 13, 5 },
                    { 14, 5 },
                    { 15, 5 },
                    { 16, 5 }
                });

            migrationBuilder.UpdateData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageURL", "Manufacturer", "Model", "Price" },
                values: new object[] { "https://r-parts-store.com/media/image/product/120679/lg/wt-250001001_wagnertuning-upgrade-oil-cooler-kit-audi-rs4-b5-27biturbo.jpg", "WAGNERTUNING", "Oil Cooler Kit for 2.7tt", 1035.35m });

            migrationBuilder.UpdateData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageURL", "Manufacturer", "Model", "Price" },
                values: new object[] { "https://cdn11.bigcommerce.com/s-6y7pa5d/images/stencil/1280x1280/products/23136/24066/fmocrs4__35308.1449614047.jpg?c=2", "Forge", "Oil Cooler Kit for 4.2 FSI", 1144.33m });

            migrationBuilder.UpdateData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageURL", "Manufacturer", "Model", "Price" },
                values: new object[] { "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/5a/a4/f2/1652886657/13_reiher_ea113b5d62_1280x1280.webp", "Bar-Tek", "Oil Cooler Kit for 2.0 TFSI", 544.92m });

            migrationBuilder.UpdateData(
                table: "OilCoolers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageURL", "Manufacturer", "Model", "Price" },
                values: new object[] { "https://c1552172.ssl.cf0.rackcdn.com/1509007_x450.webp", "ECSTuning", "Universal Oil Cooler With Thermostat", 512.95m });

            migrationBuilder.CreateIndex(
                name: "IX_Engine_OilCoolers_OilCoolerId",
                table: "Engine_OilCoolers",
                column: "OilCoolerId");
        }
    }
}
