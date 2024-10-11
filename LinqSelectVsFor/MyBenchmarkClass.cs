using AutoFixture;
using BenchmarkDotNet.Attributes;
using LinqSelectVsFor.Models;

namespace LinqSelectVsFor
{
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
		public List<CorporateUpdate> CreateDtoWithLinqSelect()
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
	}
}
