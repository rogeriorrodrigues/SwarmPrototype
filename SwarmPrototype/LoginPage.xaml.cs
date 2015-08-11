using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwarmPrototype
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();

			NavigationPage.SetHasNavigationBar (this, false);

			buttonLogin.Clicked += async (object sender, EventArgs e) => {
				await Navigation.PushAsync (new ActivityFeedPage ());
			};
		}
	}
}

