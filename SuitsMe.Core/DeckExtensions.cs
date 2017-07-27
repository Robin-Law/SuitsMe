using System;
using System.Collections.Generic;
using System.Linq;

namespace SuitsMe.Core
{
    public static class DeckExtensions
    {
        private static readonly Random Random = new Random();

        public static Deck GetOrderedCopy(this Deck deck)
        {
            return new Deck(deck.Cards.OrderBy(card => card.Suit).ThenBy(card => card.Face).ToList());
        }

        public static Deck GetShuffledCopy(this Deck deck)
        {
            var deckCardsCopy = deck.Cards.Select(x => x).ToList();
            var newCards = new List<Card>();
            while (deckCardsCopy.Count > 0)
            {
                var takeIndex = Random.Next(0, deckCardsCopy.Count - 1);
                var takeCard = deckCardsCopy[takeIndex];
                newCards.Add(takeCard);
                deckCardsCopy.Remove(takeCard);
            }
            return new Deck(new List<Card>(newCards));
        }
    }
}