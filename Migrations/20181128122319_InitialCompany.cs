using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobbook.Migrations
{
    public partial class InitialCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobbookCompanyModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobbookCompanyName = table.Column<string>(nullable: true),
                    JobbookCompanyDescription = table.Column<string>(nullable: true),
                    JobbookCompanyWebsite = table.Column<string>(nullable: true),
                    JobbookCompanyEmail = table.Column<string>(nullable: true),
                    JobbookCompanyTel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobbookCompanyModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobbookCompanyModel");
        }
    }
}
