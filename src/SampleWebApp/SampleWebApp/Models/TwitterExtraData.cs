namespace SampleWebApp.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("TwitterData")]
	public class TwitterExtraData
	{
		[Key, ForeignKey("User")]
		public int UserId { get; set; }
		public UserProfile User { get; set; }

		public string Name { get; set; }
		public string Location { get; set; }
		public string Description { get; set; }
		public string Url { get; set; }
		public string AccessToken { get; set; }
	}
}