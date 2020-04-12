using System;
using System.Linq;
using Xamarin.Essentials;


using Xamarin.Forms;

namespace Task1
{

    public delegate void SomeCallback();

    public interface IConnectionService
    {
        // SomeCallback callback { get; set; }
        void testConnection(SomeCallback onError);
    }

    public class TestService : IConnectionService
    {
        public void testConnection(SomeCallback onError)
        {
            var profiles = Connectivity.ConnectionProfiles;
            if (profiles.Contains(ConnectionProfile.WiFi))
            {

            }
            else
            {
                onError();
            }
        }
    }

    public class TestService2 : IConnectionService
    {
        public void testConnection(SomeCallback onError)
        {
            var profiles = Connectivity.ConnectionProfiles;
            if (profiles.Contains(ConnectionProfile.WiFi))
            {
                Console.WriteLine("YESSSS2");
                // Active Wi-Fi connection.
            }
        }
    }
}

