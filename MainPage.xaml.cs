﻿namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnBlackJackButton(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(BlackJackPage));
        }

    }

}
