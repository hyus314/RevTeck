using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class ChangeDataOfTurboWithId13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageURL",
                value: "https://www.bar-tek-tuning.com/cdn-cgi/image/fit=scale-down,quality=50,sharpen=1,format=auto,width=1280/https://www.bar-tek-tuning.com/thumbnail/52/d0/2c/1652867184/1460914175-17347gcxpvr99dwrhl_1280x1280.webp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TurboKits",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageURL",
                value: "https://shop.gmcracing.com/1161-large_default/turbo-kit-audivw-20-tfsi-for-powers-up-to-450hp-with-tial-recirculation-wastegate.jpg");
        }
    }
}
