using AutoFixture;
using BenchmarkDotNet.Attributes;
using BenchMarkTests.Core.Models;

namespace LinqAnyVsAll
{
    [MemoryDiagnoser]
    public class MyBenchmark
    {
        private List<Corporate> corporates { get; set; }
        public MyBenchmark()
        {
            corporates = GenerateFakeData();
        }
        private static List<Corporate> GenerateFakeData()
        {
            IFixture _fixture = new Fixture();
            return _fixture.Build<Corporate>().With(x => x.Title, $"Title-{_fixture.Create<string>()}").CreateMany(1000000).ToList();
        }

        [Benchmark]
        public bool LinqAny()
        {
            return corporates.Any(x => x.Title.Contains("Title"));
        }

        [Benchmark]
        public bool LinqAll()
        {
            return corporates.All(x => x.Title.Contains("Title"));
        }
    }
}
