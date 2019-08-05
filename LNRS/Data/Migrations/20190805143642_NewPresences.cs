using Microsoft.EntityFrameworkCore.Migrations;

namespace LNRS.Data.Migrations
{
    public partial class NewPresences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Presence",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Email",
                table: "Presence",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
