using Microsoft.EntityFrameworkCore; // for DbContext

namespace Northwind.EntityModels;

public class NorthwindDb : DbContext
{
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
    }
}
