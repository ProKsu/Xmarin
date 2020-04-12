using System;

using Xamarin.Forms;

namespace Task1
{
    public class CustomMapRendered : ContentPage
    {
        public CustomMapRendered()
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

