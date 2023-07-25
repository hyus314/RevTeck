using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class ChangeStructureOfSparkPlugTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "SparkPlugsKits");

            migrationBuilder.RenameColumn(
                name: "PriceForKit",
                table: "SparkPlugsKits",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "SparkPlugsKits",
                newName: "PriceForKit");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "SparkPlugsKits",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
