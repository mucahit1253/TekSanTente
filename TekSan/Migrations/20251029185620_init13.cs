using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TekSan.Migrations
{
    /// <inheritdoc />
    public partial class init13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "AltText", "ContentType", "FileName", "Url" },
                values: new object[,]
                {
                    { 33, "kis-bahcecileri-1.jpg", "image/jpeg", "kis-bahcecileri-1.jpg", "/assets/img/properties/kis-bahcecileri-1.jpg" },
                    { 34, "kis-bahcecileri-2.jpg", "image/jpeg", "kis-bahcecileri-2.jpg", "/assets/img/properties/kis-bahcecileri-2.jpg" },
                    { 35, "kis-bahcecileri-3.jpg", "image/jpeg", "kis-bahcecileri-3.jpg", "/assets/img/properties/kis-bahcecileri-3.jpg" },
                    { 36, "kis-bahcecileri-4.jpg", "image/jpeg", "kis-bahcecileri-4.jpg", "/assets/img/properties/kis-bahcecileri-4.jpg" },
                    { 37, "seffaf-alan-kapama-1.jpg", "image/jpeg", "seffaf-alan-kapama-1.jpg", "/assets/img/properties/seffaf-alan-kapama-1.jpg" },
                    { 38, "seffaf-alan-kapama-2.jpg", "image/jpeg", "seffaf-alan-kapama-2.jpg", "/assets/img/properties/seffaf-alan-kapama-2.jpg" },
                    { 39, "seffaf-alan-kapama-3.jpg", "image/jpeg", "seffaf-alan-kapama-3.jpg", "/assets/img/properties/seffaf-alan-kapama-3.jpg" },
                    { 40, "seffaf-alan-kapama-4.jpg", "image/jpeg", "seffaf-alan-kapama-4.jpg", "/assets/img/properties/seffaf-alan-kapama-4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "DisplayOrder", "IsMain", "MediaId", "ProductId" },
                values: new object[,]
                {
                    { 32, 3, true, 33, 8 },
                    { 33, 3, false, 34, 8 },
                    { 34, 3, false, 35, 8 },
                    { 35, 3, false, 36, 8 },
                    { 36, 3, true, 37, 9 },
                    { 37, 3, false, 38, 9 },
                    { 38, 3, false, 39, 9 },
                    { 39, 3, false, 40, 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
