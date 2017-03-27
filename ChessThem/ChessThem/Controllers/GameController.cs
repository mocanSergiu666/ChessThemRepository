using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChessThem.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Connect(string connectionMode)
		{
			return View("GameArea");
		}

		public PartialViewResult Board()
		{
			return PartialView("_BoardPartial");
		}

		public PartialViewResult Chat()
		{
			return PartialView("_ChatPartial");
		}
	}
}