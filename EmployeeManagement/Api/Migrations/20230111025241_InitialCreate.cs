using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Information Technology" },
                    { 2, "Humar Resources" },
                    { 3, "Payroll" },
                    { 4, "Administration" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DOB", "DepartmentId", "EmailAddress", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Poppy.Li@opus.com", "Poppy", 1, "Li", "images/personStock.jpg" },
                    { 2, new DateTime(1987, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Brad.Baskshi@opus.com", "Brad", 0, "Baskshi", "images/personStock.jpg" },
                    { 3, new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Richard.Hendricks@opus.com", "Richard", 0, "Hendricks", "images/personStock.jpg" },
                    { 4, new DateTime(1980, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Malcolm.Adekanbi@opus.com", "Malcolm", 0, "Adekanbi", "images/personStock.jpg" },
                    { 5, new DateTime(1986, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Elliot.Alderson@opus.com", "Elliot", 0, "Alderson", "images/personStock.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
