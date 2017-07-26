using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SuitsMe.Core.Models;

namespace SuitsMe.Core.Tests.Models
{
    [TestFixture]
    class DeckTests
    {
        private static readonly Card AceOfSpades = new Card(Suit.Spade, Face.Ace);
        private static readonly Card QueenOfHearts = new Card(Suit.Heart, Face.Queen);
        private static readonly Card SevenOfDiamonds = new Card(Suit.Diamond, Face.Seven);
        private static readonly Card EightOfDiamonds = new Card(Suit.Diamond, Face.Eight);

        [Test]
        public static void OrderDeckShouldReturnDeckGivenDeck() => Assert.IsInstanceOf<Deck>(new Deck(new List<Card>()).GetOrderedDeck());

        [Test]
        public static void OrderDeckShouldReturnNewInstanceOfDeck()
        {
            var oldDeck = new Deck(new List<Card>());
            var newDeck = oldDeck.GetOrderedDeck();
            Assert.AreNotSame(oldDeck, newDeck);
        }

        [Test]
        public static void OrderDeckShouldReturnDeckContainingAllCardsOfOldDeck()
        {
            var cards = new List<Card>
            {
                AceOfSpades,
                QueenOfHearts
            };
            var oldDeck = new Deck(cards);
            var newDeck = oldDeck.GetOrderedDeck();
            // The Assert.Contains signature is a bit messy, IMO. I usually use FluentAssertions for this sort of thing
            Assert.IsTrue(newDeck.Cards.Contains(AceOfSpades) && newDeck.Cards.Contains(AceOfSpades), "New Deck Should Contain the Ace of Spades and Queen of Hearts!");
        }

        [Test]
        public static void OrderDeckShouldReturnNewInstanceOfItsCards()
        {
            var oldDeck = new Deck(new List<Card>());
            var newDeck = oldDeck.GetOrderedDeck();
            Assert.AreNotSame(oldDeck.Cards, newDeck.Cards);
        }

        [Test]
        public static void OrderDeckProperlyOrdersThreeCards()
        {
            var cards = new List<Card>
            {
                EightOfDiamonds,
                AceOfSpades,
                QueenOfHearts,
                SevenOfDiamonds
            };
            var expectedIndexes = new[] {0, 1, 2, 3};
            var oldDeck = new Deck(cards);
            var newDeck = oldDeck.GetOrderedDeck();
            var actualIndexes = new[]
            {
                newDeck.Cards.IndexOf(SevenOfDiamonds),
                newDeck.Cards.IndexOf(EightOfDiamonds),
                newDeck.Cards.IndexOf(QueenOfHearts),
                newDeck.Cards.IndexOf(AceOfSpades)
            };
            Assert.AreEqual(expectedIndexes, actualIndexes, $"Values should be ordered! Got {string.Join(", ", actualIndexes)}!");
        }
    }
}
