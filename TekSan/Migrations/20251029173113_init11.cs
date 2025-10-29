using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TekSan.Migrations
{
    /// <inheritdoc />
    public partial class init11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "AltText", "ContentType", "FileName", "Url" },
                values: new object[,]
                {
                    { 25, "giyotin-cam-1.jpg", "image/jpeg", "giyotin-cam-1.jpg", "/assets/img/properties/giyotin-cam-1.jpg" },
                    { 26, "giyotin-cam-2.jpg", "image/jpeg", "giyotin-cam-2.jpg", "/assets/img/properties/giyotin-cam-2.jpg" },
                    { 27, "giyotin-cam-3.jpg", "image/jpeg", "giyotin-cam-3.jpg", "/assets/img/properties/giyotin-cam-3.jpg" },
                    { 28, "giyotin-cam-4.jpg", "image/jpeg", "giyotin-cam-4.jpg", "/assets/img/properties/giyotin-cam-4.jpg" },
                    { 29, "fotoselli-kapi-1.jpg", "image/jpeg", "fotoselli-kapi-1.jpg", "/assets/img/properties/fotoselli-kapi-1.jpg" },
                    { 30, "fotoselli-kapi-1.jpg", "image/jpeg", "fotoselli-kapi-2.jpg", "/assets/img/properties/fotoselli-kapi-2.jpg" },
                    { 31, "fotoselli-kapi-1.jpg", "image/jpeg", "fotoselli-kapi-3.jpg", "/assets/img/properties/fotoselli-kapi-3.jpg" },
                    { 32, "fotoselli-kapi-1.jpg", "image/jpeg", "fotoselli-kapi-4.jpg", "/assets/img/properties/fotoselli-kapi-4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "DisplayOrder", "IsMain", "MediaId", "ProductId" },
                values: new object[,]
                {
                    { 24, 3, true, 25, 6 },
                    { 25, 3, false, 26, 6 },
                    { 26, 3, false, 27, 6 },
                    { 27, 3, false, 28, 6 },
                    { 28, 3, true, 29, 6 },
                    { 29, 3, false, 30, 6 },
                    { 30, 3, false, 31, 6 },
                    { 31, 3, false, 32, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 32);
        }
    }
}
