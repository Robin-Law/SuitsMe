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

    public static class DeckExtensions
    {
        public static Deck GetOrderedDeck(this Deck deck)
        {
            return new Deck(deck.Cards);
        }
    }
}
