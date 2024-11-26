using FullStackTechTestDotNet.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullStackTechTestDotNet.DataAccessLayer;

public class AppDbContext : DbContext
{
    private string _dbPath = "app.db";

    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={_dbPath}");
    }
}

