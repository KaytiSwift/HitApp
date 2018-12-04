using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ProjectTotalExpenses",
                table: "Projects",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectTotalExpenses",
                table: "Projects");
        }
    }
}
