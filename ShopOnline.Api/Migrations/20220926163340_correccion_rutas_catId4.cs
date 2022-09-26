using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class correccion_rutas_catId4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageURL",
                value: "/Images/ProtectorColchonCamaSencilla/protectorsencillo1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageURL",
                value: "/Images/ProtectorColchonCamaSencilla/protectorsencillo2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageURL",
                value: "/Images/ProtectorColchonCamaSencilla/protectorsencillo3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageURL",
                value: "/Images/ProtectorColchonCamaSencilla/protectorsencillo4.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageURL",
                value: "/Images/ProtectorColchonCamaSencilla/protectorsencillo5.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageURL",
                value: "/Images/ProtectorColchonCamaSencilla/protectorsencillo6.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageURL",
                value: "/Images/ProtectorColchonCamaSencilla/protectorsencillo1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageURL",
                value: "/Images/ProtectorColchonCamaSencilla/protectorsencillo2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageURL",
                value: "/Images/ProtectorColchonCamaSencilla/protectorsencillo3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageURL",
                value: "/Images/ProtectorColchonCamaSencilla/protectorsencillo4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageURL",
                value: "/Images/ProtectorColchonCamaSencilla/protectorsencillo5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageURL",
                value: "/Images/ProtectorColchonCamaSencilla/protectorsencillo6.png");
        }
    }
}
