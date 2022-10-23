//Console.WriteLine("Linq Order Benchmark");
//var random = new Random(420);
//var items = Enumerable.Range(1, 100).Select(x => random.Next());
//var ordered = items.OrderBy(x => x).ToArray();
//var orderedDesc = items.OrderByDescending(x => x).ToArray();

using BenchmarkDotNet.Running;
using LinqOrderBenchmark;

// BenchmarkRunner.Run<ArrayBenchmarks>();

/*
| Method      | Mean     | Error     | StdDev    | Allocated |
| ----------  | ---------| ----------| ----------| --------- |
| OrderBy     | 6.176 us | 0.0572 us | 0.0507 us | 1.83 KB   |
| Order       | 6.173 us | 0.0214 us | 0.0167 us | 1.41 KB   |
| OrderByDesc | 6.904 us | 0.0333 us | 0.0295 us | 1.83 KB   |
| OrderDesc   | 6.724 us | 0.0631 us | 0.0590 us | 1.41 KB   |
*/

/*
| Method    | Mean      | Error     | StdDev    | Allocated |
| --------- | ---------:| ----------:| --------:| ---------:|
| OrderBy   | 9.483 us  | 0.0176 us | 0.0156 us | 2448 B |
| Order     | 9.227 us  | 0.0155 us | 0.0130 us | 2024 B |
| Sort      | 4.129 us  | 0.0113 us | 0.0101 us | 576 B  |
| SpanSort  | 4.277 us  | 0.0164 us | 0.0153 us | 1000 B |
*/

BenchmarkRunner.Run<ListBenchmarks>();
/*
| Method        | Mean | Error | StdDev | Allocated |
| ------------  | ---------:| ----------:| ----------:| ----------:|
| OrderBy       | 6.172 us | 0.0639 us | 0.0597 us | 1.83 KB |
| Order         | 6.238 us | 0.0497 us | 0.0465 us | 1.41 KB |
| OrderByDesc   | 6.865 us | 0.0433 us | 0.0384 us | 1.83 KB |
| OrderDesc     | 6.537 us | 0.0437 us | 0.0409 us | 1.41 KB |
*/