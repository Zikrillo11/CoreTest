using CoreTest.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace CoreTest.DAL.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Option>Options { get; set; }
    public DbSet<Questions> Questions { get; set; }
    public DbSet<Test> Tests { get; set; }
    public DbSet<TestSolution> TestSolutions { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<UserTestSolution> UserTestSolutions { get; set; }

}
