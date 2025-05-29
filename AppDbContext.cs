using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // Dodaj DbSet-y, np.:
    // public DbSet<User> Users { get; set; }
}
