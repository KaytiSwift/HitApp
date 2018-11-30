using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class CreatedProjectContractorsModelToLinkProjectWithContractor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectContractorId",
                table: "Projects",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "ProjectContractorId",
                table: "Contractors",
                nullable: false);

            migrationBuilder.CreateTable(
                name: "ProjectContractors",
                columns: table => new
                {
                    ProjectContractorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectId = table.Column<int>(nullable: false),
                    ContractorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectContractors", x => x.ProjectContractorId);
                });

            migrationBuilder.InsertData(
                table: "ProjectContractors",
                columns: new[] { "ProjectContractorId", "ContractorId", "ProjectId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "ProjectContractors",
                columns: new[] { "ProjectContractorId", "ContractorId", "ProjectId" },
                values: new object[] { 2, 1, 2 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_ProjectContractors_ProjectContractorId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectContractors_ProjectContractorId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "ProjectContractors");

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
        }
    }
}
