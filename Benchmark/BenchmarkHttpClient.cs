using System.Net.Http.Headers;
using System.Net.Http.Json;
using Shared;

namespace Benchmark
{
    public class BenchmarkHttpClient
    {
        private static readonly HttpClient Client;

        static BenchmarkHttpClient()
        {
            Client = new HttpClient();

            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<FibonacciItem>?> GetViaControllerAsync()
        {
            return await Client.GetFromJsonAsync<List<FibonacciItem>>("https://localhost:44380/fibonacci");
        }

        public async Task<List<FibonacciItem>?> GetViaLambdaAsync()
        {
            return await Client.GetFromJsonAsync<List<FibonacciItem>>("https://localhost:44381/fibonacci-lambda");
        }

        public async Task<List<FibonacciItem>?> GetViaStaticMethodAsync()
        {
            return await Client.GetFromJsonAsync<List<FibonacciItem>>("https://localhost:44381/fibonacci-static");
        }
    }
}