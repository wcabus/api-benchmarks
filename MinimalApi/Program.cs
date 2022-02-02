using MinimalApi;
using Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<FibonacciService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/fibonacci-lambda", async (FibonacciService service) =>
{
    var items = await service.GetItemsAsync();
    return Results.Ok(items);
});

app.MapGet("/fibonacci-static", Endpoints.Fibonacci);

app.Run();