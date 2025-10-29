using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TekSan.Migrations
{
    /// <inheritdoc />
    public partial class init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AltText", "Url" },
                values: new object[] { "Pergole-Tente-1.jpg", "/assets/img/properties/Pergole-Tente-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AltText", "Url" },
                values: new object[] { "Pergole-Tente-3.jpg", "/assets/img/properties/Pergole-Tente-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AltText", "Url" },
                values: new object[] { "Pergole-Tente-4.jpg", "/assets/img/properties/Pergole-Tente-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AltText", "Url" },
                values: new object[] { "Pergole-Tente-5.jpg", "/assets/img/properties/Pergole-Tente-5.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AltText", "Url" },
                values: new object[] { "Pergole-1.jpg", "/assets/img/properties/Pergole-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AltText", "Url" },
                values: new object[] { "Pergole-3.jpg", "/assets/img/properties/Pergole-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AltText", "Url" },
                values: new object[] { "Pergole-4.jpg", "/assets/img/properties/Pergole-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Media",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AltText", "Url" },
                values: new object[] { "Pergole-5.jpg", "/assets/img/properties/Pergole-5.jpg" });
        }
    }
}
