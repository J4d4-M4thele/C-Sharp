using Microsoft.EntityFrameworkCore.ChangeTracking; // To use EntityEntry<T>.
using Northwind.EntityModels; // To use Customer.
using Microsoft.Extensions.Caching.Memory; // To use IMemoryCache.
using Microsoft.EntityFrameworkCore; // To use ToArrayAsync.

namespace Northwind.WebApi.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly IMemoryCache _memoryCache;

    private readonly MemoryCacheEntryOptions _cacheEntryOptions = new() 
    { 
        SlidingExpiration = TimeSpan.FromMinutes(30)
    };

    private NorthwindContext _db;

    public CustomerRepository(NorthwindContext db, IMemoryCache memoryCache)
    {
        _db = db;
        _memoryCache = memoryCache;
    }

    //implement CRUD functionality
    public async Task<Customer?> CreateAsync(Customer c) 
    { }

    public Task<Customer[]> RetrieveAllAsync()
    { }

    public Task<Customer?> RetrieveAsync(string id)
    { }

    public async Task<Customer?> UpdateAsync(Customer c)
    { }

    public async Task<bool?> DeleteAsync(string id)
    { }
}
