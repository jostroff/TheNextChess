using Chess.Game.GameEngine;
using Chess.Game.GameEngine.Initializators;
using Chess.Game.InputProviders;
using Chess.Game.OutputProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chess.Web.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {


            return View();
        }

        public JsonResult GetBoard()
        {
            var inputProvider = new InputProvider();

            var engine = new TwoPlyersEngine(inputProvider);
            var strategy = new TwoPlayersInitializationStrategy();
            engine.Initialize(strategy, "Ivan", "Dragan");
            var outputProvider = new WebOutputProvider();

            var boardToRender = outputProvider.GetBoardToRender(engine);

            return Json(boardToRender, JsonRequestBehavior.AllowGet);
        }

    }
}