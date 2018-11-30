using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class LinkedProjectToContractorsAndHaveSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_ProjectContractors_ProjectContractorId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectContractors_ProjectContractorId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectContractorId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Contractors_ProjectContractorId",
                table: "Contractors");

            migrationBuilder.DropColumn(
                name: "ProjectContractorId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectContractorId",
                table: "Contractors");

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

            migrationBuilder.AddColumn<int>(
                name: "ProjectContractorId",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectContractorId",
                table: "Contractors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectContractorId",
                table: "Projects",
                column: "ProjectContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contractors_ProjectContractorId",
                table: "Contractors",
                column: "ProjectContractorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contractors_ProjectContractors_ProjectContractorId",
                table: "Contractors",
                column: "ProjectContractorId",
                principalTable: "ProjectContractors",
                principalColumn: "ProjectContractorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectContractors_ProjectContractorId",
                table: "Projects",
                column: "ProjectContractorId",
                principalTable: "ProjectContractors",
                principalColumn: "ProjectContractorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
