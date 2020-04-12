using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Task1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Three_pageMaster : ContentPage
    {
        public ListView ListView;

        public Three_pageMaster()
        {
            InitializeComponent();

            BindingContext = new Three_pageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class Three_pageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<Three_pageMenuItem> MenuItems { get; set; }

            public Three_pageMasterViewModel()
            {
                MenuItems = new ObservableCollection<Three_pageMenuItem>(new[]
                {
                    new Three_pageMenuItem { Id = 0, Title = "Page 1" },
                    new Three_pageMenuItem { Id = 1, Title = "Page 2" },
                    new Three_pageMenuItem { Id = 2, Title = "Page 3" },
                    new Three_pageMenuItem { Id = 3, Title = "Page 4" },
                    new Three_pageMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}
