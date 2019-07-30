using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PokerHand.Models.Enums;

namespace PokerHand.Models
{
    public class Hand
    {
        public List<Card> Cards { get; set; }

        public bool IsOnePair
        {
            get
            {
                return Cards.GroupBy(h => h.Value)
                           .Where(g => g.Count() == 2)
                           .Count() == 1;
            }
        }

        public bool IsFlush
        {
            get
            {
                return Cards.GroupBy(h => h.Suit).Count() == 1;
            }
        }

    }
}
