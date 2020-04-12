using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Task1
{
    public partial class SearchBarPage : ContentPage
    {
        public SearchBarPage()
        {
            InitializeComponent();
            searchResults.ItemsSource = DataService.Fruits;
        }

        public void OnTextChanged(object sender, TextChangedEventArgs e) {
            searchResults.ItemsSource = DataService.GetItems(searchBar.Text);
        }
    }
}
