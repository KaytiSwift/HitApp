using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class shortenContractorDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "ContractorId",
                keyValue: 2,
                column: "ContractorAdditionalNotes",
                value: "Electric box,electric baseboard heaters and outlets in Kitchen island. $3,376 total");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contractors",
                keyColumn: "ContractorId",
                keyValue: 2,
                column: "ContractorAdditionalNotes",
                value: "Install new electric box for house,electric baseboard heaters in basement, and outlets in Kitchen island. $3,376 total");
        }
    }
}
