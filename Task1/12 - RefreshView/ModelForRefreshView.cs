﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

public class MyViewModel : INotifyPropertyChanged
{
    public ICommand RefreshCommand { protected set; get; }
    public ObservableCollection<string> Items { get; set; }


    bool _isRefreshing = false;
    public bool IsRefreshing
    {
        get
        {
            return _isRefreshing;
        }

        set
        {
            if (_isRefreshing != value)
            {
                _isRefreshing = value;
                OnPropertyChanged("IsRefreshing");

            }
        }

    }
    public MyViewModel()
    {
        Items = new ObservableCollection<string>();

        Items.Add("Bob");
        

        RefreshCommand = new Command<string>((key) =>
        {
            Items.Add("Apple");
            IsRefreshing = false;
        });
    }
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}