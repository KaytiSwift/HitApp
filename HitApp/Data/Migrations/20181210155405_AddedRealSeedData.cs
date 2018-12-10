using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class AddedRealSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "ContractorId",
                keyValue: 1,
                columns: new[] { "ContractorAdditionalNotes", "ContractorAddress", "ContractorCompany", "ContractorPhone", "ContractorService", "ContractorZip" },
                values: new object[] { "Start 10/2, projected end date 11/2. $8,200 labor", "1234 Mian Steet", "TecTile", "216-453-0983", "mainly Tile", 44075 });

            migrationBuilder.InsertData(
                table: "Contractors",
                columns: new[] { "ContractorId", "ContractorAdditionalNotes", "ContractorAddress", "ContractorCity", "ContractorCompany", "ContractorEmail", "ContractorName", "ContractorPhone", "ContractorService", "ContractorState", "ContractorWebsiteUrl", "ContractorZip" },
                values: new object[,]
                {
                    { 2, "Install new electric box for house,electric baseboard heaters in basement, and outlets in Kitchen island. $3,376 total", "990 Erie Road, Unit P", "Eastlake", "Streb Electric", "", "Kevin and Lance", "440-953-5819", "Electric", "Ohio", null, 44095 },
                    { 3, "Works at TecTile with Jimmy", "1234 Mian Steet", "Madison", "TecTile", "tectile@live.com", "Jamie Smith", "216-453-0983", "Painting", "Ohio", null, 44075 }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "ProjectEndDate", "ProjectName", "ProjectStartDate", "ProjectTotalBudget" },
                values: new object[] { new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Upstairs Bathroom", new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000.0 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "ProjectDescription", "ProjectEndDate", "ProjectStartDate", "ProjectTotalBudget" },
                values: new object[] { "Paint and re-finish wood floors. Electricty in island and other new appliances", new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9000.0 });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectDescription", "ProjectEndDate", "ProjectIsOnDashboard", "ProjectName", "ProjectOwnerId", "ProjectStartDate", "ProjectTotalBudget", "ProjectTotalExpenses" },
                values: new object[] { 3, "Take out part of basement wall, add baseboard heaters", new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Basement", "7fdacf8b-3c46-4b86-b088-cc7a70a97c80", new DateTime(2018, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000.0, 0.0 });

            migrationBuilder.InsertData(
                table: "ProjectContractors",
                columns: new[] { "ProjectContractorId", "ContractorId", "ProjectId" },
                values: new object[,]
                {
                    { 4, 2, 2 },
                    { 6, 3, 1 },
                    { 7, 3, 2 },
                    { 3, 1, 3 },
                    { 5, 2, 3 },
                    { 8, 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectContractors",
                keyColumn: "ProjectContractorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectContractors",
                keyColumn: "ProjectContractorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProjectContractors",
                keyColumn: "ProjectContractorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProjectContractors",
                keyColumn: "ProjectContractorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProjectContractors",
                keyColumn: "ProjectContractorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProjectContractors",
                keyColumn: "ProjectContractorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contractors",
                keyColumn: "ContractorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contractors",
                keyColumn: "ContractorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "ContractorId",
                keyValue: 1,
                columns: new[] { "ContractorAdditionalNotes", "ContractorAddress", "ContractorCompany", "ContractorPhone", "ContractorService", "ContractorZip" },
                values: new object[] { "Jimmy the tile guy", null, "Self", null, null, null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                columns: new[] { "ProjectEndDate", "ProjectName", "ProjectStartDate", "ProjectTotalBudget" },
                values: new object[] { new DateTime(2018, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bathroom", new DateTime(2017, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000.0 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                columns: new[] { "ProjectDescription", "ProjectEndDate", "ProjectStartDate", "ProjectTotalBudget" },
                values: new object[] { "Paint and re-tile kitchen walls and floors", new DateTime(2018, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 12000.0 });
        }
    }
}
