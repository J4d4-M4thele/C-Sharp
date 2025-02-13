//CH 14
using Microsoft.AspNetCore.Mvc.Formatters; // To use IOutputFormatter.
using Northwind.EntityModels; // To use AddNorthwindContext method.
using Microsoft.Extensions.Caching.Memory; // To use IMemoryCache and so on.
using Swashbuckle.AspNetCore.SwaggerUI; // To use SubmitMethod.
using Microsoft.AspNetCore.HttpLogging;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore; // To use HttpLoggingFields.
using System.Net;

var builder = WebApplication.CreateBuilder(args);

//CH 14: configuring database 
//builder.Services.AddDbContext<NorthwindContext>(options =>
//    options.UseSqlite(builder.Configuration.GetConnectionString("NorthwindDatabase")));
builder.Services.AddNorthwindContext();

// Add services to the container.
builder.Services.AddControllersWithViews();

//CH 14: Configuring api
builder.Services.AddHttpClient(name: "Northwind.WebApi",
  configureClient: options =>
  {
      options.DefaultRequestVersion = HttpVersion.Version30;
      options.DefaultVersionPolicy = HttpVersionPolicy.RequestVersionExact;

      options.BaseAddress = new Uri("https://localhost:7193/");
      options.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue(
        mediaType: "application/json", quality: 1.0));
  });

builder.Services.AddHttpClient(name: "Northwind.MinimalApi",
  configureClient: options =>
  {
      options.BaseAddress = new Uri("http://localhost:7078/");
      options.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue(
        "application/json", 1.0));
  });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
