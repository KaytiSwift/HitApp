using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class LinkedExpensesToProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Expenses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1,
                column: "ProjectId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ProjectId",
                table: "Expenses",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Projects_ProjectId",
                table: "Expenses",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Projects_ProjectId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_ProjectId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Expenses");
        }
    }
}
