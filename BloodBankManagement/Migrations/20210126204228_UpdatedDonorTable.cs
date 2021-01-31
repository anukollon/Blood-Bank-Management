using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodBankManagement.Migrations
{
    public partial class UpdatedDonorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Donors");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Donors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Donors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Donors");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Donors",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
