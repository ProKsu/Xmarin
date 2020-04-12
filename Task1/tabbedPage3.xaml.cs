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
    public partial class tabbedPage3 : TabbedPage
    {
        public tabbedPage3()
        {

            var navigationPage = new NavigationPage(new SchedulePage());
            navigationPage.IconImageSource = "schedule.png";
            navigationPage.Title = "Schedule";


            Children.Add(new TodayPage());
         
           

       
        }
    }
}
