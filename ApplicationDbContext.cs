using System;

namespace SampleSecureWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(option)
    {
    }

    public DbSet<Student> Students { get; set;} = null!;
}
