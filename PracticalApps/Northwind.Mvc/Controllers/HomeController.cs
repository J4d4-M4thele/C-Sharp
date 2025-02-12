using Microsoft.AspNetCore.Mvc;
using Northwind.Mvc.Models;
using System.Diagnostics;
using Northwind.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Northwind.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //CH 14
        private readonly NorthwindContext _db;
        private readonly IHttpClientFactory _clientFactory;

        public HomeController(ILogger<HomeController> logger,
            NorthwindContext db,
            IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _db = db;
            _clientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Customers(string country)
        {
            string uri;
            if (string.IsNullOrEmpty(country))
            {
                ViewData["Title"] = "All Customers Worldwide";
                uri = "api/customers";
            }
            else
            {
                ViewData["Title"] = $"Customers in {country}";
                uri = $"api/customers/?country={country}";
            }
            HttpClient client = _clientFactory.CreateClient(
            name: "Northwind.WebApi");
            HttpRequestMessage request = new(
            method: HttpMethod.Get, requestUri: uri);
            HttpResponseMessage response = await client.SendAsync(request);
            IEnumerable<Customer>? model = await response.Content
            .ReadFromJsonAsync<IEnumerable<Customer>>();
            return View(model);
        }
    }
}
