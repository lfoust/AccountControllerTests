namespace SampleWebApp.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	[Table("GoogleData")]
	public class GoogleExtraData
	{
		[Key, ForeignKey("User")]
		public int UserId { get; set; }
		public UserProfile User { get; set; }

		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Country { get; set; }
	}
}