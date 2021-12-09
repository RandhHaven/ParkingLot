using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiServiceEstacionamiento.Migrations
{
    public partial class MigrationsParkingLot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    CarId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(maxLength: 200, nullable: false),
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
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(maxLength: 200, nullable: false),
                    Author = table.Column<string>(maxLength: 200, nullable: false),
                    Tittle = table.Column<string>(maxLength: 200, nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Orden = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Abrevation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.ID);
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

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ModelCar",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameModel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelCar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BrandCar",
                columns: table => new
                {
                    BrandID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBrand = table.Column<string>(nullable: true),
                    ModelCarID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandCar", x => x.BrandID);
                    table.ForeignKey(
                        name: "FK_BrandCar_ModelCar_ModelCarID",
                        column: x => x.ModelCarID,
                        principalTable: "ModelCar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrandCar_ModelCarID",
                table: "BrandCar",
                column: "ModelCarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandCar");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "ModelCar");
        }
    }
}
