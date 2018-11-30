using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class ContractorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contractors",
                columns: table => new
                {
                    ContractorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContractorCompany = table.Column<string>(nullable: true),
                    ContractorName = table.Column<string>(nullable: false),
                    ContractorEmail = table.Column<string>(nullable: true),
                    ContractorPhone = table.Column<string>(nullable: true),
                    ContractorAddress = table.Column<string>(nullable: true),
                    ContractorCity = table.Column<string>(nullable: true),
                    ContractorState = table.Column<string>(nullable: true),
                    ContractorZip = table.Column<int>(nullable: true),
                    ContractorAdditionalNotes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractors", x => x.ContractorId);
                });

            migrationBuilder.InsertData(
                table: "Contractors",
                columns: new[] { "ContractorId", "ContractorAdditionalNotes", "ContractorAddress", "ContractorCity", "ContractorCompany", "ContractorEmail", "ContractorName", "ContractorPhone", "ContractorState", "ContractorZip" },
                values: new object[] { 1, "Jimmy the tile guy", null, "Madison", "Self", "tectile@live.com", "Jimmy McDermitt", null, "Ohio", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contractors");
        }
    }
}
