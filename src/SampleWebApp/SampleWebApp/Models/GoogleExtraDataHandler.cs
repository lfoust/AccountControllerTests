namespace SampleWebApp.Models
{
	using System.Collections.Generic;
	using System.Linq;

	public class GoogleExtraDataHandler : IExtraDataHandler
	{
		public void Handle(UsersContext database, UserProfile profile, OAuthMembership oauthMembership, IDictionary<string, string> data)
		{
			var user = database.UserProfiles.FirstOrDefault(u => u.UserId == oauthMembership.User.UserId);
			var googleData = database.GoogleData.FirstOrDefault(d => d.UserId == user.UserId);
			if (googleData == null)
			{
				googleData = new GoogleExtraData { User = user };
				database.GoogleData.Add(googleData);
			}

			googleData.Email = data.TryGetString("email");
			googleData.Country = data.TryGetString("country");
			googleData.FirstName = data.TryGetString("firstname");
			googleData.LastName = data.TryGetString("lastname");
			database.SaveChanges();
		}
	}
}