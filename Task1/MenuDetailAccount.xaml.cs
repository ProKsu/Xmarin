using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Task1
{
    public partial class MenuDetailAccount : MasterDetailPage
    {
        public MenuDetailAccount()
        {
            InitializeComponent();
            Detail = new NavigationPage(new DetailPagePlayer.PlayerForDetailPage()) {
            BarBackgroundColor = Color.MediumPurple
            };
            IsPresented = true;
            
        }


        public void ClickAdress(Object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AddressPage())
            {
                BarBackgroundColor = Color.MediumPurple
            };

            IsPresented = false;
        }


        public void ClickedWork(Object sender, EventArgs e) {
            Detail = new NavigationPage(new WorkPage())
            {
                BarBackgroundColor = Color.MediumPurple
            };

            IsPresented = false;
        }
    }
}
