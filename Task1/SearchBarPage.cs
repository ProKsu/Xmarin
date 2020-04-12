using System;

using Xamarin.Forms;

namespace Task1
{
    public class SearchBarPage : ContentPage
    {
        public SearchBarPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

