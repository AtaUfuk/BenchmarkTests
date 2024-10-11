using BenchmarkDotNet.Running;
using LinqSelectVsFor;

var summary = BenchmarkRunner.Run<MyBenchmarkClass>();
Console.ReadKey();