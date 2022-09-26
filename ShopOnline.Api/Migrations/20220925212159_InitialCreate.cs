using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sábanas colchón cama sencilla" },
                    { 2, "Sábanas colchón cama semi doble" },
                    { 3, "Sábanas colchón cama doble" },
                    { 4, "Protectores colchón cama sencilla" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Miguel" },
                    { 2, "Lucía" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Beauty/Beauty1.png", "Sábanas para cama sencilla 1", 100m, 100 },
                    { 2, 1, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Beauty/Beauty2.png", "Sábanas para cama sencilla 2", 50m, 45 },
                    { 3, 1, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Beauty/Beauty3.png", "Sábanas para cama sencilla 3", 20m, 30 },
                    { 4, 1, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Beauty/Beauty4.png", "Sábanas para cama sencilla 4", 50m, 60 },
                    { 5, 1, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Beauty/Beauty5.png", "Sábanas para cama sencilla 5", 30m, 85 },
                    { 6, 3, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Electronic/Electronics1.png", "Sábanas para cama doble 1", 100m, 120 },
                    { 7, 3, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Electronic/Electronics2.png", "Sábanas para cama doble 2", 40m, 200 },
                    { 8, 3, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Electronic/Electronics3.png", "Sábanas para cama doble 3", 40m, 300 },
                    { 9, 3, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Electronic/Electronic4.png", "Sábanas para cama doble 4", 600m, 20 },
                    { 10, 3, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Electronic/Electronic5.png", "Sábanas para cama doble 5", 500m, 15 },
                    { 11, 3, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Electronic/technology6.png", "Sábanas para cama doble 6", 100m, 60 },
                    { 12, 2, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Furniture/Furniture1.png", "Sábanas para cama semi doble 1", 50m, 212 },
                    { 13, 2, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Furniture/Furniture2.png", "Sábanas para cama semi doble 2", 50m, 112 },
                    { 14, 2, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Furniture/Furniture3.png", "Sábanas para cama semi doble 3", 70m, 90 },
                    { 15, 2, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Furniture/Furniture4.png", "Sábanas para cama semi doble 4", 120m, 95 },
                    { 16, 2, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Furniture/Furniture6.png", "Sábanas para cama semi doble 5", 15m, 100 },
                    { 17, 2, "Sábanas género unisex colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Furniture/Furniture7.png", "Sábanas para cama semi doble 6", 20m, 73 },
                    { 18, 4, "Protector anti fluidos colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Shoes/Shoes1.png", "Protector colchón cama sencilla 1", 100m, 50 },
                    { 19, 4, "Protector anti fluidos colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Shoes/Shoes2.png", "Protector colchón cama sencilla 2", 150m, 60 },
                    { 20, 4, "Protector anti fluidos colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Shoes/Shoes3.png", "Protector colchón cama sencilla 3", 200m, 70 },
                    { 21, 4, "Protector anti fluidos colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Shoes/Shoes4.png", "Protector colchón cama sencilla 4", 120m, 120 },
                    { 22, 4, "Protector anti fluidos colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Shoes/Shoes5.png", "Protector colchón cama sencilla 5", 200m, 100 },
                    { 23, 4, "Protector anti fluidos colchon con dimensiones largo xx, ancho xx, alto xx", "/Images/Shoes/Shoes6.png", "Protector colchón cama sencilla 6", 50m, 150 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
