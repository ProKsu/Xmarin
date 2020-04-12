using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Task1
{
    public partial class SimplePinPage : ContentPage
    {
        public SimplePinPage()
        {
            InitializeComponent();
        }

        void AddNewPin(object sender, EventArgs e)
        {
            Pin dukoraPin = new Pin
            {
                Position = new Position(53.667, 27.950),
                Label = "Suburbs",
                Address = "Dukora",
                Type = PinType.Place
            };
            dukoraPin.MarkerClicked += OnMarkerClickedAsync;

            map.Pins.Add(dukoraPin);
        }

        async void OnMarkerClickedAsync(object sender, PinClickedEventArgs e)
        {
            e.HideInfoWindow = true;
            string pinName = ((Pin)sender).Label;
            await DisplayAlert("Pin Clicked", $"{pinName} was clicked.", "Ok");
        }

        async void OnInfoWindowClickedAsync(object sender, PinClickedEventArgs e)
        {
            string pinName = ((Pin)sender).Label;
            await DisplayAlert("Info Window Clicked", $"The info window was clicked for {pinName}.", "Ok");
        }
    }
}
