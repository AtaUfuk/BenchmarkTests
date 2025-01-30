
using BenchmarkDotNet.Running;
using LinqAnyVsAll;
#region Check for fake data generation
//MyBenchmark benchmark = new();
//Console.Write(benchmark.LinqAny());
#endregion
var summary = BenchmarkRunner.Run<MyBenchmark>();
Console.ReadKey();
