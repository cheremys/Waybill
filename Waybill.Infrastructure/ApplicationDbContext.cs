using Microsoft.EntityFrameworkCore;

namespace Waybill.Infrastructure;

public class ApplicationDbContext  : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema("waybill");
    }
}