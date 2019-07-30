using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static PokerHand.Models.Enums;

namespace PokerHand.Models
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }
    }
}
