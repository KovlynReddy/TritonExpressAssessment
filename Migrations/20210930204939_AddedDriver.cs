using Microsoft.EntityFrameworkCore.Migrations;

namespace TritonExpress.Migrations
{
    public partial class AddedDriver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DriverId",
                table: "Waybills",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "Waybills");
        }
    }
}
