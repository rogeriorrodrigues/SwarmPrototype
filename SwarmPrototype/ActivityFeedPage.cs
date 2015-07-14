using System;

using Xamarin.Forms;
using System.Collections.Generic;
using Prototype.Models;

namespace SwarmPrototype
{
	public class ActivityFeedPage : ContentPage
	{
		public ActivityFeedPage ()
		{
			NavigationPage.SetHasNavigationBar(this, false);

			var titleStack = new StackLayout {
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 50,
				BackgroundColor = Color.FromHex("f39c12"),
				Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5),
				Children = {
					new Image { 
						Source = ImageSource.FromFile("profile.png"),
						HeightRequest = 40,
						WidthRequest = 40
					},
					new Label {
						Text = "in",
						TextColor = Color.White,
						VerticalOptions = LayoutOptions.Center
					},
					new Label {
						Text = "East Harlem",
						TextColor = Color.White,
						FontAttributes = FontAttributes.Bold,
						VerticalOptions = LayoutOptions.Center
					}
				}
			};


			List<User> users = new List<User> {
				new User("Mike", "Queso cheeseburger manchego. Halloumi bavarian bergkase " +
				"airedale halloumi goat roquefort emmental parmesan. Pecorino brie dolcelatte cut the " +
				"cheese cheese slices cheeseburger bocconcini mozzarella. Cream cheese croque monsieur cheese and wine.",
					"ZanziBar", "Chicago, IL", 200, 600, "Workin'"),
				new User("Erica", "Danish fontina mozzarella melted cheese. Swiss cut the cheese melted cheese parmesan red leicester " +
				"airedale mozzarella stinking bishop.", "Smuggler's Cove", "San Francisco, CA", 3000, 500),
				new User("Chris", "Caerphilly swiss cheese slices. Fondue everyone loves cheese slices cottage cheese mozzarella stilton " +
				"cheddar goat. Lancashire feta cheese triangles who moved my cheese say cheese red leicester boursin squirty cheese.",
					"Cheesie's", "Las Vegas, NV", 0, 209),
				new User("Jacqueline", "Boss", "Chase Bank", "Caracas, Venezuela", 48, 550),
				new User("Mary", "Living it up", "United Center", "Chicacgo, IL", 230, 895, "GO HAWKS!"),
				new User("Liam", "I sing", "Alley Catz Bowling", "Salt Lake City, UT", 10, 59)
			};


			var listView = new ListView {
				BackgroundColor = Color.White,
				ItemsSource = users,
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate(() =>
				{
					var nameLabel = new Label();
					nameLabel.SetBinding(Label.TextProperty, "Name");
					nameLabel.TextColor = Color.Black;
					nameLabel.FontSize = 12;
					nameLabel.FontAttributes = FontAttributes.Bold;

					var checkInLabel = new Label();
					checkInLabel.SetBinding(Label.TextProperty, "LastCheckIn");
					checkInLabel.TextColor = Color.FromHex("f39c12");
					checkInLabel.FontSize = 20;

					var locationLabel = new Label();
					locationLabel.SetBinding(Label.TextProperty, "Location");
					locationLabel.TextColor = Color.Gray;
					locationLabel.FontSize = 14;

					var statusLabel = new Label();
					statusLabel.SetBinding(Label.TextProperty, "Status");
					statusLabel.TextColor = Color.Black;
					statusLabel.FontSize = 16;

					var image = new Image();
					image.Source = ImageSource.FromFile("profile.png");
					image.HeightRequest = 50;
					image.WidthRequest = 50;

					return new ViewCell {
						View = new StackLayout {
							Padding = 15,
							Orientation = StackOrientation.Horizontal,
							Children = { 
								image,
								new StackLayout {
									Orientation = StackOrientation.Vertical,
									Spacing = 2,
									VerticalOptions = LayoutOptions.Center,
									Children = { nameLabel, checkInLabel, locationLabel, statusLabel }
								},
								new StackLayout {
									Orientation = StackOrientation.Vertical,
									Spacing = 15,
									HorizontalOptions = LayoutOptions.EndAndExpand,
									Children = {
										new Label {
											Text = "♡",
											TextColor = Color.FromHex("f39c12"),
											FontSize = 16
										},
										new Label {
											Text = "10m",
											TextColor = Color.Gray,
											FontSize = 13
										}
									}
								}
							}
						}
					};
				})
			};

			listView.ItemTapped += async (object sender, ItemTappedEventArgs e) => 
			{
				User selectedUser = (User) e.Item;
				Navigation.PushAsync(new ProfilePage(selectedUser));
				((ListView)sender).SelectedItem = null;
			};

			Content = new StackLayout {
				Children = { titleStack, listView }	
			};
		}
	}
}


