using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TekSan.Migrations
{
    /// <inheritdoc />
    public partial class init14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "AltText", "ContentType", "FileName", "Url" },
                values: new object[,]
                {
                    { 41, "seffaf-branda-1.jpg", "image/jpeg", "seffaf-branda-1.jpg", "/assets/img/properties/seffaf-alan-kapama-4.jpg" },
                    { 42, "seffaf-branda-2.jpg", "image/jpeg", "seffaf-branda-2.jpg", "/assets/img/properties/seffaf-alan-kapama-4.jpg" },
                    { 43, "seffaf-branda-3.jpg", "image/jpeg", "seffaf-branda-3.jpg", "/assets/img/properties/seffaf-alan-kapama-4.jpg" },
                    { 44, "seffaf-branda-4.jpg", "image/jpeg", "seffaf-branda-4.jpg", "/assets/img/properties/seffaf-alan-kapama-4.jpg" },
                    { 45, "havuz-brandasi-1.jpg", "image/jpeg", "havuz-brandasi-1.jpg", "/assets/img/properties/havuz-brandasi-1.jpg" },
                    { 46, "havuz-brandasi-2.jpg", "image/jpeg", "havuz-brandasi-2.jpg", "/assets/img/properties/havuz-brandasi-2.jpg" },
                    { 47, "havuz-brandasi-3.jpg", "image/jpeg", "havuz-brandasi-3.jpg", "/assets/img/properties/havuz-brandasi-3.jpg" },
                    { 48, "havuz-brandasi-4.jpg", "image/jpeg", "havuz-brandasi-4.jpg", "/assets/img/properties/havuz-brandasi-4.jpg" },
                    { 49, "iskele-branda-1.jpg", "image/jpeg", "iskele-branda-1.jpg", "/assets/img/properties/iskele-branda-1.jpg" },
                    { 50, "iskele-branda-2.jpg", "image/jpeg", "iskele-branda-2.jpg", "/assets/img/properties/iskele-branda-2.jpg" },
                    { 51, "iskele-branda-3.jpg", "image/jpeg", "iskele-branda-3.jpg", "/assets/img/properties/iskele-branda-3.jpg" },
                    { 52, "iskele-branda-4.jpg", "image/jpeg", "iskele-branda-4.jpg", "/assets/img/properties/iskele-branda-4.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "DisplayOrder", "IsMain", "MediaId", "ProductId" },
                values: new object[,]
                {
                    { 40, 3, true, 41, 10 },
                    { 41, 3, false, 42, 10 },
                    { 42, 3, false, 43, 10 },
                    { 43, 3, false, 44, 10 },
                    { 44, 3, true, 45, 11 },
                    { 45, 3, false, 46, 11 },
                    { 46, 3, false, 47, 11 },
                    { 47, 3, false, 48, 11 },
                    { 48, 3, true, 49, 12 },
                    { 49, 3, false, 50, 12 },
                    { 50, 3, false, 51, 12 },
                    { 51, 3, false, 52, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 52);
        }
    }
}
