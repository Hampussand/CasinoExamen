namespace MauiApp2;

public partial class PokerPage : ContentPage
{
	public PokerPage()
	{
		InitializeComponent();
	}
	public class PokerCards
	{
        public int CardValue { get; set; }
        public string Suits {get; set; }
        //public string CardPicture { get; set; }

        public PokerCards(int cardValue, string suits)
        {
            CardValue = cardValue;
            Suits = suits;
        }
    }
    public class HandValue
    {
        
        public List<PokerCards>? Cards { get; set; }
        string[] suit = { "Heart", "Clover", "Spades", "Diamonds" };
        public HandValue()
        {
            for (int i = 0; i >= 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Cards?.Add(new PokerCards(j, suit[i]));
                }
            }
        }
    }
    public class currentHand
    {
        public List<PokerCards>? CurrentHand { get; set; }
        Random random = new Random();
        public currentHand()
        {
            CurrentHand.Clear();
            //CurrentHand.Add();
        }
    }
}