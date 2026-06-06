using Microsoft.EntityFrameworkCore;

namespace SecureOpsAPI;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<OperationalRecord> Records { get; set; }
}