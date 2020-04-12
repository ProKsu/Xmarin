
using Foundation;
using UIKit;
using MediaManager.Forms.Platforms.iOS;
using System;
using System.IO;
using Firebase.Database;
using Firebase;

namespace Task1.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {

            MediaManager.CrossMediaManager.Current.Init();


      

            

            global::Xamarin.Forms.Forms.Init();

            
            Xamarin.FormsMaps.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
