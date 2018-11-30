using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class ExpenseCost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpenseTotalCost",
                table: "Expenses",
                newName: "ExpenseCost");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpenseCost",
                table: "Expenses",
                newName: "ExpenseTotalCost");
        }
    }
}
