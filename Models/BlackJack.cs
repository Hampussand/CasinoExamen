using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    internal class BlackJack
    {
        public List<Card> Deck { get;
            set
            {
                foreach(Card card in Enum.GetValues(typeof(Card.Suit)))
                {
                    foreach()
                }
            } 
                }
    }
    class Card
    {
        public enum Suit { Hearts, Diamonds, Clubs, Spades };
        public int Rank;
    }


}
