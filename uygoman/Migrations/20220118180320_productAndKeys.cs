using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace uygoman.Migrations
{
    public partial class productAndKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductName = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductName);
                });

            migrationBuilder.CreateTable(
                name: "CrKeys",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Keys = table.Column<string>(maxLength: 8, nullable: false),
                    Product_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrKeys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CrKeys_Products_Product_Name",
                        column: x => x.Product_Name,
                        principalTable: "Products",
                        principalColumn: "ProductName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CrKeys_Product_Name",
                table: "CrKeys",
                column: "Product_Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrKeys");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
