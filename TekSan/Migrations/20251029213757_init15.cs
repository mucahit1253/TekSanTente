using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TekSan.Migrations
{
    /// <inheritdoc />
    public partial class init15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "AltText", "ContentType", "FileName", "Url" },
                values: new object[,]
                {
                    { 53, "kamleya-brandasi-1.jpg", "image/jpeg", "kamleya-brandasi-1.jpg", "/assets/img/properties/kamleya-brandasi-1.jpg" },
                    { 54, "kamleya-brandasi-2.jpg", "image/jpeg", "kamleya-brandasi-2.jpg", "/assets/img/properties/kamleya-brandasi-2.jpg" },
                    { 55, "kamleya-brandasi-3.jpg", "image/jpeg", "kamleya-brandasi-3.jpg", "/assets/img/properties/kamleya-brandasi-3.jpg" },
                    { 56, "kamleya-brandasi-4.jpg", "image/jpeg", "kamleya-brandasi-4.jpg", "/assets/img/properties/kamleya-brandasi-4.jpg" },
                    { 57, "pazar-cadir-1.jpg", "image/jpeg", "pazar-cadir-1.jpg", "/assets/img/properties/pazar-cadir-1.jpg" },
                    { 58, "pazar-cadir-2.jpg", "image/jpeg", "pazar-cadir-2.jpg", "/assets/img/properties/pazar-cadir-2.jpg" },
                    { 59, "pazar-cadir-3.jpg", "image/jpeg", "pazar-cadir-3.jpg", "/assets/img/properties/pazar-cadir-3.jpg" },
                    { 60, "reklam-afisi-1.jpg", "image/jpeg", "reklam-afisi-1.jpg", "/assets/img/properties/reklam-afisi-1.jpg" },
                    { 61, "reklam-afisi-2.jpg", "image/jpeg", "reklam-afisi-2.jpg", "/assets/img/properties/reklam-afisi-2.jpg" },
                    { 62, "reklam-afisi-3.jpg", "image/jpeg", "reklam-afisi-3.jpg", "/assets/img/properties/reklam-afisi-3.jpg" },
                    { 63, "reklam-afisi-4.jpg", "image/jpeg", "reklam-afisi-4.jpg", "/assets/img/properties/reklam-afisi-4.jpg" },
                    { 64, "arac-korumalari-1.jpg", "image/jpeg", "arac-korumalari-1.jpg", "/assets/img/properties/arac-korumalari-1.jpg" },
                    { 65, "arac-korumalari-2.jpg", "image/jpeg", "arac-korumalari-2.jpg", "/assets/img/properties/arac-korumalari-2.jpg" },
                    { 66, "arac-korumalari-3.jpg", "image/jpeg", "arac-korumalari-3.jpg", "/assets/img/properties/arac-korumalari-3.jpg" },
                    { 67, "yat-brandasi-1.jpg", "image/jpeg", "yat-brandasi-1.jpg", "/assets/img/properties/yat-brandasi-1.jpg" },
                    { 68, "yat-brandasi-2.jpg", "image/jpeg", "yat-brandasi-2.jpg", "/assets/img/properties/yat-brandasi-2.jpg" },
                    { 69, "yat-brandasi-3.jpg", "image/jpeg", "yat-brandasi-3.jpg", "/assets/img/properties/yat-brandasi-3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "DisplayOrder", "IsMain", "MediaId", "ProductId" },
                values: new object[,]
                {
                    { 52, 3, true, 53, 13 },
                    { 53, 3, false, 54, 13 },
                    { 54, 3, false, 55, 13 },
                    { 55, 3, false, 56, 13 },
                    { 56, 3, true, 57, 14 },
                    { 57, 3, false, 58, 14 },
                    { 58, 3, false, 59, 14 },
                    { 59, 3, true, 60, 15 },
                    { 60, 3, false, 61, 15 },
                    { 61, 3, false, 62, 15 },
                    { 62, 3, false, 63, 15 },
                    { 63, 3, true, 64, 16 },
                    { 64, 3, false, 65, 16 },
                    { 65, 3, false, 66, 16 },
                    { 66, 3, true, 67, 16 },
                    { 67, 3, false, 68, 16 },
                    { 68, 3, false, 69, 16 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 69);
        }
    }
}
