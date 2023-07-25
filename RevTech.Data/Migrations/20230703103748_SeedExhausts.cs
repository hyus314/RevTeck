using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedExhausts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ExhaustKits",
                columns: new[] { "Id", "CarModelId", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Model", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 1, 1, 1, 10, "https://www.dcperformance.co.uk/images/products/wm/a9fa2e54659e70c582722017b3c60776.jpg", "Jetex", "1.8t A6 C5 Exhaust Kit", 800.85m, 20 },
                    { 2, 1, 3, 10, "https://www.dcperformance.co.uk/images/products/wm/a9fa2e54659e70c582722017b3c60776.jpg", "Jetex", "1.8t A6 C5 Exhaust Kit", 800.85m, 20 },
                    { 3, 1, 4, 15, "https://www.vividracing.com/images/bbexhaust-a6-catback.jpg", "B&B", "2.7t A6 C5 Exhaust Kit", 1292.40m, 30 },
                    { 4, 1, 5, 15, "https://www.vividracing.com/images/bbexhaust-a6-catback.jpg", "B&B", "2.7t A6 C5 Exhaust Kit", 1292.40m, 30 },
                    { 5, 1, 4, 17, "https://c1552172.ssl.cf0.rackcdn.com/697789_x450.webp", "Milltek", "2.7t A6 C5 Exhaust Kit", 1800.00m, 35 },
                    { 6, 1, 5, 17, "https://c1552172.ssl.cf0.rackcdn.com/697789_x450.webp", "Milltek", "2.7t A6 C5 Exhaust Kit", 1800.00m, 35 },
                    { 7, 2, 1, 10, "https://en.bsr.se/assets/images/products/big/737962_big.jpg", "Simons", "1.8t A4 B5 Exhaust Kit", 681.20m, 20 },
                    { 8, 2, 3, 10, "https://en.bsr.se/assets/images/products/big/737962_big.jpg", "Simons", "1.8t A4 B5 Exhaust Kit", 681.20m, 20 },
                    { 9, 2, 1, 10, "https://i.ebayimg.com/images/g/1jAAAOSwXGxgQND4/s-l1600.jpg", "Jetex", "1.8t A4 B5 Exhaust Kit", 528.14m, 20 },
                    { 10, 2, 3, 10, "https://i.ebayimg.com/images/g/1jAAAOSwXGxgQND4/s-l1600.jpg", "Jetex", "1.8t A4 B5 Exhaust Kit", 528.14m, 20 },
                    { 11, 3, 4, 10, "https://www.bbexhaust.com/wp-content/uploads/2016/05/FPIM-0530-2.jpg", "Billy Boat Exhaust", "2.7tt S4 B5 Exhaust Kit", 1579.93m, 20 },
                    { 12, 5, 6, 20, "https://cmwheels.com/wp-content/uploads/2018/01/products-SSXAU116.jpg", "Milltek", "4.2FSI RS4 B7 Exhaust Kit", 2234.31m, 40 },
                    { 13, 5, 6, 15, "https://media.vwpartsinternational.com/wp-content/uploads/2018/05/21162655/Audi-RS4-B7-4.2-V8-Saloon-Avant-Milltek-Sport-Performance-Non-Resonated-Cat-Back-Exhaust-System-Inc-Satin-Sheen-Black-Tips-SSXAU218.jpeg", "Milltek", "4.2FSI RS4 B7 Exhaust Kit", 1816.85m, 30 },
                    { 14, 6, 7, 15, "https://cmwheels.com/wp-content/uploads/2018/04/SSXAU190.jpg", "Milltek", "4.2FSI S5 B8 Exhaust Kit", 1105.44m, 30 },
                    { 15, 7, 7, 15, "https://cmwheels.com/wp-content/uploads/2018/04/SSXAU190.jpg", "Milltek", "4.2FSI S5 B8.5 Exhaust Kit", 1105.44m, 30 },
                    { 16, 7, 14, 15, "https://clptuning.co.uk/product/milltek-cat-back-exhaust-system-audi-s4-s5-b8-5-3-0tfsi/", "Milltek", "3.0TFSI S5 B8.5 Exhaust Kit", 2726.91m, 30 },
                    { 17, 8, 6, 13, "https://www.armytrix.com/cdn/800_530_80_ff_cdn/audi-rs5-b8/audi-rs5-v8-exhaust-16.jpg", "Armytrix", "4.2 FSI RS5 B8.5 VALVETRONIC Exhaust Kit", 5440.69m, 15 },
                    { 18, 8, 6, 13, "https://clptuning.co.uk/wp-content/uploads/2018/01/SSXAU261_1-300x300.jpg", "Milltek", "4.2 FSI RS5 B8.5 Exhaust Kit", 3341.50m, 15 },
                    { 19, 9, 8, 5, "https://balancemotorsport.co.uk/media/catalog/product/cache/58eb3c1ce7095e93eebc6663a89e40bb/4/4/44534_1.jpg", "SuperSprint", "4.2 FSI A6 C6 Centre Exhaust + X-Pipe", 1665.06m, 9 },
                    { 20, 9, 15, 5, "https://balancemotorsport.co.uk/media/catalog/product/cache/58eb3c1ce7095e93eebc6663a89e40bb/4/4/44534_1.jpg", "SuperSprint", "3.0 TFSI A6 C6 Centre Exhaust + X-Pipe", 1581.80m, 9 },
                    { 21, 9, 15, 7, "https://cdn11.bigcommerce.com/s-ov4aejck1y/images/stencil/1920w/products/296179/35616535/840756122694944651_jhm-c6a630tcbe-thmb__05028.1668196184.jpg?c=1", "JHM", "3.0 TFSI A6 C6 Cat Back Exhaust", 1750.59m, 10 },
                    { 22, 10, 9, 5, "https://www.milltekexhaust-roadrunnermotorsport.co.uk/30048-large_default/milltek-exhaust-audi-a4-2-0-tfsi-b7-quattro-and-dtm-cat-back-exhaust-ssxau517.jpg", "Milltek", "2.0 TFSI A4 B7 Cat Back Exhaust", 1524.78m, 8 },
                    { 23, 10, 9, 5, "https://media.vwpartsinternational.com/wp-content/uploads/2018/03/14235412/Audi-A4-B7-1.8T-2.0TFSI-Quattro-Jetex-Performance-Stainless-Steel-Resonated-Half-Exhaust-System-with-Round-100mm-LR-Tail-Pipes-EC-44DH5R-416x258.jpg", "Jetex", "2.0 TFSI A4 B7 Half Exhaust Kit", 773.83m, 8 },
                    { 24, 10, 9, 7, "https://en.bsr.se/assets/images/products/big/4383_big.jpg", "Ferrita", "2.0 TFSI A4 B7 Exhaust Kit", 1144.67m, 11 },
                    { 25, 11, 10, 5, "https://www.milltekexhaust-roadrunnermotorsport.co.uk/30048-large_default/milltek-exhaust-audi-a4-2-0-tfsi-b7-quattro-and-dtm-cat-back-exhaust-ssxau517.jpg", "Milltek", "2.0 TFSI A4 B7 Cat Back Exhaust", 1524.78m, 8 },
                    { 26, 11, 10, 5, "https://media.vwpartsinternational.com/wp-content/uploads/2018/03/14235412/Audi-A4-B7-1.8T-2.0TFSI-Quattro-Jetex-Performance-Stainless-Steel-Resonated-Half-Exhaust-System-with-Round-100mm-LR-Tail-Pipes-EC-44DH5R-416x258.jpg", "Jetex", "2.0 TFSI A4 B7 Half Exhaust Kit", 773.83m, 8 },
                    { 27, 11, 10, 7, "https://en.bsr.se/assets/images/products/big/4383_big.jpg", "Ferrita", "2.0 TFSI A4 B7 Exhaust Kit", 1144.67m, 11 },
                    { 28, 12, 11, 15, "https://cdn.shopify.com/s/files/1/0070/1779/1577/products/DSC01072_53eeb7bc-42ea-4166-837b-1b16ee4022d2_1200x1200.jpg?v=1590075728", "TNEER", "4.0 TFSI S6 C7 Exhaust Kit", 7513.22m, 20 },
                    { 29, 12, 11, 15, "https://cdn.shopify.com/s/files/1/2493/0960/products/a9f1f012a32f87a8ca5b762158af25b7.jpg?v=1610140343", "APR", "4.0 TFSI S6 C7 Cat Back Exhaust ", 3500.00m, 20 },
                    { 30, 13, 12, 20, "https://www.wrsauto.it/161-thickbox_default/akrapovic-evolution-exhaust-system-audi-rs6-avant-c7-2014-2018.jpg", "Akrapovic", "4.0 TFSI RS6 C7 Cat Back Exhaust", 10417.38m, 25 },
                    { 31, 13, 12, 15, "https://www.armytrix.com/cdn/800_530_80_ff_cdn/audi-rs6-rs7/audi-rs6-c7-armytrix-exhaust-1.jpg", "Armytrix", "4.0 TFSI RS6 C7 VALVETRONIC Exhaust Kit", 7604.22m, 25 },
                    { 32, 16, 11, 10, "https://germanmuscle.co/wp-content/uploads/2022/05/FI-Exhaust-2012-2017-Audi-S6-C7-4.0T-Valvetronic-Exhaust-System-1.jpg", "FI", "4.0 TFSI S7 C7 VALVETRONIC Exhaust Kit", 4500.99m, 15 },
                    { 33, 16, 11, 10, "https://www.futurez.fi/wp-content/uploads/76ae3060571a43ba82ef55d2f9617482-1.png", "Akrapovic", "4.0 TFSI S7 C7 VALVETRONIC Exhaust Kit", 10344.74m, 15 },
                    { 34, 17, 12, 10, "https://www.armytrix.com/cdn/800_530_80_ff_cdn/audi-rs7/audi-rs7-c7-armytrix-exhaust-9.jpg", "Armytrix", "4.0 TFSI RS7 C7 VALVETRONIC Exhaust Kit", 7804.22m, 15 },
                    { 35, 17, 12, 10, "https://www.motorsport24.nl/wp-content/uploads/2022/04/SAUTI4H-1.png", "Akrapovic", "4.0 TFSI RS7 C7 VALVETRONIC Exhaust Kit", 11042.88m, 15 },
                    { 36, 14, 12, 10, "https://dtm-tuning.com/image/cache/catalog/goods_ad_eqip/milltek/a8-d4/milltek-ssxau466_1-1000x690.jpg", "Milltek", "4.0 TFSI S8 D4 Exhaust Kit", 11042.88m, 15 },
                    { 37, 14, 12, 10, "https://cdn.capristoexhaust.com/wp-content/uploads/sites/3/IMG_0710-Audi-S8-20171109-600x400.jpg", "Capristo", "4.0 TFSI S8 D4 Cat Back Exhaust", 7300.00m, 15 },
                    { 38, 14, 12, 10, "https://dtm-tuning.com/image/cache/catalog/goods_ad_eqip/milltek/a8-d4/milltek-ssxau466_1-1000x690.jpg", "Milltek", "4.0 TFSI S8 D4 Exhaust Kit", 11042.88m, 15 },
                    { 39, 15, 13, 10, "https://cdn.capristoexhaust.com/wp-content/uploads/sites/3/IMG_0710-Audi-S8-20171109-600x400.jpg", "Capristo", "4.0 TFSI S8 D4 Cat Back Exhaust", 7300.00m, 15 },
                    { 40, 18, 16, 5, "https://martelius.com/media/catalog/product/cache/c1e92043d4ce1e523c981de3ee6acbf8/5/3/530041.jpg", "Martellius", "3.0 TFSI A6 C7 Cat Back Exhaust", 1415.60m, 8 },
                    { 41, 18, 16, 5, "https://martelius.com/media/catalog/product/cache/c1e92043d4ce1e523c981de3ee6acbf8/5/3/530041.jpg", "Milltek", "4.2 FSI Q7 4L Exhaust Kit", 2700.00m, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ExhaustKits",
                keyColumn: "Id",
                keyValue: 41);
        }
    }
}
