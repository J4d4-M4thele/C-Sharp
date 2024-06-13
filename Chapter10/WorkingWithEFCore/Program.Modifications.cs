﻿using Microsoft.EntityFrameworkCore; //for ExecuteUpdate, ExecuteDelete
using Microsoft.EntityFrameworkCore.ChangeTracking; //for useEntityEntry<T>
using Northwind.EntityModels; //for Northwind, Product

partial class Program
{
    //READ
    private static void ListProducts(
        int[]? productIdsToHighlight = null)
    {
        using NorthwindDb db = new();

        if (db.Products is null || !db.Products.Any()) 
        {
            Fail("There are no products.");
            return;
        }

        WriteLine("| {0,-3} | {1,-35} | {2,8} | {3,5} | {4} |",
        "Id", "Product Name", "Cost", "Stock", "Disc.");

        foreach (Product p in db.Products)
        {
            ConsoleColor prevColor = ForegroundColor;

            if(productIdsToHighlight is not null && productIdsToHighlight.Contains(p.ProductId))
            {
                ForegroundColor = prevColor;
            }

            WriteLine("| {0:000} | {1,-35} | {2,8:$#,##0.00} | {3,5} | {4} |",
                    p.ProductId, p.ProductName, p.Cost, p.Stock, p.Discontinued);
            ForegroundColor = prevColor;
        }
    }

    //CREATE
    //returns a tuple (2 integer)
    private static (int affected, int productId) AddProduct(
        int categoryId, string productName, decimal? price, short? stock)
    {
        using NorthwindDb db = new();

        Product p = new()
        { 
            CategoryId = categoryId,
            ProductName = productName,
            Cost = price,
            Stock = stock
        };

        //set product as added in change tracking
        EntityEntry<Product> entity = db.Products.Add(p);
        WriteLine($"State: {entity.State}, ProductId: {p.ProductId}");

        //saves tracked change to db
        int affected = db.SaveChanges();
        WriteLine($"State: {entity.State}, ProductId: {p.ProductId}");

        return (affected, p.ProductId);
    }

    //UPDATE
    private static (int affected, int productId) IncreaseProductPrice(
        string productNameStartsWith, decimal amount)
    {
        using NorthwindDb db = new();

        if (db.Products is null) return (0, 0);

        Product updateProduct = db.Products.First(
        p => p.ProductName.StartsWith(productNameStartsWith));

        updateProduct.Cost += amount;

        int affected = db.SaveChanges();
        return (affected, updateProduct.ProductId);
    }

    private static int DeleteProducts(string productNameStartsWith)
    {
        using NorthwindDb db = new();

        IQueryable<Product>? products = db.Products?.Where(
        p => p.ProductName.StartsWith(productNameStartsWith));

        if (products is null || !products.Any())
        {
            WriteLine("No products found to delete.");
            return 0;
        }
        else
        {
            if (db.Products is null) return 0;
            db.Products.RemoveRange(products);
        }

        int affected = db.SaveChanges();
        return affected;
    }
}
