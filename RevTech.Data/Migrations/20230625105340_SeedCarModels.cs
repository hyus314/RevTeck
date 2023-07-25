using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedCarModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "ImageURL", "ManufacturerId", "ModelName", "YearCreated_End", "YearCreated_Start" },
                values: new object[,]
                {
                    { 1, "https://img.favcars.com/audi/a6/photos_audi_a6_2001_2_b.jpg", 1, "A6 C5", 2004, 1997 },
                    { 2, "https://i.ytimg.com/vi/AAfmxSRncBU/maxresdefault.jpg", 1, "A4 B5", 2001, 1996 },
                    { 3, "https://stillrunningstrong.com/wp-content/uploads/2018/03/Audi-A4-b6-sport-model-S4-1024x466.jpg", 1, "A4 B6", 2004, 2002 },
                    { 4, "https://images.fitmentindustries.com/web-compressed/1740944-1-2001-s4-audi-base-bc-racing-coilovers-bbs-ch-r-silver.jpg", 1, "S4 B5", 2001, 1997 },
                    { 5, "https://media.evo.co.uk/image/private/s--zWq7JwVH--/v1556260759/evo/images/dir_688/car_photo_344347.jpg", 1, "RS4 B7", 2009, 2005 },
                    { 6, "https://www.ast-suspension.com/imager/common/10988/Audi-S5-B8-3_ccc647699d3b878f33fab0fc43e2f880.jpg", 1, "S5 B8", 2013, 2007 },
                    { 7, "https://en.audiclub.eu/graphics/gallery/full/2178_13237385133-509f54d839-b.jpg", 1, "S5 B8.5", 2017, 2013 },
                    { 8, "https://cimg7.ibsrv.net/gimg/www.audiworld.com-vbulletin/1200x837/audi_driveway_725b6dcf65369cb5d7d45810f3e5e8d8c487097a.jpg", 1, "RS5 B8.5", 2017, 2013 },
                    { 9, "https://cdn.shopify.com/s/files/1/0570/5518/3000/collections/a6_c6.jpg?v=1648793950", 1, "A6 C6", 2011, 2004 },
                    { 10, "https://i.pinimg.com/originals/e1/a2/32/e1a232889a2009dffca15f9b432ab3b8.jpg", 1, "A4 B7", 2008, 2004 },
                    { 11, "https://i.pinimg.com/originals/4f/54/ea/4f54ea4597e4fc876df08c49bad03992.jpg", 1, "A4 B8.5", 2015, 2012 },
                    { 12, "https://img.md-exclusive-cardesign.com/wp-content/uploads/2019/10/audi-a6-c7-limousine-breitbau-tuning-pd600r-widebody-kit-artform-af-401-felgen-in-105x21-md-exclusive-cardesign-16-455x179.jpg", 1, "S6 C7", 2018, 2011 },
                    { 13, "https://img.md-exclusive-cardesign.com/wp-content/uploads/2019/10/audi-a6-c7-limousine-breitbau-tuning-pd600r-widebody-kit-artform-af-401-felgen-in-105x21-md-exclusive-cardesign-16-455x179.jpg", 1, "RS6 C7", 2018, 2011 },
                    { 14, "https://www.tuning.bg/public/upload/gallery/extended/normal/1358582002.jpg", 1, "S8 D4", 2015, 2012 },
                    { 15, "https://cdn-0.carsopedia.com/files/generations/Audi-D4-498.jpg", 1, "S8+ D4.5", 2018, 2015 },
                    { 16, "https://www.auto-data.net/images/f4/file3193601.jpg", 1, "S7 C7", 2017, 2012 },
                    { 17, "https://www.autocar.co.uk/sites/autocar.co.uk/files/audi-rs7_1.jpg", 1, "RS7 C7", 2019, 2013 },
                    { 18, "https://upload.wikimedia.org/wikipedia/commons/8/85/Audi_A6_S-line_%28C7%29_%E2%80%93_Frontansicht%2C_1._Mai_2012%2C_D%C3%BCsseldorf.jpg", 1, "A6 C7", 2018, 2011 },
                    { 19, "https://mir-s3-cdn-cf.behance.net/project_modules/fs/b2ebb974237045.5c27acde184ed.jpg", 1, "Q7 4L", 2015, 2005 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CarModels",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
