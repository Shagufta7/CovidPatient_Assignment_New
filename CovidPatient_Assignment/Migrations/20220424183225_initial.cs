using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CovidPatient_Assignment.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportNumber = table.Column<int>(type: "int", nullable: false),
                    Emirates_ID = table.Column<int>(type: "int", nullable: false),
                    Emirate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstDose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondDose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdDose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForthDose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordCreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
