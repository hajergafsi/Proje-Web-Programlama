using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje.Migrations
{
    public partial class mi2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "state",
                table: "Bookings");

        }
    }
}
