using Microsoft.EntityFrameworkCore.Migrations;

namespace tfzr_rsok_autosalon.Data.Migrations
{
    public partial class CarModelsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "CarModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "CarModels",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "CarModels");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "CarModels");
        }
    }
}
