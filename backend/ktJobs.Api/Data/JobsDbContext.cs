using ktJobs.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace ktJobs.Api.Data;

public class JobsDbContext : DbContext
{

    public DbSet<JobListing> Jobs => Set<JobListing>();
    
    public JobsDbContext(DbContextOptions<JobsDbContext> options)
        : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(JobsDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}