using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje.Migrations
{
    public partial class mg22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<DateTime>(
                name: "payment_date",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Bookings",
                type: "int",
                nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "payment_date",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Bookings");

        }
    }
}
