using Microsoft.EntityFrameworkCore.Migrations;

namespace HitApp.Data.Migrations
{
    public partial class KyleUsernameLinkedToSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectOwnerId",
                value: "8c3d65a8-8252-420c-aeaf-3ae2f758ce2a");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectOwnerId",
                value: "8c3d65a8-8252-420c-aeaf-3ae2f758ce2a");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectOwnerId",
                value: "8c3d65a8-8252-420c-aeaf-3ae2f758ce2a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "ProjectOwnerId",
                value: "7fdacf8b-3c46-4b86-b088-cc7a70a97c80");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "ProjectOwnerId",
                value: "7fdacf8b-3c46-4b86-b088-cc7a70a97c80");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "ProjectOwnerId",
                value: "7fdacf8b-3c46-4b86-b088-cc7a70a97c80");
        }
    }
}
