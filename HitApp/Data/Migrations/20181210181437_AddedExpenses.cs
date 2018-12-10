using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class AddedExpenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1,
                columns: new[] { "ExpenseCost", "ExpenseName", "ExpenseNotes", "ProductUrl" },
                values: new object[] { 1039.35, "Vanity", "60 in. Vanity, Home Depot", "https://www.homedepot.com/p/Home-Decorators-Collection-Sonoma-60-in-W-x-22-in-D-Double-Bath-Vanity-in-White-with-Carrara-Marble-Top-with-White-Basins-8105300410/205866623" });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ExpenseId", "ExpenseCost", "ExpenseDatePurchased", "ExpenseName", "ExpenseNotes", "ProductUrl", "ProjectId" },
                values: new object[,]
                {
                    { 2, 95.96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bath Towel Set", "Bronze towel bar set from Home Depot", null, 1 },
                    { 3, 107.74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mirror", "2 mirrors for vanity", null, 1 },
                    { 4, 372.14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tile", "From Home Depot", "https://www.homedepot.com/p/TrafficMASTER-Portland-Stone-Beige-18-in-x-18-in-Glazed-Ceramic-Floor-and-Wall-Tile-17-44-sq-ft-case-PT011818HD1PV/205897841", 1 },
                    { 5, 90.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paint", "BEHR MARQUEE 2 gal. #780F-4 Sparrow One-Coat Hide Satin Enamel Interior Paint and Primer in One", null, 1 },
                    { 6, 150.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamie Painting labor", "", null, 1 },
                    { 7, 2000.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jimmy Tile/construction labor", "", null, 1 },
                    { 8, 3450.89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electric labor", "", null, 2 },
                    { 9, 2470.12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electric labor", "", null, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectTotalBudget",
                value: 3500.0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectTotalBudget",
                value: 3000.0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectTotalBudget",
                value: 2500.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1,
                columns: new[] { "ExpenseCost", "ExpenseName", "ExpenseNotes", "ProductUrl" },
                values: new object[] { 420.0, "TestExpense1", "This is a test", "https://www.homedepot.com/p/Warehouse-of-Tiffany-Stella-12-in-Bronze-Accent-Desk-Lamp-with-Red-Dragonfly-Shade-305RBTL/206800480" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectTotalBudget",
                value: 5000.0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectTotalBudget",
                value: 9000.0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectTotalBudget",
                value: 10000.0);
        }
    }
}
