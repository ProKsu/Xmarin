using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Task1
{
    public partial class User : ContentPage
    {
        public User()
        {
            InitializeComponent();
        }

        public string Name { get; internal set; }
    }
}
