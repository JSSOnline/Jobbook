using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobbook.Migrations
{
    public partial class InitialProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobbookProfileModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobbookProfileFirstName = table.Column<string>(nullable: true),
                    JobbookProfileLastName = table.Column<string>(nullable: true),
                    JobbookProfileOpen = table.Column<string>(nullable: true),
                    JobbookProfileTitle = table.Column<string>(nullable: true),
                    JobbookProfileDescription = table.Column<string>(nullable: true),
                    JobbookProfilePosts = table.Column<string>(nullable: true),
                    JobbookProfileWork = table.Column<string>(nullable: true),
                    JobbookProfileEducation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobbookProfileModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobbookProfileModel");
        }
    }
}
