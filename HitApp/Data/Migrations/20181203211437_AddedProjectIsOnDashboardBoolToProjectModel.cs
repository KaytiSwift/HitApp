using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class AddedProjectIsOnDashboardBoolToProjectModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ProjectIsOnDashboard",
                table: "Projects",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "ContractorZip",
                table: "Contractors",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "ContractorId",
                keyValue: 1,
                column: "ContractorZip",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectIsOnDashboard",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "ContractorZip",
                table: "Contractors",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "ContractorId",
                keyValue: 1,
                column: "ContractorZip",
                value: 0);
        }
    }
}
