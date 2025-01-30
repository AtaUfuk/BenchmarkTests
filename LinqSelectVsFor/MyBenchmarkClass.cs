using AutoFixture;
using BenchmarkDotNet.Attributes;
using BenchMarkTests.Core.Models;

namespace LinqSelectVsFor
{
	[MemoryDiagnoser]
	public class MyBenchmarkClass
	{
        private List<Corporate> corporates { get; set; }
		public MyBenchmarkClass()
		{
			corporates = GenerateFakeData();
		}
		public static List<Corporate> GenerateFakeData()
		{
			IFixture _fixture = new Fixture();
			return _fixture.CreateMany<Corporate>(100000).ToList();
		}

		[Benchmark]
		public List<CorporateUpdate> CreateDtoWithLinqSelectDirectReturn()
		{
			return corporates.Select(x => new CorporateUpdate()
			{
				Title = x.Title,
				BannerUrl = x.BannerUrl,
				CDate = x.CreatedDate,
				Content = x.Content,
				CreatedUser = x.CreatedUserId,
				IsActive = x.IsActive,
				SeqNumber = x.SeqNumber,
				ShortContent = x.ShortContent,
				UDate = x.UpdatedDate,
				UpdatedId = x.Id,
				UpdatedUser = x.UpdatedUserId
			}).ToList();
		}


		[Benchmark]
		public List<CorporateUpdate> CreateDtoWithLinqSelect()
		{
			List<CorporateUpdate> result = [];
			result= corporates.Select(x => new CorporateUpdate()
			{
				Title = x.Title,
				BannerUrl = x.BannerUrl,
				CDate = x.CreatedDate,
				Content = x.Content,
				CreatedUser = x.CreatedUserId,
				IsActive = x.IsActive,
				SeqNumber = x.SeqNumber,
				ShortContent = x.ShortContent,
				UDate = x.UpdatedDate,
				UpdatedId = x.Id,
				UpdatedUser = x.UpdatedUserId
			}).ToList();
			return result;
		}

		[Benchmark]
		public List<CorporateUpdate> CreateDtoWithFor()
		{
			List<CorporateUpdate> result = [];
			for (int i = 0; i < corporates.Count; i++)
			{
				CorporateUpdate cu = new()
				{
					Title = corporates[i].Title,
					BannerUrl = corporates[i].BannerUrl,
					CDate = corporates[i].CreatedDate,
					Content = corporates[i].Content,
					CreatedUser = corporates[i].CreatedUserId,
					IsActive = corporates[i].IsActive,
					SeqNumber = corporates[i].SeqNumber,
					ShortContent = corporates[i].ShortContent,
					UDate = corporates[i].UpdatedDate,
					UpdatedId = corporates[i].Id,
					UpdatedUser = corporates[i].UpdatedUserId
				};
				result.Add(cu);
			}
			return result;
		}

		[Benchmark]
		public List<CorporateUpdate> CreateDtoWithForEach()
		{
			List<CorporateUpdate> result = [];
			foreach (var item in corporates)
			{
				CorporateUpdate cu = new()
				{
					BannerUrl = item.BannerUrl,
					CDate = item.CreatedDate,
					Content = item.Content,
					CreatedUser = item.CreatedUserId,
					IsActive = item.IsActive,
					SeqNumber = item.SeqNumber,
					ShortContent = item.ShortContent,
					UDate = item.UpdatedDate,
					Title = item.Title,
					UpdatedId = item.Id,
					UpdatedUser = item.UpdatedUserId
				};
				result.Add(cu);
			}
			return result;
		}
	}
}
