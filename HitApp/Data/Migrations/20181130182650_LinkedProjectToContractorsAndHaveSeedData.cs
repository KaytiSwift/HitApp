using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class LinkedProjectToContractorsAndHaveSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "ProjectOwnerId",
                table: "Projects",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectContractors_ContractorId",
                table: "ProjectContractors",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectContractors_ProjectId",
                table: "ProjectContractors",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectContractors_Contractors_ContractorId",
                table: "ProjectContractors",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "ContractorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectContractors_Projects_ProjectId",
                table: "ProjectContractors",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectContractors_Contractors_ContractorId",
                table: "ProjectContractors");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectContractors_Projects_ProjectId",
                table: "ProjectContractors");

            migrationBuilder.DropIndex(
                name: "IX_ProjectContractors_ContractorId",
                table: "ProjectContractors");

            migrationBuilder.DropIndex(
                name: "IX_ProjectContractors_ProjectId",
                table: "ProjectContractors");

            migrationBuilder.DropColumn(
                name: "ProjectOwnerId",
                table: "Projects");
        }
    }
}
