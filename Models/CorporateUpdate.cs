namespace BenchMarkTests.Models
{
	public class CorporateUpdate
	{
		public Guid UpdatedId { get; set; }
		public string Title { get; set; }
		public string ShortContent { get; set; }
		public string Content { get; set; }
		public string BannerUrl { get; set; }
		public int SeqNumber { get; set; }
		public bool IsActive { get; set; }
		public DateTime CDate { get; set; }
		public DateTime UDate { get; set; }
		public int CreatedUser { get; set; }
		public int UpdatedUser { get; set; }
	}
}
