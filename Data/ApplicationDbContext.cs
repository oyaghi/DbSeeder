using DbSeeder.Models;
using Microsoft.EntityFrameworkCore;

namespace DbSeeder.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Company> Companies { get; set; } = null!;

    public DbSet<Employee> Employees { get; set; } = null!;
}