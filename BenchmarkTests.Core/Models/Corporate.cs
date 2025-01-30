namespace BenchMarkTests.Core.Models
{
	public class Corporate
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string Content { get; set; }
        public string BannerUrl { get; set; }
        public int SeqNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
    }

}
