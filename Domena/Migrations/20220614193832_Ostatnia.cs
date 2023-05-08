using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domena.Migrations
{
    public partial class Ostatnia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fuels_Vehicles_VehicleId",
                table: "Fuels");

            migrationBuilder.DropForeignKey(
                name: "FK_Issues_Vehicles_VehicleId",
                table: "Issues");

            migrationBuilder.DropForeignKey(
                name: "FK_Tires_Vehicles_VehicleId",
                table: "Tires");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Tires",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Issues",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Fuels",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Fuels_Vehicles_VehicleId",
                table: "Fuels",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_Vehicles_VehicleId",
                table: "Issues",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tires_Vehicles_VehicleId",
                table: "Tires",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fuels_Vehicles_VehicleId",
                table: "Fuels");

            migrationBuilder.DropForeignKey(
                name: "FK_Issues_Vehicles_VehicleId",
                table: "Issues");

            migrationBuilder.DropForeignKey(
                name: "FK_Tires_Vehicles_VehicleId",
                table: "Tires");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Tires",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Issues",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Fuels",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fuels_Vehicles_VehicleId",
                table: "Fuels",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_Vehicles_VehicleId",
                table: "Issues",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tires_Vehicles_VehicleId",
                table: "Tires",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
