using System.Collections.Generic;
using System.Linq;
using static PokerHand.Models.Enums;

namespace PokerHand.Models
{
    public class Hand
    {
        public List<Card> Cards { get; set; }
        public HandType HandType { get; set; }

        public bool IsOnePair
        {
            // Same value card exists twice -- in different suits
            get
            {
                return Cards.GroupBy(h => h.Value)
                           .Where(g => g.Count() == 2)
                           .Count() == 1;
            }
        }

        // Add the following after basics are established. 
        // High card, Two Pair, Three of a kind, Four of a kind, Straight, Straight Flush, Royal Flush

        public bool IsFlush
        {
            get
            {
                // There is only one suit in the entire hand
                return Cards.GroupBy(h => h.Suit).Count() == 1;
            }
        }

    }
}
