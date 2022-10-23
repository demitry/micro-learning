Console.WriteLine("Linq Order Benchmark");

var random = new Random(420);

var items = Enumerable.Range(1, 100).Select(x => random.Next());

var ordered = items.OrderBy(x => x).ToArray();

var orderedDesc = items.OrderByDescending(x => x).ToArray();