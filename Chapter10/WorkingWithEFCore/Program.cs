using Northwind.EntityModels;
using NorthwindDb db = new();

//listing the provider
WriteLine($"Provider: {db.Database.ProviderName}");

//calling methods from partial classes
ConfigureConsole();
//QueryCategories();
//FilteredIncludes();
//QueryingProducts();
//GettingOneProduct();
//QueryingWithLike();
LazyLoadingWithNoTracking();