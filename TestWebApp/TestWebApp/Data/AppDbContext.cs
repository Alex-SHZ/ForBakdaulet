using Microsoft.EntityFrameworkCore;
using TestWebApp.Model;

namespace TestWebApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<TestClass> TestClasses { get; set; }
}