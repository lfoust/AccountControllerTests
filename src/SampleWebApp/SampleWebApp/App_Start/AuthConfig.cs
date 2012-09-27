using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using SampleWebApp.Models;

namespace SampleWebApp
{
	public static class AuthConfig
	{
		public static void RegisterAuth()
		{
			// To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
			// you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

			OAuthWebSecurity.RegisterMicrosoftClient(
				clientId: "000000004C0CA521",
				clientSecret: "Wn2wpkeiUD9zOlaczn3MxTGxPWbGB5Ue");

			OAuthWebSecurity.RegisterTwitterClient(
				consumerKey: "472HG3OxcsNWV5MSAG6hvA",
				consumerSecret: "gSiIaoZTxY6HnUbvjNh6nW5HmBKUMylWyle5c6VazI");

			OAuthWebSecurity.RegisterFacebookClient(
				appId: "191287864275474",
				appSecret: "7b7cb580211e89ab1745ebd452fbc949");

			OAuthWebSecurity.RegisterGoogleClient();
		}
	}
}
