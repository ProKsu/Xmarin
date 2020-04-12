using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Task1
{
    public partial class PageForWebView : ContentPage
    {
        public PageForWebView()
        {
            InitializeComponent();
            WebView.Source = "https://docs.microsoft.com/en-us/xamarin/";
        }


        public void GoBack(object sender, EventArgs e) {

            if (WebView.CanGoBack) {
                WebView.GoBack();
            }
        }

        public void GoForward(object sender, EventArgs e) {

            if (WebView.CanGoForward) {
                WebView.GoForward();
            }
        }
    }
}
