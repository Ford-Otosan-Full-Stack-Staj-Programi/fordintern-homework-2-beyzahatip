using Homework2.Data.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Homework2.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
    }
   
    public DbSet<Person> Person { get; set; }
    public DbSet<Account> Account { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
