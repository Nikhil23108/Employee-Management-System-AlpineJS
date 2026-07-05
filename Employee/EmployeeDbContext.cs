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
        var cloudConnectionString = Environment.GetEnvironmentVariable("MYSQL_CONNECTION_STRING");

        if (!string.IsNullOrEmpty(cloudConnectionString))
        {
            optionsBuilder.UseMySql(cloudConnectionString, ServerVersion.AutoDetect(cloudConnectionString));
        }
        else
        {
            var localString = "Server=172.17.64.1;Database=shop4;Uid=root;Pwd=root;";
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
