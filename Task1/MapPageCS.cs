using System;
using Xamarin.Forms.Maps;
using Xamarin.Forms;
using Task1.Mapcontrol;
using System.Collections.Generic;

namespace Task1
{
    public class MapPageCS : ContentPage
    {

        public double ScreenHeight { get; }
        public double ScreenWidth { get; }

        public MapPageCS()
        {
            var customMap = new MapView 
        {
            MapType = MapType.Street,
                WidthRequest = ScreenHeight,
                HeightRequest = ScreenWidth
            }; 

            var pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(27.988456, 86.924726),
                Label = "Mt Everest",
                Address = "Solukhumbu,Nepal",
                Id = "Xamarin",
                Url = "http://xamarin.com/about"
            };

            var pin2 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(27.988456, 86.924726),
                Label = "Mt Everest",
                Address = "Solukhumbu,Nepal",
                Id = "Xamarin",
                Url = "http://xamarin.com/about"
            };


            customMap.CustomPin = new List<CustomPin> { pin };
            customMap.Pins.Add(pin);
            customMap.Pins.Add(pin2);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(27.988456, 86.924726), Distance.FromMiles(1.0, 0)));

            Content = customMap; 
        }
    }
}

