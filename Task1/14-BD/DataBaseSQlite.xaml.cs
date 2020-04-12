//using Xamarin.Forms;
//using Task1.BD;
//using System;
//using SQLite;
//using System.IO;


//namespace Task1


//{
//    public partial class DataBaseSQlite : ContentPage
//    {
//        public string FilePath = String.Empty;

//        public DataBaseSQlite()
//        {
//            InitializeComponent();
//            string fileName = "account_db.db3";
//            string folderPath = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

//            FilePath = Path.Combine(folderPath, fileName);
//            Console.WriteLine(FilePath);

//        }

       

//        void SaveAccount(object sender, System.EventArgs e)
//        {
//            AccountList accountsList = new AccountList
//            {
//                Name = MainPage.emailEntry.Text,
//                Name = nameEntry.Text,
//                Address = AddressEntry.Text,
//                PhoneNumber = PhoneEntry.Text,
//                Email = EmailEntry.Text,
//                LastName = lastNameEntry.Text

//            };

//            using SQLiteConnection connect = new SQLiteConnection(FilePath);
//            connect.CreateTable<AccountList>();
//            int rowsAddedb = connect.Insert(accountsList);

//            Console.WriteLine(connect);
//        }
//    }
//}