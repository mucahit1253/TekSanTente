using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TekSan.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "/assets/img/properties/koruktente-1.jpg");

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "Url",
                value: "/assets/img/properties/koruktente-2.jpg");

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "Url",
                value: "/assets/img/properties/koruktente-3.jpg");

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "Url",
                value: "/assets/img/properties/koruktente-4.jpg");

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8,
                column: "Url",
                value: "/assets/img/properties/koruktente-5.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 4,
                column: "Url",
                value: "/assents/img/properties/koruktente-1.jpg");

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 5,
                column: "Url",
                value: "/assents/img/properties/koruktente-2.jpg");

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 6,
                column: "Url",
                value: "/assents/img/properties/koruktente-3.jpg");

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 7,
                column: "Url",
                value: "/assents/img/properties/koruktente-4.jpg");

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 8,
                column: "Url",
                value: "/assents/img/properties/koruktente-5.jpg");
        }
    }
}
