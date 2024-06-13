using Microsoft.EntityFrameworkCore; // for DbContext
using Microsoft.EntityFrameworkCore.Diagnostics;//for RelationalEventId

namespace Northwind.EntityModels;

public class NorthwindDb : DbContext
{
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }


    //method from DbContext superclass
    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        string databaseFile = "Northwind.db";
        string path = Path.Combine(
            Environment.CurrentDirectory, databaseFile);

        string connectionString = $"Data Source={path}";
        WriteLine($"Connection: {connectionString}");
        optionsBuilder.UseSqlite(connectionString);

        optionsBuilder.LogTo(WriteLine,
            //output ids
            new[] {RelationalEventId.CommandExecuting})//console method
#if DEBUG
            .EnableSensitiveDataLogging()//incl. SQL parameters
            .EnableDetailedErrors()
#endif
            ;
    }

    protected override void OnModelCreating(
        ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .Property(category => category.CategoryName)
            .IsRequired()
            .HasMaxLength(15);

        //global filter to remove discontinued products
        modelBuilder.Entity<Product>()
            .HasQueryFilter(p => !p.Discontinued);

        if (Database.ProviderName?.Contains("sqlite") ?? false)
        {
            modelBuilder.Entity<Product>()
                .Property(product => product.Cost)
                .HasConversion<double>();
        }
    }
}
