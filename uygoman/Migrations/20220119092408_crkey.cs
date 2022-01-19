using Microsoft.EntityFrameworkCore.Migrations;

namespace uygoman.Migrations
{
    public partial class crkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Keys",
                table: "CrKeys",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Keys",
                table: "CrKeys",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
