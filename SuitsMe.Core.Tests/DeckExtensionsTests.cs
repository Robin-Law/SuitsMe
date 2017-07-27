using System.Collections.Generic;
using NUnit.Framework;

namespace SuitsMe.Core.Tests
{
    [TestFixture]
    class DeckExtensionsTests
    {
        private static readonly Card AceOfSpades = new Card(Suit.Spade, Face.Ace);
        private static readonly Card QueenOfHearts = new Card(Suit.Heart, Face.Queen);
        private static readonly Card SevenOfDiamonds = new Card(Suit.Diamond, Face.Seven);
        private static readonly Card EightOfDiamonds = new Card(Suit.Diamond, Face.Eight);

        #region DeckExtensions.GetOrderedCopy
        [Test]
        public static void GetOrderedCopyShouldReturnDeckGivenDeck() => Assert.IsInstanceOf<Deck>(new Deck(new List<Card>()).GetOrderedCopy());

        [Test]
        public static void GetOrderedCopyShouldReturnNewInstanceOfDeck()
        {
            var oldDeck = new Deck(new List<Card>());
            var newDeck = oldDeck.GetOrderedCopy();
            Assert.AreNotSame(oldDeck, newDeck);
        }

        [Test]
        public static void GetOrderedCopyShouldReturnDeckContainingAllCardsOfOldDeck()
        {
            var cards = new List<Card>
            {
                AceOfSpades,
                QueenOfHearts
            };
            var oldDeck = new Deck(cards);
            var newDeck = oldDeck.GetOrderedCopy();
            // The Assert.Contains signature is a bit messy, IMO. I usually use FluentAssertions for this sort of thing
            Assert.IsTrue(newDeck.Cards.Contains(AceOfSpades) && newDeck.Cards.Contains(AceOfSpades), "New Deck Should Contain the Ace of Spades and Queen of Hearts!");
        }

        [Test]
        public static void GetOrderedCopyShouldReturnNewInstanceOfItsCards()
        {
            var oldDeck = new Deck(new List<Card>());
            var newDeck = oldDeck.GetOrderedCopy();
            Assert.AreNotSame(oldDeck.Cards, newDeck.Cards);
        }

        [Test]
        public static void GetOrderedCopyProperlyOrdersThreeCards()
        {
            var cards = new List<Card>
            {
                EightOfDiamonds,
                AceOfSpades,
                QueenOfHearts,
                SevenOfDiamonds
            };
            
            var oldDeck = new Deck(cards);
            var newDeck = oldDeck.GetOrderedCopy();

            var expectedIndexes = new[] {0, 1, 2, 3};
            var actualIndexes = new[]
            {
                newDeck.Cards.IndexOf(SevenOfDiamonds),
                newDeck.Cards.IndexOf(EightOfDiamonds),
                newDeck.Cards.IndexOf(QueenOfHearts),
                newDeck.Cards.IndexOf(AceOfSpades)
            };

            Assert.AreEqual(expectedIndexes, actualIndexes, $"Values should be ordered! Got {string.Join(", ", actualIndexes)}!");
        }
        #endregion

        #region DeckExtensions.GetShuffledCopy
        [Test]
        public static void GetShuffledCopyShouldReturnDeckGivenDeck() => Assert.IsInstanceOf<Deck>(new Deck(new List<Card>()).GetShuffledCopy());


        [Test]
        public static void GetShuffledCopyShouldReturnNewInstanceOfDeck()
        {
            var oldDeck = new Deck(new List<Card>());
            var newDeck = oldDeck.GetShuffledCopy();
            Assert.AreNotSame(oldDeck, newDeck);
        }

        [Test]
        public static void GetShuffledCopyShouldReturnDeckContainingAllCardsOfOldDeck()
        {
            var cards = new List<Card>
            {
                AceOfSpades,
                QueenOfHearts
            };
            var oldDeck = new Deck(cards);
            var newDeck = oldDeck.GetShuffledCopy();
            // The Assert.Contains signature is a bit messy, IMO. I usually use FluentAssertions for this sort of thing
            Assert.IsTrue(newDeck.Cards.Contains(AceOfSpades) && newDeck.Cards.Contains(AceOfSpades), "New Deck Should Contain the Ace of Spades and Queen of Hearts!");
        }

        [Test]
        public static void GetShuffledCopyShouldReturnNewInstanceOfItsCards()
        {
            var oldDeck = new Deck(new List<Card>());
            var newDeck = oldDeck.GetShuffledCopy();
            Assert.AreNotSame(oldDeck.Cards, newDeck.Cards);
        }
        #endregion
    }
}
