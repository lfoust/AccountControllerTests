namespace SampleWebApp.Models
{
	using System.Collections.Generic;
	using System.Linq;

	public class FacebookExtraDataHandler : IExtraDataHandler
	{
		public void Handle(UsersContext database, UserProfile profile, OAuthMembership oauthMembership, IDictionary<string, string> data)
		{
			var user = database.UserProfiles.FirstOrDefault(u => u.UserId == oauthMembership.User.UserId);
			var facebookData = database.FacebookData.FirstOrDefault(d => d.UserId == user.UserId);
			if (facebookData == null)
			{
				facebookData = new FacebookExtraData { User = user };
				database.FacebookData.Add(facebookData);
			}

			facebookData.Id = data.TryGetString("id");

			database.SaveChanges();
		}
	}
}