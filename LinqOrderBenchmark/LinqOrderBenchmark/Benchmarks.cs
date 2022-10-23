using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOrderBenchmark
{
    [MemoryDiagnoser(false)]
    public class ArrayBenchmarks
    {
        private readonly Random _random = new(420);

        private int[] _items;

        [GlobalSetup]
        public void Setup()
        {
            _items = Enumerable.Range(0, 100).Select(_ => _random.Next()).ToArray();
        }

        [Benchmark]
        public int[] OrderBy()
        {
            var items = Enumerable.Range(0, 100).Select(_ => _random.Next()).ToArray();
            return items.OrderBy(x => x).ToArray();
        }

        [Benchmark]
        public int[] Order()
        {
            var items = Enumerable.Range(0, 100).Select(_ => _random.Next()).ToArray();
            return items.Order().ToArray();
        }

        [Benchmark]
        public int[] Sort()
        {
            var items = Enumerable.Range(0, 100).Select(_ => _random.Next()).ToArray();
            Array.Sort(items);
            return items;
        }

        [Benchmark]
        public int[] SpanSort()
        {
            Span<int> spanItems = Enumerable.Range(0, 100).Select(_ => _random.Next()).ToArray();
            spanItems.Sort();
            return spanItems.ToArray();
        }
        //[Benchmark]
        //public int[] OrderByDesc() => _items.OrderByDescending(x => x).ToArray();

        //[Benchmark]
        //public int[] OrderDesc() => _items.OrderDescending().ToArray();

    }

    [MemoryDiagnoser(false)]
    public class ListBenchmarks
    {
        private readonly Random _random = new(420);

        private List<int> _items;

        [GlobalSetup]
        public void Setup()
        {
            _items = Enumerable.Range(0, 100).Select(_ => _random.Next()).ToList();
        }

        [Benchmark]
        public int[] OrderBy() => _items.OrderBy(x => x).ToArray();

        [Benchmark]
        public int[] Order() => _items.Order().ToArray();

        [Benchmark]
        public int[] OrderByDesc() => _items.OrderByDescending(x => x).ToArray();

        [Benchmark]
        public int[] OrderDesc() => _items.OrderDescending().ToArray();

    }
}
