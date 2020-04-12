using System;
using SQLite;
using System.ComponentModel;

using FormsGallery;
using Xamarin.Forms;
using System.IO;
using Task1.Firebase;
using Xamarin.Essentials;
using System.Linq;

namespace Task1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public string FilePath = String.Empty;
        private BD.AccountList accountsList = null;
        private IConnectionService _connectionService;

       public MainPage(IConnectionService connectionService)
        {
            InitializeComponent();
            _connectionService = connectionService;
            if (emailEntry.Text != String.Empty)
            {
                logOut.IsEnabled = true;
            }


            string fileName = "account_db.db3";


            string folderPath = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            FilePath = Path.Combine(folderPath, fileName);

            using SQLiteConnection connect = new SQLiteConnection(FilePath);
            Console.WriteLine(FilePath);

            //SQLiteCommand cmd = new SQLiteCommand(connect)
            //{
            //    CommandText = "SELECT rowid FROM BD.AccountsList WHERE  emailEntry.Text = accountsList.Name;" // Если этот запрос не выполняется
            //};
            //cmd.ExecuteNonQuery();

            //cmd.CommandText = "INSERT INTO accountsList() VALUES ('accountsList.Name')"; // то добавляем запись в таблицу




            //var profiles = Connectivity.ConnectionProfiles;
            //if (profiles.Contains(ConnectionProfile.WiFi))
            //{
            //    Console.WriteLine("YESSSS");
            //    // Active Wi-Fi connection.
            //} else
            //{
            //    DisplayAlert("Error", "Connect", "Cancel");
            //}

            _connectionService.testConnection(() => { DisplayAlert("tralalal", "Connect", "Cancel");  });
        }

       

        private async void GoToTheNextPage(object sender, EventArgs e) {

            if (String.IsNullOrEmpty(emailEntry.Text) || String.IsNullOrEmpty(passwordEntry.Text))
            {
                await DisplayAlert("Error", "You have empty field", "Ok");
            }
            else {
                string currentName = emailEntry.Text;
                Application.Current.Properties["user"] = currentName;

                //NSUserDefaults.StandardUserDefaults.SetString(currentName, "UserName");

                Task1.BD.AccountList accountsList = new BD.AccountList
                {
                    Name = emailEntry.Text,
                    Password = passwordEntry.Text

                };

                using SQLiteConnection connect = new SQLiteConnection(FilePath);
                connect.CreateTable<BD.AccountList>();
                int rowsAddedb = connect.Insert(accountsList);

                Console.WriteLine(accountsList.Name);

                if (connect.Equals(accountsList.Name))
                {
                    emailEntry.Text = accountsList.Name;
                    passwordEntry.Text = accountsList.Password;
                }
              
                   

                await Navigation.PushAsync(new TwoPage());
            };
        }

        public void LogOut(object sender, EventArgs e) {


            using SQLiteConnection connect = new SQLiteConnection(FilePath);
            connect.DeleteAll<BD.AccountList>();

            emailEntry.Text = String.Empty;
            passwordEntry.Text = String.Empty;
            logOut.IsEnabled = false;
            


        }

        public async void GoSupportPage(object sender, EventArgs e) {
            //    await Navigation.PushAsync(new SupportPage());

            // await Navigation.PushAsync(new SimplePinPage());
            //await Navigation.PushAsync(new Task1.BD.DataBaseSQlite());
            //  await Navigation.PushAsync(new CoroueselPageV());

            await Navigation.PushAsync(new FirebaseQ()); 
        }

        public async void GoMediaPlayerPage(object sender, EventArgs e) {
            // await Navigation.PushAsync(new PageForMediaPlayer());
            await Navigation.PushAsync(new CustomMap());
        }

        public async void GoToSearchPage(object sender, EventArgs e) {
            //await Navigation.PushAsync(new RefreshView.RefreshPage());

            //await Navigation.PushAsync(new Task1.BD.DataBaseSQlite());
        }

    }
}
