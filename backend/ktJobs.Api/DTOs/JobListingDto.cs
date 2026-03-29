namespace ktJobs.Api.Domain;

public class JobListingDto
{
    public int Id { get; set; }
    public string Source { get; set; } = string.Empty;
    public string SourceJobId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Salary { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string DescriptionShort { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime PostedDate { get; set; }
    public DateTime CollectedDate { get; set; }
    public bool IsRemote { get; set; }
    public bool IsHybrid { get; set; }
    public JobStatus Status { get; set; } = JobStatus.New;
}

public enum JobStatus {New, Ignored, Applied, Saved}