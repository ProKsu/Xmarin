using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    partial class tabbedPageForSample : TabbedPage
    {
        public tabbedPageForSample()
        {
            var nav = new NavigationPage(new User());

            nav.IconImageSource = "arrow.png";
            nav.Title = "Arrow";

            


            
            
        }
    }
}