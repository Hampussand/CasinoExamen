using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    internal class BlackJack
    {
        public List<Card> Deck 
        {
            get { return Deck; }
            set
            {
                foreach (Card card in Enum.GetValues(typeof(Card.Suit)))
                {
                    for (int i = 0; i < 13; i++)
                    {
                        Deck.Add();
                    }
                }
            }
        }
    }
    class Card
    {
        public enum Suit { Hearts, Diamonds, Clubs, Spades };
        public int Rank
        {
            get { return Rank; }
            set
            {
                Rank = value;
            }
        }
    }


}
