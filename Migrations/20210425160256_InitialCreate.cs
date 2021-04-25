using Microsoft.EntityFrameworkCore.Migrations;

namespace Mywebproject_core.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CandidateDetail",
                columns: table => new
                {
                    candidate_id = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    party = table.Column<string>(nullable: true),
                    candidate_status = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateDetail", x => x.candidate_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateDetail");
        }
    }
}
