using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class AddedProductUrlToExpenseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductUrl",
                table: "Expenses",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1,
                column: "ProductUrl",
                value: "https://www.homedepot.com/p/Warehouse-of-Tiffany-Stella-12-in-Bronze-Accent-Desk-Lamp-with-Red-Dragonfly-Shade-305RBTL/206800480");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductUrl",
                table: "Expenses");
        }
    }
}
