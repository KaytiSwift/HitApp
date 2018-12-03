using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class AddedServiceAndWebsiteToContractorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContractorService",
                table: "Contractors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContractorWebsiteUrl",
                table: "Contractors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractorService",
                table: "Contractors");

            migrationBuilder.DropColumn(
                name: "ContractorWebsiteUrl",
                table: "Contractors");
        }
    }
}
