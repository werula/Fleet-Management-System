using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domena.Migrations
{
    public partial class InitialCreate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeginInsurance",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "EndInsurance",
                table: "Vehicles",
                newName: "NextInsurance");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NextInsurance",
                table: "Vehicles",
                newName: "EndInsurance");

            migrationBuilder.AddColumn<DateTime>(
                name: "BeginInsurance",
                table: "Vehicles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
