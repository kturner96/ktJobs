using ktJobs.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace ktJobs.Api.Data;

public class JobsDbContext : DbContext
{
    public DbSet<JobListingDto> Jobs => Set<JobListingDto>();
    
    public JobsDbContext(DbContextOptions<JobsDbContext> options)
        : base(options) { }
}