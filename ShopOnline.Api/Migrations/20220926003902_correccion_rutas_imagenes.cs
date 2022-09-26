using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class correccion_rutas_imagenes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/Images/SabanasCamaSencilla/sencilla1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "/Images/SabanasCamaSencilla/sencilla2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "/Images/SabanasCamaSencilla/sencilla3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/Images/SabanasCamaSencilla/sencilla4.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "/Images/SabanasCamaSencilla/sencilla5.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "/Images/SabanasCamaDoble/doble1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "/Images/SabanasCamaDoble/doble2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageURL",
                value: "/Images/SabanasCamaDoble/doble3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageURL",
                value: "/Images/SabanasCamaDoble/doble4.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageURL",
                value: "/Images/SabanasCamaDoble/doble5.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageURL",
                value: "/Images/SabanasCamaDoble/doble6.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageURL",
                value: "/Images/SabanasCamaSemiDoble/semidoble1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageURL",
                value: "/Images/SabanasCamaSemiDoble/semidoble2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageURL",
                value: "/Images/SabanasCamaSemiDoble/semidoble3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageURL",
                value: "/Images/SabanasCamaSemiDoble/semidoble4.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageURL",
                value: "/Images/SabanasCamaSemiDoble/semidoble5.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageURL",
                value: "/Images/SabanasCamaSemiDoble/semidoble6.jpg");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "/Images/Beauty/Beauty5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "/Images/Electronic/Electronics1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "/Images/Electronic/Electronics2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageURL",
                value: "/Images/Electronic/Electronics3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageURL",
                value: "/Images/Electronic/Electronic4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageURL",
                value: "/Images/Electronic/Electronic5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageURL",
                value: "/Images/Electronic/technology6.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageURL",
                value: "/Images/Furniture/Furniture1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageURL",
                value: "/Images/Furniture/Furniture2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageURL",
                value: "/Images/Furniture/Furniture3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageURL",
                value: "/Images/Furniture/Furniture4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageURL",
                value: "/Images/Furniture/Furniture6.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageURL",
                value: "/Images/Furniture/Furniture7.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes1.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes2.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes3.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes4.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes5.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageURL",
                value: "/Images/Shoes/Shoes6.png");
        }
    }
}
