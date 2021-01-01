using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje.Migrations
{
    public partial class payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<DateTime>(
                name: "paymentDate",
                table: "Bookings",
                type: "datetime",
                nullable: true
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "paymentDate",
                table: "Bookings");

        }
    }
}
