using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokerHand.Models;

namespace PokerHand.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public Hand EvaluateHands(Hand hand1, Hand hand2)
        {
            var winningHand = new Hand();

            return winningHand;
        }
    }
}