using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Plugin.FilePicker;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace Task1
{
    public partial class SupportPage : ContentPage
    {
        class UserInfo {

            public UserInfo(string firstName, string lastName, string userEmail) {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.UserEmail = userEmail;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string UserEmail { get; set; }
        };

        public SupportPage()
        {
            InitializeComponent();
            FillCurrentNameAndLastName();
        }

        public async void SendEmail(object sender, EventArgs e)
        {
            string currentFirstName = entryForFirstName.Text;
            string currentLastName = entryForLastName.Text;
            string currentEmail = entryForEmail.Text;

            var userInformation = new UserInfo(currentFirstName, currentLastName, currentEmail);

            string output = JsonConvert.SerializeObject(userInformation);
         
            await DisplayAlert("Success", output, "Ok");
        }

       
        public void FillCurrentNameAndLastName()
        {
            if (Application.Current.Properties.ContainsKey("user"))
            {
                entryForFirstName.Text = Application.Current.Properties["user"] as string;
            }
        }

        public async void LoadPicture(Object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("no support", "your device not suppeted", "Ok");
                return;
            }

            var mediaOptions = new PickMediaOptions()
            {
                PhotoSize = PhotoSize.Medium
            };

            var selectedImageFile = await CrossMedia.Current.PickPhotoAsync(mediaOptions);
        }

        public async void ChooseRequestType(Object  sender, EventArgs e)
        {
            string reason = await DisplayActionSheet("Select reason", "Ok",
                               "Problem logging in", "Problem with workouts");

            if (reason == "Problem logging in")
            {
                selectReason.Text = "Problem logging in";
            } else
            {
                selectReason.Text = "Problem with workouts";
            }
        }
    }
}
