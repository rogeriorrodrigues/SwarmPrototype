using System;

using Xamarin.Forms;
using Prototype.Models;

namespace SwarmPrototype
{
	public class ProfilePage : ContentPage
	{
		public ProfilePage (User user)
		{
			Content = new StackLayout {
				Padding = new Thickness(10, Device.OnPlatform(40, 20, 20), 10, 5),
				BackgroundColor = Color.FromHex("f39c12"),
				Spacing = 20,
				Children = {
					new StackLayout {
						BackgroundColor = Color.FromHex("f39c12"),
						Orientation = StackOrientation.Vertical,
						HorizontalOptions = LayoutOptions.Center,
						Children = {
							new Image {
								Source = ImageSource.FromFile("profile.png"),
								HeightRequest = 100,
								WidthRequest = 100
							},
							new Label {
								Text = user.Name,
								TextColor = Color.White,
								HorizontalOptions = LayoutOptions.Center,
								FontSize = 20
							},
							new Label {
								Text = user.Location,
								TextColor = Color.White,
								FontSize = 14,
								HorizontalOptions = LayoutOptions.Center,
								FontAttributes = FontAttributes.Bold
							},
							new Label {
								Text = "Last seen in San Francisco",
								TextColor = Color.White,
								HorizontalOptions = LayoutOptions.Center,
								FontSize = 14
							},
							new Label {
								Text = user.Description,
								TextColor = Color.White,
								FontSize = 14,
								HorizontalOptions = LayoutOptions.Center,
								Opacity = 0.8
							}
						}
					},
					new StackLayout {
						Orientation = StackOrientation.Horizontal,
						HorizontalOptions = LayoutOptions.Center,
						Spacing = 15,
						Children = {
							new Button { 
								Text = "✓ Friends",
								BorderRadius = 15,
								TextColor = Color.FromHex("f39c12"),
								BackgroundColor = Color.White,
								WidthRequest = 150,
								HeightRequest = 35
							},
							new Button { 
								Text = "Alerts Off",
								BorderRadius = 15,
								BorderColor = Color.White,
								BorderWidth = 2,
								TextColor = Color.White,
								BackgroundColor = Color.Transparent,
								WidthRequest = 150,
								HeightRequest = 35
							}
						}
					},
					new StackLayout {
						Orientation = StackOrientation.Horizontal,
						Spacing = 1,
						Children = {
							new StackLayout {
								HeightRequest = 50,
								HorizontalOptions = LayoutOptions.FillAndExpand,
								BackgroundColor = Color.FromHex("e67e22"),
								Children = {
									new Label {
										VerticalOptions = LayoutOptions.Center,
										Text = "459 Friends",
										TextColor = Color.White,
										HorizontalOptions = LayoutOptions.Center
									}
								}
							},
							new StackLayout {
								HeightRequest = 50,
								HorizontalOptions = LayoutOptions.FillAndExpand,
								BackgroundColor = Color.FromHex("e67e22"),
								Children = {
									new Label {
										VerticalOptions = LayoutOptions.Center,
										Text = "3,320 Photos",
										TextColor = Color.White,
										HorizontalOptions = LayoutOptions.Center
									}
								}
							}
						}
					}
				}
			};
		}
	}
}


