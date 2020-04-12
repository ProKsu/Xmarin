using System;
using System.Collections.Generic;
using Xamarin.Forms.Maps;

using Xamarin.Forms;

namespace Task1
{
    public partial class CustomMapPage : ContentPage
    {
        public CustomMapPage()
        {
            InitializeComponent();


            var map = new Map(MapSpan.FromCenterAndRadius(
                new Position(36.8961, 10.1865),
                Distance.FromMiles(0.5)))
            {
                IsShowingUser = true,
                VerticalOptions = LayoutOptions.FillAndExpand

            };


            var position1 = new Position(36.8961, 10.1865);
            var position2 = new Position(36.891, 10.181);

            var pin1 = new Pin {
                Type = PinType.Place,
                Position = position1,
                Label = "IntilaQ",
                Address = "www.initaq.tn",
            };

            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "IntilaQ",
                Address = "www.groupe-telnet.com",
            };


        }



    }
}
