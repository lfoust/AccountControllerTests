namespace SampleWebApp.Models
{
	using System.Collections.Generic;
	using System.Linq;

	public class TwitterExtraDataHandler : IExtraDataHandler
	{
		public void Handle(UsersContext database, UserProfile profile, OAuthMembership oauthMembership, IDictionary<string, string> data)
		{
			var twitterData = database.TwitterData.FirstOrDefault(d => d.UserId == profile.UserId);
			if (twitterData == null)
			{
				twitterData = new TwitterExtraData { User = profile };
				database.TwitterData.Add(twitterData);
			}

			twitterData.Name = data.TryGetString("name");
			twitterData.Location = data.TryGetString("location");
			twitterData.Description = data.TryGetString("description");
			twitterData.Url = data.TryGetString("url");
			twitterData.AccessToken = data.TryGetString("accesstoken");

			database.SaveChanges();
		}
	}
}