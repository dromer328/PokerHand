using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokerHand.Models;
using PokerHand.Business;

namespace PokerHand.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public Player DetermineWinningPlayer(Game game)
        {

            var winningHand = new Hand();
            var gameAnalysis = new GameAnalysis();
            gameAnalysis.Analyze(game);

            return game.Players.Where(p => p.Rank == 1).FirstOrDefault();
        }
    }
}