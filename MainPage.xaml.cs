namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnBlackJackButton(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(BlackJackPage));
        }

        private void RouletteButton_Clicked(object sender, EventArgs e)
        {

        }

        private void SlotsButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void PokerButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PokerPage));
        }
    }

}
