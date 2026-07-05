using Microsoft.EntityFrameworkCore;

namespace DemoApp.Employee;

public class EmployeeDbContext : DbContext
{
    public DbSet<Emp> Employees { get; set; }
    public DbSet<Dept> Depts { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        // 1. Try to read the live cloud connection string from the environment variable
        var cloudConnectionString = Environment.GetEnvironmentVariable("MYSQL_CONNECTION_STRING");

        if (!string.IsNullOrEmpty(cloudConnectionString))
        {
            optionsBuilder.UseMySql(cloudConnectionString, ServerVersion.AutoDetect(cloudConnectionString));
        }
        else
        {
            // 2. Your fallback local database connection string for testing locally
            var localString = "Server=localhost;Database=emp_db;Uid=root;Pwd=root;";
            optionsBuilder.UseMySql(localString, ServerVersion.AutoDetect(localString));
        }
    }
}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>()
            .HasMany(d => d.Employees)
            .WithOne(e => e.Department)
            .HasForeignKey(e => e.DEPTID);
    }
}