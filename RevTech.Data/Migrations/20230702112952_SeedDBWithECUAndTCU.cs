using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RevTech.Data.Migrations
{
    public partial class SeedDBWithECUAndTCU : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ECUTunings",
                columns: new[] { "Id", "EngineId", "HorsePowerBoost", "ImageURL", "Manufacturer", "Name", "Price", "TorqueBoost" },
                values: new object[,]
                {
                    { 1, 1, 45, "https://motoristprod.s3.amazonaws.com/uploads/redactor_rails/picture/data/3244/motorist-ecu-tuning-june-2020.png", "Quantum Tuning", "ECU Upgrade for 1.8t", 150.0m, 100 },
                    { 2, 2, 45, "https://motoristprod.s3.amazonaws.com/uploads/redactor_rails/picture/data/3244/motorist-ecu-tuning-june-2020.png", "Quantum Tuning", "ECU Upgrade for 1.8t", 150.0m, 100 },
                    { 3, 3, 45, "https://motoristprod.s3.amazonaws.com/uploads/redactor_rails/picture/data/3244/motorist-ecu-tuning-june-2020.png", "Quantum Tuning", "ECU Upgrade for 1.8t", 150.0m, 100 },
                    { 4, 4, 65, "https://www.034motorsport.com/media/fishpig/webp/catalog/product/cache/1151afdc91a7a37549ca32dea82af8c6/b/5/b5_s4_stage1.webp", "034Motorsport", "ECU Upgrade for 2.7t", 495.0m, 90 },
                    { 5, 5, 65, "https://www.034motorsport.com/media/fishpig/webp/catalog/product/cache/1151afdc91a7a37549ca32dea82af8c6/b/5/b5_s4_stage1.webp", "034Motorsport", "ECU Upgrade for 2.7t", 495.0m, 90 },
                    { 6, 6, 10, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 4.2 FSI", 499.95m, 50 },
                    { 7, 7, 10, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 4.2 FSI", 499.95m, 50 },
                    { 8, 8, 10, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 4.2 FSI", 499.95m, 50 },
                    { 9, 9, 55, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 2.0 TFSI", 399.95m, 70 },
                    { 10, 10, 55, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 2.0 TFSI", 399.95m, 70 },
                    { 11, 11, 130, "https://clptuning.co.uk/wp-content/uploads/2016/11/APR-Stage-1-300x300.jpg", "APR", "ECU Upgrade for 4.0 TFSI", 1200.00m, 180 },
                    { 12, 12, 80, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 4.0 TFSI", 800.00m, 130 },
                    { 13, 13, 80, "https://images.goapr.com/583x/apr_ecu.png", "APR", "ECU Upgrade for 4.0 TFSI", 800.00m, 130 },
                    { 14, 14, 120, "http://www.goapr.co.uk/includes/img/icons/apr-ecu.png", "APR", "ECU Upgrade for 3.0 TFSI", 900.00m, 70 },
                    { 15, 15, 120, "http://www.goapr.co.uk/includes/img/icons/apr-ecu.png", "APR", "ECU Upgrade for 3.0 TFSI", 900.00m, 70 },
                    { 16, 16, 120, "http://www.goapr.co.uk/includes/img/icons/apr-ecu.png", "APR", "ECU Upgrade for 3.0 TFSI", 900.00m, 70 }
                });

            migrationBuilder.InsertData(
                table: "TCUTunings",
                columns: new[] { "Id", "Description", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 1, "Once this selected TCU Option is installed, it will result in a higher Top Speed, but the acceleration rate will be reduced", "https://tuitionphysics.com/wp-content/uploads/2020/06/speed-velocity-and-acceleration-concepts-differences.jpg", "Increase Top Speed" },
                    { 2, "Once this selected TCU Option is installed, it will result in a faster Acceleration, but the Top Speed will be reduced", "https://grimmermotors.co.nz/wp-content/uploads/2018/03/high-rpm.jpg", "Increase Acceleration" },
                    { 3, "This TCU Option includes a balanced combination of both Acceleration and Top Speed", "https://cdn.hswstatic.com/gif/gears-1.jpg", "Balanced" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ECUTunings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TCUTunings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TCUTunings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TCUTunings",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
