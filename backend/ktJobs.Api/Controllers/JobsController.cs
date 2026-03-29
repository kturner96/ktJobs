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
    public async Task<IActionResult> GetAllJobs()
    {
        var jobs = await _db.Jobs.ToListAsync();
        return Ok(jobs);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<JobListingDto>> GetJob(int id)
    {
        var job = await _db.Jobs.FindAsync(id);

        if (job == null)
        {
            return NotFound();
        }

        return Ok(job);
    }
}