using Microsoft.EntityFrameworkCore.Migrations;

namespace Hackathon_Greenhouse.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SensorData",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    temp = table.Column<double>(type: "REAL", nullable: false),
                    humidity = table.Column<double>(type: "REAL", nullable: false),
                    fan = table.Column<bool>(type: "INTEGER", nullable: false),
                    pump = table.Column<bool>(type: "INTEGER", nullable: false),
                    fan_power = table.Column<double>(type: "REAL", nullable: false),
                    pump_power = table.Column<double>(type: "REAL", nullable: false),
                    led_strip_matrix = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorData", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SensorData");
        }
    }
}
