using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerHand.Models;
using PokerHand.Controllers;
using PokerHand.Models;
using System.Collections.Generic;

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
            hand = CreateOnePairHand();

            // ASSERT
            Assert.IsTrue(hand.IsOnePair);
        }

        [TestMethod]
        public void CanCreate_Hand_IsFlush()
        {
            // ARRANGE
            Hand hand;

            // ACT
            hand = CreateFlushHand();

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
            hand = CreateOnePairHand();

            // ASSERT
            Assert.IsFalse(hand.IsFlush);
        }

        // NOTE TO CODE REVIEWER:
        // The following test method demonstrates how a Flush will beat One Pair

        [TestMethod]
        public void Game_WhereFlushBeatsOnePair()
        {
            // ARRANGE
            GameController gameController = new GameController();;
            Game game = new Game()
            {
                Players = new List<Player> {
                    new Player() {Name = "Mary", Hand = CreateFlushHand() },
                    new Player() {Name = "Bob", Hand = CreateOnePairHand() }
                }
            };

            // ACT
            var winningPlayer = gameController.DetermineWinningPlayer(game);

            // ASSERT
            Assert.IsTrue(winningPlayer.Hand.HandType == Enums.HandType.Flush);
        }

        [TestMethod]
        private Hand CreateOnePairHand()
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

        private Hand CreateFlushHand()
        {
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
            return hand;
        }
    }
}
