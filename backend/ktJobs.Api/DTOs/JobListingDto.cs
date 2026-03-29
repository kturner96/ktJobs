namespace ktJobs.Api.DTOs;

public class JobListingDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Salary { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string PostedDate { get; set; } = string.Empty;
    public bool IsRemote { get; set; }
    public string Status { get; set; } = string.Empty;
}