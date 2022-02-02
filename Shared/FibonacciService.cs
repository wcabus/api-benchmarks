using System.Collections.ObjectModel;

namespace Shared
{
    public class FibonacciService
    {
        private static readonly List<FibonacciItem> Items = new()
        {
            new FibonacciItem(0, 0),
            new FibonacciItem(1, 1),
            new FibonacciItem(2, 1),
            new FibonacciItem(3, 2),
            new FibonacciItem(4, 3),
            new FibonacciItem(5, 5),
            new FibonacciItem(6, 8),
            new FibonacciItem(7, 13),
            new FibonacciItem(8, 21),
            new FibonacciItem(9, 34),
            new FibonacciItem(10, 55)
        };

        public Task<ReadOnlyCollection<FibonacciItem>> GetItemsAsync() => Task.FromResult(Items.AsReadOnly());
    }
}