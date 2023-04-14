using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kozmetik.Migrations
{
    public partial class bir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
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
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
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
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "Description", "OlderPrice", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, 2, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 1", 250m, "Yüz Yıkama Jeli", 250m },
                    { 2, 2, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 2", 150m, "Cilt Maskesi", 150m },
                    { 3, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 3", 250m, "Ruj", 250m },
                    { 4, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 4", 200m, "Rimel", 150m },
                    { 5, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 5", 400m, "Fondöten", 200m },
                    { 6, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 6", 150m, "EyeShadow", 100m },
                    { 7, 3, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 7", 250m, "Peeling ", 200m },
                    { 8, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 8", 300m, "Highlighter", 300m },
                    { 9, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 9", 150m, "Oje", 100m },
                    { 10, 2, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 10", 150m, "Makyaj Sabitleyici", 150m },
                    { 11, 1, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 11", 150m, "Sünger", 150m },
                    { 12, 3, "buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek buraya açıklama gelecek 12", 150m, "Makyaj Temizleme", 150m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
