using ktJobs.Api.Domain;

namespace ktJobs.Api.DTOs;

public class UpdateJobStatusRequest
{
    public JobStatus Status { get; set; }
}