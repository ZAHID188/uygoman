using Microsoft.EntityFrameworkCore.Migrations;

namespace uygoman.Migrations
{
    public partial class companyuploadfilename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UploadFileName",
                table: "CompanyRegs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UploadFileName",
                table: "CompanyRegs");
        }
    }
}
