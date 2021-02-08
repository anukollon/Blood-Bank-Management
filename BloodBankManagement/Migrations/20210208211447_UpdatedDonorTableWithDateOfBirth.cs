using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodBankManagement.Migrations
{
    public partial class UpdatedDonorTableWithDateOfBirth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Donors",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Donors",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
