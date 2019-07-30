using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerHand.Models
{
    public class Enums
    {
        public enum Suit
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        public enum Value
        {
            Ace,  // This is ZERO by default, but may to treat specially for Royal Flush: Ten, Jack, Queen, King, Ace
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }
    }
}
