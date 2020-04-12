using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task1
{
    public partial class App : Application

    {
        public static double ScreenHeight;
        public static double ScreenWidth;

        public static string FilePath { get; internal set; }

        public App()
        {
            InitializeComponent();
            var nav = new NavigationPage(new MainPage(new TestService()) { Title = "LoginForm" })
            {
                BarBackgroundColor = Color.MediumPurple,
                BarTextColor = Color.Yellow
            };

            MainPage = nav;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
