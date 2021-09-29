using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TritonExpress.Data.Migrations
{
    public partial class ExpressInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    ItemClass = table.Column<string>(nullable: true),
                    ItemWeight = table.Column<int>(nullable: false),
                    Company = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Parcels",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParcelId = table.Column<string>(nullable: true),
                    ParcelNo = table.Column<string>(nullable: true),
                    RegNo = table.Column<string>(nullable: true),
                    WeightPerUnit = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    ReleventMeasure = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    ItemId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<string>(nullable: true),
                    Branch = table.Column<string>(nullable: true),
                    Make = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    MaxTonnage = table.Column<int>(nullable: false),
                    PlateNo = table.Column<string>(nullable: true),
                    RegNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Waybills",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaybillId = table.Column<string>(nullable: true),
                    ItemId = table.Column<string>(nullable: true),
                    ParcelId = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    InTime = table.Column<DateTime>(nullable: false),
                    ETA = table.Column<DateTime>(nullable: false),
                    OutTime = table.Column<DateTime>(nullable: false),
                    ShipperSigniture = table.Column<string>(nullable: true),
                    ConigeeSigniture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waybills", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Parcels");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Waybills");
        }
    }
}
