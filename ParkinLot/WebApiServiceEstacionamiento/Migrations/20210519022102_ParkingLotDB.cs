using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiServiceEstacionamiento.Migrations
{
    public partial class ParkingLotDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(maxLength: 200, nullable: false),
                    Model = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    Patent = table.Column<string>(maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(nullable: false),
                    Colour = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.CarId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(maxLength: 15, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileEmployee = table.Column<int>(maxLength: 10, nullable: false),
                    UserEmployee = table.Column<string>(maxLength: 200, nullable: false),
                    NameEmployee = table.Column<string>(maxLength: 200, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Mobile = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
