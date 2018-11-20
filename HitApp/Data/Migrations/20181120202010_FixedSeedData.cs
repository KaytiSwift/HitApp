using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class FixedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ExpenseName",
                table: "Expenses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "ProjectDescription", "ProjectName", "ProjectStartDate", "ProjectTotalBudget" },
                values: new object[] { "Paint and re-tile kitchen walls and floors", "Kitchen", new DateTime(2017, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 12000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ExpenseName",
                table: "Expenses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "ProjectDescription", "ProjectName", "ProjectStartDate", "ProjectTotalBudget" },
                values: new object[] { "Paint and re-tile bathroom walls and floors", "kitchen", new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000.0 });
        }
    }
}
