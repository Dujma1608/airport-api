using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightManagementWebAPI.Migrations
{
    public partial class AddingCheckedAndLuggage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "Passengers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LuggageWeight",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberLuggage",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "LuggageWeight",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "NumberLuggage",
                table: "Passengers");
        }
    }
}
