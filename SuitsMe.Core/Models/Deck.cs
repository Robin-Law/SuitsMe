using System.Collections.Generic;

namespace SuitsMe.Core.Models
{
    public class Deck
    {
        public IList<Card> Cards { get; set; }

        public Deck(IList<Card> cards)
        {
            Cards = cards;
        }
    }
}
