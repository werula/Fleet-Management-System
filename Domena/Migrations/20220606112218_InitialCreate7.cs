using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domena.Migrations
{
    public partial class InitialCreate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Vehicles",
                newName: "Car");

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Vehicles",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(4)",
                oldMaxLength: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Car",
                table: "Vehicles",
                newName: "Model");

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Vehicles",
                type: "character varying(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Vehicles",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }
    }
}
