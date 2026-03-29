namespace ktJobs.Api.Domain;

public class JobListing
{
    public int Id { get; set; } // Primary Key
    public string Title { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Salary { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime PostedDate { get; set; }
    public bool IsRemote { get; set; }
    
    // Internal
    public string Source { get; set; } = string.Empty;
    public string SourceJobId { get; set; } = string.Empty; 
    public DateTime CollectedDate { get; set; }
    public JobStatus Status { get; set; } = JobStatus.New;
}

public enum JobStatus {New, Saved, Ignored, Applied}