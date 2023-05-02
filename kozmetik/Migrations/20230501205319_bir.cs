using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kozmetik.Migrations
{
    public partial class bir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Rolees",
                columns: table => new
                {
                    RoleeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rolees", x => x.RoleeID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    OlderPrice = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Userrs",
                columns: table => new
                {
                    UserrID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emaill = table.Column<string>(type: "nvarchar(52)", maxLength: 52, nullable: false),
                    Passwordd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userrs", x => x.UserrID);
                    table.ForeignKey(
                        name: "FK_Userrs_Rolees_RoleeID",
                        column: x => x.RoleeID,
                        principalTable: "Rolees",
                        principalColumn: "RoleeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserrID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_Carts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Userrs_UserrID",
                        column: x => x.UserrID,
                        principalTable: "Userrs",
                        principalColumn: "UserrID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Makyaj" },
                    { 2, "Cilt Bakımı" },
                    { 3, "Sağlık-Hijyen" },
                    { 4, "Anne-Bebek" },
                    { 5, "Ev-Yaşam" },
                    { 6, "Saç Bakım" },
                    { 7, "Parfüm-Deodorant" },
                    { 8, "Erkek Bakım" }
                });

            migrationBuilder.InsertData(
                table: "Rolees",
                columns: new[] { "RoleeID", "RoleeName" },
                values: new object[,]
                {
                    { 1, "CandidateUser" },
                    { 2, "NormalUser" },
                    { 3, "Admin" },
                    { 4, "Supervisor" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "OlderPrice", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, 2, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 1", 250m, "AHA BHA SERUM", 250m },
                    { 2, 2, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 2", 150m, "ALOEAVERA JEL", 150m },
                    { 3, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 3", 250m, "ANESTEZİ KREMİ", 250m },
                    { 4, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 4", 200m, "ANTIAGING", 150m },
                    { 5, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 5", 400m, "ANTISPOT", 200m },
                    { 6, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 6", 150m, "APRICOT PEELING", 100m },
                    { 7, 3, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 7", 250m, "BAKIM KREMİ ", 200m },
                    { 8, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 8", 300m, "BEYAZLATICI KREM", 300m },
                    { 9, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 9", 150m, "GEL PEELING", 100m },
                    { 10, 2, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 10", 150m, "GÜNEŞ KORUYUCU", 150m },
                    { 11, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 11", 150m, "KİL", 150m },
                    { 12, 3, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12", 150m, "MOSISTURE KREM", 150m },
                    { 13, 3, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12", 150m, "PİRİNÇ", 150m },
                    { 14, 3, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12", 150m, "SIKILAŞTIRICI KREM", 150m },
                    { 15, 3, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12", 150m, "TONIK", 150m },
                    { 16, 3, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12", 150m, "TROPICAL", 150m },
                    { 17, 3, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12", 150m, "VITAMIN C", 150m },
                    { 18, 3, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12", 150m, "YÜZ TEMIZLEME GEL", 150m }
                });

            migrationBuilder.InsertData(
                table: "Userrs",
                columns: new[] { "UserrID", "Emaill", "Passwordd", "RoleeID" },
                values: new object[,]
                {
                    { 1, "candidateuser@hotmail.com", "123456", 1 },
                    { 2, "normaluser@hotmail.com", "123456", 2 },
                    { 3, "admin@hotmail.com", "123456", 3 },
                    { 4, "supervisor@hotmail.com", "123456", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductID",
                table: "Carts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserrID",
                table: "Carts",
                column: "UserrID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Userrs_RoleeID",
                table: "Userrs",
                column: "RoleeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Userrs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Rolees");
        }
    }
}
