using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Prototype.Models;
using System.Collections.ObjectModel;

namespace SwarmPrototype
{
	public partial class ActivityFeedPage : ContentPage
	{
		public ActivityFeedPage ()
		{
			InitializeComponent ();

			NavigationPage.SetHasNavigationBar(this, false);

			ObservableCollection<User> users = new ObservableCollection<User> {
				new User("Mike", "Queso cheeseburger manchego. Halloumi bavarian bergkase " +
					"airedale halloumi goat roquefort emmental parmesan. Pecorino brie dolcelatte cut the " +
					"cheese cheese slices cheeseburger bocconcini mozzarella. Cream cheese croque monsieur cheese and wine.",
					"ZanziBar", "Chicago, IL", "Workin'"),
				new User("Erica", "Danish fontina mozzarella melted cheese. Swiss cut the cheese melted cheese parmesan red leicester " +
					"airedale mozzarella stinking bishop.", "Smuggler's Cove", "San Francisco, CA"),
				new User("Chris", "Caerphilly swiss cheese slices. Fondue everyone loves cheese slices cottage cheese mozzarella stilton " +
					"cheddar goat. Lancashire feta cheese triangles who moved my cheese say cheese red leicester boursin squirty cheese.",
					"Cheesie's", "Las Vegas, NV"),
				new User("Jacqueline", "Boss", "Chase Bank", "Caracas, Venezuela"),
				new User("Mary", "Living it up", "United Center", "Chicacgo, IL", "GO HAWKS!"),
				new User("Liam", "I sing", "Alley Catz Bowling", "Salt Lake City, UT")
			};

			listView.ItemsSource = users;
			listView.ItemTapped += async (object sender, ItemTappedEventArgs e) => 
			{
				User selectedUser = (User) e.Item;
				await Navigation.PushAsync(new ProfilePage(selectedUser));
				((ListView)sender).SelectedItem = null;
			};
		}
	}
}

