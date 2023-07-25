using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class ChangeDataSuperchargers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SuperchargerKits",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "C:\\MyPrograms\\Projects\\RevTechProject\\RevTech\\RevTech\\wwwroot\\img\\superchargerKitId1.jpg");

            migrationBuilder.UpdateData(
                table: "SuperchargerKits",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "C:\\MyPrograms\\Projects\\RevTechProject\\RevTech\\RevTech\\wwwroot\\img\\superchargerKitId2.jpg");
        }
    }
}
