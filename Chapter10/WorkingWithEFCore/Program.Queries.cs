using Microsoft.EntityFrameworkCore; //for Include method
using Northwind.EntityModels; //for Northwind, Category, Product

partial class Program
{
    private static void QueryCategories()
    {
        using NorthwindDb db = new();

        SectionTitle("Categories and how many products they have");

        IQueryable<Category>? categories = db.Categories?
            .Include(c => c.Products);

        if(categories is null || !categories.Any())
        {
            Fail("No categories found.");
            return;
        }

        foreach (Category c in categories)
        {
            WriteLine($"{c.CategoryName} has {c.Products.Count} products.");
        }
    }
}
