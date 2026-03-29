using ktJobs.Api.Domain;
using ktJobs.Api.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ktJobs.Api.Data.Configurations;

public class JobListingConfiguration : IEntityTypeConfiguration<JobListing>
{
    public void Configure(EntityTypeBuilder<JobListing> builder)
    {
        builder.HasData(
    new JobListing
    {
        Id = 1,
        Source = "LinkedIn",
        SourceJobId = "LI-001",
        Title = "Junior Backend Developer",
        Company = "TechStream Solutions",
        Location = "Remote",
        Salary = "£35,000 - £45,000",
        Url = "https://www.linkedin.com",
        Description = "A great opportunity to start your backend career in a supportive team environment.",
        PostedDate = DateTime.SpecifyKind(new DateTime(2026, 3, 10), DateTimeKind.Utc),
        CollectedDate = DateTime.SpecifyKind(new DateTime(2026, 3, 29), DateTimeKind.Utc),
        IsRemote = true,
        Status = JobStatus.New
    },
    new JobListing
    {
        Id = 2,
        Source = "Indeed",
        SourceJobId = "IND-002",
        Title = "Full Stack Engineer",
        Company = "BrightBox Media",
        Location = "London",
        Salary = "£50,000",
        Url = "https://www.indeed.com",
        Description = "Looking for a developer to bridge the gap between our React frontend and C# API.",
        PostedDate = DateTime.SpecifyKind(new DateTime(2026, 3, 10), DateTimeKind.Utc),
        CollectedDate = DateTime.SpecifyKind(new DateTime(2026, 3, 29), DateTimeKind.Utc),
        IsRemote = false,
        Status = JobStatus.Saved
    },
    new JobListing
    {
        Id = 3,
        Source = "Reed",
        SourceJobId = "RE-003",
        Title = "API Integration Specialist",
        Company = "Global Logistics",
        Location = "Manchester",
        Salary = "Competitive",
        Url = "https://www.reed.co.uk",
        Description = "Focus on building robust middleware and third-party API integrations for our logistics platform.",
        PostedDate = DateTime.SpecifyKind(new DateTime(2026, 3, 10), DateTimeKind.Utc),
        CollectedDate = DateTime.SpecifyKind(new DateTime(2026, 3, 29), DateTimeKind.Utc),
        IsRemote = false,
        Status = JobStatus.New
    },
    new JobListing
    {
        Id = 4,
        Source = "Glassdoor",
        SourceJobId = "GD-004",
        Title = "Junior Software Engineer",
        Company = "StartUp Inc",
        Location = "Birmingham",
        Salary = "£32,000",
        Url = "https://www.glassdoor.com",
        Description = "We value transferable skills. Perfect first role for someone moving from IT support into development.",
        PostedDate = DateTime.SpecifyKind(new DateTime(2026, 3, 10), DateTimeKind.Utc),
        CollectedDate = DateTime.SpecifyKind(new DateTime(2026, 3, 29), DateTimeKind.Utc),
        IsRemote = true,
        Status = JobStatus.Applied
    },
    new JobListing
    {
        Id = 5,
        Source = "Totaljobs",
        SourceJobId = "TJ-005",
        Title = ".NET Backend Developer",
        Company = "FinTech Collective",
        Location = "Remote",
        Salary = "£60,000",
        Url = "https://www.totaljobs.com",
        Description = "Deep dive into .NET 8 and high-performance financial data processing.",
        PostedDate = DateTime.SpecifyKind(new DateTime(2026, 3, 10), DateTimeKind.Utc),
        CollectedDate = DateTime.SpecifyKind(new DateTime(2026, 3, 29), DateTimeKind.Utc),
        IsRemote = true,
        Status = JobStatus.Ignored
    }
);
    }
}