using JWT_advanced.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWT_advanced.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}
