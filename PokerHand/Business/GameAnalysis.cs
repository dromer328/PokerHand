using PokerHand.Models;

namespace PokerHand.Business
{
    public class GameAnalysis
    {
        public void Analyze(Game game)
        {
            // Only consider two poker hands\players for this code exercise
            foreach (Player p in game.Players)
            {
                if (p.Hand.IsFlush)
                {
                    p.Rank = 1;
                    p.Hand.HandType = Enums.HandType.Flush;
                }
                else if (p.Hand.IsOnePair)
                {
                    p.Rank = 2;
                    p.Hand.HandType = Enums.HandType.OnePair;
                }
            }
        }
    }
}
