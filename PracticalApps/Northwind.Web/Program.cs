var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

#region Configuring Http pipeline and routes
if(!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");
#endregion
//starts web server, hosts website an waits for requests
app.Run();//thread-blocking call

WriteLine("This executes after web server has stopped");
