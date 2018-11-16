using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Migrations
{
    public partial class AddProjectSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectContractorInfo", "ProjectDescription", "ProjectEndDate", "ProjectName", "ProjectStartDate", "ProjectTotalBudget" },
                values: new object[] { 1, "Jimmy the Tile Guy", "Paint and re-tile bathroom walls and floors", new DateTime(2018, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bathroom", new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1);
        }
    }
}
