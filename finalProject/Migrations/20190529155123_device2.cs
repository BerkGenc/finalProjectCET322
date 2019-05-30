using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace finalProject.Migrations
{
    public partial class device2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    deviceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    deviceName = table.Column<string>(nullable: true),
                    deviceOwner = table.Column<string>(nullable: true),
                    deviceIP = table.Column<string>(nullable: true),
                    deviceMACaddress = table.Column<string>(nullable: true),
                    deviceCPUmodel = table.Column<string>(nullable: true),
                    deviceCPUspeed = table.Column<int>(nullable: false),
                    deviceRAM = table.Column<int>(nullable: false),
                    deviceDisk = table.Column<int>(nullable: false),
                    deviceSituation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.deviceID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Device");
        }
    }
}
