using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IssueReporter.Migrations
{
    public partial class assigneeid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssigneeId",
                table: "Issues",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssigneeId",
                table: "Issues");
        }
    }
}
