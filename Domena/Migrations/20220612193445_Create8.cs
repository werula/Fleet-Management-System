using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domena.Migrations
{
    public partial class Create8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vehicle",
                table: "Fuels");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Fuels",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fuels_VehicleId",
                table: "Fuels",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fuels_Vehicles_VehicleId",
                table: "Fuels",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fuels_Vehicles_VehicleId",
                table: "Fuels");

            migrationBuilder.DropIndex(
                name: "IX_Fuels_VehicleId",
                table: "Fuels");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Fuels");

            migrationBuilder.AddColumn<string>(
                name: "Vehicle",
                table: "Fuels",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
