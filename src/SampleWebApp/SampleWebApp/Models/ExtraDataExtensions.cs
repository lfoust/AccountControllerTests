namespace SampleWebApp.Models
{
	using System.Collections.Generic;

	public static class ExtraDataExtensions
	{
		public static string TryGetString(this IDictionary<string, string> data, string key)
		{
			string val;
			if (data.TryGetValue(key, out val))
				return val;
			return null;
		}
	}
}