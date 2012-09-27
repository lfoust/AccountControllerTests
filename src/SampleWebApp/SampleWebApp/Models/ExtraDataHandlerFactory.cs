namespace SampleWebApp.Models
{
	using System;

	public static class ExtraDataHandlerFactory
	{
		public static IExtraDataHandler FromProvider(string provider)
		{
			if (provider.Equals("twitter", StringComparison.CurrentCultureIgnoreCase))
			{
				return new TwitterExtraDataHandler();
			}
			else if (provider.Equals("google", StringComparison.CurrentCultureIgnoreCase))
			{
				return new GoogleExtraDataHandler();
			}
			else if (provider.Equals("facebook", StringComparison.CurrentCultureIgnoreCase))
			{
				return new FacebookExtraDataHandler();
			}
			return null;
		}
	}
}