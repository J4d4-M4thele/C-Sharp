//CH 14
using Microsoft.AspNetCore.Mvc.Formatters; // To use IOutputFormatter.
using Northwind.EntityModels; // To use AddNorthwindContext method.
using Microsoft.Extensions.Caching.Memory;
using Northwind.WebApi.Repositories;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.AspNetCore.HttpLogging;

var builder = WebApplication.CreateBuilder(args);

//http-logging (CH 14)
builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = HttpLoggingFields.All;
    options.RequestBodyLogLimit = 4096; // Default is 32k.
    options.ResponseBodyLogLimit = 4096; // Default is 32k.
});

//in-memory cache(CH 14)
builder.Services.AddSingleton<IMemoryCache>(new MemoryCache(new MemoryCacheOptions()));

//add Northwind context (CH 14)
builder.Services.AddNorthwindContext();

// Add services to the container.
builder.Services.AddControllers(options =>
{
    WriteLine("Default output formatters: ");
    foreach (IOutputFormatter formatter in options.OutputFormatters)
    {
        OutputFormatter? mediaFormatter = formatter as OutputFormatter;
        if (mediaFormatter is null)
        {
            WriteLine($"    {formatter.GetType().Name}");
        }
        else
        {
            WriteLine("{0}, Media types: {1}",
                arg0: mediaFormatter.GetType().Name,
                arg1: string.Join(", ",
                mediaFormatter.SupportedMediaTypes));
        }
    }
})
    .AddXmlDataContractSerializerFormatters()
    .AddXmlSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//adding repositories (CH 14)
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

var app = builder.Build();

app.UseHttpLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json",
           "Northwind Service API Version 1");

        c.SupportedSubmitMethods(new[] {
        SubmitMethod.Get, SubmitMethod.Post,
        SubmitMethod.Put, SubmitMethod.Delete });
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
