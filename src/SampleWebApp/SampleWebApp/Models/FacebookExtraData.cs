namespace SampleWebApp.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("FacebookData")]
	public class FacebookExtraData
	{
		[Key, ForeignKey("User")]
		public int UserId { get; set; }
		public UserProfile User { get; set; }

		public string Id { get; set; }
		public string Name { get; set; }
		public string Link { get; set; }
		public string Gender { get; set; }
		public string AccessToken { get; set; }
	}
}