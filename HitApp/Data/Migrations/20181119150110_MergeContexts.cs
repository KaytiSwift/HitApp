using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class MergeContexts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExpenseName = table.Column<string>(nullable: true),
                    ExpenseTotalCost = table.Column<double>(nullable: false),
                    ExpenseNotes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectStartDate = table.Column<DateTime>(nullable: false),
                    ProjectEndDate = table.Column<DateTime>(nullable: false),
                    ProjectDescription = table.Column<string>(nullable: true),
                    ProjectContractorInfo = table.Column<string>(nullable: true),
                    ProjectTotalBudget = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectContractorInfo", "ProjectDescription", "ProjectEndDate", "ProjectName", "ProjectStartDate", "ProjectTotalBudget" },
                values: new object[] { 1, "Jimmy the Tile Guy", "Paint and re-tile bathroom walls and floors", new DateTime(2018, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bathroom", new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
