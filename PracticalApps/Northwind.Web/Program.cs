var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

#region Configuring Http pipeline and routes
//if app is not in development mode
if(!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseDefaultFiles();//will serve .html files
app.UseStaticFiles();

app.MapGet("/hello", () => $"Environment is {app.Environment.EnvironmentName}");
#endregion
//starts web server, hosts website an waits for requests
app.Run();//thread-blocking call

WriteLine("This executes after web server has stopped!");
