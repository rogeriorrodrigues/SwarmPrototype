using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Prototype.Models;

namespace SwarmPrototype
{
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage (User user)
		{
			InitializeComponent ();
			mainStack.BindingContext = user;
			ToolbarItems.Add(new ToolbarItem("Contact", null, async () => {
				await DisplayAlert("Contact", "You clicked the contact button!", "Okay...");
			}));
		}
	}
}

