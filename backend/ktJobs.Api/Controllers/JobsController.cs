using ktJobs.Api.Data;
using ktJobs.Api.Domain;
using ktJobs.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ktJobs.Api.Controllers;

[ApiController]
[Route("api/jobs")]
public class JobsController : ControllerBase
{
    private readonly JobsDbContext _db;

    public JobsController(JobsDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<JobListingDto>>> GetAllJobs()
    {
        var jobs = await _db.Jobs.ToListAsync();

        var result = jobs.Select(j => new JobListingDto
        {
            Id = j.Id,
            Title = j.Title,
            Company = j.Company,
            Status = j.Status.ToString(),
            PostedDate = j.PostedDate.ToString("yyyy-M-dd"),
            Description = j.Description,
            IsRemote = j.IsRemote,
            Location = j.Location,
            Salary = j.Salary,
            Url = j.Url
        });
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<JobListingDto>> GetJob(int id)
    {
        var job = await _db.Jobs.FindAsync(id);

        if (job == null)
            return NotFound();

        return Ok(job);
    }

    [HttpPatch("{id:int}/status")]
    public async Task<ActionResult<JobListing>> UpdateJobStatus(int id, UpdateJobStatusRequest request)
    {
        var job = await _db.Jobs.FindAsync(id);

        if (job == null)
            return NotFound();

        job.Status = request.Status;

        await _db.SaveChangesAsync();
        return Ok(job);
    }
}