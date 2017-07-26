using System.Collections.Generic;
using System.Linq;

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
        public static Deck GetOrderedCopy(this Deck deck)
        {
            return new Deck(deck.Cards.OrderBy(card => card.Suit).ThenBy(card => card.Face).ToList());
        }
    }
}
