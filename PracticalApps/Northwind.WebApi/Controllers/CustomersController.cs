using Microsoft.AspNetCore.Mvc;
using Northwind.EntityModels;
using Northwind.WebApi.Repositories;

namespace Northwind.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : Controller
{
    private readonly ICustomerRepository _repo;

    //initialise repository
    public CustomersController(ICustomerRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Customer>))]
    public async Task<IEnumerable<Customer>> GetCustomers(string? country)
    {
        if (string.IsNullOrWhiteSpace(country))
        {
            return await _repo.RetrieveAllAsync();
        }
        else
        {
            return (await _repo.RetrieveAllAsync())
                .Where(customer => customer.Country == country);
        }
    }

    [HttpGet("{id}", Name = nameof(GetCustomer))] // Named route.
    [ProducesResponseType(200, Type = typeof(Customer))]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetCustomer(string id)
    {
        Customer? c = await _repo.RetrieveAsync(id);
        if (c == null)
        {
            return NotFound();
        }
        return Ok(c);
    }

    [HttpPost]
    [ProducesResponseType(201, Type = typeof(Customer))]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] Customer c)
    {
        if (c == null)
        {
            return BadRequest();
        }
        Customer? addedCustomer = await _repo.CreateAsync(c);

        if (addedCustomer == null)
        {
            return BadRequest("Repository failed to create customer.");
        }
        else
        {
            return CreatedAtRoute( // 201 Created.
                routeName: nameof(GetCustomer),
                routeValues: new { id = addedCustomer.CustomerId.ToLower() },
                value: addedCustomer
            );
        }
    }

    [HttpPut]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update(string id, [FromBody] Customer c)
    {
        id = id.ToUpper();
        c.CustomerId = c.CustomerId.ToUpper();
        if(c == null || c.CustomerId != id)
        {
            return BadRequest();//400
        }
        Customer? existing = await _repo.RetrieveAsync(id);
        if(existing == null)
        {
            return NotFound();//404
        }
        await _repo.UpdateAsync(c);
        return new NoContentResult();//204
    }

    [HttpDelete]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(string id)
    {
        if (id == "bad")
        {
            ProblemDetails problemDetails = new()
            {
                Status = StatusCodes.Status400BadRequest,
                Type = "https://localhost:7193/customers/failed-to-delete",
                Title = $"Customer ID {id} found but failed to delete.",
                Detail = "More details like Company Name, Country and so on.",
                Instance = HttpContext.Request.Path
            };
            return BadRequest(problemDetails); // 400 Bad Request
        }

        Customer? existing = await _repo.RetrieveAsync(id);
        if (existing == null)
        {
            return NotFound();//404
        }
        bool? deleted = await _repo.DeleteAsync(id);
        if (deleted.HasValue && deleted.Value) 
        {
            return new NoContentResult();//204
        }
        else
        {
            return BadRequest($"Customer {id} was found but failed to delete.");//400
        }
    }
}
