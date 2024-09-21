﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;


namespace MyTasks.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
            Text = string.Empty;
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;
            // Add our item
            Items.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            // TODO: Dismiss the keyboard before navigation
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
        }
    }
}
