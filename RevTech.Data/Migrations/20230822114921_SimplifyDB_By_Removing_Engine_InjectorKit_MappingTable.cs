using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SimplifyDB_By_Removing_Engine_InjectorKit_MappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engine_InjectorKits");

            migrationBuilder.AddColumn<int>(
                name: "EngineId",
                table: "InjectorKits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 1,
                column: "EngineId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 2, 8, "https://c1552172.ssl.cf0.rackcdn.com/87249_x450.webp", "Bosch", "550 cc Fuel Injectors - Set Of Four", 291.25m, 16 });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EngineId", "HorsePowerBoost", "ImageURL", "Model", "Price", "TorqueBoost" },
                values: new object[] { 3, 8, "https://c1552172.ssl.cf0.rackcdn.com/87249_x450.webp", "550 cc Fuel Injectors - Set Of Four", 291.25m, 16 });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 1, 9, "https://c1552172.ssl.cf0.rackcdn.com/75141_x450.webp", "Siemens", "630 cc Fuel Injectors - Set Of Four", 312.80m, 18 });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 2, 9, "https://c1552172.ssl.cf0.rackcdn.com/75141_x450.webp", "Siemens", "630 cc Fuel Injectors - Set Of Four", 312.80m, 18 });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 3, 9, "https://c1552172.ssl.cf0.rackcdn.com/75141_x450.webp", "Siemens", "630 cc Fuel Injectors - Set Of Four", 312.80m, 18 });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 1, 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Four", 411.72m, 20 });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 2, 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Four", 411.72m, 20 });

            migrationBuilder.InsertData(
                table: "InjectorKits",
                columns: new[] { "Id", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 9, 3, 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Four", 411.72m, 20 },
                    { 10, 4, 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Six", 617.58m, 20 },
                    { 11, 5, 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Six", 617.58m, 20 },
                    { 12, 4, 12, "https://cdn.shopify.com/s/files/1/0109/5814/3547/products/32_710e4d04-15b1-40cf-8c72-48dc955e88d5_695x695.jpg?v=1670590394", "Bosch", "1000 cc Fuel Injectors - Set Of Six", 650.12m, 22 },
                    { 13, 5, 12, "https://cdn.shopify.com/s/files/1/0109/5814/3547/products/32_710e4d04-15b1-40cf-8c72-48dc955e88d5_695x695.jpg?v=1670590394", "Bosch", "1000 cc Fuel Injectors - Set Of Six", 650.12m, 22 },
                    { 14, 6, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 15, 7, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 16, 8, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 17, 11, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 18, 12, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 19, 13, 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 },
                    { 20, 9, 7, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Four", 762.61m, 15 },
                    { 21, 10, 7, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Four", 762.61m, 15 },
                    { 22, 14, 9, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Six", 1143.92m, 22 },
                    { 23, 15, 9, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Six", 1143.92m, 22 },
                    { 24, 16, 9, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Six", 1143.92m, 22 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InjectorKits_EngineId",
                table: "InjectorKits",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_InjectorKits_Engines_EngineId",
                table: "InjectorKits",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InjectorKits_Engines_EngineId",
                table: "InjectorKits");

            migrationBuilder.DropIndex(
                name: "IX_InjectorKits_EngineId",
                table: "InjectorKits");

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "InjectorKits");

            migrationBuilder.CreateTable(
                name: "Engine_InjectorKits",
                columns: table => new
                {
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    InjectorKitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engine_InjectorKits", x => new { x.EngineId, x.InjectorKitId });
                    table.ForeignKey(
                        name: "FK_Engine_InjectorKits_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engine_InjectorKits_InjectorKits_InjectorKitId",
                        column: x => x.InjectorKitId,
                        principalTable: "InjectorKits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Engine_InjectorKits",
                columns: new[] { "EngineId", "InjectorKitId" },
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
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 6 },
                    { 8, 6 },
                    { 9, 7 },
                    { 10, 7 },
                    { 11, 6 },
                    { 12, 6 },
                    { 13, 6 },
                    { 14, 8 },
                    { 15, 8 },
                    { 16, 8 }
                });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 9, "https://c1552172.ssl.cf0.rackcdn.com/75141_x450.webp", "Siemens", "630 cc Fuel Injectors - Set Of Four", 312.80m, 18 });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HorsePowerBoost", "ImageURL", "Model", "Price", "TorqueBoost" },
                values: new object[] { 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "750 cc Fuel Injectors - Set Of Four", 411.72m, 20 });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 10, "https://c1552172.ssl.cf0.rackcdn.com/1581767_x450.webp", "Bosch", "750 cc Fuel Injectors - Set Of Six", 617.58m, 20 });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 12, "https://cdn.shopify.com/s/files/1/0109/5814/3547/products/32_710e4d04-15b1-40cf-8c72-48dc955e88d5_695x695.jpg?v=1670590394", "Bosch", "1000 cc Fuel Injectors - Set Of Six", 650.12m, 22 });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 15, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Eight", 1525.21m, 30 });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 7, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Four", 762.61m, 15 });

            migrationBuilder.UpdateData(
                table: "InjectorKits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[] { 9, "https://www.kmdtuning.com/image/cache/data/productimage/injrs4-500x500.jpg", "OEM", "Tuning Fuel Injectors - Set Of Six", 1143.92m, 22 });

            migrationBuilder.CreateIndex(
                name: "IX_Engine_InjectorKits_InjectorKitId",
                table: "Engine_InjectorKits",
                column: "InjectorKitId");
        }
    }
}
