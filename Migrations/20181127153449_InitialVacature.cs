using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jobbook.Migrations
{
    public partial class InitialVacature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobbookVacatureModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobCompanyID = table.Column<int>(nullable: false),
                    JobPublished = table.Column<DateTime>(nullable: false),
                    JobExpiredDate = table.Column<DateTime>(nullable: false),
                    JobTitle = table.Column<string>(nullable: true),
                    JobDescription = table.Column<string>(nullable: true),
                    JobLocation = table.Column<string>(nullable: true),
                    JobContractType = table.Column<string>(nullable: true),
                    JobContractHours = table.Column<int>(nullable: false),
                    JobSeniority = table.Column<string>(nullable: true),
                    JobSalary = table.Column<int>(nullable: false),
                    JobDaysOff = table.Column<int>(nullable: false),
                    JobExpired = table.Column<bool>(nullable: false),
                    JobContactEmail = table.Column<string>(nullable: true),
                    JobContactTel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobbookVacatureModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobbookVacatureModel");
        }
    }
}
