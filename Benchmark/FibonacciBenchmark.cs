using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    [HtmlExporter]
    public class FibonacciBenchmark
    {
        [Params(100, 200)] public int IterationCount;

        private readonly BenchmarkHttpClient _client = new BenchmarkHttpClient();

        [Benchmark]
        public async Task RunControllerGetAsync()
        {
            for (var i = 0; i < IterationCount; i++)
            {
                await _client.GetViaControllerAsync();
            }
        }

        [Benchmark]
        public async Task RunLambdaGetAsync()
        {
            for (var i = 0; i < IterationCount; i++)
            {
                await _client.GetViaLambdaAsync();
            }
        }

        [Benchmark]
        public async Task RunStaticMethodGetAsync()
        {
            for (var i = 0; i < IterationCount; i++)
            {
                await _client.GetViaStaticMethodAsync();
            }
        }
    }
}