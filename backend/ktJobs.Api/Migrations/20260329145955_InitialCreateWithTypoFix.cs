using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ktJobs.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateWithTypoFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Company = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    Salary = table.Column<string>(type: "text", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    PostedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsRemote = table.Column<bool>(type: "boolean", nullable: false),
                    Source = table.Column<string>(type: "text", nullable: false),
                    SourceJobId = table.Column<string>(type: "text", nullable: false),
                    CollectedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CollectedDate", "Company", "Description", "IsRemote", "Location", "PostedDate", "Salary", "Source", "SourceJobId", "Status", "Title", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), "TechStream Solutions", "A great opportunity to start your backend career in a supportive team environment.", true, "Remote", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc), "£35,000 - £45,000", "LinkedIn", "LI-001", 0, "Junior Backend Developer", "https://www.linkedin.com" },
                    { 2, new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), "BrightBox Media", "Looking for a developer to bridge the gap between our React frontend and C# API.", false, "London", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc), "£50,000", "Indeed", "IND-002", 1, "Full Stack Engineer", "https://www.indeed.com" },
                    { 3, new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Global Logistics", "Focus on building robust middleware and third-party API integrations for our logistics platform.", false, "Manchester", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Competitive", "Reed", "RE-003", 0, "API Integration Specialist", "https://www.reed.co.uk" },
                    { 4, new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), "StartUp Inc", "We value transferable skills. Perfect first role for someone moving from IT support into development.", true, "Birmingham", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc), "£32,000", "Glassdoor", "GD-004", 3, "Junior Software Engineer", "https://www.glassdoor.com" },
                    { 5, new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), "FinTech Collective", "Deep dive into .NET 8 and high-performance financial data processing.", true, "Remote", new DateTime(2026, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc), "£60,000", "Totaljobs", "TJ-005", 2, ".NET Backend Developer", "https://www.totaljobs.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
