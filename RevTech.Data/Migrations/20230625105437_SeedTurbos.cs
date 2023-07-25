using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedTurbos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TurboKits",
                columns: new[] { "Id", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "ModelName", "PressureBoost", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 1, 1, 200, "https://www.turbozentrum.de/media/image/product/826/lg/garrett-turbokit-vw-golf-bora-audi-a3-tt-18t-350ps.jpg", "Garrett", "GT2860RS", 1.8m, 2799.67m, 250 },
                    { 2, 1, 160, "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1920/https://www.bar-tek-tuning.com/thumbnail/fe/88/79/1683873716/2218t03-1.8T%20Tuning-Kit%20STUFE%203_1920x1920.webp", "BAR-TEK", "Turbo-Total K04-001", 1.6m, 2115.26m, 200 },
                    { 3, 2, 280, "https://www.raimotorsport.com/v/vspfiles/photos/RAI_B6A4_1.8t_GTX-2.jpg", "RAI", "GTX B6A4", 2.0m, 2675.00m, 310 },
                    { 4, 2, 210, "https://turboconcepts.net/wp-content/uploads/2019/11/A4_18t_long_blackfridaypackage.gif", "RAI", "Turbo Concepts", 1.9m, 1679.00m, 270 },
                    { 5, 3, 190, "https://www.turbo-parts.de/images/product_images/info_images/1.8T%20mit%20Downpipe.jpg", "Garrett", "GT2876R", 1.8m, 1851.98m, 250 },
                    { 6, 4, 400, "https://turboconcepts.net/wp-content/uploads/2019/11/DZX-274a.gif", "Turbo Concepts", "DZX-274", 2.2m, 1995.00m, 500 },
                    { 7, 4, 400, "https://www.034motorsport.com/media/fishpig/webp/catalog/product/cache/1151afdc91a7a37549ca32dea82af8c6/0/3/034Motorsport_B5_S4_RS4_K04_Stage_3_Turbo_Kit_1.webp", "034Motorsport", "K04 Twin Turbo", 2.3m, 3671.90m, 500 },
                    { 8, 5, 380, "https://www.tzr-motorsport.de/WebRoot/Store20/Shops/61911476/5F43/7DE0/D7D2/230B/A266/0A0C/6D10/D0F0/TTE380_Turbolader_Audi_A6_C5_TZR_Motorsport.jpg", "The Turbo Engineers", "TTE380+", 2.1m, 2723.50m, 450 },
                    { 9, 9, 250, "https://shop.gmcracing.com/1161-large_default/turbo-kit-audivw-20-tfsi-for-powers-up-to-450hp-with-tial-recirculation-wastegate.jpg", "GMC Racing", "GMC0501KT", 1.9m, 4182.85m, 300 },
                    { 10, 9, 180, "https://shop.gmcracing.com/1161-large_default/turbo-kit-audivw-20-tfsi-for-powers-up-to-450hp-with-tial-recirculation-wastegate.jpg", "BAR-TEK", "Tuning-Kit K04", 1.8m, 2733.32m, 250 },
                    { 11, 9, 150, "https://www.tte24.net/images/product_images/info_images/1130_0.JPG", "The Turbo Engineers", "TTE450", 1.8m, 1902.43m, 220 },
                    { 12, 10, 250, "https://shop.gmcracing.com/1161-large_default/turbo-kit-audivw-20-tfsi-for-powers-up-to-450hp-with-tial-recirculation-wastegate.jpg", "GMC Racing", "GMC0501KT", 1.9m, 4182.85m, 300 },
                    { 13, 10, 180, "https://shop.gmcracing.com/1161-large_default/turbo-kit-audivw-20-tfsi-for-powers-up-to-450hp-with-tial-recirculation-wastegate.jpg", "BAR-TEK", "Tuning-Kit K04", 1.8m, 2733.32m, 250 },
                    { 14, 10, 150, "https://www.tte24.net/images/product_images/info_images/1130_0.JPG", "The Turbo Engineers", "TTE450", 1.8m, 1902.43m, 220 },
                    { 15, 11, 240, "https://tteglobal.com/media/image/f7/0f/4d/TTE800-2_600x600.jpg", "The Turbo Engineers", "TTE800+", 2.2m, 2788.04m, 280 },
                    { 16, 12, 240, "https://tteglobal.com/media/image/f7/0f/4d/TTE800-2_600x600.jpg", "The Turbo Engineers", "TTE800+", 2.2m, 2788.04m, 280 },
                    { 17, 13, 240, "https://tteglobal.com/media/image/f7/0f/4d/TTE800-2_600x600.jpg", "The Turbo Engineers", "TTE800+", 2.2m, 2788.04m, 280 },
                    { 18, 11, 180, "https://cdn.shopify.com/s/files/1/0451/1340/9690/products/DSC02364_1800x1800.jpg?v=1613506907", "HPA Motorsports", "HVA-246", 2.2m, 1799.00m, 240 },
                    { 19, 12, 180, "https://cdn.shopify.com/s/files/1/0451/1340/9690/products/DSC02364_1800x1800.jpg?v=1613506907", "HPA Motorsports", "HVA-246", 2.2m, 1799.00m, 240 },
                    { 20, 13, 180, "https://cdn.shopify.com/s/files/1/0451/1340/9690/products/DSC02364_1800x1800.jpg?v=1613506907", "HPA Motorsports", "HVA-246", 2.2m, 1799.00m, 240 },
                    { 21, 11, 195, "https://static.wixstatic.com/media/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg/v1/fill/w_938,h_700,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg", "Turbo Systems", "TSUTRSV2", 2.2m, 2137.50m, 280 },
                    { 22, 12, 195, "https://static.wixstatic.com/media/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg/v1/fill/w_938,h_700,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg", "Turbo Systems", "TSUTRSV2", 2.2m, 2137.50m, 280 },
                    { 23, 13, 195, "https://static.wixstatic.com/media/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg/v1/fill/w_938,h_700,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/16bf23_ed5ccc9846734ceca77e1d91994b4ef4~mv2_d_2000_1333_s_2.jpg", "Turbo Systems", "TSUTRSV2", 2.2m, 2137.50m, 280 },
                    { 24, 13, 395, "https://www.tte24.net/images/product_images/popup_images/1272_1.JPG", "The Turbo Engineers", "TTE1000+ Hybrid", 2.5m, 8745.71m, 450 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 24);
        }
    }
}
