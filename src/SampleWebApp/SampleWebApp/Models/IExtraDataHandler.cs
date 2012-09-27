namespace SampleWebApp.Models
{
	using System.Collections.Generic;

	public interface IExtraDataHandler
	{
		void Handle(UsersContext database, UserProfile profile, OAuthMembership oauthMembership, IDictionary<string, string> data);
	}
}