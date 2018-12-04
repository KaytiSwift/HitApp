using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class CreatedProjectContractorsModelToLinkProjectWithContractor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


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


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropTable(
                name: "ProjectContractors");



        }
    }
}
