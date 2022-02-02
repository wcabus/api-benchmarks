using Shared;

namespace MinimalApi
{
    public static class Endpoints
    {
        public static async Task<IResult> Fibonacci(FibonacciService service)
        {
            var items = await service.GetItemsAsync();
            return Results.Ok(items);
        }
    }
}