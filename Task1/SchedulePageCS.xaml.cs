using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Task1
{
	public partial class SettingsPageCS : ContentPage
	{
		public SettingsPageCS()
		{
			IconImageSource = "settings.png";
			Title = "Settings";
			Content = new StackLayout
			{
				Children = {
					new Label {
						Text = "Settings go here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}
