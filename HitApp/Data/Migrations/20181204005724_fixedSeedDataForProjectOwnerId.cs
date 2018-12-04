using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class fixedSeedDataForProjectOwnerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectOwnerId",
                value: "7fdacf8b-3c46-4b86-b088-cc7a70a97c80");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectOwnerId",
                value: "7fdacf8b - 3c46 - 4b86 - b088 - cc7a70a97c80");
        }
    }
}
