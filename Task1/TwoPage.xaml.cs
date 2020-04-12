using System;
using System.Collections.Generic;
using Task1;
using Xamarin.Forms;

namespace FormsGallery
{
    public partial class TwoPage : ContentPage
    {
        public string ItemSelected { get; }

        class Person
        {
            public Person(string name, DateTime birthday, string imagePath)
            {
                this.Name = name;
                this.Birthday = birthday;
                this.ImagePath = imagePath;
               // this.FavoriteColor = favoriteColor;
            }

            public string Name { private set; get; }

            public DateTime Birthday { private set; get; }

            public string ImagePath { get; set; }

            //public Color FavoriteColor { private set; get; }
        };
       


        //public async void Click_Row(object sender, SelectedItemChangedEventArgs e) {

        //    await Navigation.PushAsync(new MenuDetailAccount());
            
        //}

        public TwoPage()
        {
            
            Padding = 10;
            Title = "List View";

            ToolbarItem rightBarItem = new ToolbarItem
            {
                Text="Log out",
                Order = ToolbarItemOrder.Primary,
                Priority = 1,
               
            };

            this.ToolbarItems.Add(rightBarItem);
            rightBarItem.Clicked += onClickLogoutButton;

            async void onClickLogoutButton(object sender, EventArgs e) {

                ToolbarItem barItem = (ToolbarItem)sender;
                var result =  await DisplayAlert("Attention", "Are you sure you want to logout?","Yes", "No");

                if (result == true)
                {
                    await Navigation.PushAsync(new PageForWebView());
                   
                }
                else {
                    _ = Navigation.PopAsync();
                }


            }


            Label header = new Label
            {
                Text = "ListView",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            // Define some data.
            List<Person> people = new List<Person>
            {
                new Person("Abigail", new DateTime(1975, 1, 15), "logoPicture.jpg"),
                new Person("Bob", new DateTime(1976, 2, 20), "logoPicture.jpg"),
                // ...etc.,...
                new Person("Yvonne", new DateTime(1987, 1, 10), "logoPicture.jpg"),
                new Person("Zachary", new DateTime(1988, 2, 5), "logoPicture.jpg")
            };

            // Create the ListView.
            ListView listView = new ListView
            {
                // Source of data items.
                ItemsSource = people,
               
               
            // Define template for displaying each item.
            // (Argument of DataTemplate constructor is called for 
            //      each item; it must return a Cell derivative.)
                 ItemTemplate = new DataTemplate(() =>
                {
                    // Create views with bindings for displaying each property.
                    Label nameLabel = new Label();
                    nameLabel.SetBinding(Label.TextProperty, "Name");

                    Label birthdayLabel = new Label();
                    birthdayLabel.SetBinding(Label.TextProperty,
                        new Binding("Birthday", BindingMode.OneWay,
                            null, null, "Born {0:d}"));

                    Image image = new Image();
                    image.SetBinding(Image.SourceProperty, "ImagePath");

                    //BoxView boxView = new BoxView();
                    //boxView.SetBinding(BoxView.ColorProperty, "FavoriteColor");

                    // Return an assembled ViewCell.
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(22, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                                {
                                    image,
                                    new StackLayout
                                    {
                                        VerticalOptions = LayoutOptions.Center,
                                        Spacing = 0,
                                        Children =
                                        {
                                            nameLabel,
                                            birthdayLabel
                                        }
                                        }
                                }
                        }
                    };
                })
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            
            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    listView
                }
            };

            listView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (Person)e.SelectedItem;

                // now you can reference item.Name, item.Location, etc
                Navigation.PushAsync(new MenuDetailAccount());
                DisplayAlert("ItemSelected", item.Name, "Ok");
            };

        
        }
       
    }
}