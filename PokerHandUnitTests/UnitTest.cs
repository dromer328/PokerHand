using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHand.Models;
using PokerHand.Controllers;

namespace PokerHandUnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CanCreate_Hand_IsOnePair()
        {
            // ARRANGE
            Hand hand;

            // ACT
            hand = CreateOnePair();
            
            // ASSERT
            Assert.IsTrue(hand.IsOnePair);
        }

        [TestMethod]
        public void CanCreate_Hand_IsFlush()
        {
            // ARRANGE
            var hand = new Hand()
            {
                Cards = new System.Collections.Generic.List<Card>() {
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Ace },
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Two },
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Three },
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Four },
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Jack }
                }
            };

            // ACT

            // ASSERT
            Assert.IsTrue(hand.IsFlush);
        }

        // At leat one negative test for sanity  ;)
        [TestMethod]
        public void CanCreate_NonFlush()
        {
            // ARRANGE
            Hand hand;

            // ACT
            hand = CreateOnePair();

            // ASSERT
            Assert.IsFalse(hand.IsFlush);
        }

        private Hand CreateOnePair()
        {
            var hand = new Hand()
            {
                Cards = new System.Collections.Generic.List<Card>() {
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Ace },
                new Card() { Suit = Enums.Suit.Spades, Value = Enums.Value.Ace },
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Two },
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Three },
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Four }
                }
            };
            return hand;
        }

        private Hand CreateFlush()
        {
            var hand = new Hand()
            {
                Cards = new System.Collections.Generic.List<Card>() {
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Ace },
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Two },
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Three },
                new Card() { Suit = Enums.Suit.Clubs, Value = Enums.Value.Four },
                new Card() { Suit = Enums.Suit.Spades, Value = Enums.Value.Jack }
                }
            };
            return hand;
        }
    }
}
