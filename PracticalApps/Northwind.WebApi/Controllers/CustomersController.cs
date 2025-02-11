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
}
