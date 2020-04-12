using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Task1.RefreshView
{
    public partial class RefreshPage : ContentPage
    {
        public RefreshPage()
        {
            InitializeComponent();
            BindingContext = new MyViewModel();
        }
    }
}

